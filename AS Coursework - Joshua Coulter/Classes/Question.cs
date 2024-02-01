using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Classes;

public abstract class Question
{
    //
    //This is the base class for all of the questions in the quiz
    //Since all question types inherit from it, polymorphism can be used to easily filter questions by difficulty
    //This polymorphism also allows for question types to be identified by accessing the base class property
    //meaning that we can determine the type of question while storing it as a generic "Question"
    //

    public string QuestionText { get; set; }
    public Difficulty QuestionDifficulty {  get; set; }

    public QuestionTypes QuestionType { get; set; }

    public Question(string _qtext, Difficulty _diff)
    {
        QuestionText = _qtext;
        QuestionDifficulty = _diff;
    }

    //This function is used to serialize the objects so they can be written into a CSV file
    //All sub classes override this method by adding the extra information that each question requires
    public virtual string ToWriteable() => $"{QuestionText},{(int)QuestionDifficulty}";


    //By using overloading in this case it means that the answer to any question can be checked by making a base class reference
    //Each sub class overrides this method by applying its own criteria for having a correct answer
    public virtual bool CheckAnswer(string answer) => false;
    public virtual bool CheckAnswer(int option) => false;
    public virtual int CheckAnswer(string[] answer) => 0;
}
