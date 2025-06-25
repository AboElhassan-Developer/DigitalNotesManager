namespace DigitalNotesManager
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            lblTitle = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnRegister = new Button();
            pictureBoxLogo = new PictureBox();
            btnCancel = new Button();

            ((System.ComponentModel.ISupportInitialize)(pictureBoxLogo)).BeginInit();
            SuspendLayout();

            // pictureBoxLogo
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(140, 20);
            pictureBoxLogo.Size = new Size(70, 70);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;

            // lblTitle
            lblTitle.Text = "Create Your Account";
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(50, 50, 50);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Location = new Point(30, 100);
            lblTitle.Size = new Size(290, 30);

            // txtUsername
            txtUsername.PlaceholderText = "Username";
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.Location = new Point(70, 150);
            txtUsername.Size = new Size(210, 27);

            // txtPassword
            txtPassword.PlaceholderText = "Password";
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.PasswordChar = '*';
            txtPassword.Location = new Point(70, 195);
            txtPassword.Size = new Size(210, 27);

            // btnRegister
            btnRegister.Text = "Register";
            btnRegister.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRegister.BackColor = Color.FromArgb(0, 120, 215);
            btnRegister.ForeColor = Color.White;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.Location = new Point(70, 240);
            btnRegister.Size = new Size(210, 35);
            btnRegister.Click += new EventHandler(btnRegister_Click);

            // btnCancel
            btnCancel.Text = "Cancel";
            btnCancel.Font = new Font("Segoe UI", 10F);
            btnCancel.BackColor = Color.LightGray;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(70, 285);
            btnCancel.Size = new Size(210, 30);
            btnCancel.Click += (s, e) => { this.Close(); };

            // RegisterForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(350, 350);
            Controls.Add(pictureBoxLogo);
            Controls.Add(lblTitle);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnRegister);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register - Digital Notes";

            ((System.ComponentModel.ISupportInitialize)(pictureBoxLogo)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnRegister;
        private PictureBox pictureBoxLogo;
        private Button btnCancel;
    }
}
