using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaStore.Entities;

[Table("Roles")]

public class Role
{
    public int Roleid {get; set;}
    [Required]
    [MaxLength(50)]

    public string RoleName {get; set;}

}