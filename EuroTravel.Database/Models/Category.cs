using TravelEU.Database.Interfaces;

namespace TravelEU.Database.Models;

public class Category : IAuditable
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

   
    public ICollection<Tour> Tours { get; set; } = new List<Tour>();

 
    public string? CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }
    public DateTime? ModifiedDate { get; set; }
}