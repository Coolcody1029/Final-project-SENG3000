using System.ComponentModel.DataAnnotations;

namespace PizzaStore.Entities
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}