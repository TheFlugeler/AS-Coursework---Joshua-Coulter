using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Classes;
using System.IO;
using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Tools;

public static class CSVReader
{
    private static string UserFile = "Users.csv";
    private static string MultipleQFile = "MultipleChoiceQuestions.csv";
    private static string TextQFile = "TextQuestions.csv";
    public static List<User> ReadInUsers()
    {
        List<User> users = new List<User>();
        if (File.ReadAllLines(UserFile).Length < 1) return users;
        using (StreamReader reader = new StreamReader(UserFile))
        {
            for (int i = 0; i < File.ReadAllLines(UserFile).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if(temp.Length < 6) return users;
                User user = new User(temp[0], temp[1], Convert.ToDouble(temp[2]), Convert.ToDateTime(temp[3]), temp[4], Convert.ToBoolean(temp[5]));
                users.Add(user);
            }
            reader.Close();
        }
        return users;
    }

    public static List<MultipleChoiceQuestion> ReadInMultipleChoiceQuestions()
    {
        List<MultipleChoiceQuestion> questions = new List<MultipleChoiceQuestion>();
        if (File.ReadAllLines(MultipleQFile).Length < 1) return questions;
        using (StreamReader reader = new StreamReader(MultipleQFile))
        {
            for (int i = 0; i < File.ReadAllLines(MultipleQFile).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 6) return questions;
                string[] _options = new string[3] { temp[2], temp[3], temp[4] };
                MultipleChoiceQuestion question = new MultipleChoiceQuestion(temp[0], (Difficulty)Convert.ToInt16(temp[1]), QuestionTypes.MultipleChoice, _options, Convert.ToInt16(temp[5]));
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }

    public static List<TextQuestion> ReadInTextQuestions()
    {
        List<TextQuestion> questions = new List<TextQuestion>();
        if (File.ReadAllLines(TextQFile).Length < 1) return questions;
        using (StreamReader reader = new StreamReader(TextQFile))
        {
            for (int i = 0; i < File.ReadAllLines(TextQFile).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 3) return questions;
                TextQuestion question = new TextQuestion(temp[0], (Difficulty)Convert.ToInt16(temp[1]), QuestionTypes.Text, temp[2]);
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }
}
