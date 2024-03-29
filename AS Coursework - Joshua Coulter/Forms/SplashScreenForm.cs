namespace AS_Coursework___Joshua_Coulter
{
    public partial class SplashScreenForm : Form
    {
        //This form loads the splash screen when the application is run
        public SplashScreenForm()
        {
            InitializeComponent();
            Show();
            BringToFront();
            timer.Start();
        }

        //This timer is what moves on the progress of the loading bar each tick
        private void timer_Tick(object sender, EventArgs e)
        {
            if (panelLoader.Width >= panelBackPanel.Width - 22) End();
            panelLoader.Width += 3;
        }

        //When the timer ends, the master form is shown and this form is closed
        void End()
        {
            timer.Stop();
            Thread.Sleep(500);
            new MasterForm().Show();
            Hide();
        }
    }
}
