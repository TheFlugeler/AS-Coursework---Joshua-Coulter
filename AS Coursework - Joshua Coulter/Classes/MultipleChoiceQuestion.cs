using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class MultipleChoiceQuestion: Question
{
    //
    //This is the other basic type of question, consisting of a question and 3 options from which to choose
    //
    public string[] Options { get; set; }
    public int Answer {  get; set; }

    public MultipleChoiceQuestion(string _qtext, Difficulty _diff, string[] _options, int _answer) : base(_qtext, _diff)
    {
        Options = _options;
        Answer = _answer;
        QuestionType = QuestionTypes.MultipleChoice;
    }

    //More information is needed for a multiple choice question
    //The 3 different options and the index of the answer (1 - 3)
    public override string ToWriteable() => base.ToWriteable() + $",{Options[0]},{Options[1]},{Options[2]},{Answer}";

    //The process to check the answer is simple as it compares ints
    public override bool CheckAnswer(int _answer) => _answer == Answer;
}
