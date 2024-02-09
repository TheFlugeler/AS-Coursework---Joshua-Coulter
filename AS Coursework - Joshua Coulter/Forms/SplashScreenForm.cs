namespace AS_Coursework___Joshua_Coulter
{
    public partial class SplashScreenForm : Form
    {
        public SplashScreenForm()
        {
            InitializeComponent();
            Show();
            BringToFront();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (panelLoader.Width >= panelBackPanel.Width - 22) End();
            panelLoader.Width += 2;
        }

        void End()
        {
            timer.Stop();
            Thread.Sleep(500);
            new MasterForm().Show();
            Hide();
        }
    }
}
