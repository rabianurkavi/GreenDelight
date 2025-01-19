using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_new_property_example_project2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vardiya_VardiyaSablon_VardiyaSablonId1",
                table: "vardiya");

            migrationBuilder.DropForeignKey(
                name: "fk_vardiya_vardiya_sablon_id",
                table: "vardiya");

            migrationBuilder.DropIndex(
                name: "IX_vardiya_VardiyaSablonId1",
                table: "vardiya");

            migrationBuilder.DropColumn(
                name: "VardiyaSablonId1",
                table: "vardiya");

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

            migrationBuilder.AddForeignKey(
                name: "fk_vardiya_vardiya_sablon_id",
                table: "vardiya",
                column: "vardiya_sablon_id",
                principalTable: "VardiyaSablon",
                principalColumn: "VardiyaSablonId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vardiya_vardiya_sablon_yer_VardiyaSablonYerId",
                table: "vardiya");

            migrationBuilder.DropForeignKey(
                name: "fk_vardiya_vardiya_sablon_id",
                table: "vardiya");

            migrationBuilder.DropIndex(
                name: "IX_vardiya_VardiyaSablonYerId",
                table: "vardiya");

            migrationBuilder.DropColumn(
                name: "VardiyaSablonYerId",
                table: "vardiya");

            migrationBuilder.AddColumn<int>(
                name: "VardiyaSablonId1",
                table: "vardiya",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_vardiya_VardiyaSablonId1",
                table: "vardiya",
                column: "VardiyaSablonId1");

            migrationBuilder.AddForeignKey(
                name: "FK_vardiya_VardiyaSablon_VardiyaSablonId1",
                table: "vardiya",
                column: "VardiyaSablonId1",
                principalTable: "VardiyaSablon",
                principalColumn: "VardiyaSablonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_vardiya_vardiya_sablon_id",
                table: "vardiya",
                column: "vardiya_sablon_id",
                principalTable: "vardiya_sablon_yer",
                principalColumn: "vardiya_sablon_yer_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
