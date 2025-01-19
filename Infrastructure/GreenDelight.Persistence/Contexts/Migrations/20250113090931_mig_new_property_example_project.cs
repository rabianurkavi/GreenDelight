using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_new_property_example_project : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "max_vardiya",
                table: "vardiya_sablon_yer");

            migrationBuilder.DropColumn(
                name: "tanim",
                table: "vardiya_sablon_yer");

            migrationBuilder.AddColumn<int>(
                name: "VardiyaSablonId",
                table: "vardiya_sablon_yer",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VardiyaSablonId1",
                table: "vardiya",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "VardiyaSablon",
                columns: table => new
                {
                    VardiyaSablonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VardiyaSablonTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxVardiya = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VardiyaSablon", x => x.VardiyaSablonId);
                });

            migrationBuilder.CreateTable(
                name: "VardiyaSablonIstasyonBirim",
                columns: table => new
                {
                    VardiyaSablonIstasyonBirimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VardiyaSablonId = table.Column<int>(type: "int", nullable: false),
                    IstasyonBirimId = table.Column<int>(type: "int", nullable: false),
                    VardiyaSayisi = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VardiyaSablonIstasyonBirim", x => x.VardiyaSablonIstasyonBirimId);
                    table.ForeignKey(
                        name: "FK_VardiyaSablonIstasyonBirim_VardiyaSablon_VardiyaSablonId",
                        column: x => x.VardiyaSablonId,
                        principalTable: "VardiyaSablon",
                        principalColumn: "VardiyaSablonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VardiyaSablonIstasyonBirim_istasyon_birim_IstasyonBirimId",
                        column: x => x.IstasyonBirimId,
                        principalTable: "istasyon_birim",
                        principalColumn: "istasyon_birim_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VardiyaSablonMasa",
                columns: table => new
                {
                    VardiyaSablonMasaId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VardiyaSablonId = table.Column<int>(type: "int", nullable: false),
                    MasaId = table.Column<short>(type: "smallint", nullable: false),
                    VardiyaSayisi = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VardiyaSablonMasa", x => x.VardiyaSablonMasaId);
                    table.ForeignKey(
                        name: "FK_VardiyaSablonMasa_VardiyaSablon_VardiyaSablonId",
                        column: x => x.VardiyaSablonId,
                        principalTable: "VardiyaSablon",
                        principalColumn: "VardiyaSablonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VardiyaSablonMasa_masa_MasaId",
                        column: x => x.MasaId,
                        principalTable: "masa",
                        principalColumn: "masa_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_vardiya_sablon_yer_VardiyaSablonId",
                table: "vardiya_sablon_yer",
                column: "VardiyaSablonId");

            migrationBuilder.CreateIndex(
                name: "IX_vardiya_VardiyaSablonId1",
                table: "vardiya",
                column: "VardiyaSablonId1");

            migrationBuilder.CreateIndex(
                name: "IX_VardiyaSablonIstasyonBirim_IstasyonBirimId",
                table: "VardiyaSablonIstasyonBirim",
                column: "IstasyonBirimId");

            migrationBuilder.CreateIndex(
                name: "IX_VardiyaSablonIstasyonBirim_VardiyaSablonId",
                table: "VardiyaSablonIstasyonBirim",
                column: "VardiyaSablonId");

            migrationBuilder.CreateIndex(
                name: "IX_VardiyaSablonMasa_MasaId",
                table: "VardiyaSablonMasa",
                column: "MasaId");

            migrationBuilder.CreateIndex(
                name: "IX_VardiyaSablonMasa_VardiyaSablonId",
                table: "VardiyaSablonMasa",
                column: "VardiyaSablonId");

            migrationBuilder.AddForeignKey(
                name: "FK_vardiya_VardiyaSablon_VardiyaSablonId1",
                table: "vardiya",
                column: "VardiyaSablonId1",
                principalTable: "VardiyaSablon",
                principalColumn: "VardiyaSablonId");

            migrationBuilder.AddForeignKey(
                name: "vardiya_sablon_yer_fk_2",
                table: "vardiya_sablon_yer",
                column: "VardiyaSablonId",
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

            migrationBuilder.DropForeignKey(
                name: "vardiya_sablon_yer_fk_2",
                table: "vardiya_sablon_yer");

            migrationBuilder.DropTable(
                name: "VardiyaSablonIstasyonBirim");

            migrationBuilder.DropTable(
                name: "VardiyaSablonMasa");

            migrationBuilder.DropTable(
                name: "VardiyaSablon");

            migrationBuilder.DropIndex(
                name: "IX_vardiya_sablon_yer_VardiyaSablonId",
                table: "vardiya_sablon_yer");

            migrationBuilder.DropIndex(
                name: "IX_vardiya_VardiyaSablonId1",
                table: "vardiya");

            migrationBuilder.DropColumn(
                name: "VardiyaSablonId",
                table: "vardiya_sablon_yer");

            migrationBuilder.DropColumn(
                name: "VardiyaSablonId1",
                table: "vardiya");

            migrationBuilder.AddColumn<short>(
                name: "max_vardiya",
                table: "vardiya_sablon_yer",
                type: "smallint",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<string>(
                name: "tanim",
                table: "vardiya_sablon_yer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
