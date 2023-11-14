using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.Enums;
using AS_Coursework___Joshua_Coulter.Tools;

namespace AS_Coursework___Joshua_Coulter;

public partial class QuizForm : Form
{
    SoundPlayer player = new SoundPlayer();
    List<Question> allQuestions = new List<Question>();
    List<Question> quizQuestions = new List<Question>();
    string audioToPlay;
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
        List<MultipleChoiceQuestion> multipleChoiceQuestions = CSV.ReadInMultipleChoiceQuestions();
        List<TextQuestion> textQuestions = CSV.ReadInTextQuestions();
        List<AudioMultipleChoiceQuestion> audioMultipleChoiceQuestions = CSV.ReadInAudioMultipleChoiceQuestions();
        List<AudioTextQuestion> audioTextQuestions = CSV.ReadInAudioTextQuestions();
        foreach (Question question in multipleChoiceQuestions) allQuestions.Add(question);
        foreach (Question question in textQuestions) allQuestions.Add(question);
        foreach (Question question in audioMultipleChoiceQuestions) allQuestions.Add(question);
        foreach (Question question in audioTextQuestions) allQuestions.Add(question);
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
        player.Stop();
        currentPanel.Visible = false;
        btnPlayAudioMCQ.Visible = false;
        btnPlayAudioTQ.Visible = false;
        if (questionIndex >= quizQuestions.Count)
        {
            EndQuiz();
            return;
        }

        lblQuizTitle.Text = $"Question #{questionIndex + 1}";
        currentQuestion = quizQuestions[questionIndex];
        switch (currentQuestion.QuestionType)
        {
            case QuestionTypes.Text:
                currentPanel = panelTextQuestion;
                textBoxTextQuestion.Clear();
                textBoxTextQuestion.Select();
                lblTextQuestion.Text = $"Q: {currentQuestion.QuestionText}";
                break;
            case QuestionTypes.MultipleChoice:
                MultipleChoiceQuestion question1 = (MultipleChoiceQuestion)currentQuestion;
                currentPanel = panelMultipleChoiceQuestion;
                lblMultipleChoiceQuestion.Text = $"Q: {question1.QuestionText}";
                btnOption1.Text = question1.Options[0];
                btnOption2.Text = question1.Options[1];
                btnOption3.Text = question1.Options[2];
                break;
            case QuestionTypes.AudioMultipleChoice:
                AudioMultipleChoiceQuestion question2 = (AudioMultipleChoiceQuestion)currentQuestion;
                currentPanel = panelMultipleChoiceQuestion;
                lblMultipleChoiceQuestion.Text = $"Q: {question2.QuestionText}";
                btnPlayAudioMCQ.Visible = true;
                audioToPlay = question2.FilePath;
                btnOption1.Text = question2.Options[0];
                btnOption2.Text = question2.Options[1];
                btnOption3.Text = question2.Options[2];
                break;
            case QuestionTypes.AudioText:
                AudioTextQuestion question3 = (AudioTextQuestion)currentQuestion;
                currentPanel = panelTextQuestion;
                textBoxTextQuestion.Clear();
                textBoxTextQuestion.Select();
                lblTextQuestion.Text = $"Q: {currentQuestion.QuestionText}";
                btnPlayAudioTQ.Visible = true;
                audioToPlay = question3.FilePath;
                break;
            default:
                break;
        }

        currentPanel.Visible = true;
        questionIndex++;
    }

    private void EndQuiz()
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
        if (currentQuestion.CheckAnswer(textBoxTextQuestion.Text)) currentScore++;
        DisplayNextQuestion();
    }

    private void btnOption1_Click(object sender, EventArgs e) => CheckMultipleChoice(1);

    private void btnOption2_Click(object sender, EventArgs e) => CheckMultipleChoice(2);

    private void btnOption3_Click(object sender, EventArgs e) => CheckMultipleChoice(3);

    private void CheckMultipleChoice(int choice)
    {
        if (currentQuestion.CheckAnswer(choice)) currentScore++;
        DisplayNextQuestion();
    }

    private void btnQuizEndScreen_Click(object sender, EventArgs e) => Close();

    private void btnPlayAudioMCQ_Click(object sender, EventArgs e) => PlayAudio();

    private void btnPlayAudioTQ_Click(object sender, EventArgs e) => PlayAudio();

    private void PlayAudio()
    {
        player = new SoundPlayer("AudioFiles/" + audioToPlay);
        try { player.Play(); }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString(), "Error");
            player.Stop();
        }
    }

    private void QuizForm_FormClosing(object sender, FormClosingEventArgs e) => player.Dispose();
}