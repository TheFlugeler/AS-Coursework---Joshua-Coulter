using System.Media;
using AS_Coursework___Joshua_Coulter.Classes;
using AS_Coursework___Joshua_Coulter.Enums;
using AS_Coursework___Joshua_Coulter.ToolsLibrary;

namespace AS_Coursework___Joshua_Coulter;

public partial class QuizForm : Form
{
    //This is the form that the quiz is displayed in
    //Each question has an individual panel

    private SoundPlayer player = new();
    private List<Question> quizQuestions = new(CSV.ReadInAllQuestions());
    private string audioToPlay = "";
    private Question currentQuestion = null!;
    private int questionIndex = 0;
    private double currentScore = 0;
    private Panel currentPanel;
    private Difficulty quizDifficulty;
    private int picMaxX = 580;
    private int picMaxY = 210;
    private int picMinX = 360;
    private int picMinY = 180;

    public QuizForm()
    {
        InitializeComponent();
        currentPanel = panelQuizMenu;
    }

    public void PopulateQuizQuestions(Difficulty diff)
    {
        quizQuestions.ReturnDifficulty(diff);
        quizQuestions.Shuffle();
        quizQuestions.TrimList(10);
        quizDifficulty = diff;
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
        User user = users.GetUser(MainForm.userID);
        if (user.HighScore < currentScore)
        {
            user.HighScore = currentScore;
            users.RemoveUserID(MainForm.userID);
            users.Add(user);
            users.WriteUserList();
        }
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


    #region CheckQuestion

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
    private void btnSubmitMatch_Click(object sender, EventArgs e)
    {
        ComboBox[] leftBoxes = new ComboBox[4] { comboBoxLeft1, comboBoxLeft2, comboBoxLeft3, comboBoxLeft4 };
        ComboBox[] rightBoxes = new ComboBox[4] { comboBoxRight1, comboBoxRight2, comboBoxRight3, comboBoxRight4 };
        for (int i = 0; i < 4; i++)
        {
            if ((leftBoxes[i].SelectedIndex == -1) || (rightBoxes[i].SelectedIndex == -1))
            {
                MessageBox.Show("All options must be filled", "Error");
                return;
            }
        }

        foreach (ComboBox cbox in leftBoxes)
        {
            int doubles = 0;
            foreach (ComboBox cbox2 in leftBoxes)
            {
                if (cbox.SelectedIndex == cbox2.SelectedIndex) doubles++;
            }
            if (doubles > 1)
            {
                MessageBox.Show("Each answer must be unique", "Error");
                return;
            }
        }

        string[] answers = new string[4];
        for (int i = 0; i < 4; i++)
        {
            answers[i] = leftBoxes[i].Text + "/" + rightBoxes[i].Text;
        }
        currentScore += currentQuestion.CheckAnswer(answers);
        DisplayNextQuestion();
    }

    #endregion 


    #region Audio
    private void btnPlayAudioMCQ_Click(object sender, EventArgs e) => PlayAudio();

    private void btnPlayAudioTQ_Click(object sender, EventArgs e) => PlayAudio();

    private void PlayAudio()
    {
        player = new("AudioFiles/" + audioToPlay);
        try { player.Play(); }
        catch (Exception e)
        {
            MessageBox.Show(e.ToString(), "Error");
            player.Stop();
        }
    }
    #endregion

    #region Display

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

        // This switch expression is used to identify which display method should be run
        // Depending on the question type, a method is chosen and stored in "DisplayMethod"
        // That action is then run meaning the correct display method is run

        Action DisplayMethod = currentQuestion.QuestionType switch
        {
            QuestionTypes.Text => DisplayTextQuestion,
            QuestionTypes.MultipleChoice => DisplayMultipleChoiceQuestion,
            QuestionTypes.AudioText => DisplayAudioTextQuestion,
            QuestionTypes.AudioMultipleChoice => DisplayAudioMultipleChoiceQuestion,
            QuestionTypes.PictureText => DisplayPictureTextQuestion,
            QuestionTypes.PictureMultipleChoice => DisplayPictureMultipleChoiceQuestion,
            QuestionTypes.Match => DisplayMatchQuestion,
            _ => () => { MessageBox.Show("QuestionType error", "Error"); }
        } ;
        DisplayMethod();

        currentPanel.Visible = true;
        questionIndex++;
    }

    private void DisplayTextQuestion()
    {
        currentPanel = panelTextQuestion;
        textBoxTextQuestion.Clear();
        textBoxTextQuestion.Select();
        lblTextQuestion.Text = $"Q: {currentQuestion.QuestionText}";
    }

    private void DisplayMultipleChoiceQuestion()
    {
        MultipleChoiceQuestion question = (MultipleChoiceQuestion)currentQuestion;
        currentPanel = panelMultipleChoiceQuestion;
        lblMultipleChoiceQuestion.Text = $"Q: {question.QuestionText}";
        btnOption1.Text = question.Options[0];
        btnOption2.Text = question.Options[1];
        btnOption3.Text = question.Options[2];
    }

    private void DisplayAudioMultipleChoiceQuestion()
    {
        AudioMultipleChoiceQuestion question = (AudioMultipleChoiceQuestion)currentQuestion;
        currentPanel = panelMultipleChoiceQuestion;
        lblMultipleChoiceQuestion.Text = $"Q: {question.QuestionText}";
        btnPlayAudioMCQ.Visible = true;
        audioToPlay = question.AudioFile;
        btnOption1.Text = question.Options[0];
        btnOption2.Text = question.Options[1];
        btnOption3.Text = question.Options[2];
    }

    private void DisplayAudioTextQuestion()
    {
        AudioTextQuestion question = (AudioTextQuestion)currentQuestion;
        currentPanel = panelTextQuestion;
        textBoxTextQuestion.Clear();
        textBoxTextQuestion.Select();
        lblTextQuestion.Text = $"Q: {currentQuestion.QuestionText}";
        btnPlayAudioTQ.Visible = true;
        audioToPlay = question.AudioFile;
    }

    private void DisplayPictureMultipleChoiceQuestion()
    {
        PictureMultipleChoiceQuestion question = (PictureMultipleChoiceQuestion)currentQuestion;
        currentPanel = panelMultipleChoiceQuestion;
        lblMultipleChoiceQuestion.Text = $"Q: {question.QuestionText}";
        Bitmap bmp = new($"PictureFiles/{question.PictureFile}");
        Tools.ResizePicPanel(pictureBoxMultipleChoice, bmp, picMaxX, picMaxY, picMinX, picMinY);
        panelMCPic.Center();
        pictureBoxMultipleChoice.Image = bmp;
        panelMCPic.Visible = true;
        btnOption1.Text = question.Options[0];
        btnOption2.Text = question.Options[1];
        btnOption3.Text = question.Options[2];
    }

    private void DisplayPictureTextQuestion()
    {
        PictureTextQuestion question = (PictureTextQuestion)currentQuestion;
        currentPanel = panelTextQuestion;
        textBoxTextQuestion.Clear();
        textBoxTextQuestion.Select();
        lblTextQuestion.Text = $"Q: {currentQuestion.QuestionText}";
        Bitmap bmp = new($"PictureFiles/{question.PictureFile}");
        Tools.ResizePicPanel(pictureBoxText, bmp, picMaxX, picMaxY, picMinX, picMinY);
        panelTextPic.Center();
        pictureBoxText.Image = bmp;
        panelTextPic.Visible = true;
    }

    private void DisplayMatchQuestion()
    {
        MatchQuestion question = (MatchQuestion)currentQuestion;
        currentPanel = panelMatchQuestion;
        labelMatchQuestion.Text = $"Q: {currentQuestion.QuestionText}";
        ComboBox[] leftBoxes = new ComboBox[4] { comboBoxLeft1, comboBoxLeft2, comboBoxLeft3, comboBoxLeft4 };
        ComboBox[] rightBoxes = new ComboBox[4] { comboBoxRight1, comboBoxRight2, comboBoxRight3, comboBoxRight4 };
        string[] leftOptions = new string[4];
        string[] rightOptions = new string[4];

        for (int i = 0; i < question.Answers.Length; i++)
        {
            string[] temp = question.Answers[i].Split('/');
            leftOptions[i] = temp[0];
            rightOptions[i] = temp[1];
        }

        leftOptions.Shuffle();
        rightOptions.Shuffle();

        foreach (ComboBox cbox in leftBoxes)
        {
            cbox.Items.AddRange(leftOptions);
        }
        foreach (ComboBox cbox in rightBoxes)
        {
            cbox.Items.AddRange(rightOptions);
        }
    }

    #endregion
    
    private void textBoxTextQuestion_KeyPress(object sender, KeyPressEventArgs e) { if (e.KeyChar == 13) btnSubmitTextQuestion_Click(sender, e); }

    private void QuizForm_FormClosing(object sender, FormClosingEventArgs e) => player.Dispose();

    private void btnQuizEndScreen_Click(object sender, EventArgs e) => Close();
}