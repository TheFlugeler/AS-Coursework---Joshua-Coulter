namespace AS_Coursework___Joshua_Coulter
{
    public partial class MasterForm : Form
    {
        //This is the base form that holds the other forms
        
        public static Form DisplayedForm = null;
        public MasterForm()
        {
            InitializeComponent();
            DisplayForm(new LoginForm());
        }

        //This method is used in multiple forms to display a form within a panel in a parent form
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

        private void MasterForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}