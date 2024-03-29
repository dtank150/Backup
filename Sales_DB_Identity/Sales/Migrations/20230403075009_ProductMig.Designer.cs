﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sales.Models;

namespace Sales.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230403075009_ProductMig")]
    partial class ProductMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sales.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Soap"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Shampoo"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Body Spray"
                        });
                });

            modelBuilder.Entity("Sales.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CatId")
                        .HasColumnType("int");

                    b.Property<bool>("ISActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Profile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CatId = 1,
                            ISActive = true,
                            Name = "Lux",
                            Qty = 10,
                            Rate = 50
                        },
                        new
                        {
                            Id = 2,
                            CatId = 1,
                            ISActive = true,
                            Name = "Dove",
                            Qty = 12,
                            Rate = 55
                        },
                        new
                        {
                            Id = 3,
                            CatId = 2,
                            ISActive = true,
                            Name = "Santoor",
                            Qty = 10,
                            Rate = 105
                        },
                        new
                        {
                            Id = 4,
                            CatId = 2,
                            ISActive = true,
                            Name = "Nyle",
                            Qty = 15,
                            Rate = 200
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
