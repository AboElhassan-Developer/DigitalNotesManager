using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalNotesManager.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required] 
        [StringLength(50)] 
        public string Username { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<Category> Categories { get; set; }

        public User()
        {
            Notes = new HashSet<Note>();
            Categories = new HashSet<Category>();
        }
    }
}
