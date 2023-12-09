using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaStore.Entities;


[Table("Orders")]
public class Order
{
    [Key]
    public int OrderId {get; set; }
    [MaxLength(50)]
    [Column("OrderName")]
    public string? OrderName {get; set;}
    [MaxLength(50)]
    public bool Iscompleted {get; set;}
    [Required]
    public DateTime OrderDate {get; set;}

    public List<Product>? Products {get; set;}
    
}