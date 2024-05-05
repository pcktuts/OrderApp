using System.ComponentModel.DataAnnotations;

namespace OrderApp.Models
{
    public class Customer
    {
        [Key]
        public long CustomerId { get; set; }
        [Required]
        [MaxLength(50)]
        public required string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string? LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public required string Email { get; set; }
        public ICollection<Order>? Orders { get; set; }

    }
}
