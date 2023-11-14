using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Classes;

public class Question
{
    public string QuestionText { get; set; }
    public Difficulty QuestionDifficulty {  get; set; }

    public QuestionTypes QuestionType { get; set; }

    public Question(string _qtext,Difficulty _difficulty)
    {
        QuestionText = _qtext;
        QuestionDifficulty = _difficulty;
    }

    public virtual string ToWriteable() => $"{QuestionText},{QuestionDifficulty}";

    public virtual bool CheckAnswer(string answer) => false;
    public virtual bool CheckAnswer(int option) => false;
}
