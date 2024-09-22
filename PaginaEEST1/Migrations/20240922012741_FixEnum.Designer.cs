﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PaginaEEST1.Data;

#nullable disable

namespace PaginaEEST1.Migrations
{
    [DbContext(typeof(PaginaDbContext))]
    [Migration("20240922012741_FixEnum")]
    partial class FixEnum
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("PaginaEEST1.Data.Models.Objetos_Fisicos.Ordenador", b =>
                {
                    b.Property<int>("OrdenadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OrdenadorId"));

                    b.Property<int?>("Almacenamiento")
                        .HasColumnType("int");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<string>("NombreOrdenador")
                        .HasColumnType("longtext");

                    b.Property<string>("Procesador")
                        .HasColumnType("longtext");

                    b.Property<int?>("RAM")
                        .HasColumnType("int");

                    b.Property<string>("Sistema_Operativo")
                        .HasColumnType("longtext");

                    b.Property<int>("TipoOrdenador")
                        .HasColumnType("int");

                    b.Property<string>("tipoAlmacenamiento")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasKey("OrdenadorId");

                    b.ToTable("Ordenadores");

                    b.HasDiscriminator<int>("TipoOrdenador");

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

                    b.HasKey("PersonaId");

                    b.ToTable("Personas");

                    b.HasDiscriminator<int>("TipoPersona");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Objetos_Fisicos.Computadora", b =>
                {
                    b.HasBaseType("PaginaEEST1.Data.Models.Objetos_Fisicos.Ordenador");

                    b.Property<string>("Ubicacion")
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue(1);
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Objetos_Fisicos.Netbook", b =>
                {
                    b.HasBaseType("PaginaEEST1.Data.Models.Objetos_Fisicos.Ordenador");

                    b.Property<string>("Modelo")
                        .HasColumnType("longtext");

                    b.Property<bool>("Prestamo")
                        .HasColumnType("tinyint(1)");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Personal.Alumno", b =>
                {
                    b.HasBaseType("PaginaEEST1.Data.Models.Personal.Persona");

                    b.Property<int?>("NetbookOrdenadorId")
                        .HasColumnType("int");

                    b.Property<string>("Turno_Cursada")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasIndex("NetbookOrdenadorId");

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

                    b.Property<int?>("NetbookOrdenadorId")
                        .HasColumnType("int");

                    b.Property<string>("NivelEstudios")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Titulo")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.HasIndex("NetbookOrdenadorId");

                    b.ToTable("Personas", t =>
                        {
                            t.Property("NetbookOrdenadorId")
                                .HasColumnName("Profesor_NetbookOrdenadorId");
                        });

                    b.HasDiscriminator().HasValue(4);
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Personal.Alumno", b =>
                {
                    b.HasOne("PaginaEEST1.Data.Models.Objetos_Fisicos.Netbook", "Netbook")
                        .WithMany()
                        .HasForeignKey("NetbookOrdenadorId");

                    b.Navigation("Netbook");
                });

            modelBuilder.Entity("PaginaEEST1.Data.Models.Personal.Profesor", b =>
                {
                    b.HasOne("PaginaEEST1.Data.Models.Objetos_Fisicos.Netbook", "Netbook")
                        .WithMany()
                        .HasForeignKey("NetbookOrdenadorId");

                    b.Navigation("Netbook");
                });
#pragma warning restore 612, 618
        }
    }
}
