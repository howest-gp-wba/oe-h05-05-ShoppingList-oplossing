﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingListWebApp.Data;

#nullable disable

namespace ShoppingListWebApp.Migrations
{
    [DbContext(typeof(ShoppingListContext))]
    [Migration("20230423161431_AddedSeeding")]
    partial class AddedSeeding
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ClassLib.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Food"
                        });
                });

            modelBuilder.Entity("ClassLib.Entities.ShopItem", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(2)
                        .HasColumnType("decimal(2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("ShopItems");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryId = 1,
                            Name = "Tomaat",
                            Quantity = 4,
                            UnitPrice = 0m
                        });
                });

            modelBuilder.Entity("ClassLib.Entities.ShopItem", b =>
                {
                    b.HasOne("ClassLib.Entities.Category", "Category")
                        .WithMany("ShopItems")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ClassLib.Entities.Category", b =>
                {
                    b.Navigation("ShopItems");
                });
#pragma warning restore 612, 618
        }
    }
}
