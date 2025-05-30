namespace DigitalNotesManager.DTO
{
    public class NoteDisplayItem
    {
        public int NoteID { get; set; }
        public string Title { get; set; }
        public string Category { get; set; } 
        public DateTime CreationDate { get; set; }
        public DateTime? ReminderDate { get; set; }
    }
}
