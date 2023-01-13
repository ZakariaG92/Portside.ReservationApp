using System.ComponentModel.DataAnnotations;

namespace Portside.Entities.Model;

public class CustomerDto : BaseDocumentDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    [Phone]
    public string Phone { get; set; }
    public DateTime EnrollmentDate { get; set; }
}