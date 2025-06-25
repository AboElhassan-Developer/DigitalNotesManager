using DigitalNotesManager.DTO;
using System.Windows.Forms;

namespace DigitalNotesManager
{
    public partial class NoteEditorForm : Form
    {
        public string CurrentFilePath = null;
        public int CurrentUserID { get; set; }
        public NoteFullDetails NoteToLoad { get; set; } = null;
        private bool IsEditingExistingNote => NoteToLoad != null && NoteToLoad.NoteID > 0;
        public NoteEditorForm()
        {
            InitializeComponent();
        }

        #region Save into device
        //public void SaveNote()
        //{
        //    if (string.IsNullOrEmpty(CurrentFilePath))
        //    {
        //        saveFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf";
        //        saveFileDialog.DefaultExt = "rtf";
        //        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //        {
        //            CurrentFilePath = saveFileDialog.FileName;
        //            rtbNoteContent.SaveFile(CurrentFilePath, RichTextBoxStreamType.RichText);
        //            this.Text = System.IO.Path.GetFileNameWithoutExtension(CurrentFilePath);
        //        }
        //    }
        //    else
        //    {
        //        rtbNoteContent.SaveFile(CurrentFilePath, RichTextBoxStreamType.RichText);
        //    }
        //}

        //save 
        #endregion

        public void SaveNote()
        {
            string noteTitle;
            if (!string.IsNullOrWhiteSpace(txtNoteTitle.Text))
            {
                noteTitle = txtNoteTitle.Text.Trim();
            }
            else if (rtbNoteContent.Text.Length > 0)
            {
                noteTitle = rtbNoteContent.Text.Length > 30 ? rtbNoteContent.Text.Substring(0, 30) + "..." : rtbNoteContent.Text.Trim();
            }
            else
            {
                noteTitle = "Untitled Note Title";
            }

            string noteContent = rtbNoteContent.Rtf;
            string selectedCategory = cmbCategory.SelectedItem?.ToString();
            DateTime? reminder = null;
            if (chkEnableReminder.Checked)
            {
                reminder = dtpReminder.Value;
            }

            bool success = false;
            bool wasNewNote = !IsEditingExistingNote;
            int noteIdForTitleUpdate = 0;

            if (IsEditingExistingNote)
            {
                success = DataAccess.UpdateNoteInDB(this.NoteToLoad.NoteID, this.CurrentUserID, noteTitle, noteContent, selectedCategory, reminder);
                if (success) noteIdForTitleUpdate = this.NoteToLoad.NoteID;
            }
            else
            {
                int newNoteId = DataAccess.SaveNoteToDB(this.CurrentUserID, noteTitle, noteContent, selectedCategory, reminder);
                if (newNoteId > 0)
                {
                    success = true;
                    noteIdForTitleUpdate = newNoteId;
                    this.NoteToLoad = new NoteFullDetails
                    {
                        NoteID = newNoteId,
                        Title = noteTitle,
                        RtfContent = noteContent,
                        CategoryName = selectedCategory,
                        ReminderDate = reminder
                    };
                }
            }

            if (success)
            {
                MessageBox.Show(wasNewNote ? "Note saved successfully!" : "Note updated successfully!");
                this.Text = noteTitle;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to save the note.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveNote();
        }

        private void ToggleFontStyle(FontStyle style)
        {
            if (rtbNoteContent.SelectionFont != null)
            {
                Font currentFont = rtbNoteContent.SelectionFont;
                FontStyle newStyle;
                if (currentFont.Style.HasFlag(style))
                    newStyle = currentFont.Style & ~style;
                else
                    newStyle = currentFont.Style | style;
                rtbNoteContent.SelectionFont = new Font(currentFont, newStyle);
            }
        }

        private void tsbBold_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Bold);
        }

        private void tsbItalic_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Italic);
        }

        private void tsbUnderline_Click(object sender, EventArgs e)
        {
            ToggleFontStyle(FontStyle.Underline);
        }

        private void NoteEditorForm_Load(object sender, EventArgs e)
        {
            LoadCategories();

            if (NoteToLoad != null)
            {
                txtNoteTitle.Text = NoteToLoad.Title;
                this.Text = string.IsNullOrEmpty(NoteToLoad.Title) ? "Edit Note" : NoteToLoad.Title;

                rtbNoteContent.Rtf = NoteToLoad.RtfContent;

                if (!string.IsNullOrEmpty(NoteToLoad.CategoryName) && NoteToLoad.CategoryName != "Uncategorized")
                {
                    if (!cmbCategory.Items.Contains(NoteToLoad.CategoryName))
                    {
                        cmbCategory.Items.Add(NoteToLoad.CategoryName);
                    }
                    cmbCategory.SelectedItem = NoteToLoad.CategoryName;
                }
                else if (cmbCategory.Items.Count > 0)
                {
                    cmbCategory.SelectedIndex = 0;
                }

                if (NoteToLoad.ReminderDate.HasValue)
                {
                    dtpReminder.Value = NoteToLoad.ReminderDate.Value;
                    chkEnableReminder.Checked = true;
                    dtpReminder.Enabled = true;
                }
                else
                {
                    chkEnableReminder.Checked = false;
                    dtpReminder.Enabled = false;
                }
            }
            else
            {
                if (cmbCategory.Items.Count > 0)
                {
                    cmbCategory.SelectedIndex = 0;
                }
                txtNoteTitle.Text = "";
                this.Text = "New Note";
                chkEnableReminder.Checked = false;
                dtpReminder.Enabled = false;
            }
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();
            if (this.CurrentUserID > 0)
            {
                List<string> userCategories = DataAccess.GetUserCategoryNames(this.CurrentUserID);
                foreach (string category in userCategories)
                {
                    cmbCategory.Items.Add(category);
                }
            }
        }

        private void chkEnableReminder_CheckedChanged(object sender, EventArgs e)
        {
            dtpReminder.Enabled = chkEnableReminder.Checked;
        }

        private void tsbChangeFont_Click(object sender, EventArgs e)
        {
            ApplyFontFormatting();
        }

        private void tsbChangeFontColor_Click(object sender, EventArgs e)
        {
            ApplyFontColor();
        }

        public void ApplyFontFormatting()
        {
            if (fontDialogMain == null)
            {
                MessageBox.Show("FontDialog component (fontDialogMain) is missing on NoteEditorForm designer.", "Configuration Error");
                return;
            }

            if (rtbNoteContent.SelectionFont != null)
            {
                fontDialogMain.Font = rtbNoteContent.SelectionFont;
            }
            else
            {
                fontDialogMain.Font = rtbNoteContent.Font;
            }

            if (fontDialogMain.ShowDialog(this) == DialogResult.OK)
            {
                if (rtbNoteContent.SelectionLength > 0)
                {
                    rtbNoteContent.SelectionFont = fontDialogMain.Font;
                }
                else 
                {
                    rtbNoteContent.SelectionFont = fontDialogMain.Font;
                }
            }
        }

        public void ApplyFontColor()
        {
            if (colorDialogMain == null)
            {
                MessageBox.Show("ColorDialog component (colorDialogMain) is missing on NoteEditorForm designer.", "Configuration Error");
                return;
            }

            colorDialogMain.Color = rtbNoteContent.SelectionColor;

            if (colorDialogMain.ShowDialog(this) == DialogResult.OK)
            {
                if (rtbNoteContent.SelectionLength > 0)
                {
                    rtbNoteContent.SelectionColor = colorDialogMain.Color;
                }
                else 
                {
                    rtbNoteContent.SelectionColor = colorDialogMain.Color;
                }
            }
        }
    }
}
