using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_example_project_try : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolge",
                columns: table => new
                {
                    BolgeId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BolgeAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BolgeKisaAd = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolge", x => x.BolgeId);
                });

            migrationBuilder.CreateTable(
                name: "GorevlendirmeTur",
                columns: table => new
                {
                    GorevlendirmeTurId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevlendirmeTur", x => x.GorevlendirmeTurId);
                });

            migrationBuilder.CreateTable(
                name: "GorevTur",
                columns: table => new
                {
                    GorevTurId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GorevTur", x => x.GorevTurId);
                });

            migrationBuilder.CreateTable(
                name: "Istasyon",
                columns: table => new
                {
                    IstasyonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IstasyonKod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IstasyonAd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncellenmeTarihi = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Istasyon", x => x.IstasyonId);
                });

            migrationBuilder.CreateTable(
                name: "IstasyonBirimTur",
                columns: table => new
                {
                    IstasyonBirimTurId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IstasyonBirimTurTanim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IstasyonBirimTur", x => x.IstasyonBirimTurId);
                });

            migrationBuilder.CreateTable(
                name: "IstasyonDurumTur",
                columns: table => new
                {
                    IstasyonDurumTurId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IstasyonDurumTur", x => x.IstasyonDurumTurId);
                });

            migrationBuilder.CreateTable(
                name: "IzinTur",
                columns: table => new
                {
                    IzinTurId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IzinTur", x => x.IzinTurId);
                });

            migrationBuilder.CreateTable(
                name: "MesaiTur",
                columns: table => new
                {
                    MesaiTurId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesaiTurTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MesaiTur", x => x.MesaiTurId);
                });

            migrationBuilder.CreateTable(
                name: "OrgBirim",
                columns: table => new
                {
                    OrgBirimId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrgBirimKod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgBirimTanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UstOrgBirimKod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrgBirim", x => x.OrgBirimId);
                });

            migrationBuilder.CreateTable(
                name: "TrafikYonetimMerkezi",
                columns: table => new
                {
                    TrafikYonetimMerkeziId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    BolgeId = table.Column<short>(type: "smallint", nullable: false),
                    BirimKodu = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrafikYonetimMerkezi", x => x.TrafikYonetimMerkeziId);
                    table.ForeignKey(
                        name: "FK_TrafikYonetimMerkezi_Bolge_BolgeId",
                        column: x => x.BolgeId,
                        principalTable: "Bolge",
                        principalColumn: "BolgeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IstasyonBirim",
                columns: table => new
                {
                    IstasyonBirimId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IstasyonId = table.Column<int>(type: "int", nullable: false),
                    IstasyonBirimTurId = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IstasyonBirim", x => x.IstasyonBirimId);
                    table.ForeignKey(
                        name: "FK_IstasyonBirim_IstasyonBirimTur_IstasyonBirimTurId",
                        column: x => x.IstasyonBirimTurId,
                        principalTable: "IstasyonBirimTur",
                        principalColumn: "IstasyonBirimTurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IstasyonBirim_Istasyon_IstasyonId",
                        column: x => x.IstasyonId,
                        principalTable: "Istasyon",
                        principalColumn: "IstasyonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IstasyonDurum",
                columns: table => new
                {
                    IstasyonDurumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IstasyonId = table.Column<int>(type: "int", nullable: false),
                    BaslangicZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BitisZamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IstasyonDurumTurId = table.Column<int>(type: "int", nullable: false),
                    GecerlilikBaslangic = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GecerlilikBitis = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IstasyonDurum", x => x.IstasyonDurumId);
                    table.ForeignKey(
                        name: "FK_IstasyonDurum_IstasyonDurumTur_IstasyonDurumTurId",
                        column: x => x.IstasyonDurumTurId,
                        principalTable: "IstasyonDurumTur",
                        principalColumn: "IstasyonDurumTurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IstasyonDurum_Istasyon_IstasyonId",
                        column: x => x.IstasyonId,
                        principalTable: "Istasyon",
                        principalColumn: "IstasyonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personel",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelNo = table.Column<int>(type: "int", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TcKimlikNo = table.Column<long>(type: "bigint", nullable: false),
                    SicilNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgBirimKod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrgBirimKodNavigationOrgBirimId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personel", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personel_OrgBirim_OrgBirimKodNavigationOrgBirimId",
                        column: x => x.OrgBirimKodNavigationOrgBirimId,
                        principalTable: "OrgBirim",
                        principalColumn: "OrgBirimId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Masa",
                columns: table => new
                {
                    MasaId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aktif = table.Column<bool>(type: "bit", nullable: false),
                    TrafikYonetimMerkeziId = table.Column<short>(type: "smallint", nullable: false),
                    IsClone = table.Column<bool>(type: "bit", nullable: true),
                    ParentId = table.Column<short>(type: "smallint", nullable: true),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Masa", x => x.MasaId);
                    table.ForeignKey(
                        name: "FK_Masa_Masa_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Masa",
                        principalColumn: "MasaId");
                    table.ForeignKey(
                        name: "FK_Masa_TrafikYonetimMerkezi_TrafikYonetimMerkeziId",
                        column: x => x.TrafikYonetimMerkeziId,
                        principalTable: "TrafikYonetimMerkezi",
                        principalColumn: "TrafikYonetimMerkeziId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gorevlendirme",
                columns: table => new
                {
                    GorevlendirmeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GorevlendirmeBirim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GorevlendirmeBaslangic = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GorevlendirmeBitis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GorevlendirilecekPersonelNo = table.Column<int>(type: "int", nullable: false),
                    GorevlendirmeTurId = table.Column<short>(type: "smallint", nullable: false),
                    GorevTurId = table.Column<short>(type: "smallint", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BelgenetTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BelgenetSayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirimTur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirimAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PersonelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gorevlendirme", x => x.GorevlendirmeId);
                    table.ForeignKey(
                        name: "FK_Gorevlendirme_GorevTur_GorevTurId",
                        column: x => x.GorevTurId,
                        principalTable: "GorevTur",
                        principalColumn: "GorevTurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gorevlendirme_GorevlendirmeTur_GorevlendirmeTurId",
                        column: x => x.GorevlendirmeTurId,
                        principalTable: "GorevlendirmeTur",
                        principalColumn: "GorevlendirmeTurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Gorevlendirme_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "PersonelId");
                });

            migrationBuilder.CreateTable(
                name: "Mesai",
                columns: table => new
                {
                    MesaiId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MesaiTurId = table.Column<short>(type: "smallint", nullable: true),
                    PersonelNo = table.Column<int>(type: "int", nullable: true),
                    MesaiBaslangic = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MesaiBitis = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonelNoNavigationPersonelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesai", x => x.MesaiId);
                    table.ForeignKey(
                        name: "FK_Mesai_MesaiTur_MesaiTurId",
                        column: x => x.MesaiTurId,
                        principalTable: "MesaiTur",
                        principalColumn: "MesaiTurId");
                    table.ForeignKey(
                        name: "FK_Mesai_Personel_PersonelNoNavigationPersonelId",
                        column: x => x.PersonelNoNavigationPersonelId,
                        principalTable: "Personel",
                        principalColumn: "PersonelId");
                });

            migrationBuilder.CreateTable(
                name: "PersonelIzin",
                columns: table => new
                {
                    PersonelIzinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonelId = table.Column<int>(type: "int", nullable: false),
                    IzinBaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IzinBitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IzinTurId = table.Column<short>(type: "smallint", nullable: false),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonelIzin", x => x.PersonelIzinId);
                    table.ForeignKey(
                        name: "FK_PersonelIzin_IzinTur_IzinTurId",
                        column: x => x.IzinTurId,
                        principalTable: "IzinTur",
                        principalColumn: "IzinTurId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonelIzin_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VardiyaSablonYer",
                columns: table => new
                {
                    VardiyaSablonYerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxVardiya = table.Column<short>(type: "smallint", nullable: false),
                    GecerlilikBaslangic = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GecerlilikBitis = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MasaId = table.Column<short>(type: "smallint", nullable: true),
                    IstasyonBirimId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VardiyaSablonYer", x => x.VardiyaSablonYerId);
                    table.ForeignKey(
                        name: "FK_VardiyaSablonYer_IstasyonBirim_IstasyonBirimId",
                        column: x => x.IstasyonBirimId,
                        principalTable: "IstasyonBirim",
                        principalColumn: "IstasyonBirimId");
                    table.ForeignKey(
                        name: "FK_VardiyaSablonYer_Masa_MasaId",
                        column: x => x.MasaId,
                        principalTable: "Masa",
                        principalColumn: "MasaId");
                });

            migrationBuilder.CreateTable(
                name: "Vardiya",
                columns: table => new
                {
                    VardiyaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VardiyaSablonId = table.Column<int>(type: "int", nullable: false),
                    BaslangicSaat = table.Column<TimeOnly>(type: "time", nullable: false),
                    BitisSaat = table.Column<TimeOnly>(type: "time", nullable: false),
                    SiraNo = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vardiya", x => x.VardiyaId);
                    table.ForeignKey(
                        name: "FK_Vardiya_VardiyaSablonYer_VardiyaSablonId",
                        column: x => x.VardiyaSablonId,
                        principalTable: "VardiyaSablonYer",
                        principalColumn: "VardiyaSablonYerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunlukVardiyaIstasyonBirim",
                columns: table => new
                {
                    GunlukVardiyaIstasyonBirimId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VardiyaId = table.Column<int>(type: "int", nullable: false),
                    IstasyonBirimId = table.Column<int>(type: "int", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunlukVardiyaIstasyonBirim", x => x.GunlukVardiyaIstasyonBirimId);
                    table.ForeignKey(
                        name: "FK_GunlukVardiyaIstasyonBirim_IstasyonBirim_IstasyonBirimId",
                        column: x => x.IstasyonBirimId,
                        principalTable: "IstasyonBirim",
                        principalColumn: "IstasyonBirimId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GunlukVardiyaIstasyonBirim_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GunlukVardiyaIstasyonBirim_Vardiya_VardiyaId",
                        column: x => x.VardiyaId,
                        principalTable: "Vardiya",
                        principalColumn: "VardiyaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunlukVardiyaMasa",
                columns: table => new
                {
                    GunlukVardiyaId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VardiyaId = table.Column<int>(type: "int", nullable: false),
                    MasaId = table.Column<short>(type: "smallint", nullable: false),
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunlukVardiyaMasa", x => x.GunlukVardiyaId);
                    table.ForeignKey(
                        name: "FK_GunlukVardiyaMasa_Masa_MasaId",
                        column: x => x.MasaId,
                        principalTable: "Masa",
                        principalColumn: "MasaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GunlukVardiyaMasa_Personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "Personel",
                        principalColumn: "PersonelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GunlukVardiyaMasa_Vardiya_VardiyaId",
                        column: x => x.VardiyaId,
                        principalTable: "Vardiya",
                        principalColumn: "VardiyaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gorevlendirme_GorevlendirmeTurId",
                table: "Gorevlendirme",
                column: "GorevlendirmeTurId");

            migrationBuilder.CreateIndex(
                name: "IX_Gorevlendirme_GorevTurId",
                table: "Gorevlendirme",
                column: "GorevTurId");

            migrationBuilder.CreateIndex(
                name: "IX_Gorevlendirme_PersonelId",
                table: "Gorevlendirme",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukVardiyaIstasyonBirim_IstasyonBirimId",
                table: "GunlukVardiyaIstasyonBirim",
                column: "IstasyonBirimId");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukVardiyaIstasyonBirim_PersonelId",
                table: "GunlukVardiyaIstasyonBirim",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukVardiyaIstasyonBirim_VardiyaId",
                table: "GunlukVardiyaIstasyonBirim",
                column: "VardiyaId");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukVardiyaMasa_MasaId",
                table: "GunlukVardiyaMasa",
                column: "MasaId");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukVardiyaMasa_PersonelId",
                table: "GunlukVardiyaMasa",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukVardiyaMasa_VardiyaId",
                table: "GunlukVardiyaMasa",
                column: "VardiyaId");

            migrationBuilder.CreateIndex(
                name: "IX_IstasyonBirim_IstasyonBirimTurId",
                table: "IstasyonBirim",
                column: "IstasyonBirimTurId");

            migrationBuilder.CreateIndex(
                name: "IX_IstasyonBirim_IstasyonId",
                table: "IstasyonBirim",
                column: "IstasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_IstasyonDurum_IstasyonDurumTurId",
                table: "IstasyonDurum",
                column: "IstasyonDurumTurId");

            migrationBuilder.CreateIndex(
                name: "IX_IstasyonDurum_IstasyonId",
                table: "IstasyonDurum",
                column: "IstasyonId");

            migrationBuilder.CreateIndex(
                name: "IX_Masa_ParentId",
                table: "Masa",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Masa_TrafikYonetimMerkeziId",
                table: "Masa",
                column: "TrafikYonetimMerkeziId");

            migrationBuilder.CreateIndex(
                name: "IX_Mesai_MesaiTurId",
                table: "Mesai",
                column: "MesaiTurId");

            migrationBuilder.CreateIndex(
                name: "IX_Mesai_PersonelNoNavigationPersonelId",
                table: "Mesai",
                column: "PersonelNoNavigationPersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_OrgBirimKodNavigationOrgBirimId",
                table: "Personel",
                column: "OrgBirimKodNavigationOrgBirimId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelIzin_IzinTurId",
                table: "PersonelIzin",
                column: "IzinTurId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonelIzin_PersonelId",
                table: "PersonelIzin",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_TrafikYonetimMerkezi_BolgeId",
                table: "TrafikYonetimMerkezi",
                column: "BolgeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vardiya_VardiyaSablonId",
                table: "Vardiya",
                column: "VardiyaSablonId");

            migrationBuilder.CreateIndex(
                name: "IX_VardiyaSablonYer_IstasyonBirimId",
                table: "VardiyaSablonYer",
                column: "IstasyonBirimId");

            migrationBuilder.CreateIndex(
                name: "IX_VardiyaSablonYer_MasaId",
                table: "VardiyaSablonYer",
                column: "MasaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gorevlendirme");

            migrationBuilder.DropTable(
                name: "GunlukVardiyaIstasyonBirim");

            migrationBuilder.DropTable(
                name: "GunlukVardiyaMasa");

            migrationBuilder.DropTable(
                name: "IstasyonDurum");

            migrationBuilder.DropTable(
                name: "Mesai");

            migrationBuilder.DropTable(
                name: "PersonelIzin");

            migrationBuilder.DropTable(
                name: "GorevTur");

            migrationBuilder.DropTable(
                name: "GorevlendirmeTur");

            migrationBuilder.DropTable(
                name: "Vardiya");

            migrationBuilder.DropTable(
                name: "IstasyonDurumTur");

            migrationBuilder.DropTable(
                name: "MesaiTur");

            migrationBuilder.DropTable(
                name: "IzinTur");

            migrationBuilder.DropTable(
                name: "Personel");

            migrationBuilder.DropTable(
                name: "VardiyaSablonYer");

            migrationBuilder.DropTable(
                name: "OrgBirim");

            migrationBuilder.DropTable(
                name: "IstasyonBirim");

            migrationBuilder.DropTable(
                name: "Masa");

            migrationBuilder.DropTable(
                name: "IstasyonBirimTur");

            migrationBuilder.DropTable(
                name: "Istasyon");

            migrationBuilder.DropTable(
                name: "TrafikYonetimMerkezi");

            migrationBuilder.DropTable(
                name: "Bolge");
        }
    }
}
