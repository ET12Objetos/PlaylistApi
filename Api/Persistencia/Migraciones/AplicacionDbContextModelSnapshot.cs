﻿// <auto-generated />
using System;
using Api.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api.Persistencia.Migraciones
{
    [DbContext(typeof(AplicacionDbContext))]
    partial class AplicacionDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Aplicacion.Dominio.Playlist", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Playlist");

                    b.HasData(
                        new
                        {
                            Id = new Guid("16248298-70ba-4ee4-8959-f903c927c31a"),
                            Nombre = "Playlist 1"
                        },
                        new
                        {
                            Id = new Guid("d4eeba3d-2432-44a1-9a12-61112142dd57"),
                            Nombre = "Playlist 2"
                        });
                });

            modelBuilder.Entity("Aplicacion.Dominio.Song", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Duracion")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<Guid?>("PlaylistId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("PlaylistId");

                    b.ToTable("Song");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fb623cf7-e4bb-4088-b1e7-f560cddf72a4"),
                            Duracion = 100,
                            Nombre = "Song 1"
                        },
                        new
                        {
                            Id = new Guid("9a987689-8898-4b1c-85ca-eca50a3a21e4"),
                            Duracion = 200,
                            Nombre = "Song 2"
                        },
                        new
                        {
                            Id = new Guid("cd9576d4-c098-4f19-8b97-f6a55a6ecb6e"),
                            Duracion = 300,
                            Nombre = "Song 3"
                        });
                });

            modelBuilder.Entity("Aplicacion.Dominio.Song", b =>
                {
                    b.HasOne("Aplicacion.Dominio.Playlist", null)
                        .WithMany("Songs")
                        .HasForeignKey("PlaylistId");
                });

            modelBuilder.Entity("Aplicacion.Dominio.Playlist", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
