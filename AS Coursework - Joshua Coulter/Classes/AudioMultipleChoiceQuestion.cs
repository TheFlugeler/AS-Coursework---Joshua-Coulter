using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class AudioMultipleChoiceQuestion : MultipleChoiceQuestion
{
    //
    //This question is the same as the text question but it holds an audio file as well
    //
    public string AudioFile { get; set; }
    public AudioMultipleChoiceQuestion(string qtext, Difficulty diff, string[] options, int answer, string filename) : base(qtext,diff,options,answer)
    {
        AudioFile = filename;
        QuestionType = QuestionTypes.AudioMultipleChoice;
    }

    //The file path of the audio file is the only extra information needed
    public override string ToWriteable() => base.ToWriteable() + $",{AudioFile}";
}
