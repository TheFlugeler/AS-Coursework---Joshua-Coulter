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

public partial class MainForm : Form
{
    private Form DisplayedForm = null;

    private static List<User> allUsers = new List<User>();
    public static User currentUser;
    private static int userIndex;

    public MainForm(User user, int index)
    {
        InitializeComponent();
        currentUser = user;
        allUsers = CSVReader.ReadInUsers();
        userIndex = index;
        btnAdmin.Enabled = currentUser.IsAdmin;
        backgroundWorkerClock.RunWorkerAsync();
    }

    public static void UpdateUserFile()
    {
        allUsers.RemoveAt(userIndex);
        allUsers.Add(currentUser);
        CSVWriter.WriteUsers(allUsers);
        allUsers = CSVReader.ReadInUsers();
        userIndex = allUsers.Count - 1;
    }

    public void DisplayForm(Form form)
    {
        if (DisplayedForm != null) DisplayedForm.Close();
        DisplayedForm = form;
        DisplayedForm.Dock = DockStyle.Fill;
        DisplayedForm.FormBorderStyle = FormBorderStyle.None;
        DisplayedForm.TopLevel = false;
        panelDisplay.Controls.Add(DisplayedForm);
        DisplayedForm.BringToFront();
        DisplayedForm.Show();
    }

    private void btnLogout_Click(object sender, EventArgs e) => (ActiveForm as MasterForm).DisplayForm(new LoginForm());

    private void btnMainMenu_Click(object sender, EventArgs e)
    {
        if (DisplayedForm != null) DisplayedForm.Close();
        lblClock.Show();
    }

    private void btnQuiz_Click(object sender, EventArgs e)
    {
        lblClock.Hide();
        DisplayForm(new QuizForm());
    }

    private void btnProfile_Click(object sender, EventArgs e)
    {
        UpdateUserFile();
        lblClock.Hide();
        DisplayForm(new ProfileForm(currentUser, userIndex));
    }

    private void backgroundWorkerClock_DoWork(object sender, DoWorkEventArgs e)
    {
        while (true)
        {
            string currentTime = $"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}";
            backgroundWorkerClock.ReportProgress(0, currentTime);
            Thread.Sleep(500);
        }
    }

    private void backgroundWorkerClock_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
        lblClock.Text = (string)e.UserState;
    }

    private void btnLeaderboard_Click(object sender, EventArgs e)
    {
        lblClock.Hide();
        UpdateUserFile();
        DisplayForm(new LeaderboardForm(currentUser));
    }

    private void btnAdmin_Click(object sender, EventArgs e)
    {
        lblClock.Hide();
        DisplayForm(new AdminForm());
    }
}
