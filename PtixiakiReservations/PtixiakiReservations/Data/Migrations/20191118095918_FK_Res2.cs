using Microsoft.EntityFrameworkCore.Migrations;

namespace PtixiakiReservations.Data.Migrations
{
    public partial class FK_Res2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "Reservations",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_userId",
                table: "Reservations",
                column: "userId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_AspNetUsers_userId",
                table: "Reservations",
                column: "userId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_AspNetUsers_userId",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_userId",
                table: "Reservations");

            migrationBuilder.AlterColumn<string>(
                name: "userId",
                table: "Reservations",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
