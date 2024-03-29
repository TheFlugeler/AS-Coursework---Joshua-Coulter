using System.ComponentModel;
using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.ToolsLibrary;

namespace AS_Coursework___Joshua_Coulter.Forms
{
    public partial class DatabaseForm : Form
    {
        //This form displays the database of users in the system
        //It allows you to edit details of a user and delete users
        //A binding list was used to automatically update the list as the datagridview was changed
        BindingList<User> usersBL;
        public DatabaseForm()
        {
            InitializeComponent();
            usersBL = new BindingList<User>(CSV.ReadInUsers());
            usersBL.AllowRemove = true;
            dataGridViewUsers.DataSource = usersBL;
        }

        //This method attempts to delete the selected user
        //Unless it is the current user, then the admin is prompted to confirm the choice and then the user is removed from the view
        //This change is not saved until all changes are saved
        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count <= 0) return;
            if (MessageBox.Show("Are you sure you want to delete the user?", "Delete", MessageBoxButtons.YesNo) == DialogResult.No) return;
            List<User> users = CSV.ReadInUsers();
            User user = users.GetUser(MainForm.userID);
            if (dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString() == user.Username)
            {
                MessageBox.Show("Cannot delete current user","Error");
                return;
            }
            dataGridViewUsers.Rows.RemoveAt(dataGridViewUsers.SelectedRows[0].Index);
        }

        //This recalls the last saved state of the database
        private void btnRevert_Click(object sender, EventArgs e)
        {
            usersBL = new BindingList<User>(CSV.ReadInUsers());
            dataGridViewUsers.DataSource = usersBL;
            dataGridViewUsers.Refresh();
        }

        //This saves the changes made so far to the csv file
        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            List<User> newUsers = new(usersBL);
            if (!newUsers.GetUser(MainForm.userID).IsAdmin)
            {
                MessageBox.Show("Cannot remove current users admin", "Error");
                return;
            }
            if (!newUsers.VerifyList()) return;
            newUsers.WriteUserList();
            btnRevert_Click(sender, e);
            MessageBox.Show("Data Saved Successfully", "Data");
        }

        private void dataGridViewUsers_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("The value you entered is in the incorrect format", "Error");
        }


        //This forces the admin to use the inbuilt functions for deleting a user
        //Meaning that the program can control how the event is handled
        private void dataGridViewUsers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) e.Handled = true;
        }
    }
}
