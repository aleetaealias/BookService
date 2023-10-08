﻿// <auto-generated />
using System;
using BookService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookService.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231008143655_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookService.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RegistrationTimeStamp")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "test11",
                            Category = "test111",
                            Description = "test1111",
                            Name = "test1",
                            RegistrationTimeStamp = new DateTime(2023, 10, 8, 15, 36, 55, 446, DateTimeKind.Local).AddTicks(5)
                        },
                        new
                        {
                            Id = 2,
                            Author = "test22",
                            Category = "test222",
                            Description = "test2222",
                            Name = "test2",
                            RegistrationTimeStamp = new DateTime(2023, 10, 8, 15, 36, 55, 446, DateTimeKind.Local).AddTicks(48)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
