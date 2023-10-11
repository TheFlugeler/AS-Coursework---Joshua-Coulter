using AS_Coursework___Joshua_Coulter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class AudioTextQuestion : TextQuestion
{
    public string FilePath { get; set; }
    public AudioTextQuestion(string qtext, Difficulty diff, QuestionTypes type, string filename, string answer) : base(qtext,diff,type,answer)
    {
        FilePath = "AudioFiles/" + filename;
    }
    public override string ToWriteable() => $"{QuestionText},{QuestionDifficulty},{Answer},{FilePath}";
}
