using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DeviceManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    DeviceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ManufacturDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.DeviceId);
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "Date", "ManufacturDate", "Manufacturer", "Model" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 7, 11, 30, 32, 67, DateTimeKind.Local).AddTicks(7393), new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nothing Technology Limited", "Nothing Phone (2)" },
                    { 2, new DateTime(2024, 7, 7, 11, 30, 32, 67, DateTimeKind.Local).AddTicks(7426), new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnePlus Technology Co., Ltd.", "Oneplus 10 Pro" },
                    { 3, new DateTime(2024, 7, 7, 11, 30, 32, 67, DateTimeKind.Local).AddTicks(7428), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Inc.", "Apple iPhone 15" },
                    { 4, new DateTime(2024, 7, 7, 11, 30, 32, 67, DateTimeKind.Local).AddTicks(7430), new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Electronics Co., Ltd.", "Samsung Galaxy S24 Ultra" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Devices");
        }
    }
}
