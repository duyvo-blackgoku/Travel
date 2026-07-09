using TravelEU.Database.Interfaces;

namespace TravelEU.Database.Models;

public class Tour : IAuditable
{
    public int Id { get; set; }

    public string TourName { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal Price { get; set; }

    public int Days { get; set; }

    public string? Image { get; set; }

    
    public int CategoryId { get; set; }
    public Category? Category { get; set; }

   
    public int DestinationId { get; set; }
    public Destination? Destination { get; set; }

    
    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();

   
    public string? CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
}