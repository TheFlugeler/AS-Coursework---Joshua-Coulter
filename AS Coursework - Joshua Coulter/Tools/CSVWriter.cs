using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Classes;

namespace AS_Coursework___Joshua_Coulter.Tools;

public static class CSVWriter
{
    static string UserFile = "Databases/Users.csv";
    static string MultipleChoiceFile = "Databases/MultipleChoiceQuestions.csv";
    static string TextFile = "Databases/TextQuestions.csv";
    static string AudioMCFile = "Databases/AudioMultipleChoiceQuestions.csv";
    static string AudioTextFile = "Databases/AudioTextQuestions.csv";
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

    //
    // When writing the questions, The question type is not written as there are separate files for each question type
    // The Question type is added to the object in the CSVReader algorithm
    //

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

    public static void WriteAudioMultipleChoiceQuestions(List<AudioMultipleChoiceQuestion> list)
    {
        using (StreamWriter writer = new StreamWriter(AudioMCFile, false))
        {
            foreach (AudioMultipleChoiceQuestion question in list)
            {
                writer.WriteLine(question.ToWriteable());
            }
        }
    }

    public static void WriteAudioTextQuestions(List<AudioTextQuestion> list)
    {
        using (StreamWriter writer = new StreamWriter(AudioTextFile, false))
        {
            foreach (AudioTextQuestion question in list)
            {
                writer.WriteLine(question.ToWriteable());
            }
        }
    }
}
