using Microsoft.AspNetCore.Identity;

namespace EventTicketingBackend.Models
{
    public class User : IdentityUser<int>
    {
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
