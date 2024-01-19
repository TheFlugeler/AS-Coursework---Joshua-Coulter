using AS_Coursework___Joshua_Coulter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework___Joshua_Coulter.Classes
{
    public class PictureMultipleChoiceQuestion : MultipleChoiceQuestion
    {
        public string PictureFile {  get; set; }
        public PictureMultipleChoiceQuestion(string _qtext, Difficulty _difficulty, string[] _options, int _answer, string _picFile) : base(_qtext, _difficulty, _options, _answer)
        {
            PictureFile = _picFile;
            QuestionType = QuestionTypes.PictureMultipleChoice;
        }

        public override string ToWriteable() => base.ToWriteable() + $",{PictureFile}";
    }
}
