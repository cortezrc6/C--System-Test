using Microsoft.EntityFrameworkCore;
using Systemtest.Models.DbEntities;

namespace Systemtest.DAL
{
    public class DbCustomerContext : DbContext
    {
        public DbCustomerContext() { }
        public DbCustomerContext(DbContextOptions<DbCustomerContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; } // Adjust 'Customer' to match your entity class name
    }
}
