using TravelEU.Database.Interfaces;

namespace TravelEU.Database.Models;

public class Booking : IAuditable
{
    public int Id { get; set; }

    public DateTime BookingDate { get; set; }

    public int NumberOfPeople { get; set; }

    public decimal TotalPrice { get; set; }

    
    public int TourId { get; set; }

    public Tour? Tour { get; set; }

    
    public int MemberId { get; set; }

    public Member? Member { get; set; }

    
    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}