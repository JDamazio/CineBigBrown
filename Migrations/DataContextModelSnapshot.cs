﻿// <auto-generated />
using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CineBigBrown.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("API.Models.Cartaz", b =>
                {
                    b.Property<int>("CartazID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("value")
                        .HasColumnType("REAL");

                    b.HasKey("CartazID");

                    b.ToTable("Cartaz");
                });
#pragma warning restore 612, 618
        }
    }
}
