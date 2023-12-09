using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaStore.Entities;

[Table("LineItems")]
public class LineItem
{
    [Key]
    public int LineId {get; set;}
    [MaxLength(50)]
    [Required]
    public int LineNumber{get; set;}
    
}