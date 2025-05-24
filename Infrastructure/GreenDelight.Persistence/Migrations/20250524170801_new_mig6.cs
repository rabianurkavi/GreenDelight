using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class new_mig6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Cities_CityID",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Districts_DistrictID",
                table: "Adresses");

            migrationBuilder.DropIndex(
                name: "IX_Adresses_CityID",
                table: "Adresses");

            migrationBuilder.DropIndex(
                name: "IX_Adresses_DistrictID",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "CityID",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "DistrictID",
                table: "Adresses");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityID",
                table: "Adresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DistrictID",
                table: "Adresses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_CityID",
                table: "Adresses",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_DistrictID",
                table: "Adresses",
                column: "DistrictID");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Cities_CityID",
                table: "Adresses",
                column: "CityID",
                principalTable: "Cities",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Districts_DistrictID",
                table: "Adresses",
                column: "DistrictID",
                principalTable: "Districts",
                principalColumn: "ID");
        }
    }
}
