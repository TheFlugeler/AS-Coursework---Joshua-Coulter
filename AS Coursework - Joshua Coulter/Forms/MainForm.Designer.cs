namespace AS_Coursework___Joshua_Coulter
{
    partial class MainForm
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
            panelSideMenu = new Panel();
            panel1 = new Panel();
            btnLogout = new Button();
            btnAdmin = new Button();
            btnProfile = new Button();
            btnLeaderboard = new Button();
            btnQuiz = new Button();
            btnMainMenu = new Button();
            panelLogo = new Panel();
            pictureBoxLogo = new PictureBox();
            panelDisplay = new Panel();
            lblClock = new Label();
            lblMainTitle = new Label();
            backgroundWorkerClock = new System.ComponentModel.BackgroundWorker();
            panelSideMenu.SuspendLayout();
            panel1.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(0, 192, 192);
            panelSideMenu.Controls.Add(panel1);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(234, 673);
            panelSideMenu.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(btnAdmin);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnLeaderboard);
            panel1.Controls.Add(btnQuiz);
            panel1.Controls.Add(btnMainMenu);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 501);
            panel1.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(0, 360);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(234, 72);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdmin.Location = new Point(0, 288);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(234, 72);
            btnAdmin.TabIndex = 9;
            btnAdmin.Text = "Admin";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += btnAdmin_Click;
            // 
            // btnProfile
            // 
            btnProfile.Dock = DockStyle.Top;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfile.Location = new Point(0, 216);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(234, 72);
            btnProfile.TabIndex = 8;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnLeaderboard
            // 
            btnLeaderboard.Dock = DockStyle.Top;
            btnLeaderboard.FlatAppearance.BorderSize = 0;
            btnLeaderboard.FlatStyle = FlatStyle.Flat;
            btnLeaderboard.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLeaderboard.Location = new Point(0, 144);
            btnLeaderboard.Name = "btnLeaderboard";
            btnLeaderboard.Size = new Size(234, 72);
            btnLeaderboard.TabIndex = 7;
            btnLeaderboard.Text = "Leaderboard";
            btnLeaderboard.UseVisualStyleBackColor = true;
            btnLeaderboard.Click += btnLeaderboard_Click;
            // 
            // btnQuiz
            // 
            btnQuiz.Dock = DockStyle.Top;
            btnQuiz.FlatAppearance.BorderSize = 0;
            btnQuiz.FlatStyle = FlatStyle.Flat;
            btnQuiz.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnQuiz.Location = new Point(0, 72);
            btnQuiz.Name = "btnQuiz";
            btnQuiz.Size = new Size(234, 72);
            btnQuiz.TabIndex = 6;
            btnQuiz.Text = "Quiz";
            btnQuiz.UseVisualStyleBackColor = true;
            btnQuiz.Click += btnQuiz_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Dock = DockStyle.Top;
            btnMainMenu.FlatAppearance.BorderSize = 0;
            btnMainMenu.FlatStyle = FlatStyle.Flat;
            btnMainMenu.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMainMenu.Location = new Point(0, 0);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(234, 72);
            btnMainMenu.TabIndex = 5;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.FromArgb(66, 143, 68);
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(234, 172);
            panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.BackgroundImage = Properties.Images.logo;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(35, 6);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(160, 160);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelDisplay
            // 
            panelDisplay.BackColor = Color.FromArgb(0, 106, 125);
            panelDisplay.BackgroundImage = Properties.Images.Main_menu_graphic;
            panelDisplay.BackgroundImageLayout = ImageLayout.Stretch;
            panelDisplay.Controls.Add(lblClock);
            panelDisplay.Controls.Add(lblMainTitle);
            panelDisplay.Dock = DockStyle.Fill;
            panelDisplay.Location = new Point(234, 0);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(1028, 673);
            panelDisplay.TabIndex = 1;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.BackColor = Color.Transparent;
            lblClock.Dock = DockStyle.Right;
            lblClock.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblClock.Location = new Point(976, 0);
            lblClock.Name = "lblClock";
            lblClock.Size = new Size(52, 25);
            lblClock.TabIndex = 1;
            lblClock.Text = "clock";
            // 
            // lblMainTitle
            // 
            lblMainTitle.Anchor = AnchorStyles.Right;
            lblMainTitle.AutoSize = true;
            lblMainTitle.BackColor = Color.Transparent;
            lblMainTitle.Font = new Font("Century Gothic", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblMainTitle.Location = new Point(475, 186);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(550, 47);
            lblMainTitle.TabIndex = 0;
            lblMainTitle.Text = "Welcome to Music Maestro";
            // 
            // backgroundWorkerClock
            // 
            backgroundWorkerClock.WorkerReportsProgress = true;
            backgroundWorkerClock.DoWork += backgroundWorkerClock_DoWork;
            backgroundWorkerClock.ProgressChanged += backgroundWorkerClock_ProgressChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(153, 153, 153);
            ClientSize = new Size(1262, 673);
            Controls.Add(panelDisplay);
            Controls.Add(panelSideMenu);
            Name = "MainForm";
            Text = "MainForm";
            panelSideMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelDisplay.ResumeLayout(false);
            panelDisplay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Panel panelDisplay;
        private PictureBox pictureBoxLogo;
        private Label lblMainTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorkerClock;
        public Label lblClock;
        private Panel panel1;
        private Button btnLogout;
        private Button btnAdmin;
        private Button btnProfile;
        private Button btnLeaderboard;
        private Button btnQuiz;
        private Button btnMainMenu;
    }
}