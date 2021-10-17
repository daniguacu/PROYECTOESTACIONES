﻿// <auto-generated />
using System;
using Aplicacion.App.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Aplicacion.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Aplicacion.App.Dominio.DataMeteorologico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("EstacionId")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaDato")
                        .HasColumnType("datetime2");

                    b.Property<float>("Humedad")
                        .HasColumnType("real");

                    b.Property<float>("Pluviosidad")
                        .HasColumnType("real");

                    b.Property<float>("PresionAtmosferica")
                        .HasColumnType("real");

                    b.Property<float>("RadiacionSolar")
                        .HasColumnType("real");

                    b.Property<float>("Temperatura")
                        .HasColumnType("real");

                    b.Property<float>("VelocidadViento")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("EstacionId");

                    b.ToTable("DatoMeteorologico");
                });

            modelBuilder.Entity("Aplicacion.App.Dominio.Estacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Codigo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaMontaje")
                        .HasColumnType("datetime2");

                    b.Property<float>("Latitud")
                        .HasColumnType("real");

                    b.Property<float>("Longitud")
                        .HasColumnType("real");

                    b.Property<string>("Municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ReporteId")
                        .HasColumnType("int");

                    b.Property<int?>("TecnicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ReporteId");

                    b.HasIndex("TecnicoId");

                    b.ToTable("Estaciones");
                });

            modelBuilder.Entity("Aplicacion.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identificacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Personas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Persona");
                });

            modelBuilder.Entity("Aplicacion.App.Dominio.Reporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Reporte");
                });

            modelBuilder.Entity("Aplicacion.App.Dominio.TecnicoMantenimiento", b =>
                {
                    b.HasBaseType("Aplicacion.App.Dominio.Persona");

                    b.Property<int?>("ReporteId")
                        .HasColumnType("int");

                    b.Property<int>("TarjetaProfesional")
                        .HasColumnType("int");

                    b.HasIndex("ReporteId");

                    b.HasDiscriminator().HasValue("TecnicoMantenimiento");
                });

            modelBuilder.Entity("Aplicacion.App.Dominio.DataMeteorologico", b =>
                {
                    b.HasOne("Aplicacion.App.Dominio.Estacion", null)
                        .WithMany("DatosMeteorologicos")
                        .HasForeignKey("EstacionId");
                });

            modelBuilder.Entity("Aplicacion.App.Dominio.Estacion", b =>
                {
                    b.HasOne("Aplicacion.App.Dominio.Reporte", "Reporte")
                        .WithMany()
                        .HasForeignKey("ReporteId");

                    b.HasOne("Aplicacion.App.Dominio.TecnicoMantenimiento", "Tecnico")
                        .WithMany()
                        .HasForeignKey("TecnicoId");

                    b.Navigation("Reporte");

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("Aplicacion.App.Dominio.TecnicoMantenimiento", b =>
                {
                    b.HasOne("Aplicacion.App.Dominio.Reporte", "Reporte")
                        .WithMany()
                        .HasForeignKey("ReporteId");

                    b.Navigation("Reporte");
                });

            modelBuilder.Entity("Aplicacion.App.Dominio.Estacion", b =>
                {
                    b.Navigation("DatosMeteorologicos");
                });
#pragma warning restore 612, 618
        }
    }
}
