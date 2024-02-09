using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.Enums;
using AS_Coursework___Joshua_Coulter.ToolsLibrary;

namespace AS_Coursework___Joshua_Coulter.Forms;

public partial class QuestionsForm : Form
{
    //This form allows admins to edit, add and delete questions

    private List<Question> questions;
    private QuestionTypes type;

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
    }
    private void radioButtonAddMCQuestion_CheckedChanged(object sender, EventArgs e)
    {
        radioButtonAddTextQuestion_CheckedChanged(sender, e);
    }

    private void radioButtonMatch_CheckedChanged(object sender, EventArgs e)
    {
        radioButtonAddTextQuestion_CheckedChanged(sender, e);
    }

    private void buttonAddQuestion_Click(object sender, EventArgs e)
    {
        if (!CheckValid())
        {
            MessageBox.Show("Please enter valid values", "Error");
            return;
        }

        Difficulty diff = Enums.Difficulty.Easy;
        if (radioButtonAddEasy.Checked) diff = Enums.Difficulty.Easy;
        if (radioButtonAddMedium.Checked) diff = Enums.Difficulty.Medium;
        if (radioButtonAddHard.Checked) diff = Enums.Difficulty.Hard;

        if (radioButtonText.Checked)
        {
            TextQuestion temp = new TextQuestion(richTextBoxAddQuestionText.Text, diff, textBoxAddTextAnswer.Text);
            temp.WriteQuestion();
            MessageBox.Show("Text Question saved", "Admin");
            (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new AdminForm());
            Close();
        }
        else if (radioButtonMultipleChoice.Checked)
        {
            string[] options = new string[3] { textBoxAddOption1.Text, textBoxAddOption2.Text, textBoxAddOption3.Text };
            int answer = 0;
            if (radioButtonAddOption1.Checked) answer = 1;
            if (radioButtonAddOption2.Checked) answer = 2;
            if (radioButtonAddOption3.Checked) answer = 3;
            MultipleChoiceQuestion temp = new MultipleChoiceQuestion(richTextBoxAddQuestionText.Text, diff, options, answer);
            temp.WriteQuestion();
            MessageBox.Show("Multiple Choice Question saved", "Admin");
            (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new AdminForm());
            Close();
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

    private bool ValidateString(string text)
    {
        foreach (char c in text) if (c == ',') return false;
        return true;
    }

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
            case 0: PopulateList(QuestionTypes.Text); btnEdit.Enabled = true; break;
            case 1: PopulateList(QuestionTypes.MultipleChoice); btnEdit.Enabled = true; break;
            case 2: PopulateList(QuestionTypes.AudioText); btnEdit.Enabled = false; break;
            case 3: PopulateList(QuestionTypes.AudioMultipleChoice); btnEdit.Enabled = false; break;
            case 4: PopulateList(QuestionTypes.PictureText); btnEdit.Enabled = false; break;
            case 5: PopulateList(QuestionTypes.PictureMultipleChoice); btnEdit.Enabled = false; break;
            case 6: PopulateList(QuestionTypes.Match); btnEdit.Enabled = true; break;
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
        if (listBoxViewQuestions.SelectedIndex < 0) return;
        questions.RemoveAt(listBoxViewQuestions.SelectedIndex);
        questions.WriteQuestionsList();
        questions = CSV.ReadInQuestions(type);
        PopulateList(type);
    }

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
        labelAddQuestionTitle.Text = "Edit Question";

        radioButtonMultipleChoice.Enabled = false;
        radioButtonText.Enabled = false;
        radioButtonMatch.Enabled = false;

        buttonAddQuestion.Text = "Save Changes";
        richTextBoxAddQuestionText.Text = currentQuestion.QuestionText;

        switch (currentQuestion.QuestionType)
        {
            case QuestionTypes.Text:
                radioButtonText.Checked = true;
                panelAddAnswerOptions.Visible = false;
                panelAddTextAnswer.Visible = true;
                textBoxAddTextAnswer.Text = ((TextQuestion)currentQuestion).Answer;
                break;
            case QuestionTypes.MultipleChoice:
                radioButtonMultipleChoice.Checked = true;
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
                for (int i = 0; i < 4; i++)
                {
                    string[] temp = ((MatchQuestion)currentQuestion).Answers[i].Split('/');
                    matchBoxes[i].Text = temp[0];
                    matchBoxes[i + 4].Text = temp[1];
                }
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
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
        if (listBoxViewQuestions.SelectedIndex < 0) return;
        SetEditMode(questions[listBoxViewQuestions.SelectedIndex]);
        questions.RemoveAt(listBoxViewQuestions.SelectedIndex);
        questions.WriteQuestionsList();
    }
}
