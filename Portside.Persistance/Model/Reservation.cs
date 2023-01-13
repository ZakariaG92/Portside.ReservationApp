﻿namespace Portside.Persistance.Model;

public class Reservation : BaseDocument
{
    public string Departure { get; set; }
    public string Destination { get; set; }
    public DateTime FlightDate { get; set; }
    public decimal Price { get; set; }
    
    public string CustomerId { get; set; }
    public virtual Customer Customer { get; set; }
}