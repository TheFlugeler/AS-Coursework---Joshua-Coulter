using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class TextQuestion: Question
{
    public string Answer {  get; set; }

    public TextQuestion(string _qtext, Difficulty _difficulty,QuestionTypes type, string _answer) : base(_qtext, _difficulty, type)
    {
        Answer = _answer;
    }

    public override string ToString() => QuestionText;

    public string ToWriteable() => $"{QuestionText},{QuestionDifficulty},{Answer}";

    public bool CheckAnswer(string _answer) => Answer.ToLower() == _answer.ToLower();
}
