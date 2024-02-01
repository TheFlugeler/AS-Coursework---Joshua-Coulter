using AS_Coursework___Joshua_Coulter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class AudioTextQuestion : TextQuestion
{
    //
    //This question is the same as the text question but it holds an audio file as well
    //
    public string AudioFile { get; set; }
    public AudioTextQuestion(string qtext, Difficulty diff, string answer, string filename) : base(qtext,diff,answer)
    {
        AudioFile = filename;
        QuestionType = QuestionTypes.AudioText;
    }

    //The file path of the audio file is the only extra information needed
    public override string ToWriteable() => base.ToWriteable() + $"{AudioFile}";
}
