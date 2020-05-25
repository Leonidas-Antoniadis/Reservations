using Microsoft.EntityFrameworkCore.Migrations;

namespace PtixiakiReservations.Migrations
{
    public partial class MiAvaibleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipos",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<bool>(
                name: "Available",
                table: "Table",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Available",
                table: "Table");

            migrationBuilder.AddColumn<string>(
                name: "Tipos",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
