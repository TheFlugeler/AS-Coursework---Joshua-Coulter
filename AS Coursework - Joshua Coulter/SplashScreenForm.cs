using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        void timer_Tick(object sender, EventArgs e)
        {
            if (panelLoader.Width < panelBackPanel.Width - 24) panelLoader.Width++;
            else LoadComplete();
        }

        void LoadComplete()
        {
            timer.Stop();
            Thread.Sleep(300);
            new MasterForm().Show();
            Hide();
        }
    }
}
