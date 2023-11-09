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
            panelMultipleChoiceQuestion = new Panel();
            btnPlayAudioMCQ = new Button();
            btnOption3 = new Button();
            btnOption2 = new Button();
            btnOption1 = new Button();
            lblMultipleChoiceQuestion = new Label();
            panelQuizEndScreen = new Panel();
            btnQuizEndScreen = new Button();
            lblQuizEndScreen = new Label();
            panelQuizMenu.SuspendLayout();
            panelTextQuestion.SuspendLayout();
            panelMultipleChoiceQuestion.SuspendLayout();
            panelQuizEndScreen.SuspendLayout();
            SuspendLayout();
            // 
            // panelQuizMenu
            // 
            panelQuizMenu.Anchor = AnchorStyles.None;
            panelQuizMenu.Controls.Add(btnQuizHard);
            panelQuizMenu.Controls.Add(btnQuizMedium);
            panelQuizMenu.Controls.Add(btnQuizEasy);
            panelQuizMenu.Controls.Add(lblQuizMenuTitle);
            panelQuizMenu.Location = new Point(24, 96);
            panelQuizMenu.Name = "panelQuizMenu";
            panelQuizMenu.Size = new Size(961, 518);
            panelQuizMenu.TabIndex = 0;
            // 
            // btnQuizHard
            // 
            btnQuizHard.Anchor = AnchorStyles.None;
            btnQuizHard.BackColor = Color.FromArgb(209, 69, 50);
            btnQuizHard.FlatAppearance.BorderColor = Color.Green;
            btnQuizHard.FlatStyle = FlatStyle.Flat;
            btnQuizHard.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuizHard.Location = new Point(397, 374);
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
            btnQuizMedium.Location = new Point(397, 255);
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
            btnQuizEasy.Location = new Point(397, 136);
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
            lblQuizMenuTitle.Location = new Point(287, 43);
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
            panelTextQuestion.Controls.Add(btnPlayAudioTQ);
            panelTextQuestion.Controls.Add(btnSubmitTextQuestion);
            panelTextQuestion.Controls.Add(textBoxTextQuestion);
            panelTextQuestion.Controls.Add(lblTextQuestion);
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
            btnPlayAudioTQ.Location = new Point(458, 215);
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
            btnSubmitTextQuestion.Location = new Point(763, 361);
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
            textBoxTextQuestion.Location = new Point(76, 363);
            textBoxTextQuestion.Name = "textBoxTextQuestion";
            textBoxTextQuestion.Size = new Size(643, 41);
            textBoxTextQuestion.TabIndex = 1;
            // 
            // lblTextQuestion
            // 
            lblTextQuestion.Anchor = AnchorStyles.None;
            lblTextQuestion.AutoSize = true;
            lblTextQuestion.Font = new Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTextQuestion.Location = new Point(76, 136);
            lblTextQuestion.Name = "lblTextQuestion";
            lblTextQuestion.Size = new Size(49, 38);
            lblTextQuestion.TabIndex = 0;
            lblTextQuestion.Text = "Q:";
            // 
            // panelMultipleChoiceQuestion
            // 
            panelMultipleChoiceQuestion.Anchor = AnchorStyles.None;
            panelMultipleChoiceQuestion.BackColor = Color.Transparent;
            panelMultipleChoiceQuestion.Controls.Add(btnPlayAudioMCQ);
            panelMultipleChoiceQuestion.Controls.Add(btnOption3);
            panelMultipleChoiceQuestion.Controls.Add(btnOption2);
            panelMultipleChoiceQuestion.Controls.Add(btnOption1);
            panelMultipleChoiceQuestion.Controls.Add(lblMultipleChoiceQuestion);
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
            btnPlayAudioMCQ.Location = new Point(445, 192);
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
            btnOption3.Location = new Point(657, 340);
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
            btnOption2.Location = new Point(400, 340);
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
            btnOption1.Location = new Point(143, 340);
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
            lblMultipleChoiceQuestion.Location = new Point(89, 98);
            lblMultipleChoiceQuestion.Name = "lblMultipleChoiceQuestion";
            lblMultipleChoiceQuestion.Size = new Size(49, 38);
            lblMultipleChoiceQuestion.TabIndex = 1;
            lblMultipleChoiceQuestion.Text = "Q:";
            // 
            // panelQuizEndScreen
            // 
            panelQuizEndScreen.Anchor = AnchorStyles.None;
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
            lblQuizEndScreen.Location = new Point(114, 215);
            lblQuizEndScreen.Name = "lblQuizEndScreen";
            lblQuizEndScreen.Size = new Size(781, 37);
            lblQuizEndScreen.TabIndex = 0;
            lblQuizEndScreen.Text = "Congratulations, you finished the quiz with a score of:";
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 151, 178);
            ClientSize = new Size(1009, 626);
            Controls.Add(lblQuizTitle);
            Controls.Add(panelQuizMenu);
            Controls.Add(panelMultipleChoiceQuestion);
            Controls.Add(panelTextQuestion);
            Controls.Add(panelQuizEndScreen);
            Name = "QuizForm";
            Text = "QuizForm";
            FormClosing += QuizForm_FormClosing;
            panelQuizMenu.ResumeLayout(false);
            panelQuizMenu.PerformLayout();
            panelTextQuestion.ResumeLayout(false);
            panelTextQuestion.PerformLayout();
            panelMultipleChoiceQuestion.ResumeLayout(false);
            panelMultipleChoiceQuestion.PerformLayout();
            panelQuizEndScreen.ResumeLayout(false);
            panelQuizEndScreen.PerformLayout();
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
    }
}