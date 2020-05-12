﻿// <auto-generated />
using System;
using EntityFramework.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFramework.Migrations
{
    [DbContext(typeof(BoekContext))]
    [Migration("20200512151845_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFramework.Model.Auteur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BoekId")
                        .HasColumnType("int");

                    b.Property<string>("EmailContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BoekId");

                    b.ToTable("Auteurs");
                });

            modelBuilder.Entity("EntityFramework.Model.Boek", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UitgeverijId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UitgeverijId");

                    b.ToTable("Boeken");
                });

            modelBuilder.Entity("EntityFramework.Model.Uitgeverij", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Uitgeverijen");
                });

            modelBuilder.Entity("EntityFramework.Model.Auteur", b =>
                {
                    b.HasOne("EntityFramework.Model.Boek", null)
                        .WithMany("Auteurs")
                        .HasForeignKey("BoekId");
                });

            modelBuilder.Entity("EntityFramework.Model.Boek", b =>
                {
                    b.HasOne("EntityFramework.Model.Uitgeverij", "Uitgeverij")
                        .WithMany()
                        .HasForeignKey("UitgeverijId");
                });
#pragma warning restore 612, 618
        }
    }
}
