namespace DigitalNotesManager
{
    partial class NotesListForm
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
            panelSearch = new Panel();
            btnDeleteNote = new Button();
            cmbFilterCategory = new ComboBox();
            label3 = new Label();
            btnSearchNotes = new Button();
            txtSearchNotes = new TextBox();
            label2 = new Label();
            dgvNotes = new DataGridView();
            panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 27);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // panelSearch
            // 
            panelSearch.Controls.Add(btnDeleteNote);
            panelSearch.Controls.Add(cmbFilterCategory);
            panelSearch.Controls.Add(label3);
            panelSearch.Controls.Add(btnSearchNotes);
            panelSearch.Controls.Add(txtSearchNotes);
            panelSearch.Controls.Add(label2);
            panelSearch.Dock = DockStyle.Top;
            panelSearch.Location = new Point(0, 0);
            panelSearch.MaximumSize = new Size(0, 50);
            panelSearch.MinimumSize = new Size(0, 50);
            panelSearch.Name = "panelSearch";
            panelSearch.Size = new Size(839, 50);
            panelSearch.TabIndex = 2;
            panelSearch.Paint += panelSearch_Paint;
            // 
            // btnDeleteNote
            // 
            btnDeleteNote.Enabled = false;
            btnDeleteNote.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDeleteNote.Location = new Point(676, 12);
            btnDeleteNote.Name = "btnDeleteNote";
            btnDeleteNote.Size = new Size(134, 31);
            btnDeleteNote.TabIndex = 5;
            btnDeleteNote.Text = "Delete Selected Note";
            btnDeleteNote.UseVisualStyleBackColor = true;
            btnDeleteNote.Click += btnDeleteNote_Click;
            // 
            // cmbFilterCategory
            // 
            cmbFilterCategory.FormattingEnabled = true;
            cmbFilterCategory.Location = new Point(485, 15);
            cmbFilterCategory.Name = "cmbFilterCategory";
            cmbFilterCategory.Size = new Size(175, 23);
            cmbFilterCategory.TabIndex = 4;
            cmbFilterCategory.SelectedIndexChanged += cmbFilterCategory_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(345, 15);
            label3.Name = "label3";
            label3.Size = new Size(133, 21);
            label3.TabIndex = 3;
            label3.Text = "Filter by Category";
            // 
            // btnSearchNotes
            // 
            btnSearchNotes.Location = new Point(264, 16);
            btnSearchNotes.Name = "btnSearchNotes";
            btnSearchNotes.Size = new Size(75, 23);
            btnSearchNotes.TabIndex = 2;
            btnSearchNotes.Text = "Search";
            btnSearchNotes.UseVisualStyleBackColor = true;
            btnSearchNotes.Click += btnSearchNotes_Click;
            // 
            // txtSearchNotes
            // 
            txtSearchNotes.Location = new Point(58, 15);
            txtSearchNotes.MaximumSize = new Size(200, 0);
            txtSearchNotes.MinimumSize = new Size(200, 0);
            txtSearchNotes.Name = "txtSearchNotes";
            txtSearchNotes.Size = new Size(200, 23);
            txtSearchNotes.TabIndex = 1;
            txtSearchNotes.KeyDown += txtSearchNotes_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(5, 19);
            label2.Name = "label2";
            label2.Size = new Size(47, 17);
            label2.TabIndex = 0;
            label2.Text = "Search";
            // 
            // dgvNotes
            // 
            dgvNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNotes.Dock = DockStyle.Fill;
            dgvNotes.Location = new Point(0, 50);
            dgvNotes.Name = "dgvNotes";
            dgvNotes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvNotes.Size = new Size(839, 383);
            dgvNotes.TabIndex = 3;
            dgvNotes.CellDoubleClick += dgvNotes_CellDoubleClick;
            dgvNotes.SelectionChanged += dgvNotes_SelectionChanged;
            // 
            // NotesListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 433);
            Controls.Add(dgvNotes);
            Controls.Add(panelSearch);
            Controls.Add(label1);
            Name = "NotesListForm";
            Text = "NotesListForm";
            Load += NotesListForm_Load;
            panelSearch.ResumeLayout(false);
            panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panelSearch;
        private Label label2;
        private Button btnSearchNotes;
        private TextBox txtSearchNotes;
        private DataGridView dgvNotes;
        private ComboBox cmbFilterCategory;
        private Label label3;
        private Button btnDeleteNote;
    }
}