using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cucolas_Anamaria_Lab2.Migrations
{
    public partial class anamaria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Author",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Author",
                newName: "Id");
        }
    }
}
