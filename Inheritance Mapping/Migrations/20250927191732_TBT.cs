using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Inheritance_Mapping.Migrations
{
    /// <inheritdoc />
    public partial class TBT : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    age = table.Column<int>(type: "int", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FullTimeEmployee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FullTimeEmployee", x => x.id);
                    table.ForeignKey(
                        name: "FK_FullTimeEmployee_Employees_id",
                        column: x => x.id,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PartTimeEmployee",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    HourRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HoursWorked = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartTimeEmployee", x => x.id);
                    table.ForeignKey(
                        name: "FK_PartTimeEmployee_Employees_id",
                        column: x => x.id,
                        principalTable: "Employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FullTimeEmployee");

            migrationBuilder.DropTable(
                name: "PartTimeEmployee");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
