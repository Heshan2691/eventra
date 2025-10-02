namespace EventTicketingBackend.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int OrganizerId { get; set; }
        public User Organizer { get; set; }  // Navigation property
        public string Status { get; set; }  // draft, published, cancelled
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
