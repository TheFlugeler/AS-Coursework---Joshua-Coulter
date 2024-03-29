namespace AS_Coursework___Joshua_Coulter
{
    public partial class MasterForm : Form
    {
        //This is the base form that holds the other forms
        //When it is initally loaded it displays the login portal
        
        public static Form DisplayedForm = null;
        public MasterForm()
        {
            InitializeComponent();
            DisplayForm(new LoginForm());
        }

        //This method is used in multiple forms to display a form within a panel in a parent form
        //This particular case will only load the login and main menu forms
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

        //This ensures that all forms are closed when this form is closed
        private void MasterForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
    }
}