using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Classes
{
    public class MatchQuestion : Question
    {
        public string[] Answers;
        public MatchQuestion(string text, Difficulty diff, string[] answers) : base(text, diff)
        {
            QuestionType = QuestionTypes.Match;
            Answers = answers;
        }

        public override int CheckAnswer(string[] answers)
        {
            int correct = 0;
            foreach (string userAnswer in answers)
            {
                foreach (string answer in Answers)
                {
                    if (answer == userAnswer) correct++;
                }
            }
            return correct;
        }

        public override string ToWriteable() => base.ToWriteable + $",{Answers[0]},{Answers[1]},{Answers[2]},{Answers[3]}";
    }
}
