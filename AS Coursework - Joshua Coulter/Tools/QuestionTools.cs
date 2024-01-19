using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.Enums;

namespace AS_Coursework___Joshua_Coulter.Tools;

public static class QuestionTools
{
    public static List<Question> ReturnDifficulty(List<Question> questions,Difficulty diff)
    {
        List<Question> result = new List<Question>();
        foreach(Question question in questions)
        {
            if(question.QuestionDifficulty == diff) result.Add(question);
        }
        return result;
    }

    public static List<Question> TrimList(List<Question> questions)
    {
        Random rand = new Random();
        while(questions.Count > 10) 
        { 
            questions.RemoveAt(rand.Next(questions.Count));
        }
        return questions;
    }

    public static List<Question> ShuffleList(List<Question> questions)
    {
        List<Question> result = new List<Question>();
        Random rand = new Random();
        int length = questions.Count;
        for (int i = 0; i < length; i++) 
        {
            int index = rand.Next(questions.Count);
            result.Add(questions[index]);
            questions.RemoveAt(index);
        }
        return result;
    }


}
