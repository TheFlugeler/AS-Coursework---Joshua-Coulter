namespace AS_Coursework___Joshua_Coulter
{
    public partial class MasterForm : Form
    {
        Form DisplayedForm = null;
        public MasterForm()
        {
            InitializeComponent();
            DisplayForm(new LoginForm());
        }

        public void DisplayForm(Form form)
        {
            if (DisplayedForm != null) DisplayedForm.Close();
            DisplayedForm = form;
            DisplayedForm.Dock = DockStyle.Fill;
            DisplayedForm.FormBorderStyle = FormBorderStyle.None;
            DisplayedForm.TopLevel = false;
            panelDisplay.Controls.Add(DisplayedForm);
            DisplayedForm.BringToFront();
            DisplayedForm.Show();
        }
    }
}