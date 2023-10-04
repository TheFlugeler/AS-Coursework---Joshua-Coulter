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
using AS_Coursework___Joshua_Coulter.Tools;

namespace AS_Coursework___Joshua_Coulter
{
    public partial class ProfileForm : Form
    {
        User currentUser;
        int userIndex;
        List<User> allUsers = new List<User>();
        public ProfileForm(User user, int _userIndex)
        {
            InitializeComponent();
            currentUser = user;
            userIndex = _userIndex;
            allUsers = CSVReader.ReadInUsers();
            FillDetails();
        }

        public void FillDetails()
        {
            textBoxProfileUsername.Text = currentUser.Username;
            textBoxProfilePassword.Text = currentUser.Password;
            textBoxProfileGender.Text = currentUser.Gender;
            textBoxProfileDOB.Text = currentUser.DOB.ToShortDateString();
            textBoxProfileHighscore.Text = Convert.ToString(currentUser.HighScore);
        }

        private void linkLabelProfileEditClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelEditProfile.Visible = false;
            panelProfileDisplay.Visible = true;
        }

        private void btnProfileEdit_Click(object sender, EventArgs e)
        {
            panelEditProfile.Visible = true;
            panelProfileDisplay.Visible = false;
            textBoxEditUsername.Text = currentUser.Username;
            textBoxEditPassword.Text = currentUser.Password;
            switch (currentUser.Gender)
            {
                case "Male":
                    radioButtonMale.Checked = true;
                    break;
                case "Female":
                    radioButtonFemale.Checked = true;
                    break;
                case "Other":
                    radioButtonOther.Checked = true;
                    break;
                default:
                    break;
            }
            dateTimePickerEditDOB.Value = currentUser.DOB;

        }

        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            string[] details = new string[6];
            details[0] = textBoxEditUsername.Text;
            details[1] = textBoxEditPassword.Text;
            details[2] = Convert.ToString(currentUser.HighScore);
            details[3] = dateTimePickerEditDOB.Value.ToShortDateString();
            if (radioButtonMale.Checked) details[4] = "Male";
            else if (radioButtonFemale.Checked) details[4] = "Female";
            else if (radioButtonOther.Checked) details[4] = "Other";
            else details[4] = "";
            details[5] = Convert.ToString(currentUser.IsAdmin);

            if (!UserTools.CheckProperties(details))
            {
                MessageBox.Show("Invalid details entered", "Error");
                return;
            }

            allUsers.RemoveAt(userIndex);

            foreach (User user in allUsers)
            {
                if (details[0] == user.Username)
                {
                    MessageBox.Show("Username already taken", "Error");
                    return;
                }
            }

            currentUser.Username = details[0];
            currentUser.Password = details[1];
            currentUser.DOB = Convert.ToDateTime(details[3]);
            currentUser.Gender = details[4];

            MainForm.currentUser = currentUser;
            MainForm.UpdateUserFile();
            userIndex = allUsers.Count;
            allUsers = CSVReader.ReadInUsers();

            panelEditProfile.Visible = false;
            panelProfileDisplay.Visible = true;
            FillDetails();
            MessageBox.Show("Details Successfully edited", "Success");
        }
    }
}
