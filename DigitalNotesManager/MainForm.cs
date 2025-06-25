using DigitalNotesManager.DTO;
using System.Windows.Forms;

namespace DigitalNotesManager
{
    public partial class MainForm : Form
    {
        public int CurrentUserID { get; private set; }
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(int userId) : this()
        {
            this.CurrentUserID = userId;
            this.Text = $"Digital Notes Manager - Welcome User ID: {this.CurrentUserID}";
        }


        private void menuFileNew_Click(object sender, EventArgs e)
        {
            NoteEditorForm newNote = new NoteEditorForm();
            newNote.MdiParent = this;
            newNote.WindowState = FormWindowState.Maximized;

            newNote.CurrentUserID = this.CurrentUserID;

            newNote.Show();
        }

        private void menuViewArrangeCascade_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void menuViewArrangeTile_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuEditCut_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is NoteEditorForm activeNoteForm)
            {
                activeNoteForm.rtbNoteContent.Cut();
            }
        }

        private void menuEditCopy_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is NoteEditorForm activeNoteForm)
            {
                activeNoteForm.rtbNoteContent.Copy();
            }
        }

        private void menuEditPaste_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is NoteEditorForm activeNoteForm)
            {
                activeNoteForm.rtbNoteContent.Paste();
            }
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild is NoteEditorForm activeNoteForm)
            {
                activeNoteForm.SaveNote();
            }
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Rich Text Files (*.rtf)|*.rtf|Text Files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.DefaultExt = "rtf";
            openFileDialog.FileName = "";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string fileContent = "";
                string fileTitle = System.IO.Path.GetFileNameWithoutExtension(filePath);

                try
                {
                    using (RichTextBox tempRtb = new RichTextBox())
                    {
                        if (System.IO.Path.GetExtension(filePath).Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                        {
                            tempRtb.LoadFile(filePath, RichTextBoxStreamType.RichText);
                        }
                        else
                        {
                            tempRtb.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                        }
                        fileContent = tempRtb.Rtf;
                    }

                    NoteEditorForm newImportedNote = new NoteEditorForm();
                    newImportedNote.CurrentUserID = this.CurrentUserID;

                    newImportedNote.NoteToLoad = new NoteFullDetails
                    {
                        NoteID = 0,
                        Title = fileTitle,
                        RtfContent = fileContent,
                        CategoryName = null,
                        ReminderDate = null
                    };

                    newImportedNote.MdiParent = this;
                    newImportedNote.WindowState = FormWindowState.Maximized;
                    newImportedNote.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening file: " + ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menuViewNotesList_Click(object sender, EventArgs e)
        {
            NotesListForm notesListForm = new NotesListForm(this.CurrentUserID);
            notesListForm.MdiParent = this;

            notesListForm.WindowState = FormWindowState.Maximized;

            notesListForm.Show();
        }

        private void reminderTimer_Tick(object sender, EventArgs e)
        {
            if (this.CurrentUserID <= 0)
            {
                return;
            }

            List<NoteFullDetails> dueNotes = DataAccess.GetDueReminders(this.CurrentUserID);

            if (dueNotes.Count > 0)
            {
                reminderTimer.Stop();

                foreach (NoteFullDetails note in dueNotes)
                {
                    DialogResult result = MessageBox.Show(
                        $"Reminder: {note.Title}\nCategory: {note.CategoryName}\nDue: {note.ReminderDate?.ToString("g")}\n\nDo you want to open this note?\n(Clicking 'No' or closing this will dismiss the reminder for this instance)",
                        "Note Reminder!",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information
                    );

                    if (result == DialogResult.Yes)
                    {
                        OpenNoteForEditing(note.NoteID);
                    }

                    DataAccess.DismissReminder(note.NoteID, this.CurrentUserID);
                }
                reminderTimer.Start();
            }
        }

        public void OpenNoteForEditing(int noteId)
        {
            NoteFullDetails details = DataAccess.GetNoteDetails(noteId, this.CurrentUserID);
            if (details != null)
            {
                NoteEditorForm editorForm = new NoteEditorForm();
                editorForm.CurrentUserID = this.CurrentUserID;
                editorForm.NoteToLoad = details;
                editorForm.MdiParent = this;
                editorForm.WindowState = FormWindowState.Maximized;
                editorForm.Show();
            }
            else
            {
                MessageBox.Show("Could not retrieve note details for reminder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog(this); // ShowDialog
        }

        private void menuEditFormat_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild is NoteEditorForm activeNoteEditor)
                {
                    activeNoteEditor.ApplyFontFormatting();
                }
                else
                {
                    MessageBox.Show("Please select a note editor window to format text.", "Information");
                }
            }
            else
            {
                MessageBox.Show("No note is currently open to format.", "Information");
            }
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Category add_Category = new Add_Category(this.CurrentUserID);
            add_Category.Show();
        }
    }

}
