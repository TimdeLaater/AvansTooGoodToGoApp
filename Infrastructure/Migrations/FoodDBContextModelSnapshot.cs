﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(FoodDBContext))]
    partial class FoodDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DomainModel.Models.Canteen", b =>
                {
                    b.Property<int>("canteenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("canteenId"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ServesHot")
                        .HasColumnType("bit");

                    b.Property<int>("city")
                        .HasColumnType("int");

                    b.HasKey("canteenId");

                    b.ToTable("Canteen");

                    b.HasData(
                        new
                        {
                            canteenId = 44,
                            Name = "LA",
                            ServesHot = true,
                            city = 1
                        },
                        new
                        {
                            canteenId = 45,
                            Name = "LD",
                            ServesHot = true,
                            city = 1
                        },
                        new
                        {
                            canteenId = 46,
                            Name = "HA",
                            ServesHot = true,
                            city = 1
                        },
                        new
                        {
                            canteenId = 47,
                            Name = "HA",
                            ServesHot = true,
                            city = 2
                        },
                        new
                        {
                            canteenId = 48,
                            Name = "HA",
                            ServesHot = true,
                            city = 3
                        });
                });

            modelBuilder.Entity("DomainModel.Models.Package", b =>
                {
                    b.Property<int>("PackageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PackageId"), 1L, 1);

                    b.Property<bool>("Alcohol")
                        .HasColumnType("bit");

                    b.Property<int>("MealType")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("canteenId")
                        .HasColumnType("int");

                    b.Property<bool>("collected")
                        .HasColumnType("bit");

                    b.Property<DateTime>("orderPickup")
                        .HasColumnType("datetime2");

                    b.HasKey("PackageId");

                    b.HasIndex("StudentId");

                    b.HasIndex("canteenId");

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("DomainModel.Models.Package_Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("PackageId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("ProductId");

                    b.ToTable("package_Products");
                });

            modelBuilder.Entity("DomainModel.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<bool>("Alcohol")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 69,
                            Alcohol = false,
                            Name = "KaasoufleeBitch"
                        },
                        new
                        {
                            ProductId = 99,
                            Alcohol = false,
                            Name = "Brie"
                        });
                });

            modelBuilder.Entity("DomainModel.Models.StudentModel", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("BirthDay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("City")
                        .HasColumnType("int");

                    b.Property<int>("NotCollected")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentNr")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Email");

                    b.ToTable("StudentModel");
                });

            modelBuilder.Entity("DomainModel.Models.Package", b =>
                {
                    b.HasOne("DomainModel.Models.StudentModel", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId");

                    b.HasOne("DomainModel.Models.Canteen", "Canteen")
                        .WithMany()
                        .HasForeignKey("canteenId");

                    b.Navigation("Canteen");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("DomainModel.Models.Package_Product", b =>
                {
                    b.HasOne("DomainModel.Models.Package", "Package")
                        .WithMany("Package_Product")
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DomainModel.Models.Product", "Product")
                        .WithMany("Package_Product")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Package");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DomainModel.Models.Package", b =>
                {
                    b.Navigation("Package_Product");
                });

            modelBuilder.Entity("DomainModel.Models.Product", b =>
                {
                    b.Navigation("Package_Product");
                });
#pragma warning restore 612, 618
        }
    }
}
