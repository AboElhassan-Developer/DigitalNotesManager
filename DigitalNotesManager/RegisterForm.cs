using System;
using System.Windows.Forms;

namespace DigitalNotesManager
{
    public partial class RegisterForm : Form
    {
        public int NewUserID { get; private set; }

        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill all fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = DataAccess.RegisterUser(username, password);

            if (success)
            {
                this.NewUserID = DataAccess.GetUserIdByUsername(username);
                MessageBox.Show("Account created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
