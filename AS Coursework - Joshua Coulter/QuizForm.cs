using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.Enums;
using AS_Coursework___Joshua_Coulter.Tools;

namespace AS_Coursework___Joshua_Coulter;

public partial class QuizForm : Form
{
    List<Question> allQuestions = new List<Question>();
    List<Question> quizQuestions = new List<Question>();
    Question currentQuestion = null;
    int questionIndex = 0;
    double currentScore = 0;
    Panel currentPanel;
    Difficulty quizDifficulty;
    public QuizForm()
    {
        InitializeComponent();
        PopulateQuestionList();
        currentPanel = panelQuizMenu;
    }

    public void PopulateQuestionList()
    {
        List<MultipleChoiceQuestion> multipleChoiceQuestions = CSVReader.ReadInMultipleChoiceQuestions();
        List<TextQuestion> textQuestions = CSVReader.ReadInTextQuestions();
        foreach (Question question in multipleChoiceQuestions) allQuestions.Add(question);
        foreach (Question question in textQuestions) allQuestions.Add(question);
    }

    public void PopulateQuizQuestions(Difficulty diff)
    {
        quizQuestions = QuestionTools.ReturnDifficulty(allQuestions, diff);
        quizQuestions = QuestionTools.TrimList(quizQuestions);
        quizQuestions = QuestionTools.ShuffleList(quizQuestions);
        quizDifficulty = diff;
    }

    public void DisplayNextQuestion()
    {
        currentPanel.Visible = false;
        if (questionIndex >= quizQuestions.Count)
        {
            lblQuizTitle.Text = "Quiz finished!";
            currentPanel = panelQuizEndScreen;
            currentPanel.Visible = true;
            switch (quizDifficulty)
            {
                case Difficulty.Medium:
                    currentScore = currentScore * 1.5;
                    break;
                case Difficulty.Hard:
                    currentScore = currentScore * 2;
                    break;
                default:
                    break;
            }

            lblQuizEndScreen.Text = $"Congratulations, you finished the quiz with a score of: {currentScore}";
            if (MainForm.currentUser.HighScore < currentScore) MainForm.currentUser.HighScore = currentScore;
            MainForm.UpdateUserFile();
            return;
        }
        lblQuizTitle.Text = $"Question #{questionIndex + 1}";
        currentQuestion = quizQuestions[questionIndex];
        switch (quizQuestions[questionIndex].QuestionType)
        {
            case QuestionTypes.Text:
                currentPanel = panelTextQuestion;
                textBoxTextQuestion.Clear();
                textBoxTextQuestion.Select();
                lblTextQuestion.Text = $"Q: {currentQuestion.QuestionText}";
                break;
            case QuestionTypes.MultipleChoice:
                MultipleChoiceQuestion question = (MultipleChoiceQuestion)currentQuestion;
                currentPanel = panelMultipleChoiceQuestion;
                lblMultipleChoiceQuestion.Text = $"Q: {question.QuestionText}";
                btnOption1.Text = question.Options[0];
                btnOption2.Text = question.Options[1];
                btnOption3.Text = question.Options[2];
                break;
            default:
                break;

        }
        currentPanel.Visible = true;
        questionIndex++;
    }

    private void btnQuizEasy_Click(object sender, EventArgs e)
    {
        PopulateQuizQuestions(Difficulty.Easy);
        DisplayNextQuestion();
    }

    private void btnQuizMedium_Click(object sender, EventArgs e)
    {
        PopulateQuizQuestions(Difficulty.Medium);
        DisplayNextQuestion();
    }

    private void btnQuizHard_Click(object sender, EventArgs e)
    {
        PopulateQuizQuestions(Difficulty.Hard);
        DisplayNextQuestion();
    }

    private void btnSubmitTextQuestion_Click(object sender, EventArgs e)
    {
        TextQuestion specificQuestion = (TextQuestion)currentQuestion;
        if (specificQuestion.CheckAnswer(textBoxTextQuestion.Text)) currentScore++;
        DisplayNextQuestion();
    }

    private void btnOption1_Click(object sender, EventArgs e)
    {
        MultipleChoiceQuestion question = (MultipleChoiceQuestion)currentQuestion;
        if (question.CheckAnswer(1)) currentScore++;
        DisplayNextQuestion();
    }

    private void btnOption2_Click(object sender, EventArgs e)
    {
        MultipleChoiceQuestion question = (MultipleChoiceQuestion)currentQuestion;
        if (question.CheckAnswer(2)) currentScore++;
        DisplayNextQuestion();
    }

    private void btnOption3_Click(object sender, EventArgs e)
    {
        MultipleChoiceQuestion question = (MultipleChoiceQuestion)currentQuestion;
        if (question.CheckAnswer(3)) currentScore++;
        DisplayNextQuestion();
    }

    private void btnQuizEndScreen_Click(object sender, EventArgs e) => Close();
}
