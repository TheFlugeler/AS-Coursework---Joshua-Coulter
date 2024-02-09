namespace AS_Coursework___Joshua_Coulter.Classes;

public class User : IComparable<User>
{

    //
    //This object hold all the information needed for a user
    //It is used throughout the program to store separate scores and other details
    //
    public int ID { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public double HighScore { get; set; }
    public DateTime DOB { get; set; }
    public string Gender { get; set; }
    public bool IsAdmin { get; set; }

    public User(string username, string password,double highscore, DateTime dob, string gender, bool isadmin, int id)
    {
        Username = username;
        Password = password;
        HighScore = highscore;
        DOB = dob;
        Gender = gender;
        IsAdmin = isadmin;
        ID = id;
    }

    //The User object is serialized to be written to the CSV with a public method
    public override string ToString() => $"{Username},{Password},{HighScore},{DOB.ToShortDateString()},{Gender},{IsAdmin},{ID}";

    //The IComparable interface is used to sort the users using inbuilt sort functions by User ID
    //The unique user IDs are used throughout the program to easily differentiate users
    public int CompareTo(User? other)
    {
        if (ID > other.ID) return 1;
        if(ID < other.ID) return -1;
        MessageBox.Show("Sorting User Error","Error");
        return 0 ;
    }
}
