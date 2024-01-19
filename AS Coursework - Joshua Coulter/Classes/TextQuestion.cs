using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class TextQuestion: Question
{
    public string Answer { get; set; }
    public TextQuestion(string _qtext, Difficulty _difficulty, string _answer) : base(_qtext, _difficulty)
    {
        Answer = _answer;
        QuestionType = QuestionTypes.Text;
    }

    public override string ToWriteable() => base.ToWriteable() + $",{Answer}";

    public override bool CheckAnswer(string _answer) => Answer.ToLower() == _answer.ToLower();
}
