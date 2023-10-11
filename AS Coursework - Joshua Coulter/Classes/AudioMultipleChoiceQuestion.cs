using AS_Coursework___Joshua_Coulter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class AudioMultipleChoiceQuestion : MultipleChoiceQuestion
{
    public string FilePath { get; set; }
    public AudioMultipleChoiceQuestion(string qtext, Difficulty diff, QuestionTypes type, string[] options, int answer, string filename) : base(qtext,diff,type,options,answer)
    {
        FilePath = "AudioFiles/" + filename;
    }
    public override string ToWriteable() => $"{QuestionText},{QuestionDifficulty},{Options[0]},{Options[1]},{Options[2]},{Answer},{FilePath}";
}
