using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_city_district_neigh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdresId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdressID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AdressID",
                table: "Orders",
                column: "AdressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Adresses_AdressID",
                table: "Orders",
                column: "AdressID",
                principalTable: "Adresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Adresses_AdressID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AdressID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AdresId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AdressID",
                table: "Orders");
        }
    }
}
