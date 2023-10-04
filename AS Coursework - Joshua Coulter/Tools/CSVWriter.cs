using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Classes;

namespace AS_Coursework___Joshua_Coulter.Tools;

public static class CSVWriter
{
    static string UserFile = "Users.csv";
    static string MultipleChoiceFile = "MultipleChoiceQuestions.csv";
    static string TextFile = "TextQuestions.csv";
    public static void WriteUsers(List<User> users)
    {
        using (StreamWriter writer = new StreamWriter(UserFile,false))
        {
            foreach(User user in users)
            {
                writer.WriteLine(user.ToString());
            }
            writer.Close();
        }
    }

    public static void WriteMultipleChoiceQuestions(List<MultipleChoiceQuestion> list)
    {
        using (StreamWriter writer = new StreamWriter(MultipleChoiceFile, false))
        {
            foreach(MultipleChoiceQuestion question in list)
            {
                writer.WriteLine(question.ToWriteable());
            }
        }
    }

    public static void WriteTextQuestions(List<TextQuestion> textQuestions)
    {
        using (StreamWriter writer = new StreamWriter(TextFile, false))
        {
            foreach (TextQuestion question in textQuestions)
            {
                writer.Write(question.ToWriteable());
            }
        }
    }
}
