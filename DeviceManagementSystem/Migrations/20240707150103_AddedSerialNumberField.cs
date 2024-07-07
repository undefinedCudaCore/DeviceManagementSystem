using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddedSerialNumberField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UniqueSerialNumber",
                table: "Devices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1L,
                columns: new[] { "Date", "UniqueSerialNumber" },
                values: new object[] { new DateTime(2024, 7, 7, 18, 1, 3, 699, DateTimeKind.Local).AddTicks(2078), 0 });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2L,
                columns: new[] { "Date", "UniqueSerialNumber" },
                values: new object[] { new DateTime(2024, 7, 7, 18, 1, 3, 699, DateTimeKind.Local).AddTicks(2111), 0 });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 3L,
                columns: new[] { "Date", "UniqueSerialNumber" },
                values: new object[] { new DateTime(2024, 7, 7, 18, 1, 3, 699, DateTimeKind.Local).AddTicks(2113), 0 });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 4L,
                columns: new[] { "Date", "UniqueSerialNumber" },
                values: new object[] { new DateTime(2024, 7, 7, 18, 1, 3, 699, DateTimeKind.Local).AddTicks(2115), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UniqueSerialNumber",
                table: "Devices");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1L,
                column: "Date",
                value: new DateTime(2024, 7, 7, 13, 2, 11, 127, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2L,
                column: "Date",
                value: new DateTime(2024, 7, 7, 13, 2, 11, 127, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 3L,
                column: "Date",
                value: new DateTime(2024, 7, 7, 13, 2, 11, 127, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 4L,
                column: "Date",
                value: new DateTime(2024, 7, 7, 13, 2, 11, 127, DateTimeKind.Local).AddTicks(664));
        }
    }
}
