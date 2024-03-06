using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.ToolsLibrary;

namespace AS_Coursework___Joshua_Coulter;

public partial class LoginForm : Form
{
    //This Form contains all the controls to login or register

    List<User> users = new List<User>(CSV.ReadInUsers());
    bool passwordVisible;
    public LoginForm()
    {
        InitializeComponent();
        panelLoginBox.Show();
        panelRegister.Hide();
        textBoxPassword.PasswordChar = '•';
        pictureBoxPasswordVisible.Image = new Bitmap("ApplicationImages/show.png");
        passwordVisible = false;
    }

    private void btnSignIn_Click(object sender, EventArgs e)
    {
        int index = 0;
        foreach (User user in users)
        {
            if (user.Username == textBoxUsername.Text && user.Password == textBoxPassword.Text)
            {
                (ActiveForm as MasterForm)!.DisplayForm(new MainForm(user.ID, user.IsAdmin));
                return;
            }
            index++;
        }
        ThrowError("Invalid Log In Details");
    }

    //This method validates a new users details and appends the user to the file
    private void btnRegister_Click(object sender, EventArgs e)
    {
        string[] details = new string[4];
        details[0] = textBoxRegisterUsername.Text;
        details[1] = textBoxRegisterPassword.Text;
        details[2] = dateTimePickerRegisterDOB.Value.ToShortDateString();
        if (radioButtonMale.Checked) details[3] = "Male";
        else if (radioButtonFemale.Checked) details[3] = "Female";
        else if (radioButtonOther.Checked) details[3] = "Other";
        else details[3] = "";

        if (!details.CheckUser(true))
        {
            ThrowError(details.CheckUserMessage(true));
            return;
        }
        int id = Tools.GenerateID();

        new User(details[0], details[1], 0, Convert.ToDateTime(details[2]), details[3], false, id).WriteUser();

        users = CSV.ReadInUsers();

        panelRegister.Visible = false;
        panelLoginBox.Visible = true;

        textBoxRegisterUsername.Clear();
        textBoxRegisterPassword.Clear();
        dateTimePickerRegisterDOB.Value = DateTime.Today;
        radioButtonFemale.Checked = false;
        radioButtonMale.Checked = false;
        radioButtonOther.Checked = false;


        MessageBox.Show("Succesfully Registered", "Register");
    }


    private void linkLabelRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        panelLoginBox.Visible = false;
        panelRegister.Visible = true;
        textBoxUsername.Clear();
        textBoxPassword.Clear();
    }

    private void linkLabelSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        panelRegister.Visible = false;
        panelLoginBox.Visible = true;
        textBoxRegisterUsername.Clear();
        textBoxPassword.Clear();
        dateTimePickerRegisterDOB.Value = DateTime.Now;
        radioButtonMale.Checked = false;
        radioButtonFemale.Checked = false;
        radioButtonOther.Checked = false;
    }

    private void ThrowError(string message) => MessageBox.Show(message, "Error");

    private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == 13) btnSignIn_Click(sender, e); }

    private void pictureBoxPasswordVisible_Click(object sender, EventArgs e)
    {
        if (passwordVisible)
        {
            passwordVisible = false;
            textBoxPassword.PasswordChar = '•';
            pictureBoxPasswordVisible.Image = new Bitmap("ApplicationImages/show.png");
        }
        else
        {
            passwordVisible = true;
            textBoxPassword.PasswordChar = '\0';
            pictureBoxPasswordVisible.Image = new Bitmap("ApplicationImages/hide.png");
        }
    }

    private void textBoxUsername_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == 13) textBoxPassword.Select(); }
}
