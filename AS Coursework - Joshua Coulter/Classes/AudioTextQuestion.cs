using AS_Coursework___Joshua_Coulter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class AudioTextQuestion : TextQuestion
{
    public string AudioFile { get; set; }
    public AudioTextQuestion(string qtext, Difficulty diff, string answer, string filename) : base(qtext,diff,answer)
    {
        AudioFile = filename;
        QuestionType = QuestionTypes.AudioText;
    }
    public override string ToWriteable() => base.ToWriteable() + $"{AudioFile}";
}
