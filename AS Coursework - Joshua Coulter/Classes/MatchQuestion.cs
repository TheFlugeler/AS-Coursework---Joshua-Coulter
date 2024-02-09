using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Classes
{
    //
    //This is one of the more unique question types
    //It consists of 4 pairs of information that need to be matched for the question to be answered correctly
    //Each correct pair is given 1 point
    //
    public class MatchQuestion : Question
    {
        public string[] Answers;
        public MatchQuestion(string text, Difficulty diff, string[] answers) : base(text, diff)
        {
            QuestionType = QuestionTypes.Match;
            Answers = answers;
        }

        //Each correct pair that is answered is given a point
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

        //The pairs of information are stored in a unique way
        //Each correct pair is stored as one string separated by a '/'
        //The string is then split to be used and combined to check answers
        public override string ToWriteable() => base.ToWriteable() + $",{Answers[0]},{Answers[1]},{Answers[2]},{Answers[3]}";
    }
}
