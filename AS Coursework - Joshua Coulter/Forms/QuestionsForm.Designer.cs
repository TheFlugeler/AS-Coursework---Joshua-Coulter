namespace AS_Coursework___Joshua_Coulter.Forms
{
    partial class QuestionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelEditDelete = new Panel();
            listBoxViewQuestions = new ListBox();
            labelViewQuestionsTitle = new Label();
            panelPickQuestionType = new Panel();
            comboBoxDifficultyView = new ComboBox();
            labelPickTypeView = new Label();
            btnAddQuestion = new Button();
            btnDeleteQuestion = new Button();
            btnEdit = new Button();
            panelAdd = new Panel();
            panelAddAnswerOptions = new Panel();
            radioButtonAddOption3 = new RadioButton();
            radioButtonAddOption2 = new RadioButton();
            radioButtonAddOption1 = new RadioButton();
            labelCorrectAnswer = new Label();
            labelAddOption3 = new Label();
            textBoxAddOption3 = new TextBox();
            labelAddOption2 = new Label();
            textBoxAddOption2 = new TextBox();
            labelAddOption1 = new Label();
            textBoxAddOption1 = new TextBox();
            labelAddAnswerOptions = new Label();
            panelAddQuestionDifficulty = new Panel();
            radioButtonAddHard = new RadioButton();
            radioButtonAddMedium = new RadioButton();
            radioButtonAddEasy = new RadioButton();
            labelAddQuestionDifficulty = new Label();
            buttonAddQuestion = new Button();
            panelAddQuestionText = new Panel();
            labelAddQuestionText = new Label();
            richTextBoxAddQuestionText = new RichTextBox();
            panelAddQuestionType = new Panel();
            radioButtonAddMCQuestion = new RadioButton();
            radioButtonAddTextQuestion = new RadioButton();
            labelAddQuestionType = new Label();
            labelAddQuestionTitle = new Label();
            panelAddTextAnswer = new Panel();
            textBoxAddTextAnswer = new TextBox();
            labelQuestionAnswer = new Label();
            radioButton1 = new RadioButton();
            panelEditDelete.SuspendLayout();
            panelPickQuestionType.SuspendLayout();
            panelAdd.SuspendLayout();
            panelAddAnswerOptions.SuspendLayout();
            panelAddQuestionDifficulty.SuspendLayout();
            panelAddQuestionText.SuspendLayout();
            panelAddQuestionType.SuspendLayout();
            panelAddTextAnswer.SuspendLayout();
            SuspendLayout();
            // 
            // panelEditDelete
            // 
            panelEditDelete.Anchor = AnchorStyles.None;
            panelEditDelete.BackColor = Color.FromArgb(0, 192, 192);
            panelEditDelete.Controls.Add(listBoxViewQuestions);
            panelEditDelete.Controls.Add(labelViewQuestionsTitle);
            panelEditDelete.Controls.Add(panelPickQuestionType);
            panelEditDelete.Controls.Add(btnAddQuestion);
            panelEditDelete.Controls.Add(btnDeleteQuestion);
            panelEditDelete.Controls.Add(btnEdit);
            panelEditDelete.Location = new Point(82, 63);
            panelEditDelete.Name = "panelEditDelete";
            panelEditDelete.Size = new Size(839, 497);
            panelEditDelete.TabIndex = 0;
            // 
            // listBoxViewQuestions
            // 
            listBoxViewQuestions.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            listBoxViewQuestions.FormattingEnabled = true;
            listBoxViewQuestions.ItemHeight = 23;
            listBoxViewQuestions.Location = new Point(63, 156);
            listBoxViewQuestions.Name = "listBoxViewQuestions";
            listBoxViewQuestions.Size = new Size(493, 303);
            listBoxViewQuestions.TabIndex = 6;
            // 
            // labelViewQuestionsTitle
            // 
            labelViewQuestionsTitle.AutoSize = true;
            labelViewQuestionsTitle.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelViewQuestionsTitle.Location = new Point(60, 23);
            labelViewQuestionsTitle.Name = "labelViewQuestionsTitle";
            labelViewQuestionsTitle.Size = new Size(306, 34);
            labelViewQuestionsTitle.TabIndex = 5;
            labelViewQuestionsTitle.Text = "Edit/Delete Questions";
            // 
            // panelPickQuestionType
            // 
            panelPickQuestionType.BackColor = Color.Teal;
            panelPickQuestionType.Controls.Add(comboBoxDifficultyView);
            panelPickQuestionType.Controls.Add(labelPickTypeView);
            panelPickQuestionType.Location = new Point(60, 83);
            panelPickQuestionType.Name = "panelPickQuestionType";
            panelPickQuestionType.Size = new Size(496, 48);
            panelPickQuestionType.TabIndex = 4;
            // 
            // comboBoxDifficultyView
            // 
            comboBoxDifficultyView.FormattingEnabled = true;
            comboBoxDifficultyView.Items.AddRange(new object[] { "Text Questions", "Mulitple Choice Questions", "Audio Text Questions", "Audio Multiple Choice Questions", "Picture Text Questions", "Picture Multiple Choice Questions" });
            comboBoxDifficultyView.Location = new Point(196, 9);
            comboBoxDifficultyView.Name = "comboBoxDifficultyView";
            comboBoxDifficultyView.Size = new Size(282, 28);
            comboBoxDifficultyView.TabIndex = 1;
            comboBoxDifficultyView.SelectedIndexChanged += comboBoxDifficultyView_SelectedIndexChanged;
            // 
            // labelPickTypeView
            // 
            labelPickTypeView.AutoSize = true;
            labelPickTypeView.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelPickTypeView.Location = new Point(3, 8);
            labelPickTypeView.Name = "labelPickTypeView";
            labelPickTypeView.Size = new Size(187, 28);
            labelPickTypeView.TabIndex = 0;
            labelPickTypeView.Text = "Pick Question Type";
            // 
            // btnAddQuestion
            // 
            btnAddQuestion.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddQuestion.Location = new Point(593, 387);
            btnAddQuestion.Name = "btnAddQuestion";
            btnAddQuestion.Size = new Size(192, 70);
            btnAddQuestion.TabIndex = 3;
            btnAddQuestion.Text = "Add Question";
            btnAddQuestion.UseVisualStyleBackColor = true;
            btnAddQuestion.Click += btnAddQuestion_Click;
            // 
            // btnDeleteQuestion
            // 
            btnDeleteQuestion.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteQuestion.Location = new Point(593, 250);
            btnDeleteQuestion.Name = "btnDeleteQuestion";
            btnDeleteQuestion.Size = new Size(192, 70);
            btnDeleteQuestion.TabIndex = 2;
            btnDeleteQuestion.Text = "Delete Question";
            btnDeleteQuestion.UseVisualStyleBackColor = true;
            btnDeleteQuestion.Click += buttonDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.Location = new Point(593, 159);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(192, 70);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Question";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // panelAdd
            // 
            panelAdd.Anchor = AnchorStyles.None;
            panelAdd.BackColor = Color.FromArgb(0, 192, 192);
            panelAdd.Controls.Add(panelAddAnswerOptions);
            panelAdd.Controls.Add(panelAddQuestionDifficulty);
            panelAdd.Controls.Add(buttonAddQuestion);
            panelAdd.Controls.Add(panelAddQuestionText);
            panelAdd.Controls.Add(panelAddQuestionType);
            panelAdd.Controls.Add(labelAddQuestionTitle);
            panelAdd.Controls.Add(panelAddTextAnswer);
            panelAdd.Location = new Point(82, 63);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(870, 497);
            panelAdd.TabIndex = 1;
            // 
            // panelAddAnswerOptions
            // 
            panelAddAnswerOptions.BackColor = Color.FromArgb(0, 106, 125);
            panelAddAnswerOptions.Controls.Add(radioButtonAddOption3);
            panelAddAnswerOptions.Controls.Add(radioButtonAddOption2);
            panelAddAnswerOptions.Controls.Add(radioButtonAddOption1);
            panelAddAnswerOptions.Controls.Add(labelCorrectAnswer);
            panelAddAnswerOptions.Controls.Add(labelAddOption3);
            panelAddAnswerOptions.Controls.Add(textBoxAddOption3);
            panelAddAnswerOptions.Controls.Add(labelAddOption2);
            panelAddAnswerOptions.Controls.Add(textBoxAddOption2);
            panelAddAnswerOptions.Controls.Add(labelAddOption1);
            panelAddAnswerOptions.Controls.Add(textBoxAddOption1);
            panelAddAnswerOptions.Controls.Add(labelAddAnswerOptions);
            panelAddAnswerOptions.Location = new Point(316, 300);
            panelAddAnswerOptions.Name = "panelAddAnswerOptions";
            panelAddAnswerOptions.Size = new Size(388, 176);
            panelAddAnswerOptions.TabIndex = 4;
            panelAddAnswerOptions.Visible = false;
            // 
            // radioButtonAddOption3
            // 
            radioButtonAddOption3.AutoSize = true;
            radioButtonAddOption3.Location = new Point(332, 136);
            radioButtonAddOption3.Name = "radioButtonAddOption3";
            radioButtonAddOption3.Size = new Size(17, 16);
            radioButtonAddOption3.TabIndex = 12;
            radioButtonAddOption3.TabStop = true;
            radioButtonAddOption3.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddOption2
            // 
            radioButtonAddOption2.AutoSize = true;
            radioButtonAddOption2.Location = new Point(332, 96);
            radioButtonAddOption2.Name = "radioButtonAddOption2";
            radioButtonAddOption2.Size = new Size(17, 16);
            radioButtonAddOption2.TabIndex = 11;
            radioButtonAddOption2.TabStop = true;
            radioButtonAddOption2.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddOption1
            // 
            radioButtonAddOption1.AutoSize = true;
            radioButtonAddOption1.Location = new Point(332, 56);
            radioButtonAddOption1.Name = "radioButtonAddOption1";
            radioButtonAddOption1.Size = new Size(17, 16);
            radioButtonAddOption1.TabIndex = 10;
            radioButtonAddOption1.TabStop = true;
            radioButtonAddOption1.UseVisualStyleBackColor = true;
            // 
            // labelCorrectAnswer
            // 
            labelCorrectAnswer.AutoSize = true;
            labelCorrectAnswer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelCorrectAnswer.Location = new Point(300, 12);
            labelCorrectAnswer.Name = "labelCorrectAnswer";
            labelCorrectAnswer.Size = new Size(77, 28);
            labelCorrectAnswer.TabIndex = 9;
            labelCorrectAnswer.Text = "Correct";
            // 
            // labelAddOption3
            // 
            labelAddOption3.AutoSize = true;
            labelAddOption3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddOption3.Location = new Point(23, 132);
            labelAddOption3.Name = "labelAddOption3";
            labelAddOption3.Size = new Size(85, 25);
            labelAddOption3.TabIndex = 8;
            labelAddOption3.Text = "Option 3";
            // 
            // textBoxAddOption3
            // 
            textBoxAddOption3.Location = new Point(115, 131);
            textBoxAddOption3.Name = "textBoxAddOption3";
            textBoxAddOption3.Size = new Size(204, 27);
            textBoxAddOption3.TabIndex = 7;
            // 
            // labelAddOption2
            // 
            labelAddOption2.AutoSize = true;
            labelAddOption2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddOption2.Location = new Point(23, 92);
            labelAddOption2.Name = "labelAddOption2";
            labelAddOption2.Size = new Size(85, 25);
            labelAddOption2.TabIndex = 6;
            labelAddOption2.Text = "Option 2";
            // 
            // textBoxAddOption2
            // 
            textBoxAddOption2.Location = new Point(115, 91);
            textBoxAddOption2.Name = "textBoxAddOption2";
            textBoxAddOption2.Size = new Size(204, 27);
            textBoxAddOption2.TabIndex = 5;
            // 
            // labelAddOption1
            // 
            labelAddOption1.AutoSize = true;
            labelAddOption1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddOption1.Location = new Point(23, 52);
            labelAddOption1.Name = "labelAddOption1";
            labelAddOption1.Size = new Size(85, 25);
            labelAddOption1.TabIndex = 4;
            labelAddOption1.Text = "Option 1";
            // 
            // textBoxAddOption1
            // 
            textBoxAddOption1.Location = new Point(115, 51);
            textBoxAddOption1.Name = "textBoxAddOption1";
            textBoxAddOption1.Size = new Size(204, 27);
            textBoxAddOption1.TabIndex = 3;
            // 
            // labelAddAnswerOptions
            // 
            labelAddAnswerOptions.AutoSize = true;
            labelAddAnswerOptions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddAnswerOptions.Location = new Point(23, 12);
            labelAddAnswerOptions.Name = "labelAddAnswerOptions";
            labelAddAnswerOptions.Size = new Size(157, 28);
            labelAddAnswerOptions.TabIndex = 2;
            labelAddAnswerOptions.Text = "Answer Options";
            // 
            // panelAddQuestionDifficulty
            // 
            panelAddQuestionDifficulty.BackColor = Color.FromArgb(0, 106, 125);
            panelAddQuestionDifficulty.Controls.Add(radioButtonAddHard);
            panelAddQuestionDifficulty.Controls.Add(radioButtonAddMedium);
            panelAddQuestionDifficulty.Controls.Add(radioButtonAddEasy);
            panelAddQuestionDifficulty.Controls.Add(labelAddQuestionDifficulty);
            panelAddQuestionDifficulty.Location = new Point(35, 300);
            panelAddQuestionDifficulty.Name = "panelAddQuestionDifficulty";
            panelAddQuestionDifficulty.Size = new Size(243, 176);
            panelAddQuestionDifficulty.TabIndex = 6;
            panelAddQuestionDifficulty.Visible = false;
            // 
            // radioButtonAddHard
            // 
            radioButtonAddHard.AutoSize = true;
            radioButtonAddHard.Location = new Point(22, 130);
            radioButtonAddHard.Name = "radioButtonAddHard";
            radioButtonAddHard.Size = new Size(63, 24);
            radioButtonAddHard.TabIndex = 3;
            radioButtonAddHard.TabStop = true;
            radioButtonAddHard.Text = "Hard";
            radioButtonAddHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddMedium
            // 
            radioButtonAddMedium.AutoSize = true;
            radioButtonAddMedium.Location = new Point(22, 95);
            radioButtonAddMedium.Name = "radioButtonAddMedium";
            radioButtonAddMedium.Size = new Size(85, 24);
            radioButtonAddMedium.TabIndex = 2;
            radioButtonAddMedium.TabStop = true;
            radioButtonAddMedium.Text = "Medium";
            radioButtonAddMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonAddEasy
            // 
            radioButtonAddEasy.AutoSize = true;
            radioButtonAddEasy.Location = new Point(22, 60);
            radioButtonAddEasy.Name = "radioButtonAddEasy";
            radioButtonAddEasy.Size = new Size(59, 24);
            radioButtonAddEasy.TabIndex = 1;
            radioButtonAddEasy.TabStop = true;
            radioButtonAddEasy.Text = "Easy";
            radioButtonAddEasy.UseVisualStyleBackColor = true;
            // 
            // labelAddQuestionDifficulty
            // 
            labelAddQuestionDifficulty.AutoSize = true;
            labelAddQuestionDifficulty.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddQuestionDifficulty.Location = new Point(9, 12);
            labelAddQuestionDifficulty.Name = "labelAddQuestionDifficulty";
            labelAddQuestionDifficulty.Size = new Size(180, 28);
            labelAddQuestionDifficulty.TabIndex = 0;
            labelAddQuestionDifficulty.Text = "Question difficulty";
            // 
            // buttonAddQuestion
            // 
            buttonAddQuestion.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddQuestion.Location = new Point(723, 409);
            buttonAddQuestion.Name = "buttonAddQuestion";
            buttonAddQuestion.Size = new Size(116, 65);
            buttonAddQuestion.TabIndex = 5;
            buttonAddQuestion.Text = "Add Question";
            buttonAddQuestion.UseVisualStyleBackColor = true;
            buttonAddQuestion.Click += buttonAddQuestion_Click;
            // 
            // panelAddQuestionText
            // 
            panelAddQuestionText.BackColor = Color.FromArgb(0, 106, 125);
            panelAddQuestionText.Controls.Add(labelAddQuestionText);
            panelAddQuestionText.Controls.Add(richTextBoxAddQuestionText);
            panelAddQuestionText.Location = new Point(316, 104);
            panelAddQuestionText.Name = "panelAddQuestionText";
            panelAddQuestionText.Size = new Size(388, 170);
            panelAddQuestionText.TabIndex = 2;
            panelAddQuestionText.Visible = false;
            // 
            // labelAddQuestionText
            // 
            labelAddQuestionText.AutoSize = true;
            labelAddQuestionText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddQuestionText.Location = new Point(24, 11);
            labelAddQuestionText.Name = "labelAddQuestionText";
            labelAddQuestionText.Size = new Size(136, 28);
            labelAddQuestionText.TabIndex = 1;
            labelAddQuestionText.Text = "Question text";
            // 
            // richTextBoxAddQuestionText
            // 
            richTextBoxAddQuestionText.Location = new Point(24, 55);
            richTextBoxAddQuestionText.Name = "richTextBoxAddQuestionText";
            richTextBoxAddQuestionText.Size = new Size(335, 85);
            richTextBoxAddQuestionText.TabIndex = 0;
            richTextBoxAddQuestionText.Text = "";
            // 
            // panelAddQuestionType
            // 
            panelAddQuestionType.BackColor = Color.FromArgb(0, 106, 125);
            panelAddQuestionType.Controls.Add(radioButton1);
            panelAddQuestionType.Controls.Add(radioButtonAddMCQuestion);
            panelAddQuestionType.Controls.Add(radioButtonAddTextQuestion);
            panelAddQuestionType.Controls.Add(labelAddQuestionType);
            panelAddQuestionType.Location = new Point(35, 104);
            panelAddQuestionType.Name = "panelAddQuestionType";
            panelAddQuestionType.Size = new Size(243, 170);
            panelAddQuestionType.TabIndex = 1;
            // 
            // radioButtonAddMCQuestion
            // 
            radioButtonAddMCQuestion.AutoSize = true;
            radioButtonAddMCQuestion.Location = new Point(22, 95);
            radioButtonAddMCQuestion.Name = "radioButtonAddMCQuestion";
            radioButtonAddMCQuestion.Size = new Size(197, 24);
            radioButtonAddMCQuestion.TabIndex = 2;
            radioButtonAddMCQuestion.TabStop = true;
            radioButtonAddMCQuestion.Text = "Multiple Choice Question";
            radioButtonAddMCQuestion.UseVisualStyleBackColor = true;
            radioButtonAddMCQuestion.CheckedChanged += radioButtonAddMCQuestion_CheckedChanged;
            // 
            // radioButtonAddTextQuestion
            // 
            radioButtonAddTextQuestion.AutoSize = true;
            radioButtonAddTextQuestion.Location = new Point(22, 60);
            radioButtonAddTextQuestion.Name = "radioButtonAddTextQuestion";
            radioButtonAddTextQuestion.Size = new Size(120, 24);
            radioButtonAddTextQuestion.TabIndex = 1;
            radioButtonAddTextQuestion.TabStop = true;
            radioButtonAddTextQuestion.Text = "Text Question";
            radioButtonAddTextQuestion.UseVisualStyleBackColor = true;
            radioButtonAddTextQuestion.CheckedChanged += radioButtonAddTextQuestion_CheckedChanged;
            // 
            // labelAddQuestionType
            // 
            labelAddQuestionType.AutoSize = true;
            labelAddQuestionType.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddQuestionType.Location = new Point(9, 11);
            labelAddQuestionType.Name = "labelAddQuestionType";
            labelAddQuestionType.Size = new Size(141, 28);
            labelAddQuestionType.TabIndex = 0;
            labelAddQuestionType.Text = "Question type";
            // 
            // labelAddQuestionTitle
            // 
            labelAddQuestionTitle.AutoSize = true;
            labelAddQuestionTitle.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddQuestionTitle.Location = new Point(35, 35);
            labelAddQuestionTitle.Name = "labelAddQuestionTitle";
            labelAddQuestionTitle.Size = new Size(236, 34);
            labelAddQuestionTitle.TabIndex = 0;
            labelAddQuestionTitle.Text = "Design Question";
            // 
            // panelAddTextAnswer
            // 
            panelAddTextAnswer.BackColor = Color.FromArgb(0, 106, 125);
            panelAddTextAnswer.Controls.Add(textBoxAddTextAnswer);
            panelAddTextAnswer.Controls.Add(labelQuestionAnswer);
            panelAddTextAnswer.Location = new Point(316, 300);
            panelAddTextAnswer.Name = "panelAddTextAnswer";
            panelAddTextAnswer.Size = new Size(359, 113);
            panelAddTextAnswer.TabIndex = 3;
            panelAddTextAnswer.Visible = false;
            // 
            // textBoxAddTextAnswer
            // 
            textBoxAddTextAnswer.Location = new Point(23, 60);
            textBoxAddTextAnswer.Name = "textBoxAddTextAnswer";
            textBoxAddTextAnswer.Size = new Size(309, 27);
            textBoxAddTextAnswer.TabIndex = 3;
            // 
            // labelQuestionAnswer
            // 
            labelQuestionAnswer.AutoSize = true;
            labelQuestionAnswer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuestionAnswer.Location = new Point(23, 12);
            labelQuestionAnswer.Name = "labelQuestionAnswer";
            labelQuestionAnswer.Size = new Size(165, 28);
            labelQuestionAnswer.TabIndex = 2;
            labelQuestionAnswer.Text = "Question answer";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(22, 130);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(134, 24);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Match Question";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // QuestionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 151, 178);
            ClientSize = new Size(1009, 626);
            Controls.Add(panelAdd);
            Controls.Add(panelEditDelete);
            Name = "QuestionsForm";
            Text = "QuestionsForm";
            panelEditDelete.ResumeLayout(false);
            panelEditDelete.PerformLayout();
            panelPickQuestionType.ResumeLayout(false);
            panelPickQuestionType.PerformLayout();
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            panelAddAnswerOptions.ResumeLayout(false);
            panelAddAnswerOptions.PerformLayout();
            panelAddQuestionDifficulty.ResumeLayout(false);
            panelAddQuestionDifficulty.PerformLayout();
            panelAddQuestionText.ResumeLayout(false);
            panelAddQuestionText.PerformLayout();
            panelAddQuestionType.ResumeLayout(false);
            panelAddQuestionType.PerformLayout();
            panelAddTextAnswer.ResumeLayout(false);
            panelAddTextAnswer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelEditDelete;
        private ListView listViewQuestions;
        private ColumnHeader Question;
        private ColumnHeader Difficulty;
        private ColumnHeader Type;
        private Button btnDeleteQuestion;
        private Button btnEdit;
        private Button btnAddQuestion;
        private Panel panelAdd;
        private Panel panelAddQuestionType;
        private RadioButton radioButtonAddMCQuestion;
        private RadioButton radioButtonAddTextQuestion;
        private Label labelAddQuestionType;
        private Label labelAddQuestionTitle;
        private Panel panelAddTextAnswer;
        private Label labelQuestionAnswer;
        private Panel panelAddQuestionText;
        private Label labelAddQuestionText;
        private RichTextBox richTextBoxAddQuestionText;
        private Panel panelAddAnswerOptions;
        private TextBox textBoxAddTextAnswer;
        private Label labelCorrectAnswer;
        private Label labelAddOption3;
        private TextBox textBoxAddOption3;
        private Label labelAddOption2;
        private TextBox textBoxAddOption2;
        private Label labelAddOption1;
        private TextBox textBoxAddOption1;
        private Label labelAddAnswerOptions;
        private Button buttonAddQuestion;
        private RadioButton radioButtonAddOption3;
        private RadioButton radioButtonAddOption2;
        private RadioButton radioButtonAddOption1;
        private Panel panelAddQuestionDifficulty;
        private RadioButton radioButtonAddHard;
        private RadioButton radioButtonAddMedium;
        private RadioButton radioButtonAddEasy;
        private Label labelAddQuestionDifficulty;
        private Panel panelPickQuestionType;
        private ComboBox comboBoxDifficultyView;
        private Label labelPickTypeView;
        private Label labelViewQuestionsTitle;
        private ListBox listBoxViewQuestions;
        private RadioButton radioButton1;
    }
}