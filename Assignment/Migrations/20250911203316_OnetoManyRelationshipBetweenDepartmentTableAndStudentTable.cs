using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class OnetoManyRelationshipBetweenDepartmentTableAndStudentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dep_ID",
                table: "Student",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Student_Dep_ID",
                table: "Student",
                column: "Dep_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_Dep_ID",
                table: "Student",
                column: "Dep_ID",
                principalTable: "Department",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_Dep_ID",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_Dep_ID",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "Dep_ID",
                table: "Student");
        }
    }
}
