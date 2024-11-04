﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dotnet.Common.Data;

#nullable disable

namespace dotnet.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241102210045_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("dotnet.Features.TemperatureSensor.Models.TemperatureSensor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("CurrentTemperature")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("LastReadingTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("TemperatureSensors");
                });
#pragma warning restore 612, 618
        }
    }
}
