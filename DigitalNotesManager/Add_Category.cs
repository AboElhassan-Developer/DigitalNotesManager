using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalNotesManager
{
    public partial class Add_Category : Form
    {
        //private int UserID = 2;


        public int UserID { get; private set; }

        public Add_Category(int userID) {

          InitializeComponent();
            this.UserID = userID;

        }

        public Add_Category()
        {
            InitializeComponent();

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string categoryName = texAddCategory.Text.Trim();

            if (!string.IsNullOrEmpty(categoryName))
            {
                bool added = DataAccess.AddCategory(categoryName, UserID); // تأكد إن UserID موجود

                if (added)
                {
                    MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    texAddCategory.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddCategory_Click_1(object sender, EventArgs e)
        {
            string categoryName = texAddCategory.Text.Trim();

            if (!string.IsNullOrEmpty(categoryName))
            {
                bool added = DataAccess.AddCategory(categoryName, UserID); // تأكد إن UserID موجود

                if (added)
                {
                    MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    texAddCategory.Clear();
                }
            }
            else
            {
                MessageBox.Show("Please enter a category name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
