using System.ComponentModel.Design;
using System.Media;
using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.Enums;
using AS_Coursework___Joshua_Coulter.Tools;

namespace AS_Coursework___Joshua_Coulter;

public partial class QuizForm : Form
{
    private SoundPlayer player = new SoundPlayer();
    private List<Question> allQuestions = new List<Question>(CSV.ReadInAllQuestions());
    private List<Question> quizQuestions = new List<Question>();
    private string audioToPlay;
    private Question currentQuestion;
    private int questionIndex = 0;
    private double currentScore = 0;
    private Panel currentPanel;
    private Difficulty quizDifficulty;
    public QuizForm()
    {
        InitializeComponent();
        currentPanel = panelQuizMenu;
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
        panelMCPic.Visible = false;
        panelTextPic.Visible = false;
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
                MultipleChoiceQuestion questionMC = (MultipleChoiceQuestion)currentQuestion;
                currentPanel = panelMultipleChoiceQuestion;
                lblMultipleChoiceQuestion.Text = $"Q: {questionMC.QuestionText}";
                btnOption1.Text = questionMC.Options[0];
                btnOption2.Text = questionMC.Options[1];
                btnOption3.Text = questionMC.Options[2];
                break;
            case QuestionTypes.AudioMultipleChoice:
                AudioMultipleChoiceQuestion questionAMC = (AudioMultipleChoiceQuestion)currentQuestion;
                currentPanel = panelMultipleChoiceQuestion;
                lblMultipleChoiceQuestion.Text = $"Q: {questionAMC.QuestionText}";
                btnPlayAudioMCQ.Visible = true;
                audioToPlay = questionAMC.AudioFile;
                btnOption1.Text = questionAMC.Options[0];
                btnOption2.Text = questionAMC.Options[1];
                btnOption3.Text = questionAMC.Options[2];
                break;
            case QuestionTypes.AudioText:
                AudioTextQuestion questionAT = (AudioTextQuestion)currentQuestion;
                currentPanel = panelTextQuestion;
                textBoxTextQuestion.Clear();
                textBoxTextQuestion.Select();
                lblTextQuestion.Text = $"Q: {currentQuestion.QuestionText}";
                btnPlayAudioTQ.Visible = true;
                audioToPlay = questionAT.AudioFile;
                break;
            case QuestionTypes.PictureMultipleChoice:
                PictureMultipleChoiceQuestion questionPMC = (PictureMultipleChoiceQuestion)currentQuestion;
                currentPanel = panelMultipleChoiceQuestion;
                lblMultipleChoiceQuestion.Text = $"Q: {questionPMC.QuestionText}";
                Bitmap bmp = new Bitmap($"PictureFiles/{questionPMC.PictureFile}");
                pictureBoxMultipleChoice.Image = bmp;
                panelMCPic.Visible = true;
                btnOption1.Text = questionPMC.Options[0];
                btnOption2.Text = questionPMC.Options[1];
                btnOption3.Text = questionPMC.Options[2];
                break;
            case QuestionTypes.PictureText:
                PictureTextQuestion questionPT = (PictureTextQuestion)currentQuestion;
                currentPanel = panelTextQuestion;
                textBoxTextQuestion.Clear();
                textBoxTextQuestion.Select();
                lblTextQuestion.Text = $"Q: {currentQuestion.QuestionText}";
                Bitmap bmp2 = new Bitmap($"PictureFiles/{questionPT.PictureFile}");
                pictureBoxText.Image = bmp2;
                panelTextPic.Visible = true;
                audioToPlay = questionPT.PictureFile;
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

        List<User> users = CSV.ReadInUsers();
        User user = UserTools.FindUserID(users, MainForm.userID);
        if (user.HighScore < currentScore)
        {
            user.HighScore = currentScore;
            users = UserTools.RemoveUserID(users, MainForm.userID);
            users.Add(user);
            CSV.WriteUserList(users);
        }

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