using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class TextQuestion: Question
{
    //
    //This is one of the simpler types of questions, consisting of only a question and short typed response
    //

    public string Answer { get; set; }
    public TextQuestion(string _qtext, Difficulty _difficulty, string _answer) : base(_qtext, _difficulty)
    {
        Answer = _answer;
        QuestionType = QuestionTypes.Text;
    }

    //In this case the only thing that needs added to the serialize function is the string of the answer
    public override string ToWriteable() => base.ToWriteable() + $",{Answer}";

    //Checking the answer of this type of question is easy as it is a case of comparing strings
    public override bool CheckAnswer(string _answer) => Answer.ToLower() == _answer.ToLower();
}
