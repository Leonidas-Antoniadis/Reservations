using Microsoft.EntityFrameworkCore.Migrations;

namespace PtixiakiReservations.Migrations
{
    public partial class TableFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Table_Reservations_ReservationId",
                table: "Table");

            migrationBuilder.DropIndex(
                name: "IX_Table_ReservationId",
                table: "Table");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_tableId",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "ReservationId",
                table: "Table");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_tableId",
                table: "Reservations",
                column: "tableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Reservations_tableId",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "ReservationId",
                table: "Table",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Table_ReservationId",
                table: "Table",
                column: "ReservationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_tableId",
                table: "Reservations",
                column: "tableId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Reservations_ReservationId",
                table: "Table",
                column: "ReservationId",
                principalTable: "Reservations",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
