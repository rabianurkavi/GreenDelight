using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_city_district_neigh1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Adresses_AdressID",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "AdresId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "AdressID",
                table: "Orders",
                newName: "AdressId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_AdressID",
                table: "Orders",
                newName: "IX_Orders_AdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Adresses_AdressId",
                table: "Orders",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Adresses_AdressId",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "AdressId",
                table: "Orders",
                newName: "AdressID");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_AdressId",
                table: "Orders",
                newName: "IX_Orders_AdressID");

            migrationBuilder.AddColumn<int>(
                name: "AdresId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Adresses_AdressID",
                table: "Orders",
                column: "AdressID",
                principalTable: "Adresses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
