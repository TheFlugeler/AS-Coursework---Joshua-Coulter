using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Classes;
using System.IO;
using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Tools;

public static class CSV
{
    private static string UserFile = "Databases/Users.csv";
    private static string MultipleChoice = "Databases/MultipleChoiceQuestions.csv";
    private static string Text = "Databases/TextQuestions.csv";
    private static string AudioMC = "Databases/AudioMultipleChoiceQuestions.csv";
    private static string AudioText = "Databases/AudioTextQuestions.csv";
    private static string PictureMC = "Databases/PictureMultipleChoiceQuestions.csv";
    private static string PictureText = "Databases/PictureTextQuestions.csv";

    public static List<User> ReadInUsers()
    {
        List<User> users = new List<User>();
        if (File.ReadAllLines(UserFile).Length < 1) return users;
        using (StreamReader reader = new StreamReader(UserFile))
        {
            for (int i = 0; i < File.ReadAllLines(UserFile).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if(temp.Length < 7) return users;
                User user = new User(temp[0], temp[1], Convert.ToDouble(temp[2]), Convert.ToDateTime(temp[3]), temp[4], Convert.ToBoolean(temp[5]), Convert.ToInt16(temp[6]));
                users.Add(user);
            }
            reader.Close();
        }
        return users;
    }

    public static List<Question> ReadInAllQuestions()
    {
        List<Question> allQuestions = new List<Question>();
        allQuestions.AddRange(ReadInMultipleChoiceQuestions());
        allQuestions.AddRange(ReadInTextQuestions());
        allQuestions.AddRange(ReadInAudioMultipleChoiceQuestions());
        allQuestions.AddRange(ReadInAudioTextQuestions());
        allQuestions.AddRange(ReadInPictureMultipleChoiceQuestions());
        allQuestions.AddRange(ReadInPictureTextQuestions());

        return allQuestions;
    }

    public static List<Question> ReadInQuestions(QuestionTypes type)
    {
        switch (type)
        {
            case QuestionTypes.Text: return new List<Question>(ReadInTextQuestions());
            case QuestionTypes.MultipleChoice: return new List<Question>(ReadInMultipleChoiceQuestions());
            case QuestionTypes.AudioText: return new List<Question>(ReadInAudioTextQuestions());
            case QuestionTypes.AudioMultipleChoice: return new List<Question>(ReadInAudioMultipleChoiceQuestions());
            case QuestionTypes.PictureText: return new List<Question>(ReadInPictureTextQuestions());
            case QuestionTypes.PictureMultipleChoice: return new List<Question>(ReadInPictureMultipleChoiceQuestions());
            default: MessageBox.Show("Read in questions ERROR"); break;
        }
        return null!;
    }


    private static List<MultipleChoiceQuestion> ReadInMultipleChoiceQuestions()
    {
        List<MultipleChoiceQuestion> questions = new List<MultipleChoiceQuestion>();
        if (File.ReadAllLines(MultipleChoice).Length < 1) return questions;
        using (StreamReader reader = new StreamReader(MultipleChoice))
        {
            for (int i = 0; i < File.ReadAllLines(MultipleChoice).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 6) return questions;
                string[] _options = new string[3] { temp[2], temp[3], temp[4] };
                MultipleChoiceQuestion question = new MultipleChoiceQuestion(temp[0], (Difficulty)Convert.ToInt16(temp[1]), _options, Convert.ToInt16(temp[5]));
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }

    private static List<TextQuestion> ReadInTextQuestions()
    {
        List<TextQuestion> questions = new List<TextQuestion>();
        if (File.ReadAllLines(Text).Length < 1) return questions;
        using (StreamReader reader = new StreamReader(Text))
        {
            for (int i = 0; i < File.ReadAllLines(Text).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 3) return questions;
                TextQuestion question = new TextQuestion(temp[0], (Difficulty)Convert.ToInt16(temp[1]), temp[2]);
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }

    private static List<AudioMultipleChoiceQuestion> ReadInAudioMultipleChoiceQuestions()
    {
        List<AudioMultipleChoiceQuestion> questions = new List<AudioMultipleChoiceQuestion>();
        if (File.ReadAllLines(AudioMC).Length < 1) return questions;
        using (StreamReader reader = new StreamReader(AudioMC))
        {
            for (int i = 0; i < File.ReadAllLines(AudioMC).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 7) return questions;
                string[] _options = new string[3] { temp[2], temp[3], temp[4] };
                AudioMultipleChoiceQuestion question = new AudioMultipleChoiceQuestion(temp[0], (Difficulty)Convert.ToInt16(temp[1]), _options, Convert.ToInt16(temp[5]), temp[6]);
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }

    private static List<AudioTextQuestion> ReadInAudioTextQuestions()
    {
        List<AudioTextQuestion> questions = new List<AudioTextQuestion>();
        if (File.ReadAllLines(AudioText).Length < 1) return questions;
        using (StreamReader reader = new StreamReader(AudioText))
        {
            for (int i = 0; i < File.ReadAllLines(AudioText).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 4) return questions;
                AudioTextQuestion question = new AudioTextQuestion(temp[0], (Difficulty)Convert.ToInt16(temp[1]), temp[2], temp[3]);
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }

    private static List<PictureMultipleChoiceQuestion> ReadInPictureMultipleChoiceQuestions()
    {
        List<PictureMultipleChoiceQuestion> questions = new List<PictureMultipleChoiceQuestion>();
        if (File.ReadAllLines(PictureMC).Length < 1) return questions;
        using (StreamReader reader = new StreamReader(PictureMC))
        {
            for (int i = 0; i < File.ReadAllLines(PictureMC).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 7) return questions;
                string[] _options = new string[3] { temp[2], temp[3], temp[4] };
                PictureMultipleChoiceQuestion question = new PictureMultipleChoiceQuestion(temp[0], (Difficulty)Convert.ToInt16(temp[1]), _options, Convert.ToInt16(temp[5]), temp[6]);
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }

    private static List<PictureTextQuestion> ReadInPictureTextQuestions()
    {
        List<PictureTextQuestion> questions = new List<PictureTextQuestion>();
        if (File.ReadAllLines(PictureText).Length < 1) return questions;
        using (StreamReader reader = new StreamReader(PictureText))
        {
            for (int i = 0; i < File.ReadAllLines(PictureText).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 4) return questions;
                PictureTextQuestion question = new PictureTextQuestion(temp[0], (Difficulty)Convert.ToInt16(temp[1]), temp[2], temp[3]);
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }



    public static void WriteUserList(List<User> users)
    {
        using (StreamWriter writer = new StreamWriter(UserFile, false))
        {
            users.Sort();
            foreach (User user in users)
            {
                writer.WriteLine(user.ToString());
            }
            writer.Close();
        }
    }

    public static void AddUser(User user)
    {
        using (StreamWriter writer = new StreamWriter(UserFile, true))
        {
            writer.WriteLine(user.ToString());
            writer.Close();
        }
    }

    public static void WriteQuestionsList(List<Question> list, QuestionTypes type)
    {
        string file;
        switch (type)
        {
            case QuestionTypes.Text: file = Text; break;
            case QuestionTypes.MultipleChoice: file = MultipleChoice; break;
            case QuestionTypes.AudioText: file = AudioText; break;
            case QuestionTypes.AudioMultipleChoice: file = AudioMC; break;
            case QuestionTypes.PictureText: file = PictureText; break;
            case QuestionTypes.PictureMultipleChoice: file = PictureMC; break;
            default: MessageBox.Show("WRITE QUESTIONS ERROR"); return;
        }
        using (StreamWriter writer = new StreamWriter(file, false))
        {
            foreach (Question question in list) writer.WriteLine(question.ToWriteable());
            writer.Close();
        }
    }

    public static void AddQuestion(Question question, QuestionTypes type)
    {
        string file;
        switch (type)
        {
            case QuestionTypes.Text: file = Text; break;
            case QuestionTypes.MultipleChoice: file = MultipleChoice; break;
            case QuestionTypes.AudioText: file = AudioText; break;
            case QuestionTypes.AudioMultipleChoice: file = AudioMC; break;
            default: MessageBox.Show("ADD QUESTIONS ERROR"); return;
        }
        using (StreamWriter writer = new StreamWriter(file, false))
        {
            writer.WriteLine(question.ToWriteable());
            writer.Close();
        }
    }
}
