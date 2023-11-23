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
            currentUserPosition = UserTools.FindIndex(users, MainForm.userID)+1;
            users = UserTools.TrimList(users, 5);
            PopulateLeaderboard();
        }

        void PopulateLeaderboard()
        {
            textBox1.Text = $"1 - {users[0].Username} - {users[0].HighScore}";
            textBox2.Text = $"2 - {users[1].Username} - {users[1].HighScore}";
            textBox3.Text = $"3 - {users[2].Username} - {users[2].HighScore}";
            textBox4.Text = $"4 - {users[3].Username} - {users[3].HighScore}";
            textBox5.Text = $"5 - {users[4].Username} - {users[4].HighScore}";
            textBox6.Text = $"{currentUserPosition} - {currentUser.Username} - {currentUser.HighScore}";
        }
    }
}
