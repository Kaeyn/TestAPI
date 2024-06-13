﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VLUTESTAPI.Models;

namespace VLUTESTAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VLUTESTAPI.Models.Brand", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BrandName")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<string>("IdBrand")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.HasKey("Code")
                        .HasName("PRIMARY");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("VLUTESTAPI.Models.Category", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CategoryName")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<string>("IdCategory")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<string>("ParentId")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.HasKey("Code")
                        .HasName("PRIMARY");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("VLUTESTAPI.Models.Customer", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Avartar")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<DateTime?>("Birth")
                        .HasColumnType("date");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IdUser")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.HasKey("Code")
                        .HasName("PRIMARY");

                    b.HasIndex("IdUser")
                        .HasName("FkUser_IdUser_idx");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("VLUTESTAPI.Models.Employee", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Avartar")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<DateTime?>("Birth")
                        .HasColumnType("date");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IdUser")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.HasKey("Code")
                        .HasName("PRIMARY");

                    b.HasIndex("IdUser")
                        .HasName("FkEmployee_User_IdUser_idx");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("VLUTESTAPI.Models.Product", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("IdProduct")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.HasKey("Code")
                        .HasName("PRIMARY");

                    b.HasIndex("IdProduct")
                        .IsUnique()
                        .HasName("IdProduct_UNIQUE");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("VLUTESTAPI.Models.User", b =>
                {
                    b.Property<int>("Code")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("varchar(45)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<DateTime?>("Birth")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasColumnType("varchar(100)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<int?>("Gender")
                        .HasColumnType("int")
                        .HasComment(@"0: Male;
1: Female;");

                    b.Property<string>("IdUser")
                        .IsRequired()
                        .HasColumnType("varchar(10)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(100)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<int>("Permission")
                        .HasColumnType("int")
                        .HasComment(@"0: Customer;
1: Admin;
2: Staff;");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(13)")
                        .HasAnnotation("MySql:CharSet", "utf8mb4")
                        .HasAnnotation("MySql:Collation", "utf8mb4_0900_ai_ci");

                    b.Property<int>("Status")
                        .HasColumnType("int")
                        .HasComment(@"0: Normal;
1: Blocked;");

                    b.HasKey("Code")
                        .HasName("PRIMARY");

                    b.HasIndex("IdUser")
                        .IsUnique()
                        .HasName("idUser_UNIQUE");

                    b.ToTable("User");
                });

            modelBuilder.Entity("VLUTESTAPI.Models.Customer", b =>
                {
                    b.HasOne("VLUTESTAPI.Models.User", "IdUserNavigation")
                        .WithMany("Customer")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("FkCustomer_User_IdUser")
                        .HasPrincipalKey("IdUser")
                        .IsRequired();
                });

            modelBuilder.Entity("VLUTESTAPI.Models.Employee", b =>
                {
                    b.HasOne("VLUTESTAPI.Models.User", "IdUserNavigation")
                        .WithMany("Employee")
                        .HasForeignKey("IdUser")
                        .HasConstraintName("FkEmployee_User_IdUser")
                        .HasPrincipalKey("IdUser")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
