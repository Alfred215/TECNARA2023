﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio7_BBDD.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BBDD.Ejercicios.Ejercicios_Con_Relaciones.Ejercicio7_BBDD.Context
{
    public partial class dbContextEj7 : DbContext
    {
        public dbContextEj7()
        {
        }

        public dbContextEj7(DbContextOptions<dbContextEj7> options)
            : base(options)
        {
        }

        public virtual DbSet<CentroBelleza> CentroBelleza { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Sucursal> Sucursal { get; set; }
        public virtual DbSet<Trabajador> Trabajador { get; set; }
        public virtual DbSet<TrabajadorCliente> TrabajadorCliente { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=BellezaTecnara;Integrated Security=True; Encrypt=True; TrustServerCertificate=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CentroBelleza>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");
            });

            modelBuilder.Entity<Sucursal>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Centro)
                    .WithMany(p => p.Sucursal)
                    .HasForeignKey(d => d.CentroId)
                    .HasConstraintName("FK__Sucursal__Centro__286302EC");
            });

            modelBuilder.Entity<Trabajador>(entity =>
            {
                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.HasOne(d => d.Sucursal)
                    .WithMany(p => p.Trabajador)
                    .HasForeignKey(d => d.SucursalId)
                    .HasConstraintName("FK__Trabajado__Sucur__2C3393D0");
            });

            modelBuilder.Entity<TrabajadorCliente>(entity =>
            {
                entity.HasOne(d => d.Cliente)
                    .WithMany()
                    .HasForeignKey(d => d.ClienteId)
                    .HasConstraintName("FK__Trabajado__Clien__30F848ED");

                entity.HasOne(d => d.Trabajador)
                    .WithMany()
                    .HasForeignKey(d => d.TrabajadorId)
                    .HasConstraintName("FK__Trabajado__Traba__31EC6D26");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}