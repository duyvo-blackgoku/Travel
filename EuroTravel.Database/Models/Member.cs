using TravelEU.Database.Interfaces;

namespace TravelEU.Database.Models;

public class Member : IAuditable
{
    public int Id { get; set; }

    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    public string? Phone { get; set; }


    public int GroupId { get; set; }

    public Group? Group { get; set; }


    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();


    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}