namespace DigitalNotesManager
{
    public partial class LoginForm : Form
    {
        public int LoggedInUserID{ get; private set;}
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int userId = DataAccess.ValidateUser(txtUsername.Text, txtPassword.Text);

            if (userId > 0)
            {
                this.LoggedInUserID = userId;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
