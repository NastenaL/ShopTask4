﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopTask4.Data;

namespace ShopTask4.Migrations
{
    [DbContext(typeof(AddDBContent))]
    [Migration("20200922141613_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShopTask4.Data.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Avaitable");

                    b.Property<int>("CategoryId");

                    b.Property<string>("Image");

                    b.Property<bool>("IsFavourite");

                    b.Property<string>("LongDescription");

                    b.Property<string>("Name");

                    b.Property<int>("Price");

                    b.Property<string>("ShortDescription");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("ShopTask4.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Description");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ShopTask4.Data.Models.Car", b =>
                {
                    b.HasOne("ShopTask4.Data.Models.Category", "Category")
                        .WithMany("Cars")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
