using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class delete_unnecessary_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gorevlendirme");

            migrationBuilder.DropTable(
                name: "gunluk_vardiya_istasyon_birim");

            migrationBuilder.DropTable(
                name: "gunluk_vardiya_masa");

            migrationBuilder.DropTable(
                name: "istasyon_durum");

            migrationBuilder.DropTable(
                name: "mesai");

            migrationBuilder.DropTable(
                name: "personel_izin");

            migrationBuilder.DropTable(
                name: "vardiya_sablon_yer");

            migrationBuilder.DropTable(
                name: "VardiyaSablonIstasyonBirim");

            migrationBuilder.DropTable(
                name: "VardiyaSablonMasa");

            migrationBuilder.DropTable(
                name: "gorevlendirme_tur");

            migrationBuilder.DropTable(
                name: "gorev_tur");

            migrationBuilder.DropTable(
                name: "vardiya");

            migrationBuilder.DropTable(
                name: "istasyon_durum_tur");

            migrationBuilder.DropTable(
                name: "mesai_tur");

            migrationBuilder.DropTable(
                name: "izin_tur");

            migrationBuilder.DropTable(
                name: "personel");

            migrationBuilder.DropTable(
                name: "istasyon_birim");

            migrationBuilder.DropTable(
                name: "masa");

            migrationBuilder.DropTable(
                name: "VardiyaSablon");

            migrationBuilder.DropTable(
                name: "org_birim");

            migrationBuilder.DropTable(
                name: "istasyon_birim_tur");

            migrationBuilder.DropTable(
                name: "istasyon");

            migrationBuilder.DropTable(
                name: "trafik_yonetim_merkezi");

            migrationBuilder.DropTable(
                name: "bolge");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bolge",
                columns: table => new
                {
                    bolge_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bolge_ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bolge_kisa_ad = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("bolge_pk", x => x.bolge_id);
                });

            migrationBuilder.CreateTable(
                name: "gorev_tur",
                columns: table => new
                {
                    gorev_tur_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tanim = table.Column<string>(type: "nvarchar(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gorev_tur_pk", x => x.gorev_tur_id);
                });

            migrationBuilder.CreateTable(
                name: "gorevlendirme_tur",
                columns: table => new
                {
                    gorevlendirme_tur_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tanim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gorevlendirme_tur_pk", x => x.gorevlendirme_tur_id);
                });

            migrationBuilder.CreateTable(
                name: "istasyon",
                columns: table => new
                {
                    istasyon_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    guncellenme_tarihi = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    istasyon_ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    istasyon_kod = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("istasyon_pk", x => x.istasyon_id);
                });

            migrationBuilder.CreateTable(
                name: "istasyon_birim_tur",
                columns: table => new
                {
                    istasyon_birim_tur_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    istasyon_birim_tur_tanim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("istasyon_birim_tur_pk", x => x.istasyon_birim_tur_id);
                });

            migrationBuilder.CreateTable(
                name: "istasyon_durum_tur",
                columns: table => new
                {
                    istasyon_durum_tur_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tanim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("istasyon_durum_tur_pkey", x => x.istasyon_durum_tur_id);
                });

            migrationBuilder.CreateTable(
                name: "izin_tur",
                columns: table => new
                {
                    izin_tur_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tanim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("izin_tur_pk", x => x.izin_tur_id);
                });

            migrationBuilder.CreateTable(
                name: "mesai_tur",
                columns: table => new
                {
                    mesai_tur_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    birim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    mesai_tur_tanim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("mesai_tur_pk", x => x.mesai_tur_id);
                });

            migrationBuilder.CreateTable(
                name: "org_birim",
                columns: table => new
                {
                    org_birim_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    org_birim_kod = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    org_birim_tanim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ust_org_birim_kod = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("org_birim_pk", x => x.org_birim_id);
                    table.UniqueConstraint("AK_org_birim_org_birim_kod", x => x.org_birim_kod);
                });

            migrationBuilder.CreateTable(
                name: "VardiyaSablon",
                columns: table => new
                {
                    VardiyaSablonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirimeOzgu = table.Column<bool>(type: "bit", nullable: false),
                    MaxVardiya = table.Column<short>(type: "smallint", nullable: false),
                    VardiyaSablonTanim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VardiyaSablon", x => x.VardiyaSablonId);
                });

            migrationBuilder.CreateTable(
                name: "trafik_yonetim_merkezi",
                columns: table => new
                {
                    trafik_yonetim_merkezi_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bolge_id = table.Column<short>(type: "smallint", nullable: false),
                    aktif = table.Column<bool>(type: "bit", nullable: false),
                    birim_kodu = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    tanim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("trafik_yonetim_merkezi_pkey", x => x.trafik_yonetim_merkezi_id);
                    table.ForeignKey(
                        name: "trafik_yonetim_merkezi_fk",
                        column: x => x.bolge_id,
                        principalTable: "bolge",
                        principalColumn: "bolge_id");
                });

            migrationBuilder.CreateTable(
                name: "istasyon_birim",
                columns: table => new
                {
                    istasyon_birim_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    istasyon_birim_tur_id = table.Column<short>(type: "smallint", nullable: false),
                    istasyon_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("istasyon_birim_pk", x => x.istasyon_birim_id);
                    table.ForeignKey(
                        name: "fk_birim_istasyon_birim_tur_id",
                        column: x => x.istasyon_birim_tur_id,
                        principalTable: "istasyon_birim_tur",
                        principalColumn: "istasyon_birim_tur_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_birim_istasyon_id",
                        column: x => x.istasyon_id,
                        principalTable: "istasyon",
                        principalColumn: "istasyon_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "istasyon_durum",
                columns: table => new
                {
                    istasyon_durum_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    istasyon_durum_tur_id = table.Column<int>(type: "int", nullable: false),
                    istasyon_id = table.Column<int>(type: "int", nullable: false),
                    baslangic_zamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    bitis_zamani = table.Column<DateTime>(type: "datetime2", nullable: true),
                    gecerlilik_baslangic = table.Column<DateTime>(type: "datetime2", nullable: true),
                    gecerlilik_bitis = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("istasyon_durum_pkey", x => x.istasyon_durum_id);
                    table.ForeignKey(
                        name: "istasyon_durum_fk",
                        column: x => x.istasyon_durum_tur_id,
                        principalTable: "istasyon_durum_tur",
                        principalColumn: "istasyon_durum_tur_id");
                    table.ForeignKey(
                        name: "istasyon_istasyon_durum_fk",
                        column: x => x.istasyon_id,
                        principalTable: "istasyon",
                        principalColumn: "istasyon_id");
                });

            migrationBuilder.CreateTable(
                name: "personel",
                columns: table => new
                {
                    personel_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    org_birim_kod = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    personel_no = table.Column<int>(type: "int", nullable: false),
                    sicil_no = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tc_kimlik_no = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("personel_pk", x => x.personel_id);
                    table.UniqueConstraint("AK_personel_personel_no", x => x.personel_no);
                    table.ForeignKey(
                        name: "personel_fk",
                        column: x => x.org_birim_kod,
                        principalTable: "org_birim",
                        principalColumn: "org_birim_kod");
                });

            migrationBuilder.CreateTable(
                name: "vardiya",
                columns: table => new
                {
                    vardiya_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vardiya_sablon_id = table.Column<int>(type: "int", nullable: false),
                    baslangic_saat = table.Column<TimeOnly>(type: "time", nullable: false),
                    bitis_saat = table.Column<TimeOnly>(type: "time", nullable: false),
                    sira_no = table.Column<short>(type: "smallint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("vardiya_pkey", x => x.vardiya_id);
                    table.ForeignKey(
                        name: "fk_vardiya_vardiya_sablon_id",
                        column: x => x.vardiya_sablon_id,
                        principalTable: "VardiyaSablon",
                        principalColumn: "VardiyaSablonId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "masa",
                columns: table => new
                {
                    masa_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parent_id = table.Column<short>(type: "smallint", nullable: true),
                    trafik_yonetim_merkezi_id = table.Column<short>(type: "smallint", nullable: false),
                    aktif = table.Column<bool>(type: "bit", nullable: false),
                    is_clone = table.Column<bool>(type: "bit", nullable: true),
                    renk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tanim = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("masa_pkey", x => x.masa_id);
                    table.ForeignKey(
                        name: "fk_masa_parent_id",
                        column: x => x.parent_id,
                        principalTable: "masa",
                        principalColumn: "masa_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_masa_trafik_yonetim_merkezi_id",
                        column: x => x.trafik_yonetim_merkezi_id,
                        principalTable: "trafik_yonetim_merkezi",
                        principalColumn: "trafik_yonetim_merkezi_id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "gorevlendirme",
                columns: table => new
                {
                    gorevlendirme_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gorevlendirme_tur_id = table.Column<short>(type: "smallint", nullable: false),
                    gorev_tur_id = table.Column<short>(type: "smallint", nullable: false),
                    personel_id = table.Column<int>(type: "int", nullable: true),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    belgenet_sayi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    belgenet_tarih = table.Column<DateTime>(type: "datetime", nullable: true),
                    birim_adi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birim_tur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gorevlendirilecek_personel_no = table.Column<int>(type: "int", nullable: false),
                    gorevlendirme_baslangic = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    gorevlendirme_birim = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "org_birim_kod"),
                    gorevlendirme_bitis = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gorevlendirme_pk", x => x.gorevlendirme_id);
                    table.ForeignKey(
                        name: "gorevlendirme_fk",
                        column: x => x.gorevlendirme_tur_id,
                        principalTable: "gorevlendirme_tur",
                        principalColumn: "gorevlendirme_tur_id");
                    table.ForeignKey(
                        name: "gorevlendirme_fk2",
                        column: x => x.gorev_tur_id,
                        principalTable: "gorev_tur",
                        principalColumn: "gorev_tur_id");
                    table.ForeignKey(
                        name: "gorevlendirme_personel_fk",
                        column: x => x.personel_id,
                        principalTable: "personel",
                        principalColumn: "personel_id");
                });

            migrationBuilder.CreateTable(
                name: "mesai",
                columns: table => new
                {
                    mesai_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mesai_tur_id = table.Column<short>(type: "smallint", nullable: true),
                    mesai_baslangic = table.Column<DateTime>(type: "datetime2", nullable: true),
                    mesai_bitis = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PersonelId = table.Column<int>(type: "int", nullable: true),
                    personel_no = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("mesai_pk", x => x.mesai_id);
                    table.ForeignKey(
                        name: "FK_mesai_personel_PersonelId",
                        column: x => x.PersonelId,
                        principalTable: "personel",
                        principalColumn: "personel_id");
                    table.ForeignKey(
                        name: "mesai_fk",
                        column: x => x.mesai_tur_id,
                        principalTable: "mesai_tur",
                        principalColumn: "mesai_tur_id");
                });

            migrationBuilder.CreateTable(
                name: "personel_izin",
                columns: table => new
                {
                    personel_izin_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    izin_tur_id = table.Column<short>(type: "smallint", nullable: false),
                    personel_id = table.Column<int>(type: "int", nullable: false),
                    aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    izin_baslangic_tarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    izin_bitis_tarihi = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("personel_izin_pk", x => x.personel_izin_id);
                    table.ForeignKey(
                        name: "personel_izin_fk",
                        column: x => x.izin_tur_id,
                        principalTable: "izin_tur",
                        principalColumn: "izin_tur_id");
                    table.ForeignKey(
                        name: "personel_personel_izin_fk",
                        column: x => x.personel_id,
                        principalTable: "personel",
                        principalColumn: "personel_id");
                });

            migrationBuilder.CreateTable(
                name: "gunluk_vardiya_istasyon_birim",
                columns: table => new
                {
                    gunluk_vardiya_istasyon_birim_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    istasyon_birim_id = table.Column<int>(type: "int", nullable: false),
                    personel_id = table.Column<int>(type: "int", nullable: false),
                    vardiya_id = table.Column<int>(type: "int", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gunluk_vardiya_istasyon_pkey_1", x => x.gunluk_vardiya_istasyon_birim_id);
                    table.ForeignKey(
                        name: "fk_gunluk_vardiya_istasyon_birim_id",
                        column: x => x.istasyon_birim_id,
                        principalTable: "istasyon_birim",
                        principalColumn: "istasyon_birim_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_gunluk_vardiya_istasyon_vardiya_id",
                        column: x => x.vardiya_id,
                        principalTable: "vardiya",
                        principalColumn: "vardiya_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "gunluk_vardiya_istasyon_birim_fk",
                        column: x => x.personel_id,
                        principalTable: "personel",
                        principalColumn: "personel_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gunluk_vardiya_masa",
                columns: table => new
                {
                    gunluk_vardiya_id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    masa_id = table.Column<short>(type: "smallint", nullable: false),
                    personel_id = table.Column<int>(type: "int", nullable: false),
                    vardiya_id = table.Column<int>(type: "int", nullable: false),
                    tarih = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("gunluk_vardiya_pkey", x => x.gunluk_vardiya_id);
                    table.ForeignKey(
                        name: "fk_gunluk_vardiya_masa_id",
                        column: x => x.masa_id,
                        principalTable: "masa",
                        principalColumn: "masa_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_gunluk_vardiya_masa_vardiya_id",
                        column: x => x.vardiya_id,
                        principalTable: "vardiya",
                        principalColumn: "vardiya_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "gunluk_vardiya_masa_fk",
                        column: x => x.personel_id,
                        principalTable: "personel",
                        principalColumn: "personel_id");
                });

            migrationBuilder.CreateTable(
                name: "vardiya_sablon_yer",
                columns: table => new
                {
                    vardiya_sablon_yer_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    istasyon_birim_id = table.Column<int>(type: "int", nullable: true),
                    masa_id = table.Column<short>(type: "smallint", nullable: true),
                    VardiyaSablonId = table.Column<int>(type: "int", nullable: false),
                    gecerlilik_baslangic = table.Column<DateTime>(type: "datetime", nullable: true),
                    gecerlilik_bitis = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("vardiya_sablon_pkey", x => x.vardiya_sablon_yer_id);
                    table.ForeignKey(
                        name: "vardiya_sablon_yer_fk",
                        column: x => x.masa_id,
                        principalTable: "masa",
                        principalColumn: "masa_id");
                    table.ForeignKey(
                        name: "vardiya_sablon_yer_fk_1",
                        column: x => x.istasyon_birim_id,
                        principalTable: "istasyon_birim",
                        principalColumn: "istasyon_birim_id");
                    table.ForeignKey(
                        name: "vardiya_sablon_yer_fk_2",
                        column: x => x.VardiyaSablonId,
                        principalTable: "VardiyaSablon",
                        principalColumn: "VardiyaSablonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VardiyaSablonMasa",
                columns: table => new
                {
                    VardiyaSablonMasaId = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MasaId = table.Column<short>(type: "smallint", nullable: false),
                    VardiyaSablonId = table.Column<int>(type: "int", nullable: false),
                    BaslangicTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BitisTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                name: "gorev_tur_un",
                table: "gorev_tur",
                column: "tanim",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_gorevlendirme_gorev_tur_id",
                table: "gorevlendirme",
                column: "gorev_tur_id");

            migrationBuilder.CreateIndex(
                name: "IX_gorevlendirme_gorevlendirme_tur_id",
                table: "gorevlendirme",
                column: "gorevlendirme_tur_id");

            migrationBuilder.CreateIndex(
                name: "IX_gorevlendirme_personel_id",
                table: "gorevlendirme",
                column: "personel_id");

            migrationBuilder.CreateIndex(
                name: "fki_fk_gunluk_vardiya_istasyon_birim_id",
                table: "gunluk_vardiya_istasyon_birim",
                column: "istasyon_birim_id");

            migrationBuilder.CreateIndex(
                name: "fki_fk_gunluk_vardiya_istasyon_vardiya_id",
                table: "gunluk_vardiya_istasyon_birim",
                column: "vardiya_id");

            migrationBuilder.CreateIndex(
                name: "IX_gunluk_vardiya_istasyon_birim_personel_id",
                table: "gunluk_vardiya_istasyon_birim",
                column: "personel_id");

            migrationBuilder.CreateIndex(
                name: "fki_fk_gunluk_vardiya_masa_id",
                table: "gunluk_vardiya_masa",
                column: "masa_id");

            migrationBuilder.CreateIndex(
                name: "fki_fk_gunluk_vardiya_masa_vardiya_id",
                table: "gunluk_vardiya_masa",
                column: "vardiya_id");

            migrationBuilder.CreateIndex(
                name: "fki_fk_gunluk_vardiya_personel_id",
                table: "gunluk_vardiya_masa",
                column: "personel_id");

            migrationBuilder.CreateIndex(
                name: "fki_fk_birim_istasyon_birim_tur_id",
                table: "istasyon_birim",
                column: "istasyon_birim_tur_id");

            migrationBuilder.CreateIndex(
                name: "fki_fk_birim_istasyon_id",
                table: "istasyon_birim",
                column: "istasyon_id");

            migrationBuilder.CreateIndex(
                name: "IX_istasyon_durum_istasyon_durum_tur_id",
                table: "istasyon_durum",
                column: "istasyon_durum_tur_id");

            migrationBuilder.CreateIndex(
                name: "IX_istasyon_durum_istasyon_id",
                table: "istasyon_durum",
                column: "istasyon_id");

            migrationBuilder.CreateIndex(
                name: "fki_fk_masa_parent_id",
                table: "masa",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "fki_fk_masa_trafik_yonetim_merkezi_id",
                table: "masa",
                column: "trafik_yonetim_merkezi_id");

            migrationBuilder.CreateIndex(
                name: "IX_mesai_mesai_tur_id",
                table: "mesai",
                column: "mesai_tur_id");

            migrationBuilder.CreateIndex(
                name: "IX_mesai_PersonelId",
                table: "mesai",
                column: "PersonelId");

            migrationBuilder.CreateIndex(
                name: "org_birim_un",
                table: "org_birim",
                column: "org_birim_kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personel_org_birim_kod",
                table: "personel",
                column: "org_birim_kod");

            migrationBuilder.CreateIndex(
                name: "personel_un",
                table: "personel",
                column: "personel_no",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_personel_izin_izin_tur_id",
                table: "personel_izin",
                column: "izin_tur_id");

            migrationBuilder.CreateIndex(
                name: "IX_personel_izin_personel_id",
                table: "personel_izin",
                column: "personel_id");

            migrationBuilder.CreateIndex(
                name: "fki_fk_trafik_yonetim_merkezi_bolge",
                table: "trafik_yonetim_merkezi",
                column: "bolge_id");

            migrationBuilder.CreateIndex(
                name: "fki_fk_tym_bolge_id",
                table: "trafik_yonetim_merkezi",
                column: "bolge_id");

            migrationBuilder.CreateIndex(
                name: "trafik_yonetim_merkezi_un",
                table: "trafik_yonetim_merkezi",
                column: "birim_kodu",
                unique: true,
                filter: "[birim_kodu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "fki_fk_vardiya_vardiya_sablon_id",
                table: "vardiya",
                column: "vardiya_sablon_id");

            migrationBuilder.CreateIndex(
                name: "IX_vardiya_sablon_yer_istasyon_birim_id",
                table: "vardiya_sablon_yer",
                column: "istasyon_birim_id");

            migrationBuilder.CreateIndex(
                name: "IX_vardiya_sablon_yer_masa_id",
                table: "vardiya_sablon_yer",
                column: "masa_id");

            migrationBuilder.CreateIndex(
                name: "IX_vardiya_sablon_yer_VardiyaSablonId",
                table: "vardiya_sablon_yer",
                column: "VardiyaSablonId");

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
        }
    }
}
