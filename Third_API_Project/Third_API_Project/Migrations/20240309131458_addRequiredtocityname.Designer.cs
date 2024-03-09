﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Third_API_Project.Data;

#nullable disable

namespace Third_API_Project.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240309131458_addRequiredtocityname")]
    partial class addRequiredtocityname
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Third_API_Project.Models.City", b =>
                {
                    b.Property<Guid>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityID");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityID = new Guid("c21c766c-70e3-452d-b9c4-703f86b364c3"),
                            CityName = "Jaipur"
                        },
                        new
                        {
                            CityID = new Guid("a6b2e063-f834-416e-a3d3-196be16205af"),
                            CityName = "Jaisalmer"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
