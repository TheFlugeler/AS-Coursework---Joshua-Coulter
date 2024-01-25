using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.AllTools;

public static class Tools
{
    private static Random rand = new();
    public static void Center<T>(this T control) where T : Control
    {
        control.Location = new(control.Parent!.Width / 2 - control.Width / 2, control.Location.Y);
    }

    public static void ResizePicPanel<T>(T control, Bitmap pic, int maxX, int maxY, int minX, int minY) where T : PictureBox
    {

        int X = pic.Width;
        int Y = pic.Height;

        double ratio;
        if (X > maxX)
        {
            ratio = (double)maxX / X;
            X = Convert.ToInt16(Math.Round(X * ratio));
            Y = Convert.ToInt16(Math.Round(Y * ratio));

        }
        if (X < minX)
        {
            ratio = (double)minX / X;
            Y = Convert.ToInt16(Math.Round(Y * ratio));
            X = Convert.ToInt16(Math.Round(X * ratio));
        }
        if (Y > maxY)
        {
            ratio = (double)maxY / Y;
            X = Convert.ToInt16(Math.Round(X * ratio));
            Y = Convert.ToInt16(Math.Round(Y * ratio));

        }
        if (Y < minY)
        {
            ratio = (double)minY / Y;
            Y = Convert.ToInt16(Math.Round(Y * ratio));
            X = Convert.ToInt16(Math.Round(X * ratio));
        }

        control.Parent!.Size = new(X + 40, Y + 40);
        control.Size = new(X, Y);
    }

    public static void ReturnDifficulty(this List<Question> questions, Difficulty diff)
    {
        List<Question> result = new();
        foreach (Question question in questions)
        {
            if (question.QuestionDifficulty == diff) result.Add(question);
        }
        questions.Clear();
        foreach (Question question in result)
        {
            questions.Add(question);
        }
    }

    public static void Shuffle<T>(this List<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int j = rand.Next(i, list.Count());
            (list[i], list[j]) = (list[j], list[i]);
        }
    }

    public static void Shuffle<T>(this T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int j = rand.Next(i, array.Count());
            (array[i], array[j]) = (array[j], array[i]);
        }
    }

    public static bool CheckUser(this string[] details, bool newUser)
    {
        string username = details[0];
        if (string.IsNullOrEmpty(username)) return false;

        foreach (char c in username)
        {
            if (char.IsSymbol(c) || char.IsWhiteSpace(c) || char.IsPunctuation(c)) return false;
        }

        
        
        List<User> users = CSV.ReadInUsers();
        if (!newUser) users.RemoveUserID(MainForm.userID);
        foreach (User user in users)
        {
            if (details[0] == user.Username) return false;
        }

        string password = details[1];
        if (string.IsNullOrEmpty(password)) return false;
        foreach (char bit in password)
        {
            if (char.IsSymbol(bit) || char.IsWhiteSpace(bit) || bit == ',') return false;
        }

        DateTime dob;
        if (!DateTime.TryParse(details[2], out dob)) return false;

        if (details[3] != "Male" && details[3] != "Female" && details[3] != "Other") return false;

        return true;
    }

    public static void SortUsersHighscore(this List<User> users)
    {
        List<User> newlist = new();
        User highestuser;
        int t = users.Count;
        for (int i = 0; i < t; i++)
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
        users.Clear();
        foreach (User user in newlist)
        {
            users.Add(user);
        }
    }

    public static void TrimList<T>(this List<T> users, int amount)
    {
        if (amount > users.Count) return;
        while (users.Count > amount) users.RemoveAt(users.Count - 1);
    }

    public static int GenerateID()
    {
        List<User> users = CSV.ReadInUsers();
        users.Sort();
        return users[users.Count - 1].ID + 1;
    }

    public static void RemoveUserID(this List<User> users, int id)
    {
        for (int i = 0; i < users.Count; i++)
        {
            User user = users[i];
            if (user.ID == id) users.Remove(user);
        }
    }

    public static User FindUserID(this List<User> users, int id)
    {
        foreach (User user in users) if (user.ID == id) return user;
        MessageBox.Show("FIND USER ERROR");
        return null!;
    }

    public static int FindIndex(this List<User> users, int id)
    {
        for (int i = 0; i < users.Count; i++) if (users[i].ID == id) return i;
        MessageBox.Show("FIND INDEX ERROR");
        return -1;
    }

    public static bool VerifyList(this List<User> users)
    {
        List<User> newUsers;
        int noOfAdmins = 0;
        foreach (User user in users)
        {
            newUsers = new(users);
            newUsers.Remove(user);
            foreach (User user2 in newUsers)
            {
                if (user.Username == user2.Username)
                {
                    MessageBox.Show("Database contains user of the same username", "Error");
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

            if (user.DOB < DateTimePicker.MinimumDateTime || user.DOB > DateTimePicker.MaximumDateTime)
            {
                MessageBox.Show("Invalid date has been entered", "Error");
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
