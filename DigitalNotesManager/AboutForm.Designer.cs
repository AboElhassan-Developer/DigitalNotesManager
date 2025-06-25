namespace DigitalNotesManager
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnCloseAbout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "Digital Notes Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 49);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Version 1.0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 76);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 2;
            label3.Text = "Developed by Team";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 103);
            label4.Name = "label4";
            label4.Size = new Size(337, 15);
            label4.TabIndex = 3;
            label4.Text = "A simple application to manage your personal notes efficiently";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCloseAbout
            // 
            btnCloseAbout.Location = new Point(284, 152);
            btnCloseAbout.Name = "btnCloseAbout";
            btnCloseAbout.Size = new Size(75, 23);
            btnCloseAbout.TabIndex = 4;
            btnCloseAbout.Text = "OK";
            btnCloseAbout.UseVisualStyleBackColor = true;
            btnCloseAbout.Click += btnCloseAbout_Click;
            // 
            // AboutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(btnCloseAbout);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About Digital Notes Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnCloseAbout;
    }
}