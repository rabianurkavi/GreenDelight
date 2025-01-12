using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_new_example_project2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_vardiya_vardiya_sablon_yer_vardiya_sablon_id",
                table: "vardiya");

            migrationBuilder.DropForeignKey(
                name: "fk_vardiya_vardiya_sablon_id",
                table: "vardiya");

            migrationBuilder.DropTable(
                name: "vardiya_sablon_masa");

            migrationBuilder.DropTable(
                name: "VardiyaSablonIstasyonBirim");

            migrationBuilder.DropTable(
                name: "vardiya_sablon");

            migrationBuilder.AddForeignKey(
                name: "fk_vardiya_vardiya_sablon_id",
                table: "vardiya",
                column: "vardiya_sablon_id",
                principalTable: "vardiya_sablon_yer",
                principalColumn: "vardiya_sablon_yer_id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_vardiya_vardiya_sablon_id",
                table: "vardiya");

            migrationBuilder.CreateTable(
                name: "vardiya_sablon",
                columns: table => new
                {
                    vardiya_sablon_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    max_vardiya = table.Column<short>(type: "smallint", nullable: false),
                    vardiya_sablon_tanim = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VardiyaSablon", x => x.vardiya_sablon_id);
                });

            migrationBuilder.CreateTable(
                name: "vardiya_sablon_masa",
                columns: table => new
                {
                    vardiya_sablon_masa_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    masa_id = table.Column<short>(type: "smallint", nullable: false),
                    vardiya_sablon_id = table.Column<int>(type: "int", nullable: false),
                    baslangic_tarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    bitis_tarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    vardiya_sayisi = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VardiyaSablonMasa", x => x.vardiya_sablon_masa_id);
                    table.ForeignKey(
                        name: "FK_vardiya_sablon_masa_masa_masa_id",
                        column: x => x.masa_id,
                        principalTable: "masa",
                        principalColumn: "masa_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vardiya_sablon_masa_vardiya_sablon_vardiya_sablon_id",
                        column: x => x.vardiya_sablon_id,
                        principalTable: "vardiya_sablon",
                        principalColumn: "vardiya_sablon_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VardiyaSablonIstasyonBirim",
                columns: table => new
                {
                    VardiyaSablonIstasyonBirimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IstasyonBirimId = table.Column<int>(type: "int", nullable: false),
                    VardiyaSablonId = table.Column<int>(type: "int", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VardiyaSayisi = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VardiyaSablonIstasyonBirim", x => x.VardiyaSablonIstasyonBirimId);
                    table.ForeignKey(
                        name: "FK_VardiyaSablonIstasyonBirim_istasyon_birim_IstasyonBirimId",
                        column: x => x.IstasyonBirimId,
                        principalTable: "istasyon_birim",
                        principalColumn: "istasyon_birim_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VardiyaSablonIstasyonBirim_vardiya_sablon_VardiyaSablonId",
                        column: x => x.VardiyaSablonId,
                        principalTable: "vardiya_sablon",
                        principalColumn: "vardiya_sablon_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_vardiya_sablon_masa_masa_id",
                table: "vardiya_sablon_masa",
                column: "masa_id");

            migrationBuilder.CreateIndex(
                name: "IX_vardiya_sablon_masa_vardiya_sablon_id",
                table: "vardiya_sablon_masa",
                column: "vardiya_sablon_id");

            migrationBuilder.CreateIndex(
                name: "IX_VardiyaSablonIstasyonBirim_IstasyonBirimId",
                table: "VardiyaSablonIstasyonBirim",
                column: "IstasyonBirimId");

            migrationBuilder.CreateIndex(
                name: "IX_VardiyaSablonIstasyonBirim_VardiyaSablonId",
                table: "VardiyaSablonIstasyonBirim",
                column: "VardiyaSablonId");

            migrationBuilder.AddForeignKey(
                name: "FK_vardiya_vardiya_sablon_yer_vardiya_sablon_id",
                table: "vardiya",
                column: "vardiya_sablon_id",
                principalTable: "vardiya_sablon_yer",
                principalColumn: "vardiya_sablon_yer_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_vardiya_vardiya_sablon_id",
                table: "vardiya",
                column: "vardiya_sablon_id",
                principalTable: "vardiya_sablon",
                principalColumn: "vardiya_sablon_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
