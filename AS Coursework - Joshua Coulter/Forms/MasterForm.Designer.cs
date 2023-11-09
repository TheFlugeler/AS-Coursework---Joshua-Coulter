namespace AS_Coursework___Joshua_Coulter
{
    partial class MasterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            panelDisplay = new Panel();
            SuspendLayout();
            // 
            // panelDisplay
            // 
            panelDisplay.BackColor = SystemColors.ControlDarkDark;
            panelDisplay.Dock = DockStyle.Fill;
            panelDisplay.Location = new Point(0, 0);
            panelDisplay.Name = "panelDisplay";
            panelDisplay.Size = new Size(1262, 673);
            panelDisplay.TabIndex = 0;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panelDisplay);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1280, 720);
            Name = "MasterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Maestro";
            FormClosing += MasterForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelDisplay;
    }
}