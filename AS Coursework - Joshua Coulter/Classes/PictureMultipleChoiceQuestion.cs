using AS_Coursework___Joshua_Coulter.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS_Coursework___Joshua_Coulter.Classes
{
    //
    //This question is the same as the multiple choice question but it holds a picture file as well
    //
    public class PictureMultipleChoiceQuestion : MultipleChoiceQuestion
    {
        public string PictureFile {  get; set; }
        public PictureMultipleChoiceQuestion(string _qtext, Difficulty _difficulty, string[] _options, int _answer, string _picFile) : base(_qtext, _difficulty, _options, _answer)
        {
            PictureFile = _picFile;
            QuestionType = QuestionTypes.PictureMultipleChoice;
        }

        //The file path of the picture file is the only extra information needed
        public override string ToWriteable() => base.ToWriteable() + $",{PictureFile}";
    }
}
