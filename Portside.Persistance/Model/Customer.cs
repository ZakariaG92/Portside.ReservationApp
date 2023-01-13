using System.ComponentModel.DataAnnotations;

namespace Portside.Persistance.Model;

public class Customer : BaseDocument
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
    public ICollection<Reservation> Reservations { get; set; }
 
}  