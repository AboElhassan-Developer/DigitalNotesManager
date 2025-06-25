namespace DigitalNotesManager
{
    partial class NoteEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteEditorForm));
            topPanel = new Panel();
            txtNoteTitle = new TextBox();
            label3 = new Label();
            chkEnableReminder = new CheckBox();
            dtpReminder = new DateTimePicker();
            label2 = new Label();
            cmbCategory = new ComboBox();
            label1 = new Label();
            btnSave = new Button();
            formattingToolStrip = new ToolStrip();
            tsbBold = new ToolStripButton();
            tsbItalic = new ToolStripButton();
            tsbUnderline = new ToolStripButton();
            tsbChangeFont = new ToolStripButton();
            tsbChangeFontColor = new ToolStripButton();
            rtbNoteContent = new RichTextBox();
            saveFileDialog = new SaveFileDialog();
            fontDialogMain = new FontDialog();
            colorDialogMain = new ColorDialog();
            topPanel.SuspendLayout();
            formattingToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // topPanel
            // 
            topPanel.Controls.Add(txtNoteTitle);
            topPanel.Controls.Add(label3);
            topPanel.Controls.Add(chkEnableReminder);
            topPanel.Controls.Add(dtpReminder);
            topPanel.Controls.Add(label2);
            topPanel.Controls.Add(cmbCategory);
            topPanel.Controls.Add(label1);
            topPanel.Controls.Add(btnSave);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.MinimumSize = new Size(0, 60);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(800, 79);
            topPanel.TabIndex = 0;
            // 
            // txtNoteTitle
            // 
            txtNoteTitle.Location = new Point(73, 40);
            txtNoteTitle.Name = "txtNoteTitle";
            txtNoteTitle.Size = new Size(410, 23);
            txtNoteTitle.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 48);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 6;
            label3.Text = "Title";
            // 
            // chkEnableReminder
            // 
            chkEnableReminder.AutoSize = true;
            chkEnableReminder.Location = new Point(504, 14);
            chkEnableReminder.Name = "chkEnableReminder";
            chkEnableReminder.Size = new Size(115, 19);
            chkEnableReminder.TabIndex = 5;
            chkEnableReminder.Text = "Enable Reminder";
            chkEnableReminder.UseVisualStyleBackColor = true;
            chkEnableReminder.CheckedChanged += chkEnableReminder_CheckedChanged;
            // 
            // dtpReminder
            // 
            dtpReminder.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpReminder.Format = DateTimePickerFormat.Custom;
            dtpReminder.Location = new Point(314, 9);
            dtpReminder.Name = "dtpReminder";
            dtpReminder.Size = new Size(170, 23);
            dtpReminder.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 12);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Reminder";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(73, 9);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(150, 23);
            cmbCategory.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 1;
            label1.Text = "Category";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.Location = new Point(713, 18);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 25);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // formattingToolStrip
            // 
            formattingToolStrip.Items.AddRange(new ToolStripItem[] { tsbBold, tsbItalic, tsbUnderline, tsbChangeFont, tsbChangeFontColor });
            formattingToolStrip.Location = new Point(0, 79);
            formattingToolStrip.Name = "formattingToolStrip";
            formattingToolStrip.Size = new Size(800, 25);
            formattingToolStrip.TabIndex = 1;
            formattingToolStrip.Text = "toolStrip1";
            // 
            // tsbBold
            // 
            tsbBold.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tsbBold.Image = (Image)resources.GetObject("tsbBold.Image");
            tsbBold.ImageTransparentColor = Color.Magenta;
            tsbBold.Name = "tsbBold";
            tsbBold.Size = new Size(23, 22);
            tsbBold.Text = "B";
            tsbBold.Click += tsbBold_Click;
            // 
            // tsbItalic
            // 
            tsbItalic.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbItalic.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            tsbItalic.Image = (Image)resources.GetObject("tsbItalic.Image");
            tsbItalic.ImageTransparentColor = Color.Magenta;
            tsbItalic.Name = "tsbItalic";
            tsbItalic.Size = new Size(23, 22);
            tsbItalic.Text = "I";
            tsbItalic.Click += tsbItalic_Click;
            // 
            // tsbUnderline
            // 
            tsbUnderline.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbUnderline.Image = (Image)resources.GetObject("tsbUnderline.Image");
            tsbUnderline.ImageTransparentColor = Color.Magenta;
            tsbUnderline.Name = "tsbUnderline";
            tsbUnderline.Size = new Size(23, 22);
            tsbUnderline.Text = "U";
            tsbUnderline.Click += tsbUnderline_Click;
            // 
            // tsbChangeFont
            // 
            tsbChangeFont.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbChangeFont.Image = (Image)resources.GetObject("tsbChangeFont.Image");
            tsbChangeFont.ImageTransparentColor = Color.Magenta;
            tsbChangeFont.Name = "tsbChangeFont";
            tsbChangeFont.Size = new Size(23, 22);
            tsbChangeFont.Text = "Font";
            tsbChangeFont.Click += tsbChangeFont_Click;
            // 
            // tsbChangeFontColor
            // 
            tsbChangeFontColor.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbChangeFontColor.Image = (Image)resources.GetObject("tsbChangeFontColor.Image");
            tsbChangeFontColor.ImageTransparentColor = Color.Magenta;
            tsbChangeFontColor.Name = "tsbChangeFontColor";
            tsbChangeFontColor.Size = new Size(23, 22);
            tsbChangeFontColor.Text = "Color";
            tsbChangeFontColor.Click += tsbChangeFontColor_Click;
            // 
            // rtbNoteContent
            // 
            rtbNoteContent.Dock = DockStyle.Fill;
            rtbNoteContent.Location = new Point(0, 104);
            rtbNoteContent.Name = "rtbNoteContent";
            rtbNoteContent.Size = new Size(800, 346);
            rtbNoteContent.TabIndex = 0;
            rtbNoteContent.Text = "";
            // 
            // NoteEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbNoteContent);
            Controls.Add(formattingToolStrip);
            Controls.Add(topPanel);
            Name = "NoteEditorForm";
            Text = "NoteEditorForm";
            Load += NoteEditorForm_Load;
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            formattingToolStrip.ResumeLayout(false);
            formattingToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel topPanel;
        private ToolStrip formattingToolStrip;
        private Label label2;
        private ComboBox cmbCategory;
        private Label label1;
        private Button btnSave;
        private DateTimePicker dtpReminder;
        private ToolStripButton tsbBold;
        private ToolStripButton tsbItalic;
        private ToolStripButton tsbUnderline;
        public RichTextBox rtbNoteContent;
        private SaveFileDialog saveFileDialog;
        private CheckBox chkEnableReminder;
        private TextBox txtNoteTitle;
        private Label label3;
        private ToolStripButton tsbChangeFont;
        private ToolStripButton tsbChangeFontColor;
        private FontDialog fontDialogMain;
        private ColorDialog colorDialogMain;
    }
}