using Microsoft.EntityFrameworkCore.Migrations;

namespace PtixiakiReservations.Migrations
{
    public partial class TablePeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "people",
                table: "Table",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "x",
                table: "Table",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "y",
                table: "Table",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "people",
                table: "Table");

            migrationBuilder.DropColumn(
                name: "x",
                table: "Table");

            migrationBuilder.DropColumn(
                name: "y",
                table: "Table");
        }
    }
}
