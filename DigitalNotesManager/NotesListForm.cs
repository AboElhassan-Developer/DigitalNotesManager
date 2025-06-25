using DigitalNotesManager.DTO;
using DigitalNotesManager.Models;
using System.ComponentModel;

namespace DigitalNotesManager
{
    public partial class NotesListForm : Form
    {
        public int CurrentUserID { get; set; }
        public NotesListForm()
        {
            InitializeComponent();
        }

        public NotesListForm(int userId)
        {
            InitializeComponent();
            this.CurrentUserID = userId;
        }

        private void NotesListForm_Load(object sender, EventArgs e)
        {
            if (this.CurrentUserID > 0)
            {
                cmbFilterCategory.Items.Clear();
                cmbFilterCategory.Items.Add("All Categories");

                List<string> userCategories = DataAccess.GetUserCategoryNames(this.CurrentUserID);
                foreach (string category in userCategories)
                {
                    cmbFilterCategory.Items.Add(category);
                }
                cmbFilterCategory.SelectedIndex = 0;

                LoadNotes();
            }
            else
            {
                MessageBox.Show("User not identified. Cannot load notes.");
                this.Close();
            }
        }


        private void dgvNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int noteIdToOpen = (int)dgvNotes.Rows[e.RowIndex].Cells["NoteID"].Value;

                NoteFullDetails details = DataAccess.GetNoteDetails(noteIdToOpen, this.CurrentUserID);

                if (details != null)
                {
                    NoteEditorForm editorForm = new NoteEditorForm();
                    editorForm.CurrentUserID = this.CurrentUserID;
                    editorForm.NoteToLoad = details;

                    if (this.MdiParent != null)
                    {
                        editorForm.MdiParent = this.MdiParent;
                    }
                    editorForm.WindowState = FormWindowState.Maximized;
                    editorForm.Show();
                }
                else
                {
                    MessageBox.Show("Could not retrieve note details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadNotes()
        {
            if (this.CurrentUserID > 0)
            {
                string searchTerm = txtSearchNotes.Text.Trim();
                string selectedCategory = cmbFilterCategory.SelectedItem?.ToString();

                List<NoteDisplayItem> userNotesList = DataAccess.GetUserNotes(this.CurrentUserID, searchTerm, selectedCategory);

                dgvNotes.DataSource = null;
                dgvNotes.DataSource = userNotesList;

                if (dgvNotes.Columns.Count > 0)
                {
                    if (dgvNotes.Columns["NoteID"] != null)
                        dgvNotes.Columns["NoteID"].HeaderText = "ID";
                    if (dgvNotes.Columns["Title"] != null)
                        dgvNotes.Columns["Title"].HeaderText = "Note Title";
                    if (dgvNotes.Columns["Category"] != null)
                        dgvNotes.Columns["Category"].HeaderText = "Category";
                    if (dgvNotes.Columns["CreationDate"] != null)
                        dgvNotes.Columns["CreationDate"].HeaderText = "Created On";
                    if (dgvNotes.Columns["ReminderDate"] != null)
                        dgvNotes.Columns["ReminderDate"].HeaderText = "Reminder";
                }
            }
            else
            {
                dgvNotes.DataSource = null;
            }

            if (btnDeleteNote != null)
            {
                btnDeleteNote.Enabled = dgvNotes.SelectedRows.Count > 0;
            }
        }

        private void btnSearchNotes_Click(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void txtSearchNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadNotes();
                e.SuppressKeyPress = true;
            }
        }

        private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void dgvNotes_SelectionChanged(object sender, EventArgs e)
        {
            btnDeleteNote.Enabled = dgvNotes.SelectedRows.Count > 0;
        }

        private void btnDeleteNote_Click(object sender, EventArgs e)
        {
            if (dgvNotes.SelectedRows.Count > 0)
            {
                int noteIdToDelete = Convert.ToInt32(dgvNotes.SelectedRows[0].Cells["NoteID"].Value);

                var confirmResult = MessageBox.Show("Are you sure you want to delete this note permanently?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    bool success = DataAccess.DeleteNoteFromDB(noteIdToDelete, this.CurrentUserID);
                    if (success)
                    {
                        MessageBox.Show("Note deleted successfully.");
                        LoadNotes();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the note. It might have already been deleted or you don't have permission.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a note to delete.", "No Note Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panelSearch_Paint(object sender, PaintEventArgs e)
        {

        }


        ////////////////////////////////////////////////////// category  
        ///

        //private void NotesListForm_Load(object sender, EventArgs e)
        //{
        //    LoadCategoriesIntoComboBox();
        //}

        //private void LoadCategoriesIntoComboBox()
        //{
        //    var categories = DataAccess.GetCategories();

        //    cmbFilterCategory.DataSource = categories;
        //    cmbFilterCategory.DisplayMember = "Name"; // اسم العمود اللي عايز تعرضه
        //    cmbFilterCategory.ValueMember = "CategoryID"; // العمود اللي يمثّل القيمة
        //}





        //private void cmbFilterCategory_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int selectedCategoryId = (int)cmbFilterCategory.SelectedValue;

        //    var filteredNotes = DataAccess.GetNotesByCategory(selectedCategoryId, CurrentUserID);

        //    dataGridViewNotes.DataSource = filteredNotes;
        //}




        //public static List<NoteFullDetails> GetNotesByCategory(int categoryId, int userId)
        //{
        //    using (var context = new ApplicationDbContext())
        //    {
        //        return context.Notes
        //                      .Where(n => n.CategoryID == categoryId && n.UserID == userId)
        //                      .Select(n => new NoteFullDetails
        //                      {
        //                          NoteID = n.NoteID,
        //                          Title = n.Title,
        //                          CategoryName = n.Category.CategoryName,
        //                          //CreationDate = n.CreationDate,
        //                          ReminderDate = n.ReminderDate
        //                      }).ToList();
        //    }
        //}


    }
}
