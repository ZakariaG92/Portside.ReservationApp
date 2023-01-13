using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Portside.Persistance.Model;

public abstract class BaseDocument
{
    [Key]
    public string Id { get; set; }

    public DateTime CreatedDateTime { get; set; } = DateTime.Now;
}