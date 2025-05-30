using DigitalNotesManager.DTO;
using DigitalNotesManager.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace DigitalNotesManager
{
    public static class DataAccess
    {
        private static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static bool RegisterUser(string username, string password)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    if (db.Users.Any(u => u.Username == username))
                    {
                        MessageBox.Show("Username already exists.");
                        return false; 
                    }

                    var user = new User
                    {
                        Username = username,
                        PasswordHash = HashPassword(password)
                    };
                    db.Users.Add(user); 
                    db.SaveChanges();  
                    return true; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during registration: " + ex.ToString());   
                return false; 
            }
        }

        public static int ValidateUser(string username, string password)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    var user = db.Users.FirstOrDefault(u => u.Username == username);

                    if (user != null)
                    {
                        if (user.PasswordHash == HashPassword(password))
                        {
                            return user.UserID; 
                        }
                    }
                    return 0; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during login validation: " + ex.ToString());
                return 0; 
            }
        }

        private static int? GetOrCreateCategoryID(string categoryName, int userId, ApplicationDbContext db)
        {
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                return null;
            }

            var category = db.Categories
                             .FirstOrDefault(c => c.CategoryName == categoryName && c.UserID == userId);

            if (category != null) 
            {
                return category.CategoryID; 
            }
            else 
            {
                var newCategory = new Category
                {
                    CategoryName = categoryName,
                    UserID = userId
                };
                db.Categories.Add(newCategory);
                db.SaveChanges();
                return newCategory.CategoryID; 
            }
        }

        public static int SaveNoteToDB(int userId, string title, string content, string categoryName, DateTime? reminderDate)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    int? categoryId = GetOrCreateCategoryID(categoryName, userId, db); 

                    var note = new Note
                    {
                        UserID = userId,
                        Title = title,
                        Content = content,
                        CategoryID = categoryId,
                        ReminderDate = reminderDate,
                        IsReminderDismissed = !reminderDate.HasValue,
                        CreationDate = DateTime.Now
                    };
                    db.Notes.Add(note);
                    db.SaveChanges();
                    return note.NoteID;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error in SaveNoteToDB (EF Core): " + ex.ToString());
                return 0;
            }
        }

        public static bool UpdateNoteInDB(int noteId, int userId, string title, string content, string categoryName, DateTime? reminderDate)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    var noteToUpdate = db.Notes.FirstOrDefault(n => n.NoteID == noteId && n.UserID == userId);
                    if (noteToUpdate != null)
                    {
                        int? categoryId = GetOrCreateCategoryID(categoryName, userId, db);

                        noteToUpdate.Title = title;
                        noteToUpdate.Content = content;
                        noteToUpdate.CategoryID = categoryId;
                        noteToUpdate.ReminderDate = reminderDate;

                        if (reminderDate.HasValue)
                        {
                            noteToUpdate.IsReminderDismissed = false;
                        }
                        else
                        {
                            noteToUpdate.IsReminderDismissed = true;
                        }

                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error in UpdateNoteInDB (EF Core): " + ex.ToString());
                return false;
            }
        }

        public static List<NoteDisplayItem> GetUserNotes(int userId, string searchTerm = null, string filterCategoryName = null)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    var query = db.Notes
                                  .Include(n => n.Category) 
                                  .Where(n => n.UserID == userId);

                    if (!string.IsNullOrWhiteSpace(searchTerm))
                    {
                        query = query.Where(n => n.Title.Contains(searchTerm) ||
                                                 n.Content.Contains(searchTerm));
                    }

                    if (!string.IsNullOrWhiteSpace(filterCategoryName) && filterCategoryName != "All Categories") 
                    {
                        query = query.Where(n => n.Category != null && n.Category.CategoryName == filterCategoryName);
                    }

                    return query.OrderByDescending(n => n.CreationDate)
                                 .Select(n => new NoteDisplayItem
                                 {
                                     NoteID = n.NoteID,
                                     Title = n.Title,
                                     Category = n.Category != null ? n.Category.CategoryName : "Uncategorized",
                                     CreationDate = n.CreationDate,
                                     ReminderDate = n.ReminderDate
                                 })
                                 .ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching notes (EF Core with Filters): " + ex.ToString());
                return new List<NoteDisplayItem>();
            }
        }

        public static NoteFullDetails GetNoteDetails(int noteId, int userId)    
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    return db.Notes
                             .Where(n => n.NoteID == noteId && n.UserID == userId) 
                             .Include(n => n.Category) 
                             .Select(n => new NoteFullDetails 
                             {
                                 NoteID = n.NoteID,
                                 Title = n.Title,
                                 RtfContent = n.Content,
                                 CategoryName = n.Category != null ? n.Category.CategoryName : "Uncategorized",
                                 ReminderDate = n.ReminderDate
                             })
                             .FirstOrDefault(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GetNoteDetails (EF Core): " + ex.ToString());
                return null; 
            }
        }
        public static List<string> GetUserCategoryNames(int userId)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    return db.Categories
                             .Where(c => c.UserID == userId) 
                             .OrderBy(c => c.CategoryName) 
                             .Select(c => c.CategoryName) 
                             .ToList(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching categories (EF Core): " + ex.ToString());
                return new List<string>(); 
            }
        }

        public static bool DeleteNoteFromDB(int noteId, int userId)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    var noteToDelete = db.Notes.FirstOrDefault(n => n.NoteID == noteId && n.UserID == userId);

                    if (noteToDelete != null)
                    {
                        db.Notes.Remove(noteToDelete); 
                        db.SaveChanges(); 
                        return true; 
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting note from DB: " + ex.ToString());
                return false; 
            }
        }

        public static List<NoteFullDetails> GetDueReminders(int userId)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    DateTime currentTime = DateTime.Now;
                    return db.Notes
                             .Where(n => n.UserID == userId &&       
                                         n.ReminderDate != null &&   
                                         n.ReminderDate <= currentTime && 
                                         n.IsReminderDismissed == false) 
                             .Include(n => n.Category) 
                             .OrderBy(n => n.ReminderDate) 
                             .Select(n => new NoteFullDetails 
                             {
                                 NoteID = n.NoteID,
                                 Title = n.Title,
                                 RtfContent = n.Content,
                                 CategoryName = n.Category != null ? n.Category.CategoryName : "Uncategorized",
                                 ReminderDate = n.ReminderDate
                             })
                             .ToList();
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error fetching due reminders: " + ex.ToString());
                return new List<NoteFullDetails>();
            }
        }

        public static bool DismissReminder(int noteId, int userId)
        {
            try
            {
                using (var db = new ApplicationDbContext())
                {
                    var noteToUpdate = db.Notes.FirstOrDefault(n => n.NoteID == noteId && n.UserID == userId);
                    if (noteToUpdate != null)
                    {
                        noteToUpdate.IsReminderDismissed = true;
                        db.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error dismissing reminder: " + ex.ToString());
                return false;
            }
        }

    }

}
