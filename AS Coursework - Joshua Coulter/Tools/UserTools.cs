using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Classes;

namespace AS_Coursework___Joshua_Coulter.Tools;

public static class UserTools
{
    public static bool CheckProperties(string[] details)
    {
        bool passed = true;

        string username = details[0];
        if (string.IsNullOrEmpty(username)) passed = false;
        foreach(char bit in username)
        {
            if (char.IsSymbol(bit)) passed = false;
            if (char.IsWhiteSpace(bit)) passed = false;
        }

        List<User> users = CSV.ReadInUsers();

        foreach (User user in users)
        {
            if (details[0] == user.Username) passed = false;
        }

        string password = details[1];
        if (string.IsNullOrEmpty(password)) passed = false;
        foreach (char bit in password)
        {
            if (char.IsSymbol(bit)) passed = false;
            if (char.IsWhiteSpace(bit)) passed = false;
        }

        DateTime dob;
        if(!DateTime.TryParse(details[2],out dob)) passed = false;

        string gender = details[3];
        if (gender != "Male" && gender != "Female" && gender != "Other") passed = false;

        return passed;
    }

    public static List<User> SortUsersHighscore(List<User> users)
    {
        List<User> newlist = new List<User>();
        User highestuser;
        int t = users.Count;
        for(int i = 0;i < t; i++)
        {
            highestuser = users[0];
            foreach (User user in users)
            {
                if (user.HighScore > highestuser.HighScore)
                {
                    highestuser = user;
                }
            }
            newlist.Add(highestuser);
            users.Remove(highestuser);
        }
        users = newlist;
        return newlist;
    }

    public static List<User> TrimList(List<User> users, int amount)
    {
        if (amount > users.Count) return users;
        while(users.Count > amount) users.RemoveAt(users.Count - 1);
        return users;
    }

    public static int FindIndex(User user, List<User> users)
    {
        int index = -1;
        for (int i = 0; i < users.Count; i++) 
        {
            if (users[i].Username == user.Username) index = i;
        }
        return index;
    }
}
