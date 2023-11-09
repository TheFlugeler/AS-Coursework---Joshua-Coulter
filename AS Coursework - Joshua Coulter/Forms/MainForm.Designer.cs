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
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelDisplay.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.BackColor = Color.FromArgb(0, 192, 192);
            panelSideMenu.Controls.Add(btnLogout);
            panelSideMenu.Controls.Add(btnAdmin);
            panelSideMenu.Controls.Add(btnProfile);
            panelSideMenu.Controls.Add(btnLeaderboard);
            panelSideMenu.Controls.Add(btnQuiz);
            panelSideMenu.Controls.Add(btnMainMenu);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(235, 673);
            panelSideMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Top;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(0, 532);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(235, 72);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnAdmin
            // 
            btnAdmin.Dock = DockStyle.Top;
            btnAdmin.Enabled = false;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdmin.Location = new Point(0, 460);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(235, 72);
            btnAdmin.TabIndex = 5;
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
            btnProfile.Location = new Point(0, 388);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(235, 72);
            btnProfile.TabIndex = 4;
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
            btnLeaderboard.Location = new Point(0, 316);
            btnLeaderboard.Name = "btnLeaderboard";
            btnLeaderboard.Size = new Size(235, 72);
            btnLeaderboard.TabIndex = 3;
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
            btnQuiz.Location = new Point(0, 244);
            btnQuiz.Name = "btnQuiz";
            btnQuiz.Size = new Size(235, 72);
            btnQuiz.TabIndex = 2;
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
            btnMainMenu.Location = new Point(0, 172);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(235, 72);
            btnMainMenu.TabIndex = 1;
            btnMainMenu.Text = "Main Page";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.SeaGreen;
            panelLogo.Controls.Add(pictureBoxLogo);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(235, 172);
            panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Anchor = AnchorStyles.None;
            pictureBoxLogo.BackgroundImage = Properties.Images.Music_Maestro_Logo;
            pictureBoxLogo.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBoxLogo.Location = new Point(40, 6);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(160, 160);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // panelDisplay
            // 
            panelDisplay.BackColor = Color.DarkGray;
            panelDisplay.BackgroundImage = Properties.Images.Main_menu_graphic;
            panelDisplay.BackgroundImageLayout = ImageLayout.Stretch;
            panelDisplay.Controls.Add(lblClock);
            panelDisplay.Controls.Add(lblMainTitle);
            panelDisplay.Dock = DockStyle.Fill;
            panelDisplay.Location = new Point(235, 0);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(1027, 673);
            panelDisplay.TabIndex = 1;
            // 
            // lblClock
            // 
            lblClock.AutoSize = true;
            lblClock.BackColor = Color.Transparent;
            lblClock.Dock = DockStyle.Right;
            lblClock.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblClock.Location = new Point(975, 0);
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
            lblMainTitle.Location = new Point(465, 269);
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
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelDisplay.ResumeLayout(false);
            panelDisplay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panelLogo;
        private Button btnMainMenu;
        private Button btnQuiz;
        private Button btnLogout;
        private Button btnAdmin;
        private Button btnProfile;
        private Button btnLeaderboard;
        private Panel panelDisplay;
        private PictureBox pictureBoxLogo;
        private Label lblMainTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorkerClock;
        public Label lblClock;
    }
}