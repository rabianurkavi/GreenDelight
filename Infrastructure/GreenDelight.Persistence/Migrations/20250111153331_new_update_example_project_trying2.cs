using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class new_update_example_project_trying2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "mesai_fk2",
                table: "mesai");

            migrationBuilder.DropIndex(
                name: "IX_mesai_personel_no",
                table: "mesai");

            migrationBuilder.AddColumn<int>(
                name: "PersonelId",
                table: "mesai",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_mesai_PersonelId",
                table: "mesai",
                column: "PersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_mesai_personel_PersonelId",
                table: "mesai",
                column: "PersonelId",
                principalTable: "personel",
                principalColumn: "personel_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_mesai_personel_PersonelId",
                table: "mesai");

            migrationBuilder.DropIndex(
                name: "IX_mesai_PersonelId",
                table: "mesai");

            migrationBuilder.DropColumn(
                name: "PersonelId",
                table: "mesai");

            migrationBuilder.CreateIndex(
                name: "IX_mesai_personel_no",
                table: "mesai",
                column: "personel_no");

            migrationBuilder.AddForeignKey(
                name: "mesai_fk2",
                table: "mesai",
                column: "personel_no",
                principalTable: "personel",
                principalColumn: "personel_no");
        }
    }
}
