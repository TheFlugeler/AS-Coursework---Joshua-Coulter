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
    public AudioTextQuestion(string qtext, Difficulty diff, QuestionTypes type, string answer, string filename) : base(qtext,diff,type,answer)
    {
        FilePath = filename;
    }
    public override string ToWriteable() => base.ToWriteable() + $"{FilePath}";
}
