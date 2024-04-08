using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.ToolsLibrary;

namespace AS_Coursework___Joshua_Coulter
{
    //This form provides the facility to view and edit your profile
    //All details are changeable and validated except for the highscore
    public partial class ProfileForm : Form
    {
        User currentUser;
        List<User> allUsers = new(CSV.ReadInUsers());
        public ProfileForm()
        {
            InitializeComponent();
            currentUser = allUsers.GetUser(MainForm.userID);
            FillDetails();
            dateTimePickerEditDOB.MaxDate = DateTime.Now.Date;
            dateTimePickerEditDOB.MinDate = DateTime.Now.Date - new TimeSpan(36500,0,0,0);
        }

        //This method populates the data in the display section
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

        //This method validates the new details for the user and then removes the old details and writes the new details
        private void btnProfileUpdate_Click(object sender, EventArgs e)
        {
            string[] details = new string[5];
            details[0] = textBoxEditUsername.Text;
            details[1] = textBoxEditPassword.Text;
            details[2] = dateTimePickerEditDOB.Value.ToShortDateString();
            if (radioButtonMale.Checked) details[3] = "Male";
            else if (radioButtonFemale.Checked) details[3] = "Female";
            else if (radioButtonOther.Checked) details[3] = "Other";
            else details[3] = "";
            details[4] = Convert.ToString(MainForm.userID);

            if (!details.CheckUser(false))
            {
                MessageBox.Show(details.CheckUserMessage(false), "Error");
                return;
            }

            currentUser.Username = details[0];
            currentUser.Password = details[1];
            currentUser.DOB = Convert.ToDateTime(details[2]);
            currentUser.Gender = details[3];

            allUsers.RemoveUserID(currentUser.ID);
            allUsers.Add(currentUser);
            allUsers.WriteUserList();

            panelEditProfile.Visible = false;
            panelProfileDisplay.Visible = true;
            FillDetails();
            MessageBox.Show("Details Successfully edited", "Success");
        }
    }
}
