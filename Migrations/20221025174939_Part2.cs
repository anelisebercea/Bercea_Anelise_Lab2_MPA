using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bercea_Anelise_Lab2_MPA.Migrations
{
    public partial class Part2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Author",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Author",
                newName: "ID");
        }
    }
}
