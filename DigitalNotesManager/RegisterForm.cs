namespace DigitalNotesManager
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            bool success = DataAccess.RegisterUser(txtUsername.Text, txtPassword.Text);

            if (success)
            {
                MessageBox.Show("Registration Successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Registration Failed. The username might already exist.");
            }
        }
    }
}
