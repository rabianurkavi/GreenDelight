using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class new_mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "District",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "Neighborhood",
                table: "Adresses");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Adresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DistrictId",
                table: "Adresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NeighborhoodId",
                table: "Adresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_CityId",
                table: "Adresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_DistrictId",
                table: "Adresses",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_NeighborhoodId",
                table: "Adresses",
                column: "NeighborhoodId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Cities_CityId",
                table: "Adresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Districts_DistrictId",
                table: "Adresses",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Neighborhoods_NeighborhoodId",
                table: "Adresses",
                column: "NeighborhoodId",
                principalTable: "Neighborhoods",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Cities_CityId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Districts_DistrictId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Neighborhoods_NeighborhoodId",
                table: "Adresses");

            migrationBuilder.DropIndex(
                name: "IX_Adresses_CityId",
                table: "Adresses");

            migrationBuilder.DropIndex(
                name: "IX_Adresses_DistrictId",
                table: "Adresses");

            migrationBuilder.DropIndex(
                name: "IX_Adresses_NeighborhoodId",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "DistrictId",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "NeighborhoodId",
                table: "Adresses");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Neighborhood",
                table: "Adresses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
