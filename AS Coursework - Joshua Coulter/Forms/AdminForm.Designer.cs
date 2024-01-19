namespace AS_Coursework___Joshua_Coulter
{
    partial class AdminForm
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
            panelAdminControls = new Panel();
            btnAddQuestions = new Button();
            btnViewQuestions = new Button();
            btnViewDatabase = new Button();
            lblAdminTitle = new Label();
            panelAdminControls.SuspendLayout();
            SuspendLayout();
            // 
            // panelAdminControls
            // 
            panelAdminControls.Anchor = AnchorStyles.None;
            panelAdminControls.BackColor = Color.FromArgb(0, 192, 192);
            panelAdminControls.Controls.Add(btnAddQuestions);
            panelAdminControls.Controls.Add(btnViewQuestions);
            panelAdminControls.Controls.Add(btnViewDatabase);
            panelAdminControls.Location = new Point(166, 142);
            panelAdminControls.Name = "panelAdminControls";
            panelAdminControls.Size = new Size(716, 386);
            panelAdminControls.TabIndex = 0;
            // 
            // btnAddQuestions
            // 
            btnAddQuestions.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddQuestions.Location = new Point(71, 231);
            btnAddQuestions.Name = "btnAddQuestions";
            btnAddQuestions.Size = new Size(184, 87);
            btnAddQuestions.TabIndex = 2;
            btnAddQuestions.Text = "Add Questions";
            btnAddQuestions.UseVisualStyleBackColor = true;
            btnAddQuestions.Click += buttonAddQuestions_Click;
            // 
            // btnViewQuestions
            // 
            btnViewQuestions.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewQuestions.Location = new Point(454, 66);
            btnViewQuestions.Name = "btnViewQuestions";
            btnViewQuestions.Size = new Size(184, 87);
            btnViewQuestions.TabIndex = 1;
            btnViewQuestions.Text = "View/Edit Questions";
            btnViewQuestions.UseVisualStyleBackColor = true;
            btnViewQuestions.Click += btnViewQuestions_Click;
            // 
            // btnViewDatabase
            // 
            btnViewDatabase.Font = new Font("Corbel", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewDatabase.Location = new Point(71, 66);
            btnViewDatabase.Name = "btnViewDatabase";
            btnViewDatabase.Size = new Size(184, 87);
            btnViewDatabase.TabIndex = 0;
            btnViewDatabase.Text = "View Player Database";
            btnViewDatabase.UseVisualStyleBackColor = true;
            btnViewDatabase.Click += btnViewDatabase_Click;
            // 
            // lblAdminTitle
            // 
            lblAdminTitle.Anchor = AnchorStyles.None;
            lblAdminTitle.AutoSize = true;
            lblAdminTitle.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdminTitle.Location = new Point(405, 45);
            lblAdminTitle.Name = "lblAdminTitle";
            lblAdminTitle.Size = new Size(239, 44);
            lblAdminTitle.TabIndex = 1;
            lblAdminTitle.Text = "Admin Page";
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 151, 178);
            ClientSize = new Size(1009, 626);
            Controls.Add(lblAdminTitle);
            Controls.Add(panelAdminControls);
            Name = "AdminForm";
            Text = "Admin";
            panelAdminControls.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelAdminControls;
        private Label lblAdminTitle;
        private Button btnViewDatabase;
        private Button btnViewQuestions;
        private Button btnAddQuestions;
    }
}