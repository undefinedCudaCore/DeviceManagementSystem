﻿// <auto-generated />
using System;
using DeviceManagementSystem.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DeviceManagementSystem.Migrations
{
    [DbContext(typeof(DeviceContext))]
    [Migration("20240707100211_ChangedPropName")]
    partial class ChangedPropName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DeviceManagementSystem.Models.Device", b =>
                {
                    b.Property<long>("DeviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(1);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("DeviceId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime");

                    b.Property<DateTime>("ManufactureDate")
                        .HasColumnType("datetime")
                        .HasColumnOrder(4);

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnOrder(3);

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnOrder(2);

                    b.HasKey("DeviceId");

                    b.ToTable("Devices");

                    b.HasData(
                        new
                        {
                            DeviceId = 1L,
                            Date = new DateTime(2024, 7, 7, 13, 2, 11, 127, DateTimeKind.Local).AddTicks(627),
                            ManufactureDate = new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Manufacturer = "Nothing Technology Limited",
                            Model = "Nothing Phone (2)"
                        },
                        new
                        {
                            DeviceId = 2L,
                            Date = new DateTime(2024, 7, 7, 13, 2, 11, 127, DateTimeKind.Local).AddTicks(661),
                            ManufactureDate = new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Manufacturer = "OnePlus Technology Co., Ltd.",
                            Model = "Oneplus 10 Pro"
                        },
                        new
                        {
                            DeviceId = 3L,
                            Date = new DateTime(2024, 7, 7, 13, 2, 11, 127, DateTimeKind.Local).AddTicks(663),
                            ManufactureDate = new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Manufacturer = "Apple Inc.",
                            Model = "Apple iPhone 15"
                        },
                        new
                        {
                            DeviceId = 4L,
                            Date = new DateTime(2024, 7, 7, 13, 2, 11, 127, DateTimeKind.Local).AddTicks(664),
                            ManufactureDate = new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Manufacturer = "Samsung Electronics Co., Ltd.",
                            Model = "Samsung Galaxy S24 Ultra"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
