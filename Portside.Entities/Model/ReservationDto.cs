namespace Portside.Entities.Model;

public class ReservationDto : BaseDocumentDto
{
    public string Departure { get; set; }
    public string Destination { get; set; }
    public DateTime FlightDate { get; set; }
    public decimal Price { get; set; }
    public string CustomerId { get; set; }
}