﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using iPantry;

#nullable disable

namespace iPantry.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230124001524_servicesupdated")]
    partial class servicesupdated
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("iPantry.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("iPantry.Models.IngredientItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"), 1L, 1);

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("weight")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("RecipeId");

                    b.ToTable("ingredientItems");
                });

            modelBuilder.Entity("iPantry.Models.Pantry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("pantries");
                });

            modelBuilder.Entity("iPantry.Models.PantryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PantryId")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("PantryId");

                    b.ToTable("PantryItems");
                });

            modelBuilder.Entity("iPantry.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Instruction")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("recipes");
                });

            modelBuilder.Entity("iPantry.Models.IngredientItem", b =>
                {
                    b.HasOne("iPantry.Models.Recipe", null)
                        .WithMany("Item")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("iPantry.Models.Pantry", b =>
                {
                    b.HasOne("iPantry.Models.Account", null)
                        .WithMany("pantries")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("iPantry.Models.PantryItem", b =>
                {
                    b.HasOne("iPantry.Models.Pantry", null)
                        .WithMany("pantryItems")
                        .HasForeignKey("PantryId");
                });

            modelBuilder.Entity("iPantry.Models.Recipe", b =>
                {
                    b.HasOne("iPantry.Models.Account", null)
                        .WithMany("recipes")
                        .HasForeignKey("AccountId");
                });

            modelBuilder.Entity("iPantry.Models.Account", b =>
                {
                    b.Navigation("pantries");

                    b.Navigation("recipes");
                });

            modelBuilder.Entity("iPantry.Models.Pantry", b =>
                {
                    b.Navigation("pantryItems");
                });

            modelBuilder.Entity("iPantry.Models.Recipe", b =>
                {
                    b.Navigation("Item");
                });
#pragma warning restore 612, 618
        }
    }
}