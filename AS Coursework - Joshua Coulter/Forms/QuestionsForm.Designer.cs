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
            panelChooseFile = new Panel();
            textBoxFilePath = new TextBox();
            btnChooseFile = new Button();
            labelChooseFile = new Label();
            panelMediaChoice = new Panel();
            radioButtonNeither = new RadioButton();
            radioButtonPicture = new RadioButton();
            radioButtonAudio = new RadioButton();
            labelMediaChoice = new Label();
            panelAddQuestionDifficulty = new Panel();
            radioButtonAddHard = new RadioButton();
            radioButtonAddMedium = new RadioButton();
            radioButtonAddEasy = new RadioButton();
            labelAddQuestionDifficulty = new Label();
            buttonAddQuestion = new Button();
            panelAddQuestionType = new Panel();
            radioButtonMatch = new RadioButton();
            radioButtonMultipleChoice = new RadioButton();
            radioButtonText = new RadioButton();
            labelAddQuestionType = new Label();
            labelAddQuestionTitle = new Label();
            panelAddQuestionText = new Panel();
            labelAddQuestionText = new Label();
            richTextBoxAddQuestionText = new RichTextBox();
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
            panelAddTextAnswer = new Panel();
            textBoxAddTextAnswer = new TextBox();
            labelQuestionAnswer = new Label();
            panelAddMatchPairs = new Panel();
            textBoxRight2 = new TextBox();
            textBoxRight4 = new TextBox();
            textBoxRight3 = new TextBox();
            textBoxRight1 = new TextBox();
            textBoxLeft4 = new TextBox();
            textBoxLeft3 = new TextBox();
            textBoxLeft2 = new TextBox();
            labelQuestionOptions = new Label();
            textBoxLeft1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            openFileDialogChooseMedia = new OpenFileDialog();
            panelEditDelete.SuspendLayout();
            panelPickQuestionType.SuspendLayout();
            panelAdd.SuspendLayout();
            panelChooseFile.SuspendLayout();
            panelMediaChoice.SuspendLayout();
            panelAddQuestionDifficulty.SuspendLayout();
            panelAddQuestionType.SuspendLayout();
            panelAddQuestionText.SuspendLayout();
            panelAddAnswerOptions.SuspendLayout();
            panelAddTextAnswer.SuspendLayout();
            panelAddMatchPairs.SuspendLayout();
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
            comboBoxDifficultyView.Items.AddRange(new object[] { "Text Questions", "Mulitple Choice Questions", "Audio Text Questions", "Audio Multiple Choice Questions", "Picture Text Questions", "Picture Multiple Choice Questions", "Match Questions" });
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
            btnAddQuestion.ForeColor = Color.Black;
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
            btnDeleteQuestion.ForeColor = Color.Black;
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
            btnEdit.BackColor = Color.White;
            btnEdit.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(593, 159);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(192, 70);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit Question";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // panelAdd
            // 
            panelAdd.Anchor = AnchorStyles.None;
            panelAdd.BackColor = Color.FromArgb(0, 192, 192);
            panelAdd.Controls.Add(panelChooseFile);
            panelAdd.Controls.Add(panelMediaChoice);
            panelAdd.Controls.Add(panelAddQuestionDifficulty);
            panelAdd.Controls.Add(buttonAddQuestion);
            panelAdd.Controls.Add(panelAddQuestionType);
            panelAdd.Controls.Add(labelAddQuestionTitle);
            panelAdd.Controls.Add(panelAddQuestionText);
            panelAdd.Controls.Add(panelAddAnswerOptions);
            panelAdd.Controls.Add(panelAddTextAnswer);
            panelAdd.Controls.Add(panelAddMatchPairs);
            panelAdd.Location = new Point(47, 63);
            panelAdd.Name = "panelAdd";
            panelAdd.Size = new Size(920, 497);
            panelAdd.TabIndex = 1;
            // 
            // panelChooseFile
            // 
            panelChooseFile.BackColor = Color.FromArgb(0, 106, 125);
            panelChooseFile.Controls.Add(textBoxFilePath);
            panelChooseFile.Controls.Add(btnChooseFile);
            panelChooseFile.Controls.Add(labelChooseFile);
            panelChooseFile.Location = new Point(735, 264);
            panelChooseFile.Name = "panelChooseFile";
            panelChooseFile.Size = new Size(162, 134);
            panelChooseFile.TabIndex = 9;
            panelChooseFile.Visible = false;
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Location = new Point(12, 46);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.ReadOnly = true;
            textBoxFilePath.Size = new Size(132, 27);
            textBoxFilePath.TabIndex = 5;
            // 
            // btnChooseFile
            // 
            btnChooseFile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnChooseFile.Location = new Point(12, 96);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(94, 29);
            btnChooseFile.TabIndex = 4;
            btnChooseFile.Text = "Choose file";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // labelChooseFile
            // 
            labelChooseFile.AutoSize = true;
            labelChooseFile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelChooseFile.Location = new Point(3, 4);
            labelChooseFile.Name = "labelChooseFile";
            labelChooseFile.Size = new Size(103, 28);
            labelChooseFile.TabIndex = 3;
            labelChooseFile.Text = "Select File";
            // 
            // panelMediaChoice
            // 
            panelMediaChoice.BackColor = Color.FromArgb(0, 106, 125);
            panelMediaChoice.Controls.Add(radioButtonNeither);
            panelMediaChoice.Controls.Add(radioButtonPicture);
            panelMediaChoice.Controls.Add(radioButtonAudio);
            panelMediaChoice.Controls.Add(labelMediaChoice);
            panelMediaChoice.Location = new Point(735, 104);
            panelMediaChoice.Name = "panelMediaChoice";
            panelMediaChoice.Size = new Size(162, 138);
            panelMediaChoice.TabIndex = 8;
            panelMediaChoice.Visible = false;
            // 
            // radioButtonNeither
            // 
            radioButtonNeither.AutoSize = true;
            radioButtonNeither.Location = new Point(16, 104);
            radioButtonNeither.Name = "radioButtonNeither";
            radioButtonNeither.Size = new Size(79, 24);
            radioButtonNeither.TabIndex = 6;
            radioButtonNeither.TabStop = true;
            radioButtonNeither.Text = "Neither";
            radioButtonNeither.UseVisualStyleBackColor = true;
            radioButtonNeither.CheckedChanged += radioButtonAddTextQuestion_CheckedChanged;
            // 
            // radioButtonPicture
            // 
            radioButtonPicture.AutoSize = true;
            radioButtonPicture.Location = new Point(16, 69);
            radioButtonPicture.Name = "radioButtonPicture";
            radioButtonPicture.Size = new Size(75, 24);
            radioButtonPicture.TabIndex = 5;
            radioButtonPicture.TabStop = true;
            radioButtonPicture.Text = "Picture";
            radioButtonPicture.UseVisualStyleBackColor = true;
            radioButtonPicture.CheckedChanged += radioButtonAddTextQuestion_CheckedChanged;
            // 
            // radioButtonAudio
            // 
            radioButtonAudio.AutoSize = true;
            radioButtonAudio.Location = new Point(16, 34);
            radioButtonAudio.Name = "radioButtonAudio";
            radioButtonAudio.Size = new Size(70, 24);
            radioButtonAudio.TabIndex = 4;
            radioButtonAudio.TabStop = true;
            radioButtonAudio.Text = "Audio";
            radioButtonAudio.UseVisualStyleBackColor = true;
            radioButtonAudio.CheckedChanged += radioButtonAddTextQuestion_CheckedChanged;
            // 
            // labelMediaChoice
            // 
            labelMediaChoice.AutoSize = true;
            labelMediaChoice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMediaChoice.Location = new Point(3, 3);
            labelMediaChoice.Name = "labelMediaChoice";
            labelMediaChoice.Size = new Size(137, 28);
            labelMediaChoice.TabIndex = 2;
            labelMediaChoice.Text = "Picture/Audio";
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
            buttonAddQuestion.Location = new Point(735, 409);
            buttonAddQuestion.Name = "buttonAddQuestion";
            buttonAddQuestion.Size = new Size(162, 65);
            buttonAddQuestion.TabIndex = 5;
            buttonAddQuestion.Text = "Add Question";
            buttonAddQuestion.UseVisualStyleBackColor = true;
            buttonAddQuestion.Click += buttonAddQuestion_Click;
            // 
            // panelAddQuestionType
            // 
            panelAddQuestionType.BackColor = Color.FromArgb(0, 106, 125);
            panelAddQuestionType.Controls.Add(radioButtonMatch);
            panelAddQuestionType.Controls.Add(radioButtonMultipleChoice);
            panelAddQuestionType.Controls.Add(radioButtonText);
            panelAddQuestionType.Controls.Add(labelAddQuestionType);
            panelAddQuestionType.Location = new Point(35, 104);
            panelAddQuestionType.Name = "panelAddQuestionType";
            panelAddQuestionType.Size = new Size(243, 170);
            panelAddQuestionType.TabIndex = 1;
            // 
            // radioButtonMatch
            // 
            radioButtonMatch.AutoSize = true;
            radioButtonMatch.Location = new Point(22, 130);
            radioButtonMatch.Name = "radioButtonMatch";
            radioButtonMatch.Size = new Size(134, 24);
            radioButtonMatch.TabIndex = 3;
            radioButtonMatch.TabStop = true;
            radioButtonMatch.Text = "Match Question";
            radioButtonMatch.UseVisualStyleBackColor = true;
            radioButtonMatch.CheckedChanged += radioButtonAddTextQuestion_CheckedChanged;
            // 
            // radioButtonMultipleChoice
            // 
            radioButtonMultipleChoice.AutoSize = true;
            radioButtonMultipleChoice.Location = new Point(22, 95);
            radioButtonMultipleChoice.Name = "radioButtonMultipleChoice";
            radioButtonMultipleChoice.Size = new Size(197, 24);
            radioButtonMultipleChoice.TabIndex = 2;
            radioButtonMultipleChoice.TabStop = true;
            radioButtonMultipleChoice.Text = "Multiple Choice Question";
            radioButtonMultipleChoice.UseVisualStyleBackColor = true;
            radioButtonMultipleChoice.CheckedChanged += radioButtonAddTextQuestion_CheckedChanged;
            // 
            // radioButtonText
            // 
            radioButtonText.AutoSize = true;
            radioButtonText.Location = new Point(22, 60);
            radioButtonText.Name = "radioButtonText";
            radioButtonText.Size = new Size(120, 24);
            radioButtonText.TabIndex = 1;
            radioButtonText.TabStop = true;
            radioButtonText.Text = "Text Question";
            radioButtonText.UseVisualStyleBackColor = true;
            radioButtonText.CheckedChanged += radioButtonAddTextQuestion_CheckedChanged;
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
            // panelAddQuestionText
            // 
            panelAddQuestionText.BackColor = Color.FromArgb(0, 106, 125);
            panelAddQuestionText.Controls.Add(labelAddQuestionText);
            panelAddQuestionText.Controls.Add(richTextBoxAddQuestionText);
            panelAddQuestionText.Location = new Point(316, 60);
            panelAddQuestionText.Name = "panelAddQuestionText";
            panelAddQuestionText.Size = new Size(388, 113);
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
            richTextBoxAddQuestionText.Location = new Point(23, 44);
            richTextBoxAddQuestionText.MaxLength = 55;
            richTextBoxAddQuestionText.Name = "richTextBoxAddQuestionText";
            richTextBoxAddQuestionText.Size = new Size(335, 54);
            richTextBoxAddQuestionText.TabIndex = 0;
            richTextBoxAddQuestionText.Text = "";
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
            // panelAddMatchPairs
            // 
            panelAddMatchPairs.BackColor = Color.FromArgb(0, 106, 125);
            panelAddMatchPairs.Controls.Add(textBoxRight2);
            panelAddMatchPairs.Controls.Add(textBoxRight4);
            panelAddMatchPairs.Controls.Add(textBoxRight3);
            panelAddMatchPairs.Controls.Add(textBoxRight1);
            panelAddMatchPairs.Controls.Add(textBoxLeft4);
            panelAddMatchPairs.Controls.Add(textBoxLeft3);
            panelAddMatchPairs.Controls.Add(textBoxLeft2);
            panelAddMatchPairs.Controls.Add(labelQuestionOptions);
            panelAddMatchPairs.Controls.Add(textBoxLeft1);
            panelAddMatchPairs.Controls.Add(label1);
            panelAddMatchPairs.Controls.Add(label3);
            panelAddMatchPairs.Controls.Add(label4);
            panelAddMatchPairs.Controls.Add(label2);
            panelAddMatchPairs.Location = new Point(316, 188);
            panelAddMatchPairs.Name = "panelAddMatchPairs";
            panelAddMatchPairs.Size = new Size(388, 288);
            panelAddMatchPairs.TabIndex = 7;
            panelAddMatchPairs.Visible = false;
            // 
            // textBoxRight2
            // 
            textBoxRight2.Location = new Point(213, 125);
            textBoxRight2.Name = "textBoxRight2";
            textBoxRight2.Size = new Size(144, 27);
            textBoxRight2.TabIndex = 7;
            // 
            // textBoxRight4
            // 
            textBoxRight4.Location = new Point(213, 241);
            textBoxRight4.Name = "textBoxRight4";
            textBoxRight4.Size = new Size(144, 27);
            textBoxRight4.TabIndex = 9;
            // 
            // textBoxRight3
            // 
            textBoxRight3.Location = new Point(213, 183);
            textBoxRight3.Name = "textBoxRight3";
            textBoxRight3.Size = new Size(144, 27);
            textBoxRight3.TabIndex = 8;
            // 
            // textBoxRight1
            // 
            textBoxRight1.Location = new Point(213, 67);
            textBoxRight1.Name = "textBoxRight1";
            textBoxRight1.Size = new Size(144, 27);
            textBoxRight1.TabIndex = 6;
            // 
            // textBoxLeft4
            // 
            textBoxLeft4.Location = new Point(34, 241);
            textBoxLeft4.Name = "textBoxLeft4";
            textBoxLeft4.Size = new Size(144, 27);
            textBoxLeft4.TabIndex = 5;
            // 
            // textBoxLeft3
            // 
            textBoxLeft3.Location = new Point(34, 183);
            textBoxLeft3.Name = "textBoxLeft3";
            textBoxLeft3.Size = new Size(144, 27);
            textBoxLeft3.TabIndex = 4;
            // 
            // textBoxLeft2
            // 
            textBoxLeft2.Location = new Point(34, 125);
            textBoxLeft2.Name = "textBoxLeft2";
            textBoxLeft2.Size = new Size(144, 27);
            textBoxLeft2.TabIndex = 3;
            // 
            // labelQuestionOptions
            // 
            labelQuestionOptions.AutoSize = true;
            labelQuestionOptions.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuestionOptions.Location = new Point(15, 17);
            labelQuestionOptions.Name = "labelQuestionOptions";
            labelQuestionOptions.Size = new Size(173, 28);
            labelQuestionOptions.TabIndex = 1;
            labelQuestionOptions.Text = "Question Options";
            // 
            // textBoxLeft1
            // 
            textBoxLeft1.Location = new Point(34, 67);
            textBoxLeft1.Name = "textBoxLeft1";
            textBoxLeft1.Size = new Size(144, 27);
            textBoxLeft1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(139, 51);
            label1.Name = "label1";
            label1.Size = new Size(99, 34);
            label1.TabIndex = 10;
            label1.Text = "______";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(139, 167);
            label3.Name = "label3";
            label3.Size = new Size(99, 34);
            label3.TabIndex = 12;
            label3.Text = "______";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(139, 225);
            label4.Name = "label4";
            label4.Size = new Size(99, 34);
            label4.TabIndex = 13;
            label4.Text = "______";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(139, 109);
            label2.Name = "label2";
            label2.Size = new Size(99, 34);
            label2.TabIndex = 11;
            label2.Text = "______";
            // 
            // QuestionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 151, 178);
            ClientSize = new Size(1009, 626);
            Controls.Add(panelEditDelete);
            Controls.Add(panelAdd);
            Name = "QuestionsForm";
            Text = "QuestionsForm";
            panelEditDelete.ResumeLayout(false);
            panelEditDelete.PerformLayout();
            panelPickQuestionType.ResumeLayout(false);
            panelPickQuestionType.PerformLayout();
            panelAdd.ResumeLayout(false);
            panelAdd.PerformLayout();
            panelChooseFile.ResumeLayout(false);
            panelChooseFile.PerformLayout();
            panelMediaChoice.ResumeLayout(false);
            panelMediaChoice.PerformLayout();
            panelAddQuestionDifficulty.ResumeLayout(false);
            panelAddQuestionDifficulty.PerformLayout();
            panelAddQuestionType.ResumeLayout(false);
            panelAddQuestionType.PerformLayout();
            panelAddQuestionText.ResumeLayout(false);
            panelAddQuestionText.PerformLayout();
            panelAddAnswerOptions.ResumeLayout(false);
            panelAddAnswerOptions.PerformLayout();
            panelAddTextAnswer.ResumeLayout(false);
            panelAddTextAnswer.PerformLayout();
            panelAddMatchPairs.ResumeLayout(false);
            panelAddMatchPairs.PerformLayout();
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
        private RadioButton radioButtonMultipleChoice;
        private RadioButton radioButtonText;
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
        private RadioButton radioButtonMatch;
        private Panel panelAddMatchPairs;
        private TextBox textBoxRight2;
        private TextBox textBoxRight4;
        private TextBox textBoxRight3;
        private TextBox textBoxRight1;
        private TextBox textBoxLeft4;
        private TextBox textBoxLeft3;
        private TextBox textBoxLeft2;
        private TextBox textBoxLeft1;
        private Label labelQuestionOptions;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label2;
        private Panel panelMediaChoice;
        private RadioButton radioButtonNeither;
        private RadioButton radioButtonPicture;
        private RadioButton radioButtonAudio;
        private Label labelMediaChoice;
        private Panel panelChooseFile;
        private TextBox textBoxFilePath;
        private Button btnChooseFile;
        private Label labelChooseFile;
        private OpenFileDialog openFileDialogChooseMedia;
    }
}