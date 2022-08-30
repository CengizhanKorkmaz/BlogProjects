using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Init_Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Comments",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "Blogs",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Comments",
                newName: "Content");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Blogs",
                newName: "Content");
        }
    }
}
