namespace DigitalNotesManager.DTO
{
    public class NoteFullDetails
    {
        public int NoteID { get; set; }
        public string Title { get; set; }
        public string RtfContent { get; set; }
        public string CategoryName { get; set; }
        public DateTime? ReminderDate { get; set; }
    }
}
