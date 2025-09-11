using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class OnetoManyRelationshipBetweenInstructorTableAndDepartmentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Ins_Id",
                table: "Department",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Department_Ins_Id",
                table: "Department",
                column: "Ins_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_Ins_Id",
                table: "Department",
                column: "Ins_Id",
                principalTable: "Instructor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_Ins_Id",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_Ins_Id",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "Ins_Id",
                table: "Department");
        }
    }
}
