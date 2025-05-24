using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class new_mig3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Cities_CityId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Districts_DistrictId",
                table: "Adresses");

            migrationBuilder.RenameColumn(
                name: "DistrictId",
                table: "Adresses",
                newName: "DistrictID");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Adresses",
                newName: "CityID");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_DistrictId",
                table: "Adresses",
                newName: "IX_Adresses_DistrictID");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_CityId",
                table: "Adresses",
                newName: "IX_Adresses_CityID");

            migrationBuilder.AlterColumn<int>(
                name: "DistrictID",
                table: "Adresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CityID",
                table: "Adresses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Cities_CityID",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Districts_DistrictID",
                table: "Adresses");

            migrationBuilder.RenameColumn(
                name: "DistrictID",
                table: "Adresses",
                newName: "DistrictId");

            migrationBuilder.RenameColumn(
                name: "CityID",
                table: "Adresses",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_DistrictID",
                table: "Adresses",
                newName: "IX_Adresses_DistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_CityID",
                table: "Adresses",
                newName: "IX_Adresses_CityId");

            migrationBuilder.AlterColumn<int>(
                name: "DistrictId",
                table: "Adresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CityId",
                table: "Adresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Cities_CityId",
                table: "Adresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Districts_DistrictId",
                table: "Adresses",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
