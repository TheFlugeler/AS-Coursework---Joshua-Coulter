using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public double HighScore { get; set; }
    public DateTime DOB { get; set; }
    public string Gender { get; set; }
    public bool IsAdmin { get; set; }

    public User(string username, string password,double highscore, DateTime dob, string gender, bool isadmin)
    {
        Username = username;
        Password = password;
        HighScore = highscore;
        DOB = dob;
        Gender = gender;
        IsAdmin = isadmin;
    }

    public override string ToString() => $"{Username},{Password},{HighScore},{DOB.ToShortDateString()},{Gender},{IsAdmin}";
}
