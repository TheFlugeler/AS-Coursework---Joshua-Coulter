using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class MultipleChoiceQuestion: Question
{
    public string[] Options { get; set; }
    public int Answer {  get; set; }

    public MultipleChoiceQuestion(string _qtext, Difficulty _difficulty, QuestionTypes type, string[] _options, int _answer) : base(_qtext, _difficulty, type)
    {
        Options = _options;
        Answer = _answer;
    }

    public virtual string ToWriteable() => $"{QuestionText},{QuestionDifficulty},{Options[0]},{Options[1]},{Options[2]},{Answer}";

    public bool CheckAnswer(int _answer) => _answer == Answer;
}
