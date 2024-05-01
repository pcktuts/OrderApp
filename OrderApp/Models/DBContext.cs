using Microsoft.EntityFrameworkCore;

namespace OrderApp.Models
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options)
       : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } = null!;
    }
}
