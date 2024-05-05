using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.Models
{
    public class Product
    {
        [Key]
        public long ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public required string ProductName { get; set; }
        [Required]
        [MaxLength(500)]
        public string? Description { get; set; }
        [Required]
        [Precision(18, 2)]
        public required decimal Price { get; set; }
        [Required]
        public int StockQuantity { get; set; }
    }
}
