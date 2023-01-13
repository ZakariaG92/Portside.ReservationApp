namespace Portside.Entities.Model;

public class BaseDocumentDto
{
    public string? Id { get; set; }
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
}