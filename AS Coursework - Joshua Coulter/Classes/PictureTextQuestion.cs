using AS_Coursework___Joshua_Coulter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class PictureTextQuestion : TextQuestion
{
    public string PictureFile { get; set; }
    public PictureTextQuestion(string _qtext, Difficulty _difficulty, string _answer, string _picFile) : base(_qtext, _difficulty, _answer)
    {
        PictureFile = _picFile;
        QuestionType = QuestionTypes.PictureText;
    }

    public override string ToWriteable() => base.ToWriteable() + $",{PictureFile}";
}
