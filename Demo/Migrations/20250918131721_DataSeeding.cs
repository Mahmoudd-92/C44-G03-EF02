using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DeptId", "DateOfCreation", "Department Name" },
                values: new object[,]
                {
                    { 10, new DateTime(2025, 9, 18, 16, 17, 21, 249, DateTimeKind.Local).AddTicks(3697), "HR" },
                    { 20, new DateTime(2025, 9, 18, 16, 17, 21, 249, DateTimeKind.Local).AddTicks(3754), "PR" },
                    { 30, new DateTime(2025, 9, 18, 16, 17, 21, 249, DateTimeKind.Local).AddTicks(3756), "Sales" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DeptId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DeptId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "DeptId",
                keyValue: 30);
        }
    }
}
