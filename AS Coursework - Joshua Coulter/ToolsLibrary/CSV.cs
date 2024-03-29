using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.ToolsLibrary;

public static class CSV
{
    //
    //This is the helper class for writing and reading from the CSV files
    //It contains specific methods for reading each question type and users
    //It also contains a generic method for writing questions to file as polymorphism can be used
    //Instead of having a long list of methods for reading each question type, we use one base method that references the others
    //It also contains methods to append individual questions and users to the file
    //

    private static string UserFile = "Databases/Users.csv";
    private static string MultipleChoice = "Databases/MultipleChoiceQuestions.csv";
    private static string Text = "Databases/TextQuestions.csv";
    private static string AudioMC = "Databases/AudioMultipleChoiceQuestions.csv";
    private static string AudioText = "Databases/AudioTextQuestions.csv";
    private static string PictureMC = "Databases/PictureMultipleChoiceQuestions.csv";
    private static string PictureText = "Databases/PictureTextQuestions.csv";
    private static string Match = "Databases/MatchQuestions.csv";

    public static List<User> ReadInUsers()
    {
        List<User> users = new();
        if (File.ReadAllLines(UserFile).Length < 1) return users;
        using (StreamReader reader = new(UserFile))
        {
            for (int i = 0; i < File.ReadAllLines(UserFile).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if(temp.Length < 7) return users;
                User user = new(temp[0], temp[1], Convert.ToDouble(temp[2]), Convert.ToDateTime(temp[3]), temp[4], Convert.ToBoolean(temp[5]), Convert.ToInt16(temp[6]));
                users.Add(user);
            }
            reader.Close();
        }
        return users;
    }

    public static List<Question> ReadInAllQuestions()
    {
        List<Question> allQuestions = new();
        allQuestions.AddRange(ReadInMultipleChoiceQuestions());
        allQuestions.AddRange(ReadInTextQuestions());
        allQuestions.AddRange(ReadInAudioMultipleChoiceQuestions());
        allQuestions.AddRange(ReadInAudioTextQuestions());
        allQuestions.AddRange(ReadInPictureMultipleChoiceQuestions());
        allQuestions.AddRange(ReadInPictureTextQuestions());
        allQuestions.AddRange(ReadInMatchQuestions());
        return allQuestions;
    }

    //This is the public method for accessing all the different question databases
    //Each question type has a different method to read in and they are all centralised to here
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
            case QuestionTypes.Match: return new List<Question>(ReadInMatchQuestions());
        }
        return new();
    }


    private static List<MultipleChoiceQuestion> ReadInMultipleChoiceQuestions()
    {
        List<MultipleChoiceQuestion> questions = new();
        if (File.ReadAllLines(MultipleChoice).Length < 1) return questions;
        using (StreamReader reader = new(MultipleChoice))
        {
            for (int i = 0; i < File.ReadAllLines(MultipleChoice).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 6) return questions;
                string[] _options = new string[3] { temp[2], temp[3], temp[4] };
                MultipleChoiceQuestion question = new(temp[0], (Difficulty)Convert.ToInt16(temp[1]), _options, Convert.ToInt16(temp[5]));
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }

    private static List<TextQuestion> ReadInTextQuestions()
    {
        List<TextQuestion> questions = new();
        if (File.ReadAllLines(Text).Length < 1) return questions;
        using (StreamReader reader = new(Text))
        {
            for (int i = 0; i < File.ReadAllLines(Text).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 3) return questions;
                TextQuestion question = new(temp[0], (Difficulty)Convert.ToInt16(temp[1]), temp[2]);
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }

    private static List<AudioMultipleChoiceQuestion> ReadInAudioMultipleChoiceQuestions()
    {
        List<AudioMultipleChoiceQuestion> questions = new();
        if (File.ReadAllLines(AudioMC).Length < 1) return questions;
        using (StreamReader reader = new(AudioMC))
        {
            for (int i = 0; i < File.ReadAllLines(AudioMC).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 7) return questions;
                string[] _options = new string[3] { temp[2], temp[3], temp[4] };
                AudioMultipleChoiceQuestion question = new(temp[0], (Difficulty)Convert.ToInt16(temp[1]), _options, Convert.ToInt16(temp[5]), temp[6]);
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }

    private static List<AudioTextQuestion> ReadInAudioTextQuestions()
    {
        List<AudioTextQuestion> questions = new();
        if (File.ReadAllLines(AudioText).Length < 1) return questions;
        using (StreamReader reader = new(AudioText))
        {
            for (int i = 0; i < File.ReadAllLines(AudioText).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 4) return questions;
                AudioTextQuestion question = new(temp[0], (Difficulty)Convert.ToInt16(temp[1]), temp[2], temp[3]);
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }

    private static List<PictureMultipleChoiceQuestion> ReadInPictureMultipleChoiceQuestions()
    {
        List<PictureMultipleChoiceQuestion> questions = new();
        if (File.ReadAllLines(PictureMC).Length < 1) return questions;
        using (StreamReader reader = new(PictureMC))
        {
            for (int i = 0; i < File.ReadAllLines(PictureMC).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 7) return questions;
                string[] _options = new string[3] { temp[2], temp[3], temp[4] };
                PictureMultipleChoiceQuestion question = new(temp[0], (Difficulty)Convert.ToInt16(temp[1]), _options, Convert.ToInt16(temp[5]), temp[6]);
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }

    private static List<PictureTextQuestion> ReadInPictureTextQuestions()
    {
        List<PictureTextQuestion> questions = new();
        if (File.ReadAllLines(PictureText).Length < 1) return questions;
        using (StreamReader reader = new(PictureText))
        {
            for (int i = 0; i < File.ReadAllLines(PictureText).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 4) return questions;
                PictureTextQuestion question = new(temp[0], (Difficulty)Convert.ToInt16(temp[1]), temp[2], temp[3]);
                questions.Add(question);
            }
            reader.Close();
        }
        return questions;
    }

    private static List<MatchQuestion> ReadInMatchQuestions()
    {
        List<MatchQuestion> questions = new();
        if (File.ReadAllLines(Match).Length < 1) return questions;

        using (StreamReader reader = new(Match))
        {
            for (int i = 0; i < File.ReadAllLines(Match).Length; i++)
            {
                string[] temp = reader.ReadLine().Split(",");
                if (temp.Length < 6) return questions;
                string[] options = new string[4] { temp[2], temp[3], temp[4], temp[5] };
                MatchQuestion question = new(temp[0], (Difficulty)Convert.ToInt16(temp[1]), options);
                questions.Add(question);                
            }
            reader.Close();
        }
        return questions;
    }


    //=================================================================

    public static void WriteUserList(this List<User> users)
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

    public static void WriteUser(this User user)
    {
        using (StreamWriter writer = new StreamWriter(UserFile, true))
        {
            writer.WriteLine(user.ToString());
            writer.Close();
        }
    }

    //Writing the questions puts polymorphism into practice as each question overrides a base method
    //"ToWriteable" which allows me to make a specifc object level request at runtime with a base class method call
    public static void WriteQuestionsList(this List<Question> list)
    {
        QuestionTypes type = list[0].QuestionType;
        string file = "";
        switch (type)
        {
            case QuestionTypes.Text: file = Text; break;
            case QuestionTypes.MultipleChoice: file = MultipleChoice; break;
            case QuestionTypes.AudioText: file = AudioText; break;
            case QuestionTypes.AudioMultipleChoice: file = AudioMC; break;
            case QuestionTypes.PictureText: file = PictureText; break;
            case QuestionTypes.PictureMultipleChoice: file = PictureMC; break;
            case QuestionTypes.Match: file = Match; break;
        }
        using (StreamWriter writer = new StreamWriter(file, false))
        {
            foreach (Question question in list) writer.WriteLine(question.ToWriteable());
            writer.Close();
        }
    }

    public static void WriteQuestion(this Question question)
    {
        QuestionTypes type = question.QuestionType;
        string file = "";
        switch (type)
        {
            case QuestionTypes.Text: file = Text; break;
            case QuestionTypes.MultipleChoice: file = MultipleChoice; break;
            case QuestionTypes.AudioText: file = AudioText; break;
            case QuestionTypes.AudioMultipleChoice: file = AudioMC; break;
            case QuestionTypes.PictureText: file = PictureText; break;
            case QuestionTypes.PictureMultipleChoice: file = PictureMC; break;
            case QuestionTypes.Match: file = Match; break;
        }
        using (StreamWriter writer = new StreamWriter(file, true))
        {
            writer.WriteLine(question.ToWriteable());
            writer.Close();
        }
    }
}
