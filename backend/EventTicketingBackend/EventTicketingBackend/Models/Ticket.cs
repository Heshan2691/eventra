namespace EventTicketingBackend.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }  // purchased, refunded
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
