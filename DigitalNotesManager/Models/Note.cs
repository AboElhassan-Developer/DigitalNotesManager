using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalNotesManager.Models
{
    public class Note
    {
        [Key]
        public int NoteID { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        public string Content { get; set; } 

        public DateTime CreationDate { get; set; }

        public DateTime? ReminderDate { get; set; }

        public bool IsReminderDismissed { get; set; }

        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public virtual User User { get; set; }

        public int? CategoryID { get; set; } 
        [ForeignKey("CategoryID")]
        public virtual Category Category { get; set; } 
    }
}
