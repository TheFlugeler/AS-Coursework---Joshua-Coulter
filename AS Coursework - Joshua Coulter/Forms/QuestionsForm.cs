using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.Enums;
using AS_Coursework___Joshua_Coulter.ToolsLibrary;

namespace AS_Coursework___Joshua_Coulter.Forms;

public partial class QuestionsForm : Form
{
    //This form allows admins to edit, add and delete questions

    private List<Question> questions;
    private QuestionTypes type;
    private string OldFilePath = "";
    private string NewFilePath = "";

    public QuestionsForm(bool isAdd)
    {
        InitializeComponent();
        panelEditDelete.Visible = !isAdd;
        panelAdd.Visible = isAdd;
        if (isAdd) SetAddMode();
    }

    private void radioButtonAddTextQuestion_CheckedChanged(object sender, EventArgs e)
    {
        panelAddAnswerOptions.Visible = radioButtonMultipleChoice.Checked;
        panelAddTextAnswer.Visible = radioButtonText.Checked;
        panelAddMatchPairs.Visible = radioButtonMatch.Checked;
        if (radioButtonMatch.Checked) panelAddQuestionText.Location = new(316, 60);
        else panelAddQuestionText.Location = new(316, 104);
        panelAddQuestionText.Visible = true;
        panelAddQuestionDifficulty.Visible = true;
        if (radioButtonText.Checked || radioButtonMultipleChoice.Checked) panelMediaChoice.Visible = true;
        else panelMediaChoice.Visible = false;
        if (radioButtonPicture.Checked || radioButtonAudio.Checked) panelChooseFile.Visible = true;
        else panelChooseFile.Visible = false;
    }

    private void buttonAddQuestion_Click(object sender, EventArgs e)
    {
        if (!CheckValid())
        {
            MessageBox.Show(QuestionError(), "Error");
            return;
        }

        Difficulty diff = Enums.Difficulty.Easy;
        if (radioButtonAddEasy.Checked) diff = Enums.Difficulty.Easy;
        if (radioButtonAddMedium.Checked) diff = Enums.Difficulty.Medium;
        if (radioButtonAddHard.Checked) diff = Enums.Difficulty.Hard;

        if (radioButtonText.Checked)
        {
            if (radioButtonNeither.Checked)
            {
                TextQuestion temp = new(richTextBoxAddQuestionText.Text, diff, textBoxAddTextAnswer.Text);
                temp.WriteQuestion();
                MessageBox.Show("Text Question saved", "Admin");
                (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new AdminForm());
                Close();
            }
            else if (radioButtonPicture.Checked)
            {
                if (!CopyFile() && OldFilePath != null) return;
                PictureTextQuestion temp = new(richTextBoxAddQuestionText.Text, diff, textBoxAddTextAnswer.Text, NewFilePath);
                temp.WriteQuestion();
                MessageBox.Show("Picture Text Question saved", "Admin");
                (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new AdminForm());
                Close();
            }
            else if (radioButtonAudio.Checked)
            {
                if (!CopyFile() && OldFilePath != null) return;
                AudioTextQuestion temp = new(richTextBoxAddQuestionText.Text, diff, textBoxAddTextAnswer.Text, NewFilePath);
                temp.WriteQuestion();
                MessageBox.Show("Audio Text Question saved", "Admin");
                (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new AdminForm());
                Close();
            }
        }
        else if (radioButtonMultipleChoice.Checked)
        {
            string[] options = new string[3] { textBoxAddOption1.Text, textBoxAddOption2.Text, textBoxAddOption3.Text };
            int answer = 0;
            if (radioButtonAddOption1.Checked) answer = 1;
            if (radioButtonAddOption2.Checked) answer = 2;
            if (radioButtonAddOption3.Checked) answer = 3;

            if (radioButtonNeither.Checked)
            {
                MultipleChoiceQuestion temp = new(richTextBoxAddQuestionText.Text, diff, options, answer);
                temp.WriteQuestion();
                MessageBox.Show("Multiple Choice Question saved", "Admin");
                (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new AdminForm());
                Close();
            }
            else if (radioButtonPicture.Checked)
            {
                if (!CopyFile() && OldFilePath != null) return;
                PictureMultipleChoiceQuestion temp = new(richTextBoxAddQuestionText.Text, diff, options, answer, NewFilePath);
                temp.WriteQuestion();
                MessageBox.Show("Picture Multiple Choice Question saved", "Admin");
                (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new AdminForm());
                Close();
            }
            else if (radioButtonAudio.Checked)
            {
                if (!CopyFile() && OldFilePath != null) return;
                AudioMultipleChoiceQuestion temp = new(richTextBoxAddQuestionText.Text, diff, options, answer, NewFilePath);
                temp.WriteQuestion();
                MessageBox.Show("Audio Multiple Choice Question saved", "Admin");
                (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new AdminForm());
                Close();
            }
        }
        else if (radioButtonMatch.Checked)
        {
            string[] answers = new string[4] {
                textBoxLeft1.Text + "/" + textBoxRight1.Text,
                textBoxLeft2.Text + "/" + textBoxRight2.Text,
                textBoxLeft3.Text + "/" + textBoxRight3.Text,
                textBoxLeft4.Text + "/" + textBoxRight4.Text
            };
            MatchQuestion temp = new(richTextBoxAddQuestionText.Text, diff, answers);
            temp.WriteQuestion();
            MessageBox.Show("Match Question Saved", "Admin");
            (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new AdminForm());
            Close();
        }
    }

    #region Validate
    private bool CheckValid()
    {
        if (!radioButtonAddEasy.Checked && !radioButtonAddMedium.Checked && !radioButtonAddHard.Checked) return false;
        if (string.IsNullOrEmpty(richTextBoxAddQuestionText.Text)) return false;
        if (!ValidateString(richTextBoxAddQuestionText.Text)) return false;
        if (radioButtonText.Checked)
        {
            if (string.IsNullOrEmpty(textBoxAddTextAnswer.Text)) return false;
        }
        else if (radioButtonMultipleChoice.Checked)
        {
            if (string.IsNullOrEmpty(textBoxAddOption1.Text)) return false;
            if (string.IsNullOrEmpty(textBoxAddOption2.Text)) return false;
            if (string.IsNullOrEmpty(textBoxAddOption3.Text)) return false;
            if (!ValidateString(textBoxAddOption1.Text + textBoxAddOption2.Text + textBoxAddOption3.Text)) return false;
            if (!radioButtonAddOption1.Checked && !radioButtonAddOption2.Checked && !radioButtonAddOption3.Checked) return false;
        }
        else if (radioButtonMatch.Checked)
        {
            TextBox[] matchBoxes = new TextBox[8]
            {
                textBoxLeft1,textBoxLeft2, textBoxLeft3,textBoxLeft3,textBoxRight1,textBoxRight2,textBoxRight3,textBoxRight4
            };
            foreach (var matchBox in matchBoxes)
            {
                if (string.IsNullOrEmpty(matchBox.Text)) return false;
                if (!ValidateString(matchBox.Text)) return false;
            }
        }
        return true;
    }

    private string QuestionError()
    {
        if (!radioButtonAddEasy.Checked && !radioButtonAddMedium.Checked && !radioButtonAddHard.Checked) return "Please select a difficulty";
        if (string.IsNullOrEmpty(richTextBoxAddQuestionText.Text)) return "Please enter a valid question text";
        if (!ValidateString(richTextBoxAddQuestionText.Text)) return "Please enter a valid question text";
        if (radioButtonText.Checked)
        {
            if (string.IsNullOrEmpty(textBoxAddTextAnswer.Text) || !ValidateString(textBoxAddTextAnswer.Text)) return "Please enter a valid text answer";
        }
        else if (radioButtonMultipleChoice.Checked)
        {
            if (string.IsNullOrEmpty(textBoxAddOption1.Text) || !ValidateString(textBoxAddOption1.Text)) return "Please enter a valid option 1";
            if (string.IsNullOrEmpty(textBoxAddOption2.Text) || !ValidateString(textBoxAddOption2.Text)) return "Please enter a valid option 2";
            if (string.IsNullOrEmpty(textBoxAddOption3.Text) || !ValidateString(textBoxAddOption3.Text)) return "Please enter a valid option 3";

            if (!radioButtonAddOption1.Checked && !radioButtonAddOption2.Checked && !radioButtonAddOption3.Checked) return "Please select the correct option";
        }
        else if (radioButtonMatch.Checked)
        {
            TextBox[] matchBoxes = new TextBox[8]
            {
                textBoxLeft1,textBoxLeft2, textBoxLeft3,textBoxLeft3,textBoxRight1,textBoxRight2,textBoxRight3,textBoxRight4
            };
            foreach (var matchBox in matchBoxes)
            {
                if (string.IsNullOrEmpty(matchBox.Text) || !ValidateString(matchBox.Text)) return "Please check your match options for invalid characters";
            }
        }
        return "no error";
    }

    private bool ValidateString(string text)
    {
        foreach (char c in text) if (c == ',') return false;
        return true;
    }

    #endregion

    private void PopulateList(QuestionTypes _type)
    {
        type = _type;
        listBoxViewQuestions.Items.Clear();
        questions = new(CSV.ReadInQuestions(type));
        foreach (Question question in questions)
        {
            listBoxViewQuestions.Items.Add(question.QuestionText);
        }
    }

    private void comboBoxDifficultyView_SelectedIndexChanged(object sender, EventArgs e)
    {
        switch (comboBoxDifficultyView.SelectedIndex)
        {
            case 0: PopulateList(QuestionTypes.Text); break;
            case 1: PopulateList(QuestionTypes.MultipleChoice); break;
            case 2: PopulateList(QuestionTypes.AudioText); break;
            case 3: PopulateList(QuestionTypes.AudioMultipleChoice); break;
            case 4: PopulateList(QuestionTypes.PictureText); break;
            case 5: PopulateList(QuestionTypes.PictureMultipleChoice); break;
            case 6: PopulateList(QuestionTypes.Match); break;
        }
    }

    private void btnAddQuestion_Click(object sender, EventArgs e)
    {
        panelAdd.Visible = true;
        panelEditDelete.Visible = false;
        SetAddMode();
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        Question temp = questions[listBoxViewQuestions.SelectedIndex];
        if (listBoxViewQuestions.SelectedIndex < 0) return;
        if (MessageBox.Show("Are you sure you want to delete this question?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;

        if (temp.QuestionType == QuestionTypes.PictureMultipleChoice) File.Delete($"PictureFiles/{((PictureMultipleChoiceQuestion)temp).PictureFile}");
        if (temp.QuestionType == QuestionTypes.PictureText) File.Delete($"PictureFiles/{((PictureTextQuestion)temp).PictureFile}");
        if (temp.QuestionType == QuestionTypes.AudioMultipleChoice) File.Delete($"PictureFiles/{((AudioMultipleChoiceQuestion)temp).AudioFile}");
        if (temp.QuestionType == QuestionTypes.AudioText) File.Delete($"PictureFiles/{((AudioTextQuestion)temp).AudioFile}");

        questions.RemoveAt(listBoxViewQuestions.SelectedIndex);
        questions.WriteQuestionsList();
        questions = CSV.ReadInQuestions(type);
        PopulateList(type);
    }

    #region Modes

    private void SetEditMode(Question currentQuestion)
    {
        TextBox[] matchBoxes = new TextBox[8]
        {
            textBoxLeft1,
            textBoxLeft2,
            textBoxLeft3,
            textBoxLeft4,
            textBoxRight1,
            textBoxRight2,
            textBoxRight3,
            textBoxRight4
        };

        panelEditDelete.Visible = false;
        panelAdd.Visible = true;
        panelMediaChoice.Visible = true;
        panelChooseFile.Visible = true;
        labelAddQuestionTitle.Text = "Edit Question";

        radioButtonMultipleChoice.Enabled = false;
        radioButtonText.Enabled = false;
        radioButtonMatch.Enabled = false;
        radioButtonNeither.Enabled = false;
        radioButtonPicture.Enabled = false;
        radioButtonAudio.Enabled = false;

        buttonAddQuestion.Text = "Save Changes";
        richTextBoxAddQuestionText.Text = currentQuestion.QuestionText;

        OldFilePath = null;
        btnChooseFile.Enabled = false;

        switch (currentQuestion.QuestionType)
        {
            case QuestionTypes.Text:
                radioButtonText.Checked = true;
                radioButtonNeither.Checked = true;
                panelAddAnswerOptions.Visible = false;
                panelAddTextAnswer.Visible = true;
                textBoxAddTextAnswer.Text = ((TextQuestion)currentQuestion).Answer;
                break;
            case QuestionTypes.MultipleChoice:
                radioButtonMultipleChoice.Checked = true;
                radioButtonNeither.Checked = true;
                textBoxAddOption1.Text = ((MultipleChoiceQuestion)currentQuestion).Options[0];
                textBoxAddOption2.Text = ((MultipleChoiceQuestion)currentQuestion).Options[1];
                textBoxAddOption3.Text = ((MultipleChoiceQuestion)currentQuestion).Options[2];
                switch (((MultipleChoiceQuestion)currentQuestion).Answer)
                {
                    case 1: radioButtonAddOption1.Checked = true; break;
                    case 2: radioButtonAddOption2.Checked = true; break;
                    case 3: radioButtonAddOption3.Checked = true; break;
                }
                break;
            case QuestionTypes.Match:
                radioButtonMatch.Checked = true;
                radioButtonNeither.Checked = true;
                panelChooseFile.Visible = false;
                panelMediaChoice.Visible = false;
                for (int i = 0; i < 4; i++)
                {
                    string[] temp = ((MatchQuestion)currentQuestion).Answers[i].Split('/');
                    matchBoxes[i].Text = temp[0];
                    matchBoxes[i + 4].Text = temp[1];
                }
                break;
            case QuestionTypes.AudioText:
                radioButtonText.Checked = true;
                radioButtonAudio.Checked = true;
                panelAddAnswerOptions.Visible = false;
                panelAddTextAnswer.Visible = true;
                textBoxAddTextAnswer.Text = ((AudioTextQuestion)currentQuestion).Answer;
                textBoxFilePath.Text = ((AudioTextQuestion)currentQuestion).AudioFile;
                NewFilePath = ((AudioTextQuestion)currentQuestion).AudioFile;
                break;
            case QuestionTypes.AudioMultipleChoice:
                radioButtonMultipleChoice.Checked = true;
                radioButtonAudio.Checked = true;
                textBoxAddOption1.Text = ((AudioMultipleChoiceQuestion)currentQuestion).Options[0];
                textBoxAddOption2.Text = ((AudioMultipleChoiceQuestion)currentQuestion).Options[1];
                textBoxAddOption3.Text = ((AudioMultipleChoiceQuestion)currentQuestion).Options[2];
                switch (((AudioMultipleChoiceQuestion)currentQuestion).Answer)
                {
                    case 1: radioButtonAddOption1.Checked = true; break;
                    case 2: radioButtonAddOption2.Checked = true; break;
                    case 3: radioButtonAddOption3.Checked = true; break;
                }
                textBoxFilePath.Text = ((AudioMultipleChoiceQuestion)currentQuestion).AudioFile;
                NewFilePath = ((AudioMultipleChoiceQuestion)currentQuestion).AudioFile;
                break;
            case QuestionTypes.PictureText:
                radioButtonText.Checked = true;
                radioButtonPicture.Checked = true;
                panelAddAnswerOptions.Visible = false;
                panelAddTextAnswer.Visible = true;
                textBoxAddTextAnswer.Text = ((PictureTextQuestion)currentQuestion).Answer;
                textBoxFilePath.Text = ((PictureTextQuestion)currentQuestion).PictureFile;
                NewFilePath = ((PictureTextQuestion)currentQuestion).PictureFile;
                break;
            case QuestionTypes.PictureMultipleChoice:
                radioButtonMultipleChoice.Checked = true;
                radioButtonPicture.Checked = true;
                textBoxAddOption1.Text = ((PictureMultipleChoiceQuestion)currentQuestion).Options[0];
                textBoxAddOption2.Text = ((PictureMultipleChoiceQuestion)currentQuestion).Options[1];
                textBoxAddOption3.Text = ((PictureMultipleChoiceQuestion)currentQuestion).Options[2];
                switch (((PictureMultipleChoiceQuestion)currentQuestion).Answer)
                {
                    case 1: radioButtonAddOption1.Checked = true; break;
                    case 2: radioButtonAddOption2.Checked = true; break;
                    case 3: radioButtonAddOption3.Checked = true; break;
                }
                textBoxFilePath.Text = ((PictureMultipleChoiceQuestion)currentQuestion).PictureFile;
                NewFilePath = ((PictureMultipleChoiceQuestion)currentQuestion).PictureFile;
                break;
        }
        switch (currentQuestion.QuestionDifficulty)
        {
            case Enums.Difficulty.Easy: radioButtonAddEasy.Checked = true; break;
            case Enums.Difficulty.Medium: radioButtonAddMedium.Checked = true; break;
            case Enums.Difficulty.Hard: radioButtonAddHard.Checked = true; break;
        }
    }

    private void SetAddMode()
    {
        TextBox[] tBoxes = new TextBox[12]
        {
            textBoxAddTextAnswer,
            textBoxAddOption1,
            textBoxAddOption2,
            textBoxAddOption3,
            textBoxLeft1,
            textBoxLeft2,
            textBoxLeft3,
            textBoxLeft4,
            textBoxRight1,
            textBoxRight2,
            textBoxRight3,
            textBoxRight4
        };

        RadioButton[] rBtns = new RadioButton[8]
        {
            radioButtonAddOption1,
            radioButtonAddOption2,
            radioButtonAddOption3,
            radioButtonAddEasy,
            radioButtonAddMedium,
            radioButtonAddHard,
            radioButtonMultipleChoice,
            radioButtonText
        };

        foreach (TextBox box in tBoxes) box.Clear();
        foreach (RadioButton btn in rBtns) btn.Checked = false;

        panelEditDelete.Visible = false;
        panelAdd.Visible = true;
        labelAddQuestionTitle.Text = "Design Question";
        richTextBoxAddQuestionText.Text = string.Empty;

        buttonAddQuestion.Text = "Add Question";
        btnChooseFile.Enabled = true;
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        Question temp = questions[listBoxViewQuestions.SelectedIndex];
        if (listBoxViewQuestions.SelectedIndex < 0) return;
        SetEditMode(questions[listBoxViewQuestions.SelectedIndex]);
        questions.RemoveAt(listBoxViewQuestions.SelectedIndex);
        questions.WriteQuestionsList();
    }
    #endregion

    #region Files
    private async void btnChooseFile_Click(object sender, EventArgs e)
    {
        string filepath = "";
        if (openFileDialogChooseMedia.ShowDialog() == DialogResult.OK)
        {
            filepath = openFileDialogChooseMedia.FileName;
        }
        else return;

        string type = Path.GetExtension(filepath).ToLower();

        if (radioButtonAudio.Checked)
        {
            if (type != ".wav")
            {
                MessageBox.Show("Audio File type must be .wav", "Error");
                return;
            }
        }
        if (radioButtonPicture.Checked)
        {
            if (type != ".jpg" && type != ".png" && type != ".jpeg")
            {
                MessageBox.Show("Picture file type must be .jpg or .png", "Error");
                return;
            }
        }

        OldFilePath = filepath;
        textBoxFilePath.Text = Path.GetFileName(filepath);
        radioButtonAudio.Enabled = false;
        radioButtonPicture.Enabled = false;
        radioButtonNeither.Enabled = false;
        radioButtonText.Enabled = false;
        radioButtonMultipleChoice.Enabled = false;
        radioButtonMatch.Enabled = false;
    }

    private bool CopyFile()
    {
        if (OldFilePath == null) return true;
        string filename = Path.GetFileName(OldFilePath);
        if (radioButtonAudio.Checked)
        {
            try
            {
                File.Copy(OldFilePath, $"AudioFiles/{filename}");
                NewFilePath = filename;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Program contains file of same name\n\n{ex}", "Error");
                return false;
            }
        }
        else if (radioButtonPicture.Checked)
        {
            try
            {
                File.Copy(OldFilePath, $"PictureFiles/{filename}");
                NewFilePath = filename;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Program contains file of same name\n\n{ex}", "Error");
                return false;
            }
        }
        return false;
    }
    #endregion
}
