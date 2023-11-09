namespace AS_Coursework___Joshua_Coulter
{
    partial class ProfileForm
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
            panelProfileDisplay = new Panel();
            textBoxProfileHighscore = new TextBox();
            textBoxProfileDOB = new TextBox();
            textBoxProfileGender = new TextBox();
            textBoxProfilePassword = new TextBox();
            textBoxProfileUsername = new TextBox();
            btnProfileEdit = new Button();
            lblProfileHighscore = new Label();
            lblProfileDOB = new Label();
            lblProfileGender = new Label();
            lblProfilePassword = new Label();
            lblProfileUsername = new Label();
            label4 = new Label();
            panelEditProfile = new Panel();
            linkLabelProfileEditClose = new LinkLabel();
            btnProfileUpdate = new Button();
            dateTimePickerEditDOB = new DateTimePicker();
            radioButtonFemale = new RadioButton();
            radioButtonOther = new RadioButton();
            radioButtonMale = new RadioButton();
            textBoxEditPassword = new TextBox();
            textBoxEditUsername = new TextBox();
            lblEditProfileDOB = new Label();
            lblEditProfileGender = new Label();
            lblEditProfilePassword = new Label();
            lblEditProfileUsername = new Label();
            panelProfileDisplay.SuspendLayout();
            panelEditProfile.SuspendLayout();
            SuspendLayout();
            // 
            // panelProfileDisplay
            // 
            panelProfileDisplay.Anchor = AnchorStyles.None;
            panelProfileDisplay.BackColor = Color.FromArgb(144, 144, 144);
            panelProfileDisplay.Controls.Add(textBoxProfileHighscore);
            panelProfileDisplay.Controls.Add(textBoxProfileDOB);
            panelProfileDisplay.Controls.Add(textBoxProfileGender);
            panelProfileDisplay.Controls.Add(textBoxProfilePassword);
            panelProfileDisplay.Controls.Add(textBoxProfileUsername);
            panelProfileDisplay.Controls.Add(btnProfileEdit);
            panelProfileDisplay.Controls.Add(lblProfileHighscore);
            panelProfileDisplay.Controls.Add(lblProfileDOB);
            panelProfileDisplay.Controls.Add(lblProfileGender);
            panelProfileDisplay.Controls.Add(lblProfilePassword);
            panelProfileDisplay.Controls.Add(lblProfileUsername);
            panelProfileDisplay.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelProfileDisplay.Location = new Point(306, 112);
            panelProfileDisplay.Name = "panelProfileDisplay";
            panelProfileDisplay.Size = new Size(397, 431);
            panelProfileDisplay.TabIndex = 0;
            // 
            // textBoxProfileHighscore
            // 
            textBoxProfileHighscore.Location = new Point(173, 309);
            textBoxProfileHighscore.Name = "textBoxProfileHighscore";
            textBoxProfileHighscore.ReadOnly = true;
            textBoxProfileHighscore.Size = new Size(74, 32);
            textBoxProfileHighscore.TabIndex = 10;
            // 
            // textBoxProfileDOB
            // 
            textBoxProfileDOB.Location = new Point(173, 244);
            textBoxProfileDOB.Name = "textBoxProfileDOB";
            textBoxProfileDOB.ReadOnly = true;
            textBoxProfileDOB.Size = new Size(152, 32);
            textBoxProfileDOB.TabIndex = 9;
            // 
            // textBoxProfileGender
            // 
            textBoxProfileGender.Location = new Point(173, 179);
            textBoxProfileGender.Name = "textBoxProfileGender";
            textBoxProfileGender.ReadOnly = true;
            textBoxProfileGender.Size = new Size(119, 32);
            textBoxProfileGender.TabIndex = 8;
            // 
            // textBoxProfilePassword
            // 
            textBoxProfilePassword.Location = new Point(173, 114);
            textBoxProfilePassword.Name = "textBoxProfilePassword";
            textBoxProfilePassword.ReadOnly = true;
            textBoxProfilePassword.Size = new Size(210, 32);
            textBoxProfilePassword.TabIndex = 7;
            // 
            // textBoxProfileUsername
            // 
            textBoxProfileUsername.Location = new Point(173, 49);
            textBoxProfileUsername.Name = "textBoxProfileUsername";
            textBoxProfileUsername.ReadOnly = true;
            textBoxProfileUsername.Size = new Size(210, 32);
            textBoxProfileUsername.TabIndex = 6;
            // 
            // btnProfileEdit
            // 
            btnProfileEdit.Location = new Point(123, 366);
            btnProfileEdit.Name = "btnProfileEdit";
            btnProfileEdit.Size = new Size(124, 43);
            btnProfileEdit.TabIndex = 5;
            btnProfileEdit.Text = "Edit";
            btnProfileEdit.UseVisualStyleBackColor = true;
            btnProfileEdit.Click += btnProfileEdit_Click;
            // 
            // lblProfileHighscore
            // 
            lblProfileHighscore.AutoSize = true;
            lblProfileHighscore.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfileHighscore.Location = new Point(36, 312);
            lblProfileHighscore.Name = "lblProfileHighscore";
            lblProfileHighscore.Size = new Size(110, 23);
            lblProfileHighscore.TabIndex = 4;
            lblProfileHighscore.Text = "Highscore:";
            // 
            // lblProfileDOB
            // 
            lblProfileDOB.AutoSize = true;
            lblProfileDOB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfileDOB.Location = new Point(88, 247);
            lblProfileDOB.Name = "lblProfileDOB";
            lblProfileDOB.Size = new Size(58, 23);
            lblProfileDOB.TabIndex = 3;
            lblProfileDOB.Text = "DOB:";
            // 
            // lblProfileGender
            // 
            lblProfileGender.AutoSize = true;
            lblProfileGender.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfileGender.Location = new Point(61, 182);
            lblProfileGender.Name = "lblProfileGender";
            lblProfileGender.Size = new Size(85, 23);
            lblProfileGender.TabIndex = 2;
            lblProfileGender.Text = "Gender";
            // 
            // lblProfilePassword
            // 
            lblProfilePassword.AutoSize = true;
            lblProfilePassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfilePassword.Location = new Point(38, 117);
            lblProfilePassword.Name = "lblProfilePassword";
            lblProfilePassword.Size = new Size(108, 23);
            lblProfilePassword.TabIndex = 1;
            lblProfilePassword.Text = "Password:";
            // 
            // lblProfileUsername
            // 
            lblProfileUsername.AutoSize = true;
            lblProfileUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblProfileUsername.Location = new Point(33, 52);
            lblProfileUsername.Name = "lblProfileUsername";
            lblProfileUsername.Size = new Size(113, 23);
            lblProfileUsername.TabIndex = 0;
            lblProfileUsername.Text = "Username:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(456, 48);
            label4.Name = "label4";
            label4.Size = new Size(117, 40);
            label4.TabIndex = 6;
            label4.Text = "Profile";
            // 
            // panelEditProfile
            // 
            panelEditProfile.Anchor = AnchorStyles.None;
            panelEditProfile.BackColor = Color.FromArgb(144, 144, 144);
            panelEditProfile.Controls.Add(linkLabelProfileEditClose);
            panelEditProfile.Controls.Add(btnProfileUpdate);
            panelEditProfile.Controls.Add(dateTimePickerEditDOB);
            panelEditProfile.Controls.Add(radioButtonFemale);
            panelEditProfile.Controls.Add(radioButtonOther);
            panelEditProfile.Controls.Add(radioButtonMale);
            panelEditProfile.Controls.Add(textBoxEditPassword);
            panelEditProfile.Controls.Add(textBoxEditUsername);
            panelEditProfile.Controls.Add(lblEditProfileDOB);
            panelEditProfile.Controls.Add(lblEditProfileGender);
            panelEditProfile.Controls.Add(lblEditProfilePassword);
            panelEditProfile.Controls.Add(lblEditProfileUsername);
            panelEditProfile.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panelEditProfile.Location = new Point(274, 112);
            panelEditProfile.Name = "panelEditProfile";
            panelEditProfile.Size = new Size(460, 431);
            panelEditProfile.TabIndex = 7;
            panelEditProfile.Visible = false;
            // 
            // linkLabelProfileEditClose
            // 
            linkLabelProfileEditClose.ActiveLinkColor = Color.DarkGray;
            linkLabelProfileEditClose.AutoSize = true;
            linkLabelProfileEditClose.LinkColor = Color.White;
            linkLabelProfileEditClose.Location = new Point(196, 376);
            linkLabelProfileEditClose.Name = "linkLabelProfileEditClose";
            linkLabelProfileEditClose.Size = new Size(83, 23);
            linkLabelProfileEditClose.TabIndex = 21;
            linkLabelProfileEditClose.TabStop = true;
            linkLabelProfileEditClose.Text = "Cancel";
            linkLabelProfileEditClose.LinkClicked += linkLabelProfileEditClose_LinkClicked;
            // 
            // btnProfileUpdate
            // 
            btnProfileUpdate.Location = new Point(155, 296);
            btnProfileUpdate.Name = "btnProfileUpdate";
            btnProfileUpdate.Size = new Size(169, 55);
            btnProfileUpdate.TabIndex = 20;
            btnProfileUpdate.Text = "Update Profile";
            btnProfileUpdate.UseVisualStyleBackColor = true;
            btnProfileUpdate.Click += btnProfileUpdate_Click;
            // 
            // dateTimePickerEditDOB
            // 
            dateTimePickerEditDOB.Location = new Point(164, 240);
            dateTimePickerEditDOB.Name = "dateTimePickerEditDOB";
            dateTimePickerEditDOB.Size = new Size(250, 32);
            dateTimePickerEditDOB.TabIndex = 19;
            // 
            // radioButtonFemale
            // 
            radioButtonFemale.AutoSize = true;
            radioButtonFemale.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonFemale.Location = new Point(242, 179);
            radioButtonFemale.Name = "radioButtonFemale";
            radioButtonFemale.Size = new Size(96, 25);
            radioButtonFemale.TabIndex = 18;
            radioButtonFemale.TabStop = true;
            radioButtonFemale.Text = "Female";
            radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonOther
            // 
            radioButtonOther.AutoSize = true;
            radioButtonOther.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonOther.Location = new Point(341, 179);
            radioButtonOther.Name = "radioButtonOther";
            radioButtonOther.Size = new Size(82, 25);
            radioButtonOther.TabIndex = 17;
            radioButtonOther.TabStop = true;
            radioButtonOther.Text = "Other";
            radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            radioButtonMale.AutoSize = true;
            radioButtonMale.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            radioButtonMale.Location = new Point(164, 179);
            radioButtonMale.Name = "radioButtonMale";
            radioButtonMale.Size = new Size(75, 25);
            radioButtonMale.TabIndex = 16;
            radioButtonMale.TabStop = true;
            radioButtonMale.Text = "Male";
            radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // textBoxEditPassword
            // 
            textBoxEditPassword.Location = new Point(164, 111);
            textBoxEditPassword.Name = "textBoxEditPassword";
            textBoxEditPassword.Size = new Size(253, 32);
            textBoxEditPassword.TabIndex = 15;
            // 
            // textBoxEditUsername
            // 
            textBoxEditUsername.Location = new Point(164, 46);
            textBoxEditUsername.Name = "textBoxEditUsername";
            textBoxEditUsername.Size = new Size(253, 32);
            textBoxEditUsername.TabIndex = 14;
            // 
            // lblEditProfileDOB
            // 
            lblEditProfileDOB.AutoSize = true;
            lblEditProfileDOB.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEditProfileDOB.Location = new Point(79, 244);
            lblEditProfileDOB.Name = "lblEditProfileDOB";
            lblEditProfileDOB.Size = new Size(58, 23);
            lblEditProfileDOB.TabIndex = 13;
            lblEditProfileDOB.Text = "DOB:";
            // 
            // lblEditProfileGender
            // 
            lblEditProfileGender.AutoSize = true;
            lblEditProfileGender.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEditProfileGender.Location = new Point(52, 179);
            lblEditProfileGender.Name = "lblEditProfileGender";
            lblEditProfileGender.Size = new Size(85, 23);
            lblEditProfileGender.TabIndex = 12;
            lblEditProfileGender.Text = "Gender";
            // 
            // lblEditProfilePassword
            // 
            lblEditProfilePassword.AutoSize = true;
            lblEditProfilePassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEditProfilePassword.Location = new Point(29, 114);
            lblEditProfilePassword.Name = "lblEditProfilePassword";
            lblEditProfilePassword.Size = new Size(108, 23);
            lblEditProfilePassword.TabIndex = 11;
            lblEditProfilePassword.Text = "Password:";
            // 
            // lblEditProfileUsername
            // 
            lblEditProfileUsername.AutoSize = true;
            lblEditProfileUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEditProfileUsername.Location = new Point(24, 49);
            lblEditProfileUsername.Name = "lblEditProfileUsername";
            lblEditProfileUsername.Size = new Size(113, 23);
            lblEditProfileUsername.TabIndex = 10;
            lblEditProfileUsername.Text = "Username:";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 151, 178);
            ClientSize = new Size(1009, 626);
            Controls.Add(label4);
            Controls.Add(panelProfileDisplay);
            Controls.Add(panelEditProfile);
            Name = "ProfileForm";
            Text = "ProfileForm";
            panelProfileDisplay.ResumeLayout(false);
            panelProfileDisplay.PerformLayout();
            panelEditProfile.ResumeLayout(false);
            panelEditProfile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelProfileDisplay;
        private Button btnProfileEdit;
        private Label lblProfileHighscore;
        private Label lblProfileDOB;
        private Label lblProfileGender;
        private Label lblProfilePassword;
        private Label lblProfileUsername;
        private Label label4;
        private TextBox textBoxProfileHighscore;
        private TextBox textBoxProfileDOB;
        private TextBox textBoxProfileGender;
        private TextBox textBoxProfilePassword;
        private TextBox textBoxProfileUsername;
        private Panel panelEditProfile;
        private TextBox textBoxEditPassword;
        private TextBox textBoxEditUsername;
        private Label lblEditProfileDOB;
        private Label lblEditProfileGender;
        private Label lblEditProfilePassword;
        private Label lblEditProfileUsername;
        private DateTimePicker dateTimePickerEditDOB;
        private RadioButton radioButtonFemale;
        private RadioButton radioButtonOther;
        private RadioButton radioButtonMale;
        private LinkLabel linkLabelProfileEditClose;
        private Button btnProfileUpdate;
    }
}