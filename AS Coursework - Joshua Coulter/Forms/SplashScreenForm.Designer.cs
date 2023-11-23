namespace AS_Coursework___Joshua_Coulter
{
    partial class SplashScreenForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreenForm));
            panelLoader = new Panel();
            panelBackPanel = new Panel();
            labelSplashScreenTitle = new Label();
            timer = new System.Windows.Forms.Timer(components);
            panelBackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panelLoader
            // 
            panelLoader.Anchor = AnchorStyles.Left;
            panelLoader.BackColor = Color.OliveDrab;
            panelLoader.Location = new Point(10, 10);
            panelLoader.Name = "panelLoader";
            panelLoader.Size = new Size(15, 40);
            panelLoader.TabIndex = 0;
            // 
            // panelBackPanel
            // 
            panelBackPanel.Anchor = AnchorStyles.None;
            panelBackPanel.BackColor = Color.Teal;
            panelBackPanel.Controls.Add(panelLoader);
            panelBackPanel.Location = new Point(100, 370);
            panelBackPanel.Name = "panelBackPanel";
            panelBackPanel.Size = new Size(600, 60);
            panelBackPanel.TabIndex = 1;
            // 
            // labelSplashScreenTitle
            // 
            labelSplashScreenTitle.Anchor = AnchorStyles.None;
            labelSplashScreenTitle.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelSplashScreenTitle.Location = new Point(231, 183);
            labelSplashScreenTitle.Name = "labelSplashScreenTitle";
            labelSplashScreenTitle.Size = new Size(352, 56);
            labelSplashScreenTitle.TabIndex = 2;
            labelSplashScreenTitle.Text = "Music Maestro";
            // 
            // timer
            // 
            timer.Interval = 2;
            timer.Tick += timer_Tick;
            // 
            // SplashScreenForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 151, 178);
            ClientSize = new Size(800, 500);
            Controls.Add(labelSplashScreenTitle);
            Controls.Add(panelBackPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SplashScreenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreenForm";
            panelBackPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLoader;
        private Panel panelBackPanel;
        private Label labelSplashScreenTitle;
        private System.Windows.Forms.Timer timer;
    }
}