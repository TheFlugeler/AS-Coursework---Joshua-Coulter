namespace AS_Coursework___Joshua_Coulter.Forms
{
    partial class DatabaseForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panelDatabaseContainer = new Panel();
            btnRevert = new Button();
            btnSaveChanges = new Button();
            btnDeleteRow = new Button();
            dataGridViewUsers = new DataGridView();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            highScoreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dOBDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            isAdminDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            userBindingSource = new BindingSource(components);
            label1 = new Label();
            panelDatabaseContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panelDatabaseContainer
            // 
            panelDatabaseContainer.Anchor = AnchorStyles.None;
            panelDatabaseContainer.BackColor = Color.FromArgb(0, 192, 192);
            panelDatabaseContainer.Controls.Add(btnRevert);
            panelDatabaseContainer.Controls.Add(btnSaveChanges);
            panelDatabaseContainer.Controls.Add(btnDeleteRow);
            panelDatabaseContainer.Controls.Add(dataGridViewUsers);
            panelDatabaseContainer.Location = new Point(73, 82);
            panelDatabaseContainer.Name = "panelDatabaseContainer";
            panelDatabaseContainer.Size = new Size(881, 487);
            panelDatabaseContainer.TabIndex = 0;
            // 
            // btnRevert
            // 
            btnRevert.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRevert.Location = new Point(663, 426);
            btnRevert.Name = "btnRevert";
            btnRevert.Size = new Size(176, 45);
            btnRevert.TabIndex = 3;
            btnRevert.Text = "Revert Changes";
            btnRevert.UseVisualStyleBackColor = true;
            btnRevert.Click += btnRevert_Click;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSaveChanges.Location = new Point(253, 426);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.Size = new Size(176, 45);
            btnSaveChanges.TabIndex = 2;
            btnSaveChanges.Text = "Save Changes";
            btnSaveChanges.UseVisualStyleBackColor = true;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // btnDeleteRow
            // 
            btnDeleteRow.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteRow.Location = new Point(36, 426);
            btnDeleteRow.Name = "btnDeleteRow";
            btnDeleteRow.Size = new Size(176, 45);
            btnDeleteRow.TabIndex = 1;
            btnDeleteRow.Text = "Delete Row";
            btnDeleteRow.UseVisualStyleBackColor = true;
            btnDeleteRow.Click += btnDeleteRow_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AllowUserToAddRows = false;
            dataGridViewUsers.AutoGenerateColumns = false;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Columns.AddRange(new DataGridViewColumn[] { usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, highScoreDataGridViewTextBoxColumn, dOBDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, isAdminDataGridViewCheckBoxColumn });
            dataGridViewUsers.DataSource = userBindingSource;
            dataGridViewUsers.Location = new Point(36, 36);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 51;
            dataGridViewUsers.RowTemplate.Height = 29;
            dataGridViewUsers.Size = new Size(803, 380);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.DataError += dataGridViewUsers_DataError;
            dataGridViewUsers.KeyDown += dataGridViewUsers_KeyDown;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // highScoreDataGridViewTextBoxColumn
            // 
            highScoreDataGridViewTextBoxColumn.DataPropertyName = "HighScore";
            dataGridViewCellStyle1.Format = "N1";
            dataGridViewCellStyle1.NullValue = null;
            highScoreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            highScoreDataGridViewTextBoxColumn.HeaderText = "HighScore";
            highScoreDataGridViewTextBoxColumn.MinimumWidth = 6;
            highScoreDataGridViewTextBoxColumn.Name = "highScoreDataGridViewTextBoxColumn";
            highScoreDataGridViewTextBoxColumn.ReadOnly = true;
            highScoreDataGridViewTextBoxColumn.Width = 125;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            dOBDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            dOBDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Items.AddRange(new object[] { "Male", "Female", "Other" });
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            genderDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            isAdminDataGridViewCheckBoxColumn.DataPropertyName = "IsAdmin";
            isAdminDataGridViewCheckBoxColumn.HeaderText = "IsAdmin";
            isAdminDataGridViewCheckBoxColumn.MinimumWidth = 6;
            isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            isAdminDataGridViewCheckBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Classes.User);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(377, 23);
            label1.Name = "label1";
            label1.Size = new Size(293, 40);
            label1.TabIndex = 1;
            label1.Text = "Admin Database";
            // 
            // DatabaseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 151, 178);
            ClientSize = new Size(1038, 581);
            Controls.Add(label1);
            Controls.Add(panelDatabaseContainer);
            Name = "DatabaseForm";
            Text = "Database";
            panelDatabaseContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelDatabaseContainer;
        private DataGridView dataGridViewUsers;
        private Label label1;
        private BindingSource userBindingSource;
        private Button btnSaveChanges;
        private Button btnDeleteRow;
        private Button btnRevert;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn highScoreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
    }
}