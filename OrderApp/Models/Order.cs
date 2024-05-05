using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OrderApp.Models
{
    public class Order
    {
        public long OrderId { get; set; }
        public Customer? Customer { get; set; }
        [Required]
        public  required DateTime OrderDate  { get; set; }
        [Required]
        [Precision(18, 2)]
        public virtual decimal TotalAmount  {get; set;}
        public required long CustomerId {  get; set; }
    }
}
