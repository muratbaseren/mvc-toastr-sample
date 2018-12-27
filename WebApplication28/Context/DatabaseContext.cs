using WebApplication28.Models;
using System.Data.Entity;

namespace WebApplication28.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }
    }
}
