﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230427100436_AllMigration")]
    partial class AllMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Infraestructure.Entities.Area", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HospitalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tamaño")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.ToTable("Area", (string)null);
                });

            modelBuilder.Entity("Infraestructure.Entities.Diagnostico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("MedicoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MedicoId");

                    b.HasIndex("PacienteId");

                    b.ToTable("Diagnostico", (string)null);
                });

            modelBuilder.Entity("Infraestructure.Entities.DiagnosticoTratamiento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DiagnosticoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TratamientoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DiagnosticoId");

                    b.HasIndex("TratamientoId");

                    b.ToTable("DiagnosticoTratamiento", (string)null);
                });

            modelBuilder.Entity("Infraestructure.Entities.Enfermedad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AreaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Riesgo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("Enfermedad", (string)null);
                });

            modelBuilder.Entity("Infraestructure.Entities.Funcion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AreaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AreaId");

                    b.ToTable("Funcion", (string)null);
                });

            modelBuilder.Entity("Infraestructure.Entities.Hospital", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("Especialidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Localizacion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Trabajadores")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Hospital", (string)null);
                });

            modelBuilder.Entity("Infraestructure.Entities.Medico", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FuncionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<TimeSpan>("HorasDia")
                        .HasColumnType("time");

                    b.Property<Guid>("HospitalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PersonaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("FuncionId");

                    b.HasIndex("HospitalId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Medico", (string)null);
                });

            modelBuilder.Entity("Infraestructure.Entities.Paciente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("Fecha")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("HospitalId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Motivo")
                        .HasColumnType("int");

                    b.Property<Guid>("PersonaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("HospitalId");

                    b.HasIndex("PersonaId");

                    b.ToTable("Paciente", (string)null);
                });

            modelBuilder.Entity("Infraestructure.Entities.PacienteEnfermedad", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EnfermedadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PacienteId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EnfermedadId");

                    b.HasIndex("PacienteId");

                    b.ToTable("PacienteEnfermedad", (string)null);
                });

            modelBuilder.Entity("Infraestructure.Entities.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person", (string)null);
                });

            modelBuilder.Entity("Infraestructure.Entities.Tratamiento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Duracion")
                        .HasColumnType("int");

                    b.Property<Guid>("EnfermedadId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EnfermedadId");

                    b.ToTable("Tratamiento", (string)null);
                });

            modelBuilder.Entity("Infraestructure.Entities.Area", b =>
                {
                    b.HasOne("Infraestructure.Entities.Hospital", "Hospital")
                        .WithMany()
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospital");
                });

            modelBuilder.Entity("Infraestructure.Entities.Diagnostico", b =>
                {
                    b.HasOne("Infraestructure.Entities.Medico", "Medico")
                        .WithMany()
                        .HasForeignKey("MedicoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entities.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Medico");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Infraestructure.Entities.DiagnosticoTratamiento", b =>
                {
                    b.HasOne("Infraestructure.Entities.Diagnostico", "Diagnostico")
                        .WithMany()
                        .HasForeignKey("DiagnosticoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entities.Tratamiento", "Tratamiento")
                        .WithMany()
                        .HasForeignKey("TratamientoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diagnostico");

                    b.Navigation("Tratamiento");
                });

            modelBuilder.Entity("Infraestructure.Entities.Enfermedad", b =>
                {
                    b.HasOne("Infraestructure.Entities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("Infraestructure.Entities.Funcion", b =>
                {
                    b.HasOne("Infraestructure.Entities.Area", "Area")
                        .WithMany()
                        .HasForeignKey("AreaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Area");
                });

            modelBuilder.Entity("Infraestructure.Entities.Medico", b =>
                {
                    b.HasOne("Infraestructure.Entities.Funcion", "Funcion")
                        .WithMany("Medico")
                        .HasForeignKey("FuncionId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entities.Hospital", "Hospital")
                        .WithMany("Medicos")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entities.Person", "Persona")
                        .WithMany("Medicos")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funcion");

                    b.Navigation("Hospital");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Infraestructure.Entities.Paciente", b =>
                {
                    b.HasOne("Infraestructure.Entities.Hospital", "Hospital")
                        .WithMany("Pacientes")
                        .HasForeignKey("HospitalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entities.Person", "Persona")
                        .WithMany("Pacientes")
                        .HasForeignKey("PersonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hospital");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Infraestructure.Entities.PacienteEnfermedad", b =>
                {
                    b.HasOne("Infraestructure.Entities.Enfermedad", "Enfermedad")
                        .WithMany()
                        .HasForeignKey("EnfermedadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Infraestructure.Entities.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Enfermedad");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Infraestructure.Entities.Tratamiento", b =>
                {
                    b.HasOne("Infraestructure.Entities.Enfermedad", "Enfermedad")
                        .WithMany()
                        .HasForeignKey("EnfermedadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enfermedad");
                });

            modelBuilder.Entity("Infraestructure.Entities.Funcion", b =>
                {
                    b.Navigation("Medico");
                });

            modelBuilder.Entity("Infraestructure.Entities.Hospital", b =>
                {
                    b.Navigation("Medicos");

                    b.Navigation("Pacientes");
                });

            modelBuilder.Entity("Infraestructure.Entities.Person", b =>
                {
                    b.Navigation("Medicos");

                    b.Navigation("Pacientes");
                });
#pragma warning restore 612, 618
        }
    }
}