using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using PizzaStore.Entities;

namespace PizzaStore.Entities;

[Table("Products")]
public class Product
{
    [Key]
    public long Id { get; set; }
    [MaxLength(50)]
    [Column("ProductName")]
    public string? ProductName { get; set; }
    public bool IsComplete { get; set; }
    [Required]
    public DateTime Duedate {get; set;}

    public int OrderId {get; set;}

    public Order? Order {get; set;}
}


