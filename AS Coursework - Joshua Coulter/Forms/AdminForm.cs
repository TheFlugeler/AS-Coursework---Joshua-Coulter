using AS_Coursework___Joshua_Coulter.Forms;
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
    public partial class AdminForm : Form
    {
        //This form is the hub to send the user to different admin forms
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btnViewDatabase_Click(object sender, EventArgs e)
        {
            (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new DatabaseForm());
        }

        private void buttonAddQuestions_Click(object sender, EventArgs e)
        {
            (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new QuestionsForm(true));
        }

        private void btnViewQuestions_Click(object sender, EventArgs e)
        {
            (MasterForm.DisplayedForm as MainForm)!.DisplayForm(new QuestionsForm(false));
        }
    }
}
