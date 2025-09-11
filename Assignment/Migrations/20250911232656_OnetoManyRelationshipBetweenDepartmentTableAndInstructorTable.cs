using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class OnetoManyRelationshipBetweenDepartmentTableAndInstructorTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dep_Id",
                table: "Instructor",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Dep_Id",
                table: "Instructor",
                column: "Dep_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_Dep_Id",
                table: "Instructor",
                column: "Dep_Id",
                principalTable: "Department",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_Dep_Id",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_Dep_Id",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "Dep_Id",
                table: "Instructor");
        }
    }
}
