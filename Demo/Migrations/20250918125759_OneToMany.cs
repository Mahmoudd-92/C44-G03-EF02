using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class OneToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Courses_CourseID",
                table: "StudentCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourse_Students_StudentID",
                table: "StudentCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse");

            migrationBuilder.RenameTable(
                name: "StudentCourse",
                newName: "studentCourses");

            migrationBuilder.RenameIndex(
                name: "IX_StudentCourse_CourseID",
                table: "studentCourses",
                newName: "IX_studentCourses_CourseID");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_studentCourses",
                table: "studentCourses",
                columns: new[] { "StudentID", "CourseID" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentID",
                table: "Employees",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Department_DepartmentID",
                table: "Employees",
                column: "DepartmentID",
                principalTable: "Department",
                principalColumn: "DeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_studentCourses_Courses_CourseID",
                table: "studentCourses",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_studentCourses_Students_StudentID",
                table: "studentCourses",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Department_DepartmentID",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_studentCourses_Courses_CourseID",
                table: "studentCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_studentCourses_Students_StudentID",
                table: "studentCourses");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentID",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_studentCourses",
                table: "studentCourses");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "studentCourses",
                newName: "StudentCourse");

            migrationBuilder.RenameIndex(
                name: "IX_studentCourses_CourseID",
                table: "StudentCourse",
                newName: "IX_StudentCourse_CourseID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourse",
                table: "StudentCourse",
                columns: new[] { "StudentID", "CourseID" });

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Courses_CourseID",
                table: "StudentCourse",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourse_Students_StudentID",
                table: "StudentCourse",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
