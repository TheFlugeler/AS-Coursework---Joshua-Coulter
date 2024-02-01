using System.ComponentModel;

namespace AS_Coursework___Joshua_Coulter;

public partial class MainForm : Form
{
    //This is the Main form for the entire program and all subsequent forms are displayed within it

    private Form DisplayedForm;
    public static int userID;

    public MainForm(int id, bool isAdmin)
    {
        InitializeComponent();
        userID = id;
        btnAdmin.Visible = isAdmin;
        backgroundWorkerClock.RunWorkerAsync();
    }

    //This is the same method as in the master form
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
        lblClock.Hide();
        DisplayForm(new ProfileForm());
    }

    private void btnLeaderboard_Click(object sender, EventArgs e)
    {
        lblClock.Hide();
        DisplayForm(new LeaderboardForm());
    }

    private void btnAdmin_Click(object sender, EventArgs e)
    {
        lblClock.Hide();
        DisplayForm(new AdminForm());
    }


    //=======================================================

    //This background worker keeps the clock going every half second
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
}
