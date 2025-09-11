using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class OnetoManyRelationshipBetweenCourseTableAndTopicTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Top_ID",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses",
                column: "Top_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topic_Top_ID",
                table: "Courses",
                column: "Top_ID",
                principalTable: "Topic",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topic_Top_ID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_Top_ID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Top_ID",
                table: "Courses");
        }
    }
}
