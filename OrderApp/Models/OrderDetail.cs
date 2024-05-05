using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OrderApp.Models
{
    public class OrderDetail
    {
        [Key]
        public long OrderDetailId { get; set; }
        [Required]
        public long OrderId { get; set; }
        public Order? Order { get; set; }
        [Required]
        public long ProductId { get; set; }
        public  Product? Product { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        [Precision(18, 2)]
        public decimal OrderPrice { get; set; }
    }
}
