using Microsoft.EntityFrameworkCore;
using Entities;

namespace BD_Swagger
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) 
        {
        
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }
    }
}
