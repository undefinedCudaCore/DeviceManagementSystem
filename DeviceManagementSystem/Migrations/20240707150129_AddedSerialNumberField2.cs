using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeviceManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddedSerialNumberField2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UniqueSerialNumber",
                table: "Devices",
                type: "int",
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 5);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1L,
                column: "Date",
                value: new DateTime(2024, 7, 7, 18, 1, 28, 894, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2L,
                column: "Date",
                value: new DateTime(2024, 7, 7, 18, 1, 28, 894, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 3L,
                column: "Date",
                value: new DateTime(2024, 7, 7, 18, 1, 28, 894, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 4L,
                column: "Date",
                value: new DateTime(2024, 7, 7, 18, 1, 28, 894, DateTimeKind.Local).AddTicks(292));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UniqueSerialNumber",
                table: "Devices",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 11)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1L,
                column: "Date",
                value: new DateTime(2024, 7, 7, 18, 1, 3, 699, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2L,
                column: "Date",
                value: new DateTime(2024, 7, 7, 18, 1, 3, 699, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 3L,
                column: "Date",
                value: new DateTime(2024, 7, 7, 18, 1, 3, 699, DateTimeKind.Local).AddTicks(2113));

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 4L,
                column: "Date",
                value: new DateTime(2024, 7, 7, 18, 1, 3, 699, DateTimeKind.Local).AddTicks(2115));
        }
    }
}
