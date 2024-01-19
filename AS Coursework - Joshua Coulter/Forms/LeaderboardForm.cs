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
    public partial class LeaderboardForm : Form
    {
        List<User> users = new List<User>();
        User currentUser;
        int currentUserPosition;
        public LeaderboardForm()
        {
            InitializeComponent();
            users = CSV.ReadInUsers();
            currentUser = UserTools.FindUserID(users, MainForm.userID);
            users = UserTools.SortUsersHighscore(users);
            currentUserPosition = UserTools.FindIndex(users, MainForm.userID) + 1;
            users = UserTools.TrimList(users, 5);
            PopulateLeaderboard();
        }

        void PopulateLeaderboard()
        {
            textBoxUsername1.Text = " " + users[0].Username;
            textBoxUsername2.Text = " " + users[1].Username;
            textBoxUsername3.Text = " " + users[2].Username;
            textBoxUsername4.Text = " " + users[3].Username;
            textBoxUsername5.Text = " " + users[4].Username;

            textBoxScore1.Text = " " + Convert.ToString(users[0].HighScore);
            textBoxScore2.Text = " " + Convert.ToString(users[1].HighScore);
            textBoxScore3.Text = " " + Convert.ToString(users[2].HighScore);
            textBoxScore4.Text = " " + Convert.ToString(users[3].HighScore);
            textBoxScore5.Text = " " + Convert.ToString(users[4].HighScore);

            textBoxRankUser.Text = " " + Convert.ToString(currentUserPosition);
            textBoxScoreUser.Text = " " + Convert.ToString(currentUser.HighScore);
            textBoxUsernameUser.Text = " " + currentUser.Username;
        }

    }
}
