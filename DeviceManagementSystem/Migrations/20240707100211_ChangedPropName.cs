using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DeviceManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class ChangedPropName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "ManufacturDate",
                table: "Devices",
                newName: "ManufactureDate");

            migrationBuilder.AlterColumn<long>(
                name: "DeviceId",
                table: "Devices",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "Date", "ManufactureDate", "Manufacturer", "Model" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 7, 7, 13, 2, 11, 127, DateTimeKind.Local).AddTicks(627), new DateTime(2023, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nothing Technology Limited", "Nothing Phone (2)" },
                    { 2L, new DateTime(2024, 7, 7, 13, 2, 11, 127, DateTimeKind.Local).AddTicks(661), new DateTime(2022, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "OnePlus Technology Co., Ltd.", "Oneplus 10 Pro" },
                    { 3L, new DateTime(2024, 7, 7, 13, 2, 11, 127, DateTimeKind.Local).AddTicks(663), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple Inc.", "Apple iPhone 15" },
                    { 4L, new DateTime(2024, 7, 7, 13, 2, 11, 127, DateTimeKind.Local).AddTicks(664), new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung Electronics Co., Ltd.", "Samsung Galaxy S24 Ultra" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 4L);

            migrationBuilder.RenameColumn(
                name: "ManufactureDate",
                table: "Devices",
                newName: "ManufacturDate");

            migrationBuilder.AlterColumn<int>(
                name: "DeviceId",
                table: "Devices",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1");

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
    }
}
