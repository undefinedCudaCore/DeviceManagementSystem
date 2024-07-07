using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddedSerialNumberDeviceClassProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SerialNumber",
                table: "Devices",
                type: "int",
                maxLength: 11,
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1L,
                columns: new[] { "Date", "SerialNumber" },
                values: new object[] { new DateTime(2024, 7, 7, 17, 25, 49, 802, DateTimeKind.Local).AddTicks(9091), 0 });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2L,
                columns: new[] { "Date", "SerialNumber" },
                values: new object[] { new DateTime(2024, 7, 7, 17, 25, 49, 802, DateTimeKind.Local).AddTicks(9123), 0 });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 3L,
                columns: new[] { "Date", "SerialNumber" },
                values: new object[] { new DateTime(2024, 7, 7, 17, 25, 49, 802, DateTimeKind.Local).AddTicks(9125), 0 });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 4L,
                columns: new[] { "Date", "SerialNumber" },
                values: new object[] { new DateTime(2024, 7, 7, 17, 25, 49, 802, DateTimeKind.Local).AddTicks(9126), 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SerialNumber",
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
