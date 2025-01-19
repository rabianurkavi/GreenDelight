using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_new_property_example_projectt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vardiya_VardiyaSablon_VardiyaSablonId1",
                table: "vardiya");

            migrationBuilder.AddColumn<bool>(
                name: "BirimeOzgu",
                table: "VardiyaSablon",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "VardiyaSablonId1",
                table: "vardiya",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_vardiya_VardiyaSablon_VardiyaSablonId1",
                table: "vardiya",
                column: "VardiyaSablonId1",
                principalTable: "VardiyaSablon",
                principalColumn: "VardiyaSablonId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vardiya_VardiyaSablon_VardiyaSablonId1",
                table: "vardiya");

            migrationBuilder.DropColumn(
                name: "BirimeOzgu",
                table: "VardiyaSablon");

            migrationBuilder.AlterColumn<int>(
                name: "VardiyaSablonId1",
                table: "vardiya",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_vardiya_VardiyaSablon_VardiyaSablonId1",
                table: "vardiya",
                column: "VardiyaSablonId1",
                principalTable: "VardiyaSablon",
                principalColumn: "VardiyaSablonId");
        }
    }
}
