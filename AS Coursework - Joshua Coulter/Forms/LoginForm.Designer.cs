namespace AS_Coursework___Joshua_Coulter
{
    partial class LoginForm
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
            pictureBoxPasswordVisible = new PictureBox();
            linkLabelRegister = new LinkLabel();
            btnSignIn = new Button();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            lblLoginSubTitle = new Label();
            linkLabelSignIn = new LinkLabel();
            btnRegister = new Button();
            lblRegisterGender = new Label();
            radioButtonFemale = new RadioButton();
            radioButtonOther = new RadioButton();
            radioButtonMale = new RadioButton();
            dateTimePickerRegisterDOB = new DateTimePicker();
            lblRegisterDOB = new Label();
            textBoxRegisterPassword = new TextBox();
            lblRegisterPassword = new Label();
            textBoxRegisterUsername = new TextBox();
            lblRegisterUsername = new Label();
            lblRegister = new Label();
            label1 = new Label();
            panelLoginBox = new Panel();
            panelRegister = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPasswordVisible).BeginInit();
            panelLoginBox.SuspendLayout();
            panelRegister.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxPasswordVisible
            // 
            pictureBoxPasswordVisible.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxPasswordVisible.Location = new Point(314, 176);
            pictureBoxPasswordVisible.Name = "pictureBoxPasswordVisible";
            pictureBoxPasswordVisible.Size = new Size(33, 28);
            pictureBoxPasswordVisible.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPasswordVisible.TabIndex = 7;
            pictureBoxPasswordVisible.TabStop = false;
            pictureBoxPasswordVisible.Click += pictureBoxPasswordVisible_Click;
            // 
            // linkLabelRegister
            // 
            linkLabelRegister.ActiveLinkColor = Color.DarkGray;
            linkLabelRegister.AutoSize = true;
            linkLabelRegister.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelRegister.LinkColor = Color.White;
            linkLabelRegister.Location = new Point(105, 314);
            linkLabelRegister.Name = "linkLabelRegister";
            linkLabelRegister.Size = new Size(158, 23);
            linkLabelRegister.TabIndex = 6;
            linkLabelRegister.TabStop = true;
            linkLabelRegister.Text = "Or register here";
            linkLabelRegister.VisitedLinkColor = Color.Gray;
            linkLabelRegister.LinkClicked += linkLabelRegister_LinkClicked;
            // 
            // btnSignIn
            // 
            btnSignIn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignIn.Location = new Point(117, 246);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(130, 48);
            btnSignIn.TabIndex = 5;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top;
            textBoxPassword.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(59, 172);
            textBoxPassword.MaxLength = 24;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PlaceholderText = "Password";
            textBoxPassword.Size = new Size(250, 36);
            textBoxPassword.TabIndex = 4;
            textBoxPassword.KeyPress += textBoxPassword_KeyPress;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Anchor = AnchorStyles.Top;
            textBoxUsername.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(59, 96);
            textBoxUsername.MaxLength = 24;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.PlaceholderText = "Username";
            textBoxUsername.Size = new Size(250, 36);
            textBoxUsername.TabIndex = 2;
            textBoxUsername.KeyPress += textBoxUsername_KeyPress;
            // 
            // lblLoginSubTitle
            // 
            lblLoginSubTitle.Anchor = AnchorStyles.Top;
            lblLoginSubTitle.AutoSize = true;
            lblLoginSubTitle.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoginSubTitle.Location = new Point(141, 34);
            lblLoginSubTitle.Name = "lblLoginSubTitle";
            lblLoginSubTitle.Size = new Size(87, 34);
            lblLoginSubTitle.TabIndex = 0;
            lblLoginSubTitle.Text = "Login";
            // 
            // linkLabelSignIn
            // 
            linkLabelSignIn.ActiveLinkColor = Color.DarkGray;
            linkLabelSignIn.AutoSize = true;
            linkLabelSignIn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabelSignIn.LinkColor = Color.White;
            linkLabelSignIn.Location = new Point(178, 407);
            linkLabelSignIn.Name = "linkLabelSignIn";
            linkLabelSignIn.Size = new Size(100, 23);
            linkLabelSignIn.TabIndex = 12;
            linkLabelSignIn.TabStop = true;
            linkLabelSignIn.Text = "Or Sign In";
            linkLabelSignIn.VisitedLinkColor = Color.Gray;
            linkLabelSignIn.LinkClicked += linkLabelSignIn_LinkClicked;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.Location = new Point(159, 337);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(139, 58);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblRegisterGender
            // 
            lblRegisterGender.AutoSize = true;
            lblRegisterGender.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegisterGender.Location = new Point(52, 282);
            lblRegisterGender.Name = "lblRegisterGender";
            lblRegisterGender.Size = new Size(105, 27);
            lblRegisterGender.TabIndex = 10;
            lblRegisterGender.Text = "Gender:";
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFemale.Location = new Point(250, 286);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(96, 25);
            radioButtonFemale.TabIndex = 9;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonOther
            // 
            radioButtonOther.AutoSize = true;
            radioButtonOther.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonOther.Location = new Point(353, 286);
            radioButtonOther.Name = "radioButtonOther";
            radioButtonOther.Size = new Size(82, 25);
            radioButtonOther.TabIndex = 8;
            radioButtonOther.TabStop = true;
            radioButtonOther.Text = "Other";
            radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonMale.Location = new Point(168, 286);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(75, 25);
            radioButtonMale.TabIndex = 7;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerRegisterDOB
            // 
            dateTimePickerRegisterDOB.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerRegisterDOB.Location = new Point(168, 215);
            dateTimePickerRegisterDOB.MaxDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dateTimePickerRegisterDOB.Name = "dateTimePickerRegisterDOB";
            dateTimePickerRegisterDOB.Size = new Size(270, 36);
            dateTimePickerRegisterDOB.TabIndex = 6;
            dateTimePickerRegisterDOB.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // lblRegisterDOB
            // 
            lblRegisterDOB.AutoSize = true;
            lblRegisterDOB.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegisterDOB.Location = new Point(89, 216);
            lblRegisterDOB.Name = "lblRegisterDOB";
            lblRegisterDOB.Size = new Size(68, 27);
            lblRegisterDOB.TabIndex = 5;
            lblRegisterDOB.Text = "DOB:";
            // 
            // textBoxRegisterPassword
            // 
            textBoxRegisterPassword.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRegisterPassword.Location = new Point(168, 144);
            textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            textBoxRegisterPassword.Size = new Size(270, 36);
            textBoxRegisterPassword.TabIndex = 4;
            // 
            // lblRegisterPassword
            // 
            lblRegisterPassword.AutoSize = true;
            lblRegisterPassword.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegisterPassword.Location = new Point(33, 146);
            lblRegisterPassword.Name = "lblRegisterPassword";
            lblRegisterPassword.Size = new Size(124, 27);
            lblRegisterPassword.TabIndex = 3;
            lblRegisterPassword.Text = "Password:";
            // 
            // textBoxRegisterUsername
            // 
            textBoxRegisterUsername.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxRegisterUsername.Location = new Point(168, 73);
            textBoxRegisterUsername.Name = "textBoxRegisterUsername";
            textBoxRegisterUsername.Size = new Size(270, 36);
            textBoxRegisterUsername.TabIndex = 2;
            // 
            // lblRegisterUsername
            // 
            lblRegisterUsername.AutoSize = true;
            lblRegisterUsername.Font = new Font("Century Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegisterUsername.Location = new Point(25, 76);
            lblRegisterUsername.Name = "lblRegisterUsername";
            lblRegisterUsername.Size = new Size(132, 27);
            lblRegisterUsername.TabIndex = 1;
            lblRegisterUsername.Text = "Username:";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblRegister.Location = new Point(168, 19);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(121, 34);
            lblRegister.TabIndex = 0;
            lblRegister.Text = "Register";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(371, 28);
            label1.Name = "label1";
            label1.Size = new Size(515, 44);
            label1.TabIndex = 3;
            label1.Text = "Welcome to Music Maestro!";
            // 
            // panelLoginBox
            // 
            panelLoginBox.BackColor = Color.FromArgb(0, 106, 125);
            panelLoginBox.Controls.Add(pictureBoxPasswordVisible);
            panelLoginBox.Controls.Add(lblLoginSubTitle);
            panelLoginBox.Controls.Add(linkLabelRegister);
            panelLoginBox.Controls.Add(textBoxUsername);
            panelLoginBox.Controls.Add(btnSignIn);
            panelLoginBox.Controls.Add(textBoxPassword);
            panelLoginBox.Location = new Point(441, 170);
            panelLoginBox.Name = "panelLoginBox";
            panelLoginBox.Size = new Size(375, 376);
            panelLoginBox.TabIndex = 4;
            // 
            // panelRegister
            // 
            panelRegister.BackColor = Color.FromArgb(0, 106, 125);
            panelRegister.Controls.Add(linkLabelSignIn);
            panelRegister.Controls.Add(lblRegister);
            panelRegister.Controls.Add(btnRegister);
            panelRegister.Controls.Add(lblRegisterUsername);
            panelRegister.Controls.Add(lblRegisterGender);
            panelRegister.Controls.Add(textBoxRegisterUsername);
            panelRegister.Controls.Add(radioButtonFemale);
            panelRegister.Controls.Add(lblRegisterPassword);
            panelRegister.Controls.Add(radioButtonOther);
            panelRegister.Controls.Add(textBoxRegisterPassword);
            panelRegister.Controls.Add(radioButtonMale);
            panelRegister.Controls.Add(lblRegisterDOB);
            panelRegister.Controls.Add(dateTimePickerRegisterDOB);
            panelRegister.Location = new Point(391, 137);
            panelRegister.Name = "panelRegister";
            panelRegister.Size = new Size(474, 444);
            panelRegister.TabIndex = 5;
            panelRegister.Text = "roundedPanel1";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 151, 178);
            BackgroundImage = Properties.Images.Login_Graphic;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelRegister);
            Controls.Add(panelLoginBox);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxPasswordVisible).EndInit();
            panelLoginBox.ResumeLayout(false);
            panelLoginBox.PerformLayout();
            panelRegister.ResumeLayout(false);
            panelRegister.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblLoginSubTitle;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private LinkLabel linkLabelRegister;
        private Button btnSignIn;
        private DateTimePicker dateTimePickerRegisterDOB;
        private Label lblRegisterDOB;
        private TextBox textBoxRegisterPassword;
        private Label lblRegisterPassword;
        private TextBox textBoxRegisterUsername;
        private Label lblRegisterUsername;
        private Label lblRegister;
        private RadioButton radioButtonMale;
        private Label lblRegisterGender;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonOther;
        private Button btnRegister;
        private LinkLabel linkLabelSignIn;
        private Label label1;
        public PictureBox pictureBoxPasswordVisible;
        private Panel panelLoginBox;
        private Panel panelRegister;
    }
}