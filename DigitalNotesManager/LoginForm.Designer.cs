namespace DigitalNotesManager
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnGoToRegister = new Button();
            logopic = new PictureBox();
            lblTitle = new Label();

            ((System.ComponentModel.ISupportInitialize)logopic).BeginInit();
            SuspendLayout();

            // logopic
            logopic.Image = (Image)resources.GetObject("logopic.Image");
            logopic.Location = new Point(135, 20);
            logopic.Name = "logopic";
            logopic.Size = new Size(70, 70);
            logopic.SizeMode = PictureBoxSizeMode.StretchImage;
            logopic.TabIndex = 6;
            logopic.TabStop = false;
            logopic.Click += pictureBox1_Click;

            // lblTitle
            lblTitle.AutoSize = false;
            lblTitle.Text = "Welcome to Digital Notes";
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 30, 30);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Location = new Point(30, 95);
            lblTitle.Size = new Size(290, 30);

            // label1 (Username)
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(90, 140);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            label1.Click += label1_Click;

            // txtUsername
            txtUsername.Location = new Point(90, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(169, 23);
            txtUsername.TabIndex = 1;

            // label2 (Password)
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(90, 195);
            label2.Name = "label2";
            label2.Size = new Size(79, 21);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            label2.Click += label2_Click;

            // txtPassword
            txtPassword.Location = new Point(90, 220);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(169, 23);
            txtPassword.TabIndex = 3;

            // btnLogin
            btnLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLogin.Location = new Point(90, 260);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(169, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.BackColor = Color.FromArgb(0, 120, 215);
            btnLogin.ForeColor = Color.White;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;

            // btnGoToRegister
            btnGoToRegister.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnGoToRegister.Location = new Point(90, 310);
            btnGoToRegister.Name = "btnGoToRegister";
            btnGoToRegister.Size = new Size(169, 32);
            btnGoToRegister.TabIndex = 5;
            btnGoToRegister.Text = "Create New Account";
            btnGoToRegister.BackColor = Color.FromArgb(40, 167, 69);
            btnGoToRegister.ForeColor = Color.White;
            btnGoToRegister.FlatStyle = FlatStyle.Flat;
            btnGoToRegister.FlatAppearance.BorderSize = 0;
            btnGoToRegister.UseVisualStyleBackColor = false;
            btnGoToRegister.Click += btnGoToRegister_Click;

            // LoginForm
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(350, 400);
            Controls.Add(lblTitle);
            Controls.Add(logopic);
            Controls.Add(btnGoToRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Digital Notes Manager";
            Load += LoginForm_Load;

            ((System.ComponentModel.ISupportInitialize)logopic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Label label2;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnGoToRegister;
        private PictureBox logopic;
        private Label lblTitle;
    }
}
