using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_new_property_example_project3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vardiya_vardiya_sablon_yer_VardiyaSablonYerId",
                table: "vardiya");

            migrationBuilder.DropIndex(
                name: "IX_vardiya_VardiyaSablonYerId",
                table: "vardiya");

            migrationBuilder.DropColumn(
                name: "VardiyaSablonYerId",
                table: "vardiya");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VardiyaSablonYerId",
                table: "vardiya",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_vardiya_VardiyaSablonYerId",
                table: "vardiya",
                column: "VardiyaSablonYerId");

            migrationBuilder.AddForeignKey(
                name: "FK_vardiya_vardiya_sablon_yer_VardiyaSablonYerId",
                table: "vardiya",
                column: "VardiyaSablonYerId",
                principalTable: "vardiya_sablon_yer",
                principalColumn: "vardiya_sablon_yer_id");
        }
    }
}
