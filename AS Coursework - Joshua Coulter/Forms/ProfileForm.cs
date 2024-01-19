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
        List<User> allUsers = new List<User>();
        public ProfileForm()
        {
            InitializeComponent();
            allUsers = CSV.ReadInUsers();
            currentUser = UserTools.FindUserID(allUsers, MainForm.userID);
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
            string[] details = new string[4];
            details[0] = textBoxEditUsername.Text;
            details[1] = textBoxEditPassword.Text;
            details[2] = dateTimePickerEditDOB.Value.ToShortDateString();
            if (radioButtonMale.Checked) details[3] = "Male";
            else if (radioButtonFemale.Checked) details[3] = "Female";
            else if (radioButtonOther.Checked) details[3] = "Other";
            else details[3] = "";
            details[4] = Convert.ToString(MainForm.userID);

            if (!UserTools.CheckProperties(details))
            {
                MessageBox.Show("Invalid details entered", "Error");
                return;
            }

            currentUser.Username = details[0];
            currentUser.Password = details[1];
            currentUser.DOB = Convert.ToDateTime(details[2]);
            currentUser.Gender = details[3];

            allUsers = UserTools.RemoveUserID(allUsers, currentUser.ID);
            allUsers.Add(currentUser);
            CSV.WriteUserList(allUsers);

            panelEditProfile.Visible = false;
            panelProfileDisplay.Visible = true;
            FillDetails();
            MessageBox.Show("Details Successfully edited", "Success");
        }
    }
}
