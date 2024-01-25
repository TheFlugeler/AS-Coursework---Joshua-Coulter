using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.Enums;
using AS_Coursework___Joshua_Coulter.AllTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AS_Coursework___Joshua_Coulter.Forms
{
    public partial class QuestionsForm : Form
    {
        private List<Question> questions;
        private QuestionTypes type;
        private bool isEdit;

        public QuestionsForm(bool isAdd)
        {
            InitializeComponent();
            panelEditDelete.Visible = !isAdd;
            panelAdd.Visible = isAdd;
            if (isAdd) SetAddMode();
        }

        private void radioButtonAddTextQuestion_CheckedChanged(object sender, EventArgs e)
        {
            panelAddAnswerOptions.Visible = radioButtonAddMCQuestion.Checked;
            panelAddTextAnswer.Visible = radioButtonAddTextQuestion.Checked;
            panelAddQuestionText.Visible = true;
            panelAddQuestionDifficulty.Visible = true;
        }
        private void radioButtonAddMCQuestion_CheckedChanged(object sender, EventArgs e) => radioButtonAddTextQuestion_CheckedChanged(sender, e);

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            if (!CheckValid())
            {
                MessageBox.Show("Please fill in all details");
                return;
            }

            Difficulty diff = Enums.Difficulty.Easy;
            if (radioButtonAddEasy.Checked) diff = Enums.Difficulty.Easy;
            if (radioButtonAddMedium.Checked) diff = Enums.Difficulty.Medium;
            if (radioButtonAddHard.Checked) diff = Enums.Difficulty.Hard;

            if (radioButtonAddTextQuestion.Checked)
            {
                TextQuestion temp = new TextQuestion(richTextBoxAddQuestionText.Text, diff, textBoxAddTextAnswer.Text);
                temp.WriteQuestion();
                MessageBox.Show("Text Question Successfully Added");
                (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new AdminForm());
                Close();
            }
            else if (radioButtonAddMCQuestion.Checked)
            {
                string[] options = new string[3] { textBoxAddOption1.Text, textBoxAddOption2.Text, textBoxAddOption3.Text };
                int answer = 0;
                if (radioButtonAddOption1.Checked) answer = 1;
                if (radioButtonAddOption2.Checked) answer = 2;
                if (radioButtonAddOption3.Checked) answer = 3;
                MultipleChoiceQuestion temp = new MultipleChoiceQuestion(richTextBoxAddQuestionText.Text, diff, options, answer);
                temp.WriteQuestion();
                MessageBox.Show("Text Question Successfully Added");
                (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new AdminForm());
                Close();
            }
        }

        private bool CheckValid()
        {
            if (!radioButtonAddEasy.Checked && !radioButtonAddMedium.Checked && !radioButtonAddHard.Checked) return false;
            if (string.IsNullOrEmpty(richTextBoxAddQuestionText.Text)) return false;
            if (radioButtonAddTextQuestion.Checked)
            {
                if (string.IsNullOrEmpty(textBoxAddTextAnswer.Text)) return false;
            }
            else if (radioButtonAddMCQuestion.Checked)
            {

                if (string.IsNullOrEmpty(textBoxAddOption1.Text)) return false;
                if (string.IsNullOrEmpty(textBoxAddOption2.Text)) return false;
                if (string.IsNullOrEmpty(textBoxAddOption3.Text)) return false;
                if (!radioButtonAddOption1.Checked && !radioButtonAddOption2.Checked && !radioButtonAddOption3.Checked) return false;
            }
            else return false;
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
                default: break;
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
            panelEditDelete.Visible = false;
            panelAdd.Visible = true;
            labelAddQuestionTitle.Text = "Edit Question";
            switch (type)
            {
                case QuestionTypes.Text: radioButtonAddTextQuestion.Checked = true; break;
                case QuestionTypes.MultipleChoice: radioButtonAddMCQuestion.Checked = true; break;
                default: MessageBox.Show("Type error in edit mode"); return;
            }
            radioButtonAddMCQuestion.Enabled = false;
            radioButtonAddTextQuestion.Enabled = false;
            buttonAddQuestion.Text = "Save Changes";
            isEdit = true;
            richTextBoxAddQuestionText.Text = currentQuestion.QuestionText;
            switch (currentQuestion.QuestionType)
            {
                case QuestionTypes.Text:
                    panelAddAnswerOptions.Visible = false;
                    panelAddTextAnswer.Visible = true;
                    textBoxAddTextAnswer.Text = ((TextQuestion)currentQuestion).Answer;
                    break;
                case QuestionTypes.MultipleChoice:
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
            panelEditDelete.Visible = false;
            panelAdd.Visible = true;
            labelAddQuestionTitle.Text = "Design Question";
            richTextBoxAddQuestionText.Text = string.Empty;
            textBoxAddOption1.Text = string.Empty;
            textBoxAddOption2.Text = string.Empty;
            textBoxAddOption3.Text = string.Empty;
            radioButtonAddOption1.Checked = false;
            radioButtonAddOption2.Checked = false;
            radioButtonAddOption3.Checked = false;
            radioButtonAddEasy.Checked = false;
            radioButtonAddMedium.Checked = false;
            radioButtonAddHard.Checked = false;
            radioButtonAddMCQuestion.Checked = false;
            radioButtonAddTextQuestion.Checked = false;
            buttonAddQuestion.Text = "Add Question";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listBoxViewQuestions.SelectedIndex < 0) return;
            SetEditMode(questions[listBoxViewQuestions.SelectedIndex]);
            questions.RemoveAt(listBoxViewQuestions.SelectedIndex);
            questions.WriteQuestionsList();
            questions = CSV.ReadInQuestions(type);
        }
    }
}
