using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.ToolsLibrary;

namespace AS_Coursework___Joshua_Coulter;

public partial class LeaderboardForm : Form
{
    //This form shows the top 5 users by highscore and the current users placement overall
    List<User> users = new(CSV.ReadInUsers());
    User currentUser;
    int currentUserPosition;
    public LeaderboardForm()
    {
        InitializeComponent();
        currentUser = users.GetUser(MainForm.userID);
        users.RemoveAdmins();
        users.SortUsersHighscore();
        
        if (!currentUser.IsAdmin) currentUserPosition = users.FindIndex(MainForm.userID) + 1;

        PopulateLeaderboard();
    }

    void PopulateLeaderboard()
    {
        List<TextBox> usernames = new() {textBoxUsername1, textBoxUsername2, textBoxUsername3, textBoxUsername4, textBoxUsername5 };
        List<TextBox> highscores = new() {textBoxScore1,  textBoxScore2, textBoxScore3, textBoxScore4, textBoxScore5};
        
        for (int i = 0; i < 5; i++)
        {
            try
            {
                usernames[i].Text = users[i].Username;
                highscores[i].Text = users[i].HighScore.ToString();
            }catch
            {
                usernames[i].Text = "N/A";
                highscores[i].Text = "N/A";
            }
        }


        if (currentUser.IsAdmin) textBoxRankUser.Text = " N/A";
        else textBoxRankUser.Text = " " + Convert.ToString(currentUserPosition);

        textBoxScoreUser.Text = " " + Convert.ToString(currentUser.HighScore);
        textBoxUsernameUser.Text = " " + currentUser.Username;
    }

}
