﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

#nullable disable

namespace Persistencia.Data.Migrations
{
    [DbContext(typeof(ApiIncidenciasContext))]
    [Migration("20230821213018_RolesUsuariosV2Mig")]
    partial class RolesUsuariosV2Mig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Dominio.Ciudad", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("IdDepFk")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("NombreCiudad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdDepFk");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Dominio.Departamento", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("IdPaisFk")
                        .HasColumnType("varchar(3)");

                    b.Property<string>("NombreDep")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("departamento", (string)null);
                });

            modelBuilder.Entity("Dominio.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombreGenero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("genero", (string)null);
                });

            modelBuilder.Entity("Dominio.Matricula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IdPersonaFk")
                        .HasColumnType("longtext");

                    b.Property<int>("IdSalonFk")
                        .HasColumnType("int");

                    b.Property<string>("PersonaId")
                        .HasColumnType("varchar(20)");

                    b.Property<int?>("SalonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonaId");

                    b.HasIndex("SalonId");

                    b.ToTable("matricula", (string)null);
                });

            modelBuilder.Entity("Dominio.Pais", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(3)
                        .HasColumnType("varchar(3)");

                    b.Property<string>("NombrePais")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("NombrePais")
                        .IsUnique();

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("ApellidoMaterno")
                        .HasColumnType("longtext");

                    b.Property<string>("ApellidoPaterno")
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<string>("IdCiudadFk")
                        .HasColumnType("varchar(3)");

                    b.Property<int>("IdGeneroFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPerFk")
                        .HasColumnType("int");

                    b.Property<string>("NombrePersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudadFk");

                    b.HasIndex("IdGeneroFk");

                    b.HasIndex("IdTipoPerFk");

                    b.ToTable("persona", (string)null);
                });

            modelBuilder.Entity("Dominio.PersonaRoles", b =>
                {
                    b.Property<string>("UsuarioId")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.HasKey("UsuarioId", "RolId");

                    b.HasIndex("RolId");

                    b.ToTable("PersonaRoles");
                });

            modelBuilder.Entity("Dominio.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("rol", (string)null);
                });

            modelBuilder.Entity("Dominio.Salon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.Property<string>("NombreSalon")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("salon", (string)null);
                });

            modelBuilder.Entity("Dominio.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DescripcionTipoPersona")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("tipopersona", (string)null);
                });

            modelBuilder.Entity("Dominio.TrainerSalon", b =>
                {
                    b.Property<string>("IdPerTrainerFk")
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<int>("IdSalonFk")
                        .HasColumnType("int");

                    b.HasKey("IdPerTrainerFk", "IdSalonFk");

                    b.HasIndex("IdSalonFk");

                    b.ToTable("trainersalon", (string)null);
                });

            modelBuilder.Entity("Dominio.Ciudad", b =>
                {
                    b.HasOne("Dominio.Departamento", "Departamento")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepFk");

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Dominio.Departamento", b =>
                {
                    b.HasOne("Dominio.Pais", "Pais")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Dominio.Matricula", b =>
                {
                    b.HasOne("Dominio.Persona", "Persona")
                        .WithMany("Matriculas")
                        .HasForeignKey("PersonaId");

                    b.HasOne("Dominio.Salon", "Salon")
                        .WithMany("Matriculas")
                        .HasForeignKey("SalonId");

                    b.Navigation("Persona");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.HasOne("Dominio.Ciudad", "Ciudad")
                        .WithMany("Personas")
                        .HasForeignKey("IdCiudadFk");

                    b.HasOne("Dominio.Genero", "Genero")
                        .WithMany("Personas")
                        .HasForeignKey("IdGeneroFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.TipoPersona", "TipoPersona")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPerFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");

                    b.Navigation("Genero");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Dominio.PersonaRoles", b =>
                {
                    b.HasOne("Dominio.Rol", "Rol")
                        .WithMany("PersonaRoles")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Persona", "Persona")
                        .WithMany("PersonaRoles")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Dominio.TrainerSalon", b =>
                {
                    b.HasOne("Dominio.Persona", "Persona")
                        .WithMany("TrainerSalones")
                        .HasForeignKey("IdPerTrainerFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Dominio.Salon", "Salon")
                        .WithMany("TrainerSalones")
                        .HasForeignKey("IdSalonFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("Dominio.Ciudad", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Dominio.Genero", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Dominio.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Dominio.Persona", b =>
                {
                    b.Navigation("Matriculas");

                    b.Navigation("PersonaRoles");

                    b.Navigation("TrainerSalones");
                });

            modelBuilder.Entity("Dominio.Rol", b =>
                {
                    b.Navigation("PersonaRoles");
                });

            modelBuilder.Entity("Dominio.Salon", b =>
                {
                    b.Navigation("Matriculas");

                    b.Navigation("TrainerSalones");
                });

            modelBuilder.Entity("Dominio.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
