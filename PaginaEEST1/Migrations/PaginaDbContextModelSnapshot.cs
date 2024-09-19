﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaginaEEST1.Data;

#nullable disable

namespace PaginaEEST1.Migrations
{
    [DbContext(typeof(PaginaDbContext))]
    partial class PaginaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("PaginaEEST1.Data.Models.Objetos_Fisicos.Computadora", b =>
                {
                    b.Property<int>("ComputadoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ComputadoraId"));

                    b.Property<string>("Estado")
                        .HasColumnType("longtext");

                    b.Property<DateTime>("FechaAdquisicion")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("SistemaOperativo")
                        .HasColumnType("longtext");

                    b.Property<int>("TipoComputadora")
                        .HasColumnType("int");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("longtext");

                    b.HasKey("ComputadoraId");

                    b.ToTable("Computadoras");

                    b.HasDiscriminator<int>("TipoComputadora").HasValue(1);

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Personal.Persona", b =>
                {
                    b.Property<int>("PersonaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("PersonaId"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Documento")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("TipoPersona")
                        .HasColumnType("int");

                    b.Property<int>("TipoPersonaId")
                        .HasColumnType("int");

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");

                    b.HasDiscriminator<int>("TipoPersona").IsComplete(true);

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Objetos_Fisicos.Netbook", b =>
                {
                    b.HasBaseType("PaginaEEST1.Data.Models.Objetos_Fisicos.Computadora");

                    b.Property<int?>("AlumnoId")
                        .HasColumnType("int");

                    b.Property<int?>("ProfesorId")
                        .HasColumnType("int");

                    b.HasIndex("AlumnoId")
                        .IsUnique();

                    b.HasIndex("ProfesorId")
                        .IsUnique();

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Personal.Alumno", b =>
                {
                    b.HasBaseType("PaginaEEST1.Data.Models.Personal.Persona");

                    b.Property<string>("Turno_Cursada")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasDiscriminator().HasValue(5);
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Personal.Directivo", b =>
                {
                    b.HasBaseType("PaginaEEST1.Data.Models.Personal.Persona");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Personal.EMATP", b =>
                {
                    b.HasBaseType("PaginaEEST1.Data.Models.Personal.Persona");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Personal.Paniol", b =>
                {
                    b.HasBaseType("PaginaEEST1.Data.Models.Personal.Persona");

                    b.HasDiscriminator().HasValue(3);
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Personal.Profesor", b =>
                {
                    b.HasBaseType("PaginaEEST1.Data.Models.Personal.Persona");

                    b.Property<string>("NivelEstudios")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Titulo")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasDiscriminator().HasValue(4);
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Objetos_Fisicos.Netbook", b =>
                {
                    b.HasOne("PaginaEEST1.Data.Models.Personal.Alumno", "Alumno")
                        .WithOne("Netbook")
                        .HasForeignKey("PaginaEEST1.Data.Models.Objetos_Fisicos.Netbook", "AlumnoId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("PaginaEEST1.Data.Models.Personal.Profesor", "Profesor")
                        .WithOne("Netbook")
                        .HasForeignKey("PaginaEEST1.Data.Models.Objetos_Fisicos.Netbook", "ProfesorId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Alumno");

                    b.Navigation("Profesor");
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Personal.Alumno", b =>
                {
                    b.Navigation("Netbook");
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Personal.Profesor", b =>
                {
                    b.Navigation("Netbook");
                });
#pragma warning restore 612, 618
        }
    }
}
