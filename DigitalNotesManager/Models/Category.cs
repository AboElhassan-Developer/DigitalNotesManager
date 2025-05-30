using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalNotesManager.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public int UserID { get; set; }
        [ForeignKey("UserID")] 
        public virtual User User { get; set; } 

        public virtual ICollection<Note> Notes { get; set; }

        public Category()
        {
            Notes = new HashSet<Note>();
        }
    }
}
