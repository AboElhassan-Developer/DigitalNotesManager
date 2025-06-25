namespace DigitalNotesManager
{
    partial class Add_Category
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
            btnAddCategory = new Button();
            label1 = new Label();
            texAddCategory = new TextBox();
            SuspendLayout();
            // 
            // btnAddCategory
            // 
            btnAddCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddCategory.Location = new Point(126, 164);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(130, 34);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(107, 20);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 1;
            label1.Text = "Add Category";
            // 
            // texAddCategory
            // 
            texAddCategory.Location = new Point(107, 96);
            texAddCategory.Name = "texAddCategory";
            texAddCategory.Size = new Size(165, 23);
            texAddCategory.TabIndex = 2;
            // 
            // Add_Category
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 293);
            Controls.Add(texAddCategory);
            Controls.Add(label1);
            Controls.Add(btnAddCategory);
            Name = "Add_Category";
            Text = "Add_Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCategory;
        private Label label1;
        private TextBox texAddCategory;
    }
}