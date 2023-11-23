using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            if (char.IsSymbol(bit) || char.IsWhiteSpace(bit) || char.IsPunctuation(bit)) passed = false;
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
            if (char.IsSymbol(bit) || char.IsWhiteSpace(bit) || char.IsPunctuation(bit)) passed = false;
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

    public static int GenerateID()
    {
        List<User> users = CSV.ReadInUsers();
        users.Sort();
        return users[users.Count - 1].ID + 1;
    }

    public static List<User> RemoveUserID(List<User> users, int id)
    {
        foreach (User user in users)
        {
            if (user.ID == id) users.Remove(user);
        }
        return users;
    }

    public static User FindUserID(List<User> users, int id)
    {
        foreach (User user in users) if (user.ID == id) return user;
        MessageBox.Show("FIND USER ERROR");
        return null;
    }

    public static int FindIndex(List<User> users, int id)
    {
        for (int i = 0; i < users.Count; i++) if (users[i].ID == id) return i;
        return -2;
    }

    public static bool VerifyList(List<User> users)
    {
        List<User> newUsers;
        int noOfAdmins = 0;
        foreach (User user in users)
        {
            newUsers = new List<User>(users);
            newUsers.Remove(user);
            foreach (User user2 in newUsers)
            {
                if (user.Username == user2.Username)
                {
                    MessageBox.Show("Database contains user of the same username","Error");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(user.Username))
            {
                MessageBox.Show("Empty or null username entered", "Error");
                return false;
            }
            foreach (char bit in user.Username)
            {
                if (char.IsSymbol(bit) || char.IsWhiteSpace(bit) || char.IsPunctuation(bit))
                {
                    MessageBox.Show("Username contains invalid symbol or white space", "Error");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(user.Password))
            {
                MessageBox.Show("Empty or null password entered", "Error");
                return false;
            }
            foreach (char bit in user.Password)
            {
                if (char.IsSymbol(bit) || char.IsWhiteSpace(bit) || char.IsPunctuation(bit))
                {
                    MessageBox.Show("Password contains invalid symbol or white space", "Error");
                    return false;
                }
            }

            if (user.Gender != "Male" && user.Gender != "Female" && user.Gender != "Other")
            {
                MessageBox.Show("Invalid gender has been entered *SOMEHOW*", "Error");
                return false;
            }

            if (user.IsAdmin) noOfAdmins++;
        }
        if (noOfAdmins < 1)
        {
            MessageBox.Show("There must be at least one admin account", "Error");
            return false;
            
        }
        return true;
    }
}
