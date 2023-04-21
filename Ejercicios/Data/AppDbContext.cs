using Infraestructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Person> Personas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Hospital> Hospitales { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Funcion> Funciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Indicamos como queremos que se llamen las tablas en la base de datos
            modelBuilder.Entity<Person>().ToTable("Person");
            modelBuilder.Entity<Medico>().ToTable("Medico");
            modelBuilder.Entity<Paciente>().ToTable("Paciente");
            modelBuilder.Entity<Hospital>().ToTable("Hospital");
            modelBuilder.Entity<Area>().ToTable("Area");
            modelBuilder.Entity<Funcion>().ToTable("Funcion");


            //Indicamos la relación que hay entre dos tablas y si hay algun tipo de DELETE 
            //Siempre que no hayamos hecho la relación en las entidades
            //modelBuilder.Entity<Medico>(config =>
            //{
            //    config.HasOne(o => o.Persona)
            //         .WithMany()
            //         .HasForeignKey(o => o.PersonaId)
            //         .OnDelete(DeleteBehavior.Cascade);

            //    config.HasOne(o => o.Hospital)
            //         .WithMany()
            //         .HasForeignKey(o => o.HospitalId)
            //         .OnDelete(DeleteBehavior.NoAction);
            //});

            //modelBuilder.Entity<Paciente>(config =>
            //{
            //    config.HasOne(o => o.Persona)
            //         .WithMany()
            //         .HasForeignKey(o => o.PersonaId)
            //         .OnDelete(DeleteBehavior.Cascade);

            //    config.HasOne(o => o.Hospital)
            //         .WithMany()
            //         .HasForeignKey(o => o.HospitalId)
            //         .OnDelete(DeleteBehavior.NoAction);
            //});
        }
    }
}