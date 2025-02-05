﻿// <auto-generated />
using System;
using Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Core.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200421001843_inicio")]
    partial class inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Models.Artist", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Generoid")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Generoid");

                    b.ToTable("Artistas");
                });

            modelBuilder.Entity("Core.Models.Genero", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("Core.Models.Song", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Artistaid")
                        .HasColumnType("int");

                    b.Property<int?>("Generoid")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Artistaid");

                    b.HasIndex("Generoid");

                    b.ToTable("Canciones");
                });

            modelBuilder.Entity("Core.Models.Artist", b =>
                {
                    b.HasOne("Core.Models.Genero", null)
                        .WithMany("Artistas")
                        .HasForeignKey("Generoid");
                });

            modelBuilder.Entity("Core.Models.Song", b =>
                {
                    b.HasOne("Core.Models.Artist", "Artista")
                        .WithMany("Canciones")
                        .HasForeignKey("Artistaid");

                    b.HasOne("Core.Models.Genero", "Genero")
                        .WithMany("Canciones")
                        .HasForeignKey("Generoid");
                });
#pragma warning restore 612, 618
        }
    }
}
