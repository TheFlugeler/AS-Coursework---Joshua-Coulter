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

namespace AS_Coursework___Joshua_Coulter;

public partial class LoginForm : Form
{
    List<User> users = new List<User>();
    public LoginForm()
    {
        InitializeComponent();
        users = CSV.ReadInUsers();
        panelLoginBox.Show();
        panelRegister.Hide();
    }

    private void btnSignIn_Click(object sender, EventArgs e)
    {
        int index = 0;
        foreach (User user in users)
        {
            if (user.Username == textBoxUsername.Text && user.Password == textBoxPassword.Text)
            {
                (ActiveForm as MasterForm).DisplayForm(new MainForm(user, index));
                return;
            }
            index++;
        }
        ThrowError("Invalid Log In Details");
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        User NewUser;
        string[] details = new string[4];
        details[0] = textBoxRegisterUsername.Text;
        details[1] = textBoxRegisterPassword.Text;
        details[2] = dateTimePickerRegisterDOB.Value.ToShortDateString();
        if (radioButtonMale.Checked) details[3] = "Male";
        else if (radioButtonFemale.Checked) details[3] = "Female";
        else if (radioButtonOther.Checked) details[3] = "Other";
        else details[3] = "";

        if (!UserTools.CheckProperties(details))
        {
            ThrowError("Invalid User Details Entered");
            return;
        }

        NewUser = new User(details[0], details[1], 0, Convert.ToDateTime(details[2]), details[3], false);
        
        CSV.AddUser(NewUser);
        users = CSV.ReadInUsers();

        panelRegister.Visible = false;
        panelLoginBox.Visible = true;

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
}
