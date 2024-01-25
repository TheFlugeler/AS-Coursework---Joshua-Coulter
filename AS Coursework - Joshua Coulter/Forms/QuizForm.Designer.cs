namespace AS_Coursework___Joshua_Coulter
{
    partial class QuizForm
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
            panelQuizMenu = new Panel();
            btnQuizHard = new Button();
            btnQuizMedium = new Button();
            btnQuizEasy = new Button();
            lblQuizMenuTitle = new Label();
            lblQuizTitle = new Label();
            panelTextQuestion = new Panel();
            btnPlayAudioTQ = new Button();
            btnSubmitTextQuestion = new Button();
            textBoxTextQuestion = new TextBox();
            lblTextQuestion = new Label();
            panelTextPic = new Panel();
            pictureBoxText = new PictureBox();
            panelMultipleChoiceQuestion = new Panel();
            btnPlayAudioMCQ = new Button();
            btnOption3 = new Button();
            btnOption2 = new Button();
            btnOption1 = new Button();
            lblMultipleChoiceQuestion = new Label();
            panelMCPic = new Panel();
            pictureBoxMultipleChoice = new PictureBox();
            panelQuizEndScreen = new Panel();
            btnQuizEndScreen = new Button();
            lblQuizEndScreen = new Label();
            panelMatchQuestion = new Panel();
            btnSubmitMatch = new Button();
            comboBoxRight4 = new ComboBox();
            comboBoxLeft4 = new ComboBox();
            comboBoxRight1 = new ComboBox();
            comboBoxLeft2 = new ComboBox();
            comboBoxRight2 = new ComboBox();
            comboBoxLeft3 = new ComboBox();
            comboBoxRight3 = new ComboBox();
            comboBoxLeft1 = new ComboBox();
            labelMatchQuestion = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            panelQuizMenu.SuspendLayout();
            panelTextQuestion.SuspendLayout();
            panelTextPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxText).BeginInit();
            panelMultipleChoiceQuestion.SuspendLayout();
            panelMCPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMultipleChoice).BeginInit();
            panelQuizEndScreen.SuspendLayout();
            panelMatchQuestion.SuspendLayout();
            SuspendLayout();
            // 
            // panelQuizMenu
            // 
            panelQuizMenu.Anchor = AnchorStyles.None;
            panelQuizMenu.BackColor = Color.FromArgb(0, 106, 125);
            panelQuizMenu.Controls.Add(btnQuizHard);
            panelQuizMenu.Controls.Add(btnQuizMedium);
            panelQuizMenu.Controls.Add(btnQuizEasy);
            panelQuizMenu.Controls.Add(lblQuizMenuTitle);
            panelQuizMenu.Location = new Point(226, 96);
            panelQuizMenu.Name = "panelQuizMenu";
            panelQuizMenu.Size = new Size(557, 518);
            panelQuizMenu.TabIndex = 0;
            // 
            // btnQuizHard
            // 
            btnQuizHard.Anchor = AnchorStyles.None;
            btnQuizHard.BackColor = Color.FromArgb(209, 69, 50);
            btnQuizHard.FlatAppearance.BorderColor = Color.Green;
            btnQuizHard.FlatStyle = FlatStyle.Flat;
            btnQuizHard.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuizHard.Location = new Point(195, 374);
            btnQuizHard.Name = "btnQuizHard";
            btnQuizHard.Size = new Size(166, 63);
            btnQuizHard.TabIndex = 3;
            btnQuizHard.Text = "Hard";
            btnQuizHard.UseVisualStyleBackColor = false;
            btnQuizHard.Click += btnQuizHard_Click;
            // 
            // btnQuizMedium
            // 
            btnQuizMedium.Anchor = AnchorStyles.None;
            btnQuizMedium.BackColor = Color.FromArgb(235, 228, 40);
            btnQuizMedium.FlatAppearance.BorderColor = Color.Green;
            btnQuizMedium.FlatStyle = FlatStyle.Flat;
            btnQuizMedium.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuizMedium.Location = new Point(195, 255);
            btnQuizMedium.Name = "btnQuizMedium";
            btnQuizMedium.Size = new Size(166, 63);
            btnQuizMedium.TabIndex = 2;
            btnQuizMedium.Text = "Medium";
            btnQuizMedium.UseVisualStyleBackColor = false;
            btnQuizMedium.Click += btnQuizMedium_Click;
            // 
            // btnQuizEasy
            // 
            btnQuizEasy.Anchor = AnchorStyles.None;
            btnQuizEasy.BackColor = Color.FromArgb(76, 130, 64);
            btnQuizEasy.FlatAppearance.BorderColor = Color.Green;
            btnQuizEasy.FlatStyle = FlatStyle.Flat;
            btnQuizEasy.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuizEasy.Location = new Point(195, 136);
            btnQuizEasy.Name = "btnQuizEasy";
            btnQuizEasy.Size = new Size(166, 63);
            btnQuizEasy.TabIndex = 1;
            btnQuizEasy.Text = "Easy";
            btnQuizEasy.UseVisualStyleBackColor = false;
            btnQuizEasy.Click += btnQuizEasy_Click;
            // 
            // lblQuizMenuTitle
            // 
            lblQuizMenuTitle.Anchor = AnchorStyles.None;
            lblQuizMenuTitle.AutoSize = true;
            lblQuizMenuTitle.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblQuizMenuTitle.Location = new Point(85, 43);
            lblQuizMenuTitle.Name = "lblQuizMenuTitle";
            lblQuizMenuTitle.Size = new Size(386, 37);
            lblQuizMenuTitle.TabIndex = 0;
            lblQuizMenuTitle.Text = "Please choose a difficulty";
            // 
            // lblQuizTitle
            // 
            lblQuizTitle.Anchor = AnchorStyles.None;
            lblQuizTitle.AutoSize = true;
            lblQuizTitle.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuizTitle.Location = new Point(306, 22);
            lblQuizTitle.Name = "lblQuizTitle";
            lblQuizTitle.Size = new Size(396, 44);
            lblQuizTitle.TabIndex = 1;
            lblQuizTitle.Text = "Welcome to the quiz!";
            // 
            // panelTextQuestion
            // 
            panelTextQuestion.Anchor = AnchorStyles.None;
            panelTextQuestion.BackColor = Color.FromArgb(0, 106, 125);
            panelTextQuestion.Controls.Add(btnPlayAudioTQ);
            panelTextQuestion.Controls.Add(btnSubmitTextQuestion);
            panelTextQuestion.Controls.Add(textBoxTextQuestion);
            panelTextQuestion.Controls.Add(lblTextQuestion);
            panelTextQuestion.Controls.Add(panelTextPic);
            panelTextQuestion.Location = new Point(24, 96);
            panelTextQuestion.Name = "panelTextQuestion";
            panelTextQuestion.Size = new Size(961, 518);
            panelTextQuestion.TabIndex = 2;
            panelTextQuestion.Visible = false;
            // 
            // btnPlayAudioTQ
            // 
            btnPlayAudioTQ.BackgroundImage = Properties.Images.Play_button;
            btnPlayAudioTQ.BackgroundImageLayout = ImageLayout.Zoom;
            btnPlayAudioTQ.FlatAppearance.BorderSize = 0;
            btnPlayAudioTQ.FlatStyle = FlatStyle.Flat;
            btnPlayAudioTQ.ForeColor = Color.Transparent;
            btnPlayAudioTQ.Location = new Point(469, 215);
            btnPlayAudioTQ.Name = "btnPlayAudioTQ";
            btnPlayAudioTQ.Size = new Size(70, 70);
            btnPlayAudioTQ.TabIndex = 6;
            btnPlayAudioTQ.UseVisualStyleBackColor = true;
            btnPlayAudioTQ.Visible = false;
            btnPlayAudioTQ.Click += btnPlayAudioTQ_Click;
            // 
            // btnSubmitTextQuestion
            // 
            btnSubmitTextQuestion.Anchor = AnchorStyles.None;
            btnSubmitTextQuestion.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitTextQuestion.Location = new Point(770, 407);
            btnSubmitTextQuestion.Name = "btnSubmitTextQuestion";
            btnSubmitTextQuestion.Size = new Size(147, 44);
            btnSubmitTextQuestion.TabIndex = 2;
            btnSubmitTextQuestion.Text = "Submit";
            btnSubmitTextQuestion.UseVisualStyleBackColor = true;
            btnSubmitTextQuestion.Click += btnSubmitTextQuestion_Click;
            // 
            // textBoxTextQuestion
            // 
            textBoxTextQuestion.Anchor = AnchorStyles.None;
            textBoxTextQuestion.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTextQuestion.Location = new Point(76, 410);
            textBoxTextQuestion.Name = "textBoxTextQuestion";
            textBoxTextQuestion.Size = new Size(643, 41);
            textBoxTextQuestion.TabIndex = 1;
            // 
            // lblTextQuestion
            // 
            lblTextQuestion.Anchor = AnchorStyles.None;
            lblTextQuestion.AutoSize = true;
            lblTextQuestion.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTextQuestion.Location = new Point(70, 70);
            lblTextQuestion.Name = "lblTextQuestion";
            lblTextQuestion.Size = new Size(49, 38);
            lblTextQuestion.TabIndex = 0;
            lblTextQuestion.Text = "Q:";
            // 
            // panelTextPic
            // 
            panelTextPic.BackColor = Color.FromArgb(0, 192, 192);
            panelTextPic.Controls.Add(pictureBoxText);
            panelTextPic.Location = new Point(298, 125);
            panelTextPic.Name = "panelTextPic";
            panelTextPic.Size = new Size(421, 223);
            panelTextPic.TabIndex = 9;
            panelTextPic.Visible = false;
            // 
            // pictureBoxText
            // 
            pictureBoxText.BackColor = Color.FromArgb(0, 192, 192);
            pictureBoxText.Location = new Point(22, 20);
            pictureBoxText.Name = "pictureBoxText";
            pictureBoxText.Size = new Size(378, 188);
            pictureBoxText.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxText.TabIndex = 8;
            pictureBoxText.TabStop = false;
            // 
            // panelMultipleChoiceQuestion
            // 
            panelMultipleChoiceQuestion.Anchor = AnchorStyles.None;
            panelMultipleChoiceQuestion.BackColor = Color.FromArgb(0, 106, 125);
            panelMultipleChoiceQuestion.Controls.Add(btnPlayAudioMCQ);
            panelMultipleChoiceQuestion.Controls.Add(btnOption3);
            panelMultipleChoiceQuestion.Controls.Add(btnOption2);
            panelMultipleChoiceQuestion.Controls.Add(btnOption1);
            panelMultipleChoiceQuestion.Controls.Add(lblMultipleChoiceQuestion);
            panelMultipleChoiceQuestion.Controls.Add(panelMCPic);
            panelMultipleChoiceQuestion.Location = new Point(24, 96);
            panelMultipleChoiceQuestion.Name = "panelMultipleChoiceQuestion";
            panelMultipleChoiceQuestion.Size = new Size(961, 518);
            panelMultipleChoiceQuestion.TabIndex = 3;
            panelMultipleChoiceQuestion.Visible = false;
            // 
            // btnPlayAudioMCQ
            // 
            btnPlayAudioMCQ.BackgroundImage = Properties.Images.Play_button;
            btnPlayAudioMCQ.BackgroundImageLayout = ImageLayout.Zoom;
            btnPlayAudioMCQ.FlatAppearance.BorderSize = 0;
            btnPlayAudioMCQ.FlatStyle = FlatStyle.Flat;
            btnPlayAudioMCQ.ForeColor = Color.Transparent;
            btnPlayAudioMCQ.Location = new Point(469, 215);
            btnPlayAudioMCQ.Name = "btnPlayAudioMCQ";
            btnPlayAudioMCQ.Size = new Size(70, 70);
            btnPlayAudioMCQ.TabIndex = 5;
            btnPlayAudioMCQ.UseVisualStyleBackColor = true;
            btnPlayAudioMCQ.Visible = false;
            btnPlayAudioMCQ.Click += btnPlayAudioMCQ_Click;
            // 
            // btnOption3
            // 
            btnOption3.Anchor = AnchorStyles.None;
            btnOption3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOption3.Location = new Point(653, 410);
            btnOption3.Name = "btnOption3";
            btnOption3.Size = new Size(161, 58);
            btnOption3.TabIndex = 4;
            btnOption3.Text = "option 3";
            btnOption3.UseVisualStyleBackColor = true;
            btnOption3.Click += btnOption3_Click;
            // 
            // btnOption2
            // 
            btnOption2.Anchor = AnchorStyles.None;
            btnOption2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOption2.Location = new Point(423, 410);
            btnOption2.Name = "btnOption2";
            btnOption2.Size = new Size(161, 58);
            btnOption2.TabIndex = 3;
            btnOption2.Text = "option 2";
            btnOption2.UseVisualStyleBackColor = true;
            btnOption2.Click += btnOption2_Click;
            // 
            // btnOption1
            // 
            btnOption1.Anchor = AnchorStyles.None;
            btnOption1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOption1.Location = new Point(193, 410);
            btnOption1.Name = "btnOption1";
            btnOption1.Size = new Size(161, 58);
            btnOption1.TabIndex = 2;
            btnOption1.Text = "option 1";
            btnOption1.UseVisualStyleBackColor = true;
            btnOption1.Click += btnOption1_Click;
            // 
            // lblMultipleChoiceQuestion
            // 
            lblMultipleChoiceQuestion.Anchor = AnchorStyles.None;
            lblMultipleChoiceQuestion.AutoSize = true;
            lblMultipleChoiceQuestion.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblMultipleChoiceQuestion.Location = new Point(70, 70);
            lblMultipleChoiceQuestion.Name = "lblMultipleChoiceQuestion";
            lblMultipleChoiceQuestion.Size = new Size(49, 38);
            lblMultipleChoiceQuestion.TabIndex = 1;
            lblMultipleChoiceQuestion.Text = "Q:";
            // 
            // panelMCPic
            // 
            panelMCPic.BackColor = Color.FromArgb(0, 192, 192);
            panelMCPic.Controls.Add(pictureBoxMultipleChoice);
            panelMCPic.Location = new Point(301, 125);
            panelMCPic.Name = "panelMCPic";
            panelMCPic.Size = new Size(380, 220);
            panelMCPic.TabIndex = 10;
            panelMCPic.Visible = false;
            // 
            // pictureBoxMultipleChoice
            // 
            pictureBoxMultipleChoice.BackColor = Color.FromArgb(0, 192, 192);
            pictureBoxMultipleChoice.Location = new Point(20, 20);
            pictureBoxMultipleChoice.Name = "pictureBoxMultipleChoice";
            pictureBoxMultipleChoice.Size = new Size(580, 230);
            pictureBoxMultipleChoice.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMultipleChoice.TabIndex = 8;
            pictureBoxMultipleChoice.TabStop = false;
            // 
            // panelQuizEndScreen
            // 
            panelQuizEndScreen.Anchor = AnchorStyles.None;
            panelQuizEndScreen.BackColor = Color.FromArgb(0, 106, 125);
            panelQuizEndScreen.Controls.Add(btnQuizEndScreen);
            panelQuizEndScreen.Controls.Add(lblQuizEndScreen);
            panelQuizEndScreen.Location = new Point(24, 96);
            panelQuizEndScreen.Name = "panelQuizEndScreen";
            panelQuizEndScreen.Size = new Size(961, 518);
            panelQuizEndScreen.TabIndex = 4;
            panelQuizEndScreen.Visible = false;
            // 
            // btnQuizEndScreen
            // 
            btnQuizEndScreen.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuizEndScreen.Location = new Point(434, 338);
            btnQuizEndScreen.Name = "btnQuizEndScreen";
            btnQuizEndScreen.Size = new Size(140, 45);
            btnQuizEndScreen.TabIndex = 1;
            btnQuizEndScreen.Text = "Continue";
            btnQuizEndScreen.UseVisualStyleBackColor = true;
            btnQuizEndScreen.Click += btnQuizEndScreen_Click;
            // 
            // lblQuizEndScreen
            // 
            lblQuizEndScreen.Anchor = AnchorStyles.None;
            lblQuizEndScreen.AutoSize = true;
            lblQuizEndScreen.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblQuizEndScreen.Location = new Point(70, 215);
            lblQuizEndScreen.Name = "lblQuizEndScreen";
            lblQuizEndScreen.Size = new Size(781, 37);
            lblQuizEndScreen.TabIndex = 0;
            lblQuizEndScreen.Text = "Congratulations, you finished the quiz with a score of:";
            // 
            // panelMatchQuestion
            // 
            panelMatchQuestion.Anchor = AnchorStyles.None;
            panelMatchQuestion.BackColor = Color.FromArgb(0, 106, 125);
            panelMatchQuestion.Controls.Add(btnSubmitMatch);
            panelMatchQuestion.Controls.Add(comboBoxRight4);
            panelMatchQuestion.Controls.Add(comboBoxLeft4);
            panelMatchQuestion.Controls.Add(comboBoxRight1);
            panelMatchQuestion.Controls.Add(comboBoxLeft2);
            panelMatchQuestion.Controls.Add(comboBoxRight2);
            panelMatchQuestion.Controls.Add(comboBoxLeft3);
            panelMatchQuestion.Controls.Add(comboBoxRight3);
            panelMatchQuestion.Controls.Add(comboBoxLeft1);
            panelMatchQuestion.Controls.Add(labelMatchQuestion);
            panelMatchQuestion.Controls.Add(label3);
            panelMatchQuestion.Controls.Add(label2);
            panelMatchQuestion.Controls.Add(label1);
            panelMatchQuestion.Controls.Add(label4);
            panelMatchQuestion.Location = new Point(24, 96);
            panelMatchQuestion.Name = "panelMatchQuestion";
            panelMatchQuestion.Size = new Size(961, 518);
            panelMatchQuestion.TabIndex = 10;
            panelMatchQuestion.Visible = false;
            // 
            // btnSubmitMatch
            // 
            btnSubmitMatch.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSubmitMatch.Location = new Point(786, 457);
            btnSubmitMatch.Name = "btnSubmitMatch";
            btnSubmitMatch.Size = new Size(147, 44);
            btnSubmitMatch.TabIndex = 13;
            btnSubmitMatch.Text = "Submit";
            btnSubmitMatch.UseVisualStyleBackColor = true;
            btnSubmitMatch.Click += btnSubmitMatch_Click;
            // 
            // comboBoxRight4
            // 
            comboBoxRight4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxRight4.FormattingEnabled = true;
            comboBoxRight4.Location = new Point(542, 397);
            comboBoxRight4.Name = "comboBoxRight4";
            comboBoxRight4.Size = new Size(217, 39);
            comboBoxRight4.TabIndex = 8;
            // 
            // comboBoxLeft4
            // 
            comboBoxLeft4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxLeft4.FormattingEnabled = true;
            comboBoxLeft4.Location = new Point(217, 397);
            comboBoxLeft4.Name = "comboBoxLeft4";
            comboBoxLeft4.Size = new Size(217, 39);
            comboBoxLeft4.TabIndex = 7;
            // 
            // comboBoxRight1
            // 
            comboBoxRight1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxRight1.FormattingEnabled = true;
            comboBoxRight1.Location = new Point(542, 136);
            comboBoxRight1.Name = "comboBoxRight1";
            comboBoxRight1.Size = new Size(217, 39);
            comboBoxRight1.TabIndex = 6;
            // 
            // comboBoxLeft2
            // 
            comboBoxLeft2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxLeft2.FormattingEnabled = true;
            comboBoxLeft2.Location = new Point(217, 223);
            comboBoxLeft2.Name = "comboBoxLeft2";
            comboBoxLeft2.Size = new Size(217, 39);
            comboBoxLeft2.TabIndex = 5;
            // 
            // comboBoxRight2
            // 
            comboBoxRight2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxRight2.FormattingEnabled = true;
            comboBoxRight2.Location = new Point(542, 223);
            comboBoxRight2.Name = "comboBoxRight2";
            comboBoxRight2.Size = new Size(217, 39);
            comboBoxRight2.TabIndex = 4;
            // 
            // comboBoxLeft3
            // 
            comboBoxLeft3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxLeft3.FormattingEnabled = true;
            comboBoxLeft3.Location = new Point(217, 310);
            comboBoxLeft3.Name = "comboBoxLeft3";
            comboBoxLeft3.Size = new Size(217, 39);
            comboBoxLeft3.TabIndex = 3;
            // 
            // comboBoxRight3
            // 
            comboBoxRight3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxRight3.FormattingEnabled = true;
            comboBoxRight3.Location = new Point(542, 310);
            comboBoxRight3.Name = "comboBoxRight3";
            comboBoxRight3.Size = new Size(217, 39);
            comboBoxRight3.TabIndex = 2;
            // 
            // comboBoxLeft1
            // 
            comboBoxLeft1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxLeft1.FormattingEnabled = true;
            comboBoxLeft1.Location = new Point(217, 136);
            comboBoxLeft1.Name = "comboBoxLeft1";
            comboBoxLeft1.Size = new Size(217, 39);
            comboBoxLeft1.TabIndex = 1;
            // 
            // labelMatchQuestion
            // 
            labelMatchQuestion.AutoSize = true;
            labelMatchQuestion.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelMatchQuestion.Location = new Point(69, 44);
            labelMatchQuestion.Name = "labelMatchQuestion";
            labelMatchQuestion.Size = new Size(49, 38);
            labelMatchQuestion.TabIndex = 0;
            labelMatchQuestion.Text = "Q:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(419, 301);
            label3.Name = "label3";
            label3.Size = new Size(155, 34);
            label3.TabIndex = 11;
            label3.Text = "__________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(419, 213);
            label2.Name = "label2";
            label2.Size = new Size(155, 34);
            label2.TabIndex = 10;
            label2.Text = "__________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(419, 125);
            label1.Name = "label1";
            label1.Size = new Size(155, 34);
            label1.TabIndex = 9;
            label1.Text = "__________";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(419, 389);
            label4.Name = "label4";
            label4.Size = new Size(155, 34);
            label4.TabIndex = 12;
            label4.Text = "__________";
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 151, 178);
            ClientSize = new Size(1009, 626);
            Controls.Add(lblQuizTitle);
            Controls.Add(panelMatchQuestion);
            Controls.Add(panelTextQuestion);
            Controls.Add(panelQuizEndScreen);
            Controls.Add(panelQuizMenu);
            Controls.Add(panelMultipleChoiceQuestion);
            Name = "QuizForm";
            Text = "QuizForm";
            FormClosing += QuizForm_FormClosing;
            panelQuizMenu.ResumeLayout(false);
            panelQuizMenu.PerformLayout();
            panelTextQuestion.ResumeLayout(false);
            panelTextQuestion.PerformLayout();
            panelTextPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxText).EndInit();
            panelMultipleChoiceQuestion.ResumeLayout(false);
            panelMultipleChoiceQuestion.PerformLayout();
            panelMCPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMultipleChoice).EndInit();
            panelQuizEndScreen.ResumeLayout(false);
            panelQuizEndScreen.PerformLayout();
            panelMatchQuestion.ResumeLayout(false);
            panelMatchQuestion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelQuizMenu;
        private Label lblQuizTitle;
        private Label lblQuizMenuTitle;
        private Button btnQuizEasy;
        private Button btnQuizHard;
        private Button btnQuizMedium;
        private Panel panelTextQuestion;
        private Label lblTextQuestion;
        private TextBox textBoxTextQuestion;
        private Button btnSubmitTextQuestion;
        private Panel panelMultipleChoiceQuestion;
        private Label lblMultipleChoiceQuestion;
        private Button btnOption3;
        private Button btnOption2;
        private Button btnOption1;
        private Panel panelQuizEndScreen;
        private Label lblQuizEndScreen;
        private Button btnQuizEndScreen;
        private Button btnPlayAudioMCQ;
        private Button btnPlayAudioTQ;
        private PictureBox pictureBoxText;
        private Panel panelTextPic;
        private Panel panelMCPic;
        private PictureBox pictureBoxMultipleChoice;
        private Panel panelMatchQuestion;
        private Label labelMatchQuestion;
        private ComboBox comboBoxRight4;
        private ComboBox comboBoxLeft4;
        private ComboBox comboBoxRight1;
        private ComboBox comboBoxLeft2;
        private ComboBox comboBoxRight2;
        private ComboBox comboBoxLeft3;
        private ComboBox comboBoxRight3;
        private ComboBox comboBoxLeft1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnSubmitMatch;
    }
}