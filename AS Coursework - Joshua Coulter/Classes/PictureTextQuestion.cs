using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class PictureTextQuestion : TextQuestion
{
    //
    //This question is the same as the text question but it holds a picture file as well
    //
    public string PictureFile { get; set; }
    public PictureTextQuestion(string _qtext, Difficulty _difficulty, string _answer, string _picFile) : base(_qtext, _difficulty, _answer)
    {
        PictureFile = _picFile;
        QuestionType = QuestionTypes.PictureText;
    }

    //The file path of the picture file is the only extra information needed
    public override string ToWriteable() => base.ToWriteable() + $",{PictureFile}";
}
