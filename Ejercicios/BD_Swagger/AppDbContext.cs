using Microsoft.EntityFrameworkCore;
using Infraestructure.Entities;

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
            //Indicamos como queremos que se llamen las tablas en la base de datos
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Customer>().ToTable("Customer");

            //Indicamos la relación que hay entre dos tablas y si hay algun tipo de DELETE
            modelBuilder.Entity<Customer>(config =>
            {
                config.HasOne(o => o.Person)
                     .WithMany()
                     .HasForeignKey(o => o.PersonId)
                     .OnDelete(DeleteBehavior.Cascade);

            });
        }
    }
}
