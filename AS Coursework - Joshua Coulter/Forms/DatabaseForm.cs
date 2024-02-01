using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.ToolsLibrary;

namespace AS_Coursework___Joshua_Coulter.Forms
{
    public partial class DatabaseForm : Form
    {
        //This form displays the database of users in the system
        //It allows you to edit details of a user and delete users
        BindingList<User> usersBL;
        public DatabaseForm()
        {
            InitializeComponent();
            usersBL = new BindingList<User>(CSV.ReadInUsers());
            usersBL.AllowRemove = true;
            dataGridViewUsers.DataSource = usersBL;
        }
        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count <= 0) return;
            List<User> users = CSV.ReadInUsers();
            User user = users.FindUserID(MainForm.userID);
            if (dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString() == user.Username)
            {
                MessageBox.Show("Cannot delete current user","Error");
                return;
            }
            dataGridViewUsers.Rows.RemoveAt(dataGridViewUsers.SelectedRows[0].Index);
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            usersBL = new BindingList<User>(CSV.ReadInUsers());
            dataGridViewUsers.DataSource = usersBL;
            dataGridViewUsers.Refresh();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            List<User> newUsers = new(usersBL);
            if (!newUsers.VerifyList()) return;
            newUsers.WriteUserList();
            btnRevert_Click(sender, e);
            MessageBox.Show("Data Saved Successfully", "Data");
        }

        private void dataGridViewUsers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("The value you entered is in the incorrect format", "Error");
        }

        private void dataGridViewUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) e.Handled = true;
        }
    }
}
