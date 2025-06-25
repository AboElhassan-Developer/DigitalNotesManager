using DigitalNotesManager.Models;

namespace DigitalNotesManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            ApplicationDbContext db = new ApplicationDbContext();

            //db.Database.EnsureDeleted();
            //db.Database.EnsureCreated();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new MainForm( ));



            LoginForm loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                int currentUserId = loginForm.LoggedInUserID;

                Application.Run(new MainForm(currentUserId));
            }
        }




        ///////////////////////////////////////////
        ///
        //public static List<Category> GetCategories()
        //{
        //    using (var context = new ApplicationDbContext())
        //    {
        //        return context.Categories.ToList();
        //    }
        //}



            /////////
            ///


            //public static void AddCategory(string name, int userId)
            //{
            //using (var context = new ApplicationDbContext())
            //{
            //    var newCategory = new Category
            //    {
            //        CategoryName = name,
            //        UserID = userId
            //    };

            //    context.Categories.Add(newCategory);
            //    context.SaveChanges();
            //}
            //         }


        /////////////////





    }
}
