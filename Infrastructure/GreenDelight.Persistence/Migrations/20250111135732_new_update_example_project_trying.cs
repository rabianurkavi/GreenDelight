using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GreenDelight.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class new_update_example_project_trying : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gorevlendirme_GorevTur_GorevTurId",
                table: "Gorevlendirme");

            migrationBuilder.DropForeignKey(
                name: "FK_Gorevlendirme_GorevlendirmeTur_GorevlendirmeTurId",
                table: "Gorevlendirme");

            migrationBuilder.DropForeignKey(
                name: "FK_Gorevlendirme_Personel_PersonelId",
                table: "Gorevlendirme");

            migrationBuilder.DropForeignKey(
                name: "FK_GunlukVardiyaIstasyonBirim_IstasyonBirim_IstasyonBirimId",
                table: "GunlukVardiyaIstasyonBirim");

            migrationBuilder.DropForeignKey(
                name: "FK_GunlukVardiyaIstasyonBirim_Personel_PersonelId",
                table: "GunlukVardiyaIstasyonBirim");

            migrationBuilder.DropForeignKey(
                name: "FK_GunlukVardiyaIstasyonBirim_Vardiya_VardiyaId",
                table: "GunlukVardiyaIstasyonBirim");

            migrationBuilder.DropForeignKey(
                name: "FK_GunlukVardiyaMasa_Masa_MasaId",
                table: "GunlukVardiyaMasa");

            migrationBuilder.DropForeignKey(
                name: "FK_GunlukVardiyaMasa_Personel_PersonelId",
                table: "GunlukVardiyaMasa");

            migrationBuilder.DropForeignKey(
                name: "FK_GunlukVardiyaMasa_Vardiya_VardiyaId",
                table: "GunlukVardiyaMasa");

            migrationBuilder.DropForeignKey(
                name: "FK_IstasyonBirim_IstasyonBirimTur_IstasyonBirimTurId",
                table: "IstasyonBirim");

            migrationBuilder.DropForeignKey(
                name: "FK_IstasyonBirim_Istasyon_IstasyonId",
                table: "IstasyonBirim");

            migrationBuilder.DropForeignKey(
                name: "FK_IstasyonDurum_IstasyonDurumTur_IstasyonDurumTurId",
                table: "IstasyonDurum");

            migrationBuilder.DropForeignKey(
                name: "FK_IstasyonDurum_Istasyon_IstasyonId",
                table: "IstasyonDurum");

            migrationBuilder.DropForeignKey(
                name: "FK_Masa_Masa_ParentId",
                table: "Masa");

            migrationBuilder.DropForeignKey(
                name: "FK_Masa_TrafikYonetimMerkezi_TrafikYonetimMerkeziId",
                table: "Masa");

            migrationBuilder.DropForeignKey(
                name: "FK_Mesai_MesaiTur_MesaiTurId",
                table: "Mesai");

            migrationBuilder.DropForeignKey(
                name: "FK_Mesai_Personel_PersonelNoNavigationPersonelId",
                table: "Mesai");

            migrationBuilder.DropForeignKey(
                name: "FK_Personel_OrgBirim_OrgBirimKodNavigationOrgBirimId",
                table: "Personel");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonelIzin_IzinTur_IzinTurId",
                table: "PersonelIzin");

            migrationBuilder.DropForeignKey(
                name: "FK_PersonelIzin_Personel_PersonelId",
                table: "PersonelIzin");

            migrationBuilder.DropForeignKey(
                name: "FK_TrafikYonetimMerkezi_Bolge_BolgeId",
                table: "TrafikYonetimMerkezi");

            migrationBuilder.DropForeignKey(
                name: "FK_Vardiya_VardiyaSablonYer_VardiyaSablonId",
                table: "Vardiya");

            migrationBuilder.DropForeignKey(
                name: "FK_VardiyaSablonYer_IstasyonBirim_IstasyonBirimId",
                table: "VardiyaSablonYer");

            migrationBuilder.DropForeignKey(
                name: "FK_VardiyaSablonYer_Masa_MasaId",
                table: "VardiyaSablonYer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vardiya",
                table: "Vardiya");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personel",
                table: "Personel");

            migrationBuilder.DropIndex(
                name: "IX_Personel_OrgBirimKodNavigationOrgBirimId",
                table: "Personel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mesai",
                table: "Mesai");

            migrationBuilder.DropIndex(
                name: "IX_Mesai_PersonelNoNavigationPersonelId",
                table: "Mesai");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Masa",
                table: "Masa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Istasyon",
                table: "Istasyon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gorevlendirme",
                table: "Gorevlendirme");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bolge",
                table: "Bolge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VardiyaSablonYer",
                table: "VardiyaSablonYer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrafikYonetimMerkezi",
                table: "TrafikYonetimMerkezi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonelIzin",
                table: "PersonelIzin");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrgBirim",
                table: "OrgBirim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MesaiTur",
                table: "MesaiTur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IzinTur",
                table: "IzinTur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IstasyonDurumTur",
                table: "IstasyonDurumTur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IstasyonDurum",
                table: "IstasyonDurum");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IstasyonBirimTur",
                table: "IstasyonBirimTur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IstasyonBirim",
                table: "IstasyonBirim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GunlukVardiyaMasa",
                table: "GunlukVardiyaMasa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GunlukVardiyaIstasyonBirim",
                table: "GunlukVardiyaIstasyonBirim");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GorevTur",
                table: "GorevTur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GorevlendirmeTur",
                table: "GorevlendirmeTur");

            migrationBuilder.DropColumn(
                name: "OrgBirimKodNavigationOrgBirimId",
                table: "Personel");

            migrationBuilder.DropColumn(
                name: "PersonelNoNavigationPersonelId",
                table: "Mesai");

            migrationBuilder.RenameTable(
                name: "Vardiya",
                newName: "vardiya");

            migrationBuilder.RenameTable(
                name: "Personel",
                newName: "personel");

            migrationBuilder.RenameTable(
                name: "Mesai",
                newName: "mesai");

            migrationBuilder.RenameTable(
                name: "Masa",
                newName: "masa");

            migrationBuilder.RenameTable(
                name: "Istasyon",
                newName: "istasyon");

            migrationBuilder.RenameTable(
                name: "Gorevlendirme",
                newName: "gorevlendirme");

            migrationBuilder.RenameTable(
                name: "Bolge",
                newName: "bolge");

            migrationBuilder.RenameTable(
                name: "VardiyaSablonYer",
                newName: "vardiya_sablon_yer");

            migrationBuilder.RenameTable(
                name: "TrafikYonetimMerkezi",
                newName: "trafik_yonetim_merkezi");

            migrationBuilder.RenameTable(
                name: "PersonelIzin",
                newName: "personel_izin");

            migrationBuilder.RenameTable(
                name: "OrgBirim",
                newName: "org_birim");

            migrationBuilder.RenameTable(
                name: "MesaiTur",
                newName: "mesai_tur");

            migrationBuilder.RenameTable(
                name: "IzinTur",
                newName: "izin_tur");

            migrationBuilder.RenameTable(
                name: "IstasyonDurumTur",
                newName: "istasyon_durum_tur");

            migrationBuilder.RenameTable(
                name: "IstasyonDurum",
                newName: "istasyon_durum");

            migrationBuilder.RenameTable(
                name: "IstasyonBirimTur",
                newName: "istasyon_birim_tur");

            migrationBuilder.RenameTable(
                name: "IstasyonBirim",
                newName: "istasyon_birim");

            migrationBuilder.RenameTable(
                name: "GunlukVardiyaMasa",
                newName: "gunluk_vardiya_masa");

            migrationBuilder.RenameTable(
                name: "GunlukVardiyaIstasyonBirim",
                newName: "gunluk_vardiya_istasyon_birim");

            migrationBuilder.RenameTable(
                name: "GorevTur",
                newName: "gorev_tur");

            migrationBuilder.RenameTable(
                name: "GorevlendirmeTur",
                newName: "gorevlendirme_tur");

            migrationBuilder.RenameColumn(
                name: "VardiyaSablonId",
                table: "vardiya",
                newName: "vardiya_sablon_id");

            migrationBuilder.RenameColumn(
                name: "SiraNo",
                table: "vardiya",
                newName: "sira_no");

            migrationBuilder.RenameColumn(
                name: "BitisSaat",
                table: "vardiya",
                newName: "bitis_saat");

            migrationBuilder.RenameColumn(
                name: "BaslangicSaat",
                table: "vardiya",
                newName: "baslangic_saat");

            migrationBuilder.RenameColumn(
                name: "VardiyaId",
                table: "vardiya",
                newName: "vardiya_id");

            migrationBuilder.RenameIndex(
                name: "IX_Vardiya_VardiyaSablonId",
                table: "vardiya",
                newName: "fki_fk_vardiya_vardiya_sablon_id");

            migrationBuilder.RenameColumn(
                name: "Soyad",
                table: "personel",
                newName: "soyad");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "personel",
                newName: "ad");

            migrationBuilder.RenameColumn(
                name: "TcKimlikNo",
                table: "personel",
                newName: "tc_kimlik_no");

            migrationBuilder.RenameColumn(
                name: "SicilNo",
                table: "personel",
                newName: "sicil_no");

            migrationBuilder.RenameColumn(
                name: "PersonelNo",
                table: "personel",
                newName: "personel_no");

            migrationBuilder.RenameColumn(
                name: "OrgBirimKod",
                table: "personel",
                newName: "org_birim_kod");

            migrationBuilder.RenameColumn(
                name: "PersonelId",
                table: "personel",
                newName: "personel_id");

            migrationBuilder.RenameColumn(
                name: "PersonelNo",
                table: "mesai",
                newName: "personel_no");

            migrationBuilder.RenameColumn(
                name: "MesaiTurId",
                table: "mesai",
                newName: "mesai_tur_id");

            migrationBuilder.RenameColumn(
                name: "MesaiBitis",
                table: "mesai",
                newName: "mesai_bitis");

            migrationBuilder.RenameColumn(
                name: "MesaiBaslangic",
                table: "mesai",
                newName: "mesai_baslangic");

            migrationBuilder.RenameColumn(
                name: "MesaiId",
                table: "mesai",
                newName: "mesai_id");

            migrationBuilder.RenameIndex(
                name: "IX_Mesai_MesaiTurId",
                table: "mesai",
                newName: "IX_mesai_mesai_tur_id");

            migrationBuilder.RenameColumn(
                name: "Tanim",
                table: "masa",
                newName: "tanim");

            migrationBuilder.RenameColumn(
                name: "Renk",
                table: "masa",
                newName: "renk");

            migrationBuilder.RenameColumn(
                name: "Aktif",
                table: "masa",
                newName: "aktif");

            migrationBuilder.RenameColumn(
                name: "TrafikYonetimMerkeziId",
                table: "masa",
                newName: "trafik_yonetim_merkezi_id");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "masa",
                newName: "parent_id");

            migrationBuilder.RenameColumn(
                name: "IsClone",
                table: "masa",
                newName: "is_clone");

            migrationBuilder.RenameColumn(
                name: "MasaId",
                table: "masa",
                newName: "masa_id");

            migrationBuilder.RenameIndex(
                name: "IX_Masa_TrafikYonetimMerkeziId",
                table: "masa",
                newName: "fki_fk_masa_trafik_yonetim_merkezi_id");

            migrationBuilder.RenameIndex(
                name: "IX_Masa_ParentId",
                table: "masa",
                newName: "fki_fk_masa_parent_id");

            migrationBuilder.RenameColumn(
                name: "IstasyonKod",
                table: "istasyon",
                newName: "istasyon_kod");

            migrationBuilder.RenameColumn(
                name: "IstasyonAd",
                table: "istasyon",
                newName: "istasyon_ad");

            migrationBuilder.RenameColumn(
                name: "GuncellenmeTarihi",
                table: "istasyon",
                newName: "guncellenme_tarihi");

            migrationBuilder.RenameColumn(
                name: "IstasyonId",
                table: "istasyon",
                newName: "istasyon_id");

            migrationBuilder.RenameColumn(
                name: "Aciklama",
                table: "gorevlendirme",
                newName: "aciklama");

            migrationBuilder.RenameColumn(
                name: "PersonelId",
                table: "gorevlendirme",
                newName: "personel_id");

            migrationBuilder.RenameColumn(
                name: "GorevlendirmeTurId",
                table: "gorevlendirme",
                newName: "gorevlendirme_tur_id");

            migrationBuilder.RenameColumn(
                name: "GorevlendirmeBitis",
                table: "gorevlendirme",
                newName: "gorevlendirme_bitis");

            migrationBuilder.RenameColumn(
                name: "GorevlendirmeBirim",
                table: "gorevlendirme",
                newName: "gorevlendirme_birim");

            migrationBuilder.RenameColumn(
                name: "GorevlendirmeBaslangic",
                table: "gorevlendirme",
                newName: "gorevlendirme_baslangic");

            migrationBuilder.RenameColumn(
                name: "GorevlendirilecekPersonelNo",
                table: "gorevlendirme",
                newName: "gorevlendirilecek_personel_no");

            migrationBuilder.RenameColumn(
                name: "GorevTurId",
                table: "gorevlendirme",
                newName: "gorev_tur_id");

            migrationBuilder.RenameColumn(
                name: "BirimTur",
                table: "gorevlendirme",
                newName: "birim_tur");

            migrationBuilder.RenameColumn(
                name: "BirimAdi",
                table: "gorevlendirme",
                newName: "birim_adi");

            migrationBuilder.RenameColumn(
                name: "BelgenetTarih",
                table: "gorevlendirme",
                newName: "belgenet_tarih");

            migrationBuilder.RenameColumn(
                name: "BelgenetSayi",
                table: "gorevlendirme",
                newName: "belgenet_sayi");

            migrationBuilder.RenameColumn(
                name: "GorevlendirmeId",
                table: "gorevlendirme",
                newName: "gorevlendirme_id");

            migrationBuilder.RenameIndex(
                name: "IX_Gorevlendirme_PersonelId",
                table: "gorevlendirme",
                newName: "IX_gorevlendirme_personel_id");

            migrationBuilder.RenameIndex(
                name: "IX_Gorevlendirme_GorevTurId",
                table: "gorevlendirme",
                newName: "IX_gorevlendirme_gorev_tur_id");

            migrationBuilder.RenameIndex(
                name: "IX_Gorevlendirme_GorevlendirmeTurId",
                table: "gorevlendirme",
                newName: "IX_gorevlendirme_gorevlendirme_tur_id");

            migrationBuilder.RenameColumn(
                name: "BolgeKisaAd",
                table: "bolge",
                newName: "bolge_kisa_ad");

            migrationBuilder.RenameColumn(
                name: "BolgeAd",
                table: "bolge",
                newName: "bolge_ad");

            migrationBuilder.RenameColumn(
                name: "BolgeId",
                table: "bolge",
                newName: "bolge_id");

            migrationBuilder.RenameColumn(
                name: "Tanim",
                table: "vardiya_sablon_yer",
                newName: "tanim");

            migrationBuilder.RenameColumn(
                name: "MaxVardiya",
                table: "vardiya_sablon_yer",
                newName: "max_vardiya");

            migrationBuilder.RenameColumn(
                name: "MasaId",
                table: "vardiya_sablon_yer",
                newName: "masa_id");

            migrationBuilder.RenameColumn(
                name: "IstasyonBirimId",
                table: "vardiya_sablon_yer",
                newName: "istasyon_birim_id");

            migrationBuilder.RenameColumn(
                name: "GecerlilikBitis",
                table: "vardiya_sablon_yer",
                newName: "gecerlilik_bitis");

            migrationBuilder.RenameColumn(
                name: "GecerlilikBaslangic",
                table: "vardiya_sablon_yer",
                newName: "gecerlilik_baslangic");

            migrationBuilder.RenameColumn(
                name: "VardiyaSablonYerId",
                table: "vardiya_sablon_yer",
                newName: "vardiya_sablon_yer_id");

            migrationBuilder.RenameIndex(
                name: "IX_VardiyaSablonYer_MasaId",
                table: "vardiya_sablon_yer",
                newName: "IX_vardiya_sablon_yer_masa_id");

            migrationBuilder.RenameIndex(
                name: "IX_VardiyaSablonYer_IstasyonBirimId",
                table: "vardiya_sablon_yer",
                newName: "IX_vardiya_sablon_yer_istasyon_birim_id");

            migrationBuilder.RenameColumn(
                name: "Tanim",
                table: "trafik_yonetim_merkezi",
                newName: "tanim");

            migrationBuilder.RenameColumn(
                name: "Aktif",
                table: "trafik_yonetim_merkezi",
                newName: "aktif");

            migrationBuilder.RenameColumn(
                name: "BolgeId",
                table: "trafik_yonetim_merkezi",
                newName: "bolge_id");

            migrationBuilder.RenameColumn(
                name: "BirimKodu",
                table: "trafik_yonetim_merkezi",
                newName: "birim_kodu");

            migrationBuilder.RenameColumn(
                name: "TrafikYonetimMerkeziId",
                table: "trafik_yonetim_merkezi",
                newName: "trafik_yonetim_merkezi_id");

            migrationBuilder.RenameIndex(
                name: "IX_TrafikYonetimMerkezi_BolgeId",
                table: "trafik_yonetim_merkezi",
                newName: "fki_fk_tym_bolge_id");

            migrationBuilder.RenameColumn(
                name: "Aciklama",
                table: "personel_izin",
                newName: "aciklama");

            migrationBuilder.RenameColumn(
                name: "PersonelId",
                table: "personel_izin",
                newName: "personel_id");

            migrationBuilder.RenameColumn(
                name: "IzinTurId",
                table: "personel_izin",
                newName: "izin_tur_id");

            migrationBuilder.RenameColumn(
                name: "IzinBitisTarihi",
                table: "personel_izin",
                newName: "izin_bitis_tarihi");

            migrationBuilder.RenameColumn(
                name: "IzinBaslangicTarihi",
                table: "personel_izin",
                newName: "izin_baslangic_tarihi");

            migrationBuilder.RenameColumn(
                name: "PersonelIzinId",
                table: "personel_izin",
                newName: "personel_izin_id");

            migrationBuilder.RenameIndex(
                name: "IX_PersonelIzin_PersonelId",
                table: "personel_izin",
                newName: "IX_personel_izin_personel_id");

            migrationBuilder.RenameIndex(
                name: "IX_PersonelIzin_IzinTurId",
                table: "personel_izin",
                newName: "IX_personel_izin_izin_tur_id");

            migrationBuilder.RenameColumn(
                name: "UstOrgBirimKod",
                table: "org_birim",
                newName: "ust_org_birim_kod");

            migrationBuilder.RenameColumn(
                name: "OrgBirimTanim",
                table: "org_birim",
                newName: "org_birim_tanim");

            migrationBuilder.RenameColumn(
                name: "OrgBirimKod",
                table: "org_birim",
                newName: "org_birim_kod");

            migrationBuilder.RenameColumn(
                name: "OrgBirimId",
                table: "org_birim",
                newName: "org_birim_id");

            migrationBuilder.RenameColumn(
                name: "Birim",
                table: "mesai_tur",
                newName: "birim");

            migrationBuilder.RenameColumn(
                name: "MesaiTurTanim",
                table: "mesai_tur",
                newName: "mesai_tur_tanim");

            migrationBuilder.RenameColumn(
                name: "MesaiTurId",
                table: "mesai_tur",
                newName: "mesai_tur_id");

            migrationBuilder.RenameColumn(
                name: "Tanim",
                table: "izin_tur",
                newName: "tanim");

            migrationBuilder.RenameColumn(
                name: "Aciklama",
                table: "izin_tur",
                newName: "aciklama");

            migrationBuilder.RenameColumn(
                name: "IzinTurId",
                table: "izin_tur",
                newName: "izin_tur_id");

            migrationBuilder.RenameColumn(
                name: "Tanim",
                table: "istasyon_durum_tur",
                newName: "tanim");

            migrationBuilder.RenameColumn(
                name: "IstasyonDurumTurId",
                table: "istasyon_durum_tur",
                newName: "istasyon_durum_tur_id");

            migrationBuilder.RenameColumn(
                name: "IstasyonId",
                table: "istasyon_durum",
                newName: "istasyon_id");

            migrationBuilder.RenameColumn(
                name: "IstasyonDurumTurId",
                table: "istasyon_durum",
                newName: "istasyon_durum_tur_id");

            migrationBuilder.RenameColumn(
                name: "GecerlilikBitis",
                table: "istasyon_durum",
                newName: "gecerlilik_bitis");

            migrationBuilder.RenameColumn(
                name: "GecerlilikBaslangic",
                table: "istasyon_durum",
                newName: "gecerlilik_baslangic");

            migrationBuilder.RenameColumn(
                name: "BitisZamani",
                table: "istasyon_durum",
                newName: "bitis_zamani");

            migrationBuilder.RenameColumn(
                name: "BaslangicZamani",
                table: "istasyon_durum",
                newName: "baslangic_zamani");

            migrationBuilder.RenameColumn(
                name: "IstasyonDurumId",
                table: "istasyon_durum",
                newName: "istasyon_durum_id");

            migrationBuilder.RenameIndex(
                name: "IX_IstasyonDurum_IstasyonId",
                table: "istasyon_durum",
                newName: "IX_istasyon_durum_istasyon_id");

            migrationBuilder.RenameIndex(
                name: "IX_IstasyonDurum_IstasyonDurumTurId",
                table: "istasyon_durum",
                newName: "IX_istasyon_durum_istasyon_durum_tur_id");

            migrationBuilder.RenameColumn(
                name: "IstasyonBirimTurTanim",
                table: "istasyon_birim_tur",
                newName: "istasyon_birim_tur_tanim");

            migrationBuilder.RenameColumn(
                name: "IstasyonBirimTurId",
                table: "istasyon_birim_tur",
                newName: "istasyon_birim_tur_id");

            migrationBuilder.RenameColumn(
                name: "IstasyonId",
                table: "istasyon_birim",
                newName: "istasyon_id");

            migrationBuilder.RenameColumn(
                name: "IstasyonBirimTurId",
                table: "istasyon_birim",
                newName: "istasyon_birim_tur_id");

            migrationBuilder.RenameColumn(
                name: "IstasyonBirimId",
                table: "istasyon_birim",
                newName: "istasyon_birim_id");

            migrationBuilder.RenameIndex(
                name: "IX_IstasyonBirim_IstasyonId",
                table: "istasyon_birim",
                newName: "fki_fk_birim_istasyon_id");

            migrationBuilder.RenameIndex(
                name: "IX_IstasyonBirim_IstasyonBirimTurId",
                table: "istasyon_birim",
                newName: "fki_fk_birim_istasyon_birim_tur_id");

            migrationBuilder.RenameColumn(
                name: "Tarih",
                table: "gunluk_vardiya_masa",
                newName: "tarih");

            migrationBuilder.RenameColumn(
                name: "VardiyaId",
                table: "gunluk_vardiya_masa",
                newName: "vardiya_id");

            migrationBuilder.RenameColumn(
                name: "PersonelId",
                table: "gunluk_vardiya_masa",
                newName: "personel_id");

            migrationBuilder.RenameColumn(
                name: "MasaId",
                table: "gunluk_vardiya_masa",
                newName: "masa_id");

            migrationBuilder.RenameColumn(
                name: "GunlukVardiyaId",
                table: "gunluk_vardiya_masa",
                newName: "gunluk_vardiya_id");

            migrationBuilder.RenameIndex(
                name: "IX_GunlukVardiyaMasa_VardiyaId",
                table: "gunluk_vardiya_masa",
                newName: "fki_fk_gunluk_vardiya_masa_vardiya_id");

            migrationBuilder.RenameIndex(
                name: "IX_GunlukVardiyaMasa_PersonelId",
                table: "gunluk_vardiya_masa",
                newName: "fki_fk_gunluk_vardiya_personel_id");

            migrationBuilder.RenameIndex(
                name: "IX_GunlukVardiyaMasa_MasaId",
                table: "gunluk_vardiya_masa",
                newName: "fki_fk_gunluk_vardiya_masa_id");

            migrationBuilder.RenameColumn(
                name: "Tarih",
                table: "gunluk_vardiya_istasyon_birim",
                newName: "tarih");

            migrationBuilder.RenameColumn(
                name: "VardiyaId",
                table: "gunluk_vardiya_istasyon_birim",
                newName: "vardiya_id");

            migrationBuilder.RenameColumn(
                name: "PersonelId",
                table: "gunluk_vardiya_istasyon_birim",
                newName: "personel_id");

            migrationBuilder.RenameColumn(
                name: "IstasyonBirimId",
                table: "gunluk_vardiya_istasyon_birim",
                newName: "istasyon_birim_id");

            migrationBuilder.RenameColumn(
                name: "GunlukVardiyaIstasyonBirimId",
                table: "gunluk_vardiya_istasyon_birim",
                newName: "gunluk_vardiya_istasyon_birim_id");

            migrationBuilder.RenameIndex(
                name: "IX_GunlukVardiyaIstasyonBirim_VardiyaId",
                table: "gunluk_vardiya_istasyon_birim",
                newName: "fki_fk_gunluk_vardiya_istasyon_vardiya_id");

            migrationBuilder.RenameIndex(
                name: "IX_GunlukVardiyaIstasyonBirim_PersonelId",
                table: "gunluk_vardiya_istasyon_birim",
                newName: "IX_gunluk_vardiya_istasyon_birim_personel_id");

            migrationBuilder.RenameIndex(
                name: "IX_GunlukVardiyaIstasyonBirim_IstasyonBirimId",
                table: "gunluk_vardiya_istasyon_birim",
                newName: "fki_fk_gunluk_vardiya_istasyon_birim_id");

            migrationBuilder.RenameColumn(
                name: "Tanim",
                table: "gorev_tur",
                newName: "tanim");

            migrationBuilder.RenameColumn(
                name: "GorevTurId",
                table: "gorev_tur",
                newName: "gorev_tur_id");

            migrationBuilder.RenameColumn(
                name: "Tanim",
                table: "gorevlendirme_tur",
                newName: "tanim");

            migrationBuilder.RenameColumn(
                name: "GorevlendirmeTurId",
                table: "gorevlendirme_tur",
                newName: "gorevlendirme_tur_id");

            migrationBuilder.AlterColumn<string>(
                name: "org_birim_kod",
                table: "personel",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "guncellenme_tarihi",
                table: "istasyon",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "gorevlendirme_bitis",
                table: "gorevlendirme",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "gorevlendirme_birim",
                table: "gorevlendirme",
                type: "nvarchar(max)",
                nullable: false,
                comment: "org_birim_kod",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "gorevlendirme_baslangic",
                table: "gorevlendirme",
                type: "datetime",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "belgenet_tarih",
                table: "gorevlendirme",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "gecerlilik_bitis",
                table: "vardiya_sablon_yer",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "gecerlilik_baslangic",
                table: "vardiya_sablon_yer",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "birim_kodu",
                table: "trafik_yonetim_merkezi",
                type: "nvarchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "izin_bitis_tarihi",
                table: "personel_izin",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "izin_baslangic_tarihi",
                table: "personel_izin",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "org_birim_kod",
                table: "org_birim",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "tarih",
                table: "gunluk_vardiya_masa",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "tarih",
                table: "gunluk_vardiya_istasyon_birim",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "tanim",
                table: "gorev_tur",
                type: "nvarchar(255)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "vardiya_pkey",
                table: "vardiya",
                column: "vardiya_id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_personel_personel_no",
                table: "personel",
                column: "personel_no");

            migrationBuilder.AddPrimaryKey(
                name: "personel_pk",
                table: "personel",
                column: "personel_id");

            migrationBuilder.AddPrimaryKey(
                name: "mesai_pk",
                table: "mesai",
                column: "mesai_id");

            migrationBuilder.AddPrimaryKey(
                name: "masa_pkey",
                table: "masa",
                column: "masa_id");

            migrationBuilder.AddPrimaryKey(
                name: "istasyon_pk",
                table: "istasyon",
                column: "istasyon_id");

            migrationBuilder.AddPrimaryKey(
                name: "gorevlendirme_pk",
                table: "gorevlendirme",
                column: "gorevlendirme_id");

            migrationBuilder.AddPrimaryKey(
                name: "bolge_pk",
                table: "bolge",
                column: "bolge_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.AddPrimaryKey(
                name: "vardiya_sablon_pkey",
                table: "vardiya_sablon_yer",
                column: "vardiya_sablon_yer_id");

            migrationBuilder.AddPrimaryKey(
                name: "trafik_yonetim_merkezi_pkey",
                table: "trafik_yonetim_merkezi",
                column: "trafik_yonetim_merkezi_id");

            migrationBuilder.AddPrimaryKey(
                name: "personel_izin_pk",
                table: "personel_izin",
                column: "personel_izin_id");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_org_birim_org_birim_kod",
                table: "org_birim",
                column: "org_birim_kod");

            migrationBuilder.AddPrimaryKey(
                name: "org_birim_pk",
                table: "org_birim",
                column: "org_birim_id");

            migrationBuilder.AddPrimaryKey(
                name: "mesai_tur_pk",
                table: "mesai_tur",
                column: "mesai_tur_id");

            migrationBuilder.AddPrimaryKey(
                name: "izin_tur_pk",
                table: "izin_tur",
                column: "izin_tur_id");

            migrationBuilder.AddPrimaryKey(
                name: "istasyon_durum_tur_pkey",
                table: "istasyon_durum_tur",
                column: "istasyon_durum_tur_id");

            migrationBuilder.AddPrimaryKey(
                name: "istasyon_durum_pkey",
                table: "istasyon_durum",
                column: "istasyon_durum_id");

            migrationBuilder.AddPrimaryKey(
                name: "istasyon_birim_tur_pk",
                table: "istasyon_birim_tur",
                column: "istasyon_birim_tur_id");

            migrationBuilder.AddPrimaryKey(
                name: "istasyon_birim_pk",
                table: "istasyon_birim",
                column: "istasyon_birim_id");

            migrationBuilder.AddPrimaryKey(
                name: "gunluk_vardiya_pkey",
                table: "gunluk_vardiya_masa",
                column: "gunluk_vardiya_id");

            migrationBuilder.AddPrimaryKey(
                name: "gunluk_vardiya_istasyon_pkey_1",
                table: "gunluk_vardiya_istasyon_birim",
                column: "gunluk_vardiya_istasyon_birim_id");

            migrationBuilder.AddPrimaryKey(
                name: "gorev_tur_pk",
                table: "gorev_tur",
                column: "gorev_tur_id");

            migrationBuilder.AddPrimaryKey(
                name: "gorevlendirme_tur_pk",
                table: "gorevlendirme_tur",
                column: "gorevlendirme_tur_id");

            migrationBuilder.CreateTable(
                name: "IdentityRole<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityRole<Guid>", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IdentityUser<Guid>",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser<Guid>", x => x.Id);
                });

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
                name: "IX_mesai_personel_no",
                table: "mesai",
                column: "personel_no");

            migrationBuilder.CreateIndex(
                name: "fki_fk_trafik_yonetim_merkezi_bolge",
                table: "trafik_yonetim_merkezi",
                column: "bolge_id");

            migrationBuilder.CreateIndex(
                name: "trafik_yonetim_merkezi_un",
                table: "trafik_yonetim_merkezi",
                column: "birim_kodu",
                unique: true,
                filter: "[birim_kodu] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "org_birim_un",
                table: "org_birim",
                column: "org_birim_kod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "gorev_tur_un",
                table: "gorev_tur",
                column: "tanim",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "gorevlendirme_fk",
                table: "gorevlendirme",
                column: "gorevlendirme_tur_id",
                principalTable: "gorevlendirme_tur",
                principalColumn: "gorevlendirme_tur_id");

            migrationBuilder.AddForeignKey(
                name: "gorevlendirme_fk2",
                table: "gorevlendirme",
                column: "gorev_tur_id",
                principalTable: "gorev_tur",
                principalColumn: "gorev_tur_id");

            migrationBuilder.AddForeignKey(
                name: "gorevlendirme_personel_fk",
                table: "gorevlendirme",
                column: "personel_id",
                principalTable: "personel",
                principalColumn: "personel_id");

            migrationBuilder.AddForeignKey(
                name: "fk_gunluk_vardiya_istasyon_birim_id",
                table: "gunluk_vardiya_istasyon_birim",
                column: "istasyon_birim_id",
                principalTable: "istasyon_birim",
                principalColumn: "istasyon_birim_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_gunluk_vardiya_istasyon_vardiya_id",
                table: "gunluk_vardiya_istasyon_birim",
                column: "vardiya_id",
                principalTable: "vardiya",
                principalColumn: "vardiya_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "gunluk_vardiya_istasyon_birim_fk",
                table: "gunluk_vardiya_istasyon_birim",
                column: "personel_id",
                principalTable: "personel",
                principalColumn: "personel_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_gunluk_vardiya_masa_id",
                table: "gunluk_vardiya_masa",
                column: "masa_id",
                principalTable: "masa",
                principalColumn: "masa_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_gunluk_vardiya_masa_vardiya_id",
                table: "gunluk_vardiya_masa",
                column: "vardiya_id",
                principalTable: "vardiya",
                principalColumn: "vardiya_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "gunluk_vardiya_masa_fk",
                table: "gunluk_vardiya_masa",
                column: "personel_id",
                principalTable: "personel",
                principalColumn: "personel_id");

            migrationBuilder.AddForeignKey(
                name: "fk_birim_istasyon_birim_tur_id",
                table: "istasyon_birim",
                column: "istasyon_birim_tur_id",
                principalTable: "istasyon_birim_tur",
                principalColumn: "istasyon_birim_tur_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_birim_istasyon_id",
                table: "istasyon_birim",
                column: "istasyon_id",
                principalTable: "istasyon",
                principalColumn: "istasyon_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "istasyon_durum_fk",
                table: "istasyon_durum",
                column: "istasyon_durum_tur_id",
                principalTable: "istasyon_durum_tur",
                principalColumn: "istasyon_durum_tur_id");

            migrationBuilder.AddForeignKey(
                name: "istasyon_istasyon_durum_fk",
                table: "istasyon_durum",
                column: "istasyon_id",
                principalTable: "istasyon",
                principalColumn: "istasyon_id");

            migrationBuilder.AddForeignKey(
                name: "fk_masa_parent_id",
                table: "masa",
                column: "parent_id",
                principalTable: "masa",
                principalColumn: "masa_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_masa_trafik_yonetim_merkezi_id",
                table: "masa",
                column: "trafik_yonetim_merkezi_id",
                principalTable: "trafik_yonetim_merkezi",
                principalColumn: "trafik_yonetim_merkezi_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "mesai_fk",
                table: "mesai",
                column: "mesai_tur_id",
                principalTable: "mesai_tur",
                principalColumn: "mesai_tur_id");

            migrationBuilder.AddForeignKey(
                name: "mesai_fk2",
                table: "mesai",
                column: "personel_no",
                principalTable: "personel",
                principalColumn: "personel_no");

            migrationBuilder.AddForeignKey(
                name: "personel_fk",
                table: "personel",
                column: "org_birim_kod",
                principalTable: "org_birim",
                principalColumn: "org_birim_kod");

            migrationBuilder.AddForeignKey(
                name: "personel_izin_fk",
                table: "personel_izin",
                column: "izin_tur_id",
                principalTable: "izin_tur",
                principalColumn: "izin_tur_id");

            migrationBuilder.AddForeignKey(
                name: "personel_personel_izin_fk",
                table: "personel_izin",
                column: "personel_id",
                principalTable: "personel",
                principalColumn: "personel_id");

            migrationBuilder.AddForeignKey(
                name: "trafik_yonetim_merkezi_fk",
                table: "trafik_yonetim_merkezi",
                column: "bolge_id",
                principalTable: "bolge",
                principalColumn: "bolge_id");

            migrationBuilder.AddForeignKey(
                name: "fk_vardiya_vardiya_sablon_id",
                table: "vardiya",
                column: "vardiya_sablon_id",
                principalTable: "vardiya_sablon_yer",
                principalColumn: "vardiya_sablon_yer_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "vardiya_sablon_yer_fk",
                table: "vardiya_sablon_yer",
                column: "masa_id",
                principalTable: "masa",
                principalColumn: "masa_id");

            migrationBuilder.AddForeignKey(
                name: "vardiya_sablon_yer_fk_1",
                table: "vardiya_sablon_yer",
                column: "istasyon_birim_id",
                principalTable: "istasyon_birim",
                principalColumn: "istasyon_birim_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "gorevlendirme_fk",
                table: "gorevlendirme");

            migrationBuilder.DropForeignKey(
                name: "gorevlendirme_fk2",
                table: "gorevlendirme");

            migrationBuilder.DropForeignKey(
                name: "gorevlendirme_personel_fk",
                table: "gorevlendirme");

            migrationBuilder.DropForeignKey(
                name: "fk_gunluk_vardiya_istasyon_birim_id",
                table: "gunluk_vardiya_istasyon_birim");

            migrationBuilder.DropForeignKey(
                name: "fk_gunluk_vardiya_istasyon_vardiya_id",
                table: "gunluk_vardiya_istasyon_birim");

            migrationBuilder.DropForeignKey(
                name: "gunluk_vardiya_istasyon_birim_fk",
                table: "gunluk_vardiya_istasyon_birim");

            migrationBuilder.DropForeignKey(
                name: "fk_gunluk_vardiya_masa_id",
                table: "gunluk_vardiya_masa");

            migrationBuilder.DropForeignKey(
                name: "fk_gunluk_vardiya_masa_vardiya_id",
                table: "gunluk_vardiya_masa");

            migrationBuilder.DropForeignKey(
                name: "gunluk_vardiya_masa_fk",
                table: "gunluk_vardiya_masa");

            migrationBuilder.DropForeignKey(
                name: "fk_birim_istasyon_birim_tur_id",
                table: "istasyon_birim");

            migrationBuilder.DropForeignKey(
                name: "fk_birim_istasyon_id",
                table: "istasyon_birim");

            migrationBuilder.DropForeignKey(
                name: "istasyon_durum_fk",
                table: "istasyon_durum");

            migrationBuilder.DropForeignKey(
                name: "istasyon_istasyon_durum_fk",
                table: "istasyon_durum");

            migrationBuilder.DropForeignKey(
                name: "fk_masa_parent_id",
                table: "masa");

            migrationBuilder.DropForeignKey(
                name: "fk_masa_trafik_yonetim_merkezi_id",
                table: "masa");

            migrationBuilder.DropForeignKey(
                name: "mesai_fk",
                table: "mesai");

            migrationBuilder.DropForeignKey(
                name: "mesai_fk2",
                table: "mesai");

            migrationBuilder.DropForeignKey(
                name: "personel_fk",
                table: "personel");

            migrationBuilder.DropForeignKey(
                name: "personel_izin_fk",
                table: "personel_izin");

            migrationBuilder.DropForeignKey(
                name: "personel_personel_izin_fk",
                table: "personel_izin");

            migrationBuilder.DropForeignKey(
                name: "trafik_yonetim_merkezi_fk",
                table: "trafik_yonetim_merkezi");

            migrationBuilder.DropForeignKey(
                name: "fk_vardiya_vardiya_sablon_id",
                table: "vardiya");

            migrationBuilder.DropForeignKey(
                name: "vardiya_sablon_yer_fk",
                table: "vardiya_sablon_yer");

            migrationBuilder.DropForeignKey(
                name: "vardiya_sablon_yer_fk_1",
                table: "vardiya_sablon_yer");

            migrationBuilder.DropTable(
                name: "IdentityRole<Guid>");

            migrationBuilder.DropTable(
                name: "IdentityUser<Guid>");

            migrationBuilder.DropPrimaryKey(
                name: "vardiya_pkey",
                table: "vardiya");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_personel_personel_no",
                table: "personel");

            migrationBuilder.DropPrimaryKey(
                name: "personel_pk",
                table: "personel");

            migrationBuilder.DropIndex(
                name: "IX_personel_org_birim_kod",
                table: "personel");

            migrationBuilder.DropIndex(
                name: "personel_un",
                table: "personel");

            migrationBuilder.DropPrimaryKey(
                name: "mesai_pk",
                table: "mesai");

            migrationBuilder.DropIndex(
                name: "IX_mesai_personel_no",
                table: "mesai");

            migrationBuilder.DropPrimaryKey(
                name: "masa_pkey",
                table: "masa");

            migrationBuilder.DropPrimaryKey(
                name: "istasyon_pk",
                table: "istasyon");

            migrationBuilder.DropPrimaryKey(
                name: "gorevlendirme_pk",
                table: "gorevlendirme");

            migrationBuilder.DropPrimaryKey(
                name: "bolge_pk",
                table: "bolge");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "vardiya_sablon_pkey",
                table: "vardiya_sablon_yer");

            migrationBuilder.DropPrimaryKey(
                name: "trafik_yonetim_merkezi_pkey",
                table: "trafik_yonetim_merkezi");

            migrationBuilder.DropIndex(
                name: "fki_fk_trafik_yonetim_merkezi_bolge",
                table: "trafik_yonetim_merkezi");

            migrationBuilder.DropIndex(
                name: "trafik_yonetim_merkezi_un",
                table: "trafik_yonetim_merkezi");

            migrationBuilder.DropPrimaryKey(
                name: "personel_izin_pk",
                table: "personel_izin");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_org_birim_org_birim_kod",
                table: "org_birim");

            migrationBuilder.DropPrimaryKey(
                name: "org_birim_pk",
                table: "org_birim");

            migrationBuilder.DropIndex(
                name: "org_birim_un",
                table: "org_birim");

            migrationBuilder.DropPrimaryKey(
                name: "mesai_tur_pk",
                table: "mesai_tur");

            migrationBuilder.DropPrimaryKey(
                name: "izin_tur_pk",
                table: "izin_tur");

            migrationBuilder.DropPrimaryKey(
                name: "istasyon_durum_tur_pkey",
                table: "istasyon_durum_tur");

            migrationBuilder.DropPrimaryKey(
                name: "istasyon_durum_pkey",
                table: "istasyon_durum");

            migrationBuilder.DropPrimaryKey(
                name: "istasyon_birim_tur_pk",
                table: "istasyon_birim_tur");

            migrationBuilder.DropPrimaryKey(
                name: "istasyon_birim_pk",
                table: "istasyon_birim");

            migrationBuilder.DropPrimaryKey(
                name: "gunluk_vardiya_pkey",
                table: "gunluk_vardiya_masa");

            migrationBuilder.DropPrimaryKey(
                name: "gunluk_vardiya_istasyon_pkey_1",
                table: "gunluk_vardiya_istasyon_birim");

            migrationBuilder.DropPrimaryKey(
                name: "gorevlendirme_tur_pk",
                table: "gorevlendirme_tur");

            migrationBuilder.DropPrimaryKey(
                name: "gorev_tur_pk",
                table: "gorev_tur");

            migrationBuilder.DropIndex(
                name: "gorev_tur_un",
                table: "gorev_tur");

            migrationBuilder.RenameTable(
                name: "vardiya",
                newName: "Vardiya");

            migrationBuilder.RenameTable(
                name: "personel",
                newName: "Personel");

            migrationBuilder.RenameTable(
                name: "mesai",
                newName: "Mesai");

            migrationBuilder.RenameTable(
                name: "masa",
                newName: "Masa");

            migrationBuilder.RenameTable(
                name: "istasyon",
                newName: "Istasyon");

            migrationBuilder.RenameTable(
                name: "gorevlendirme",
                newName: "Gorevlendirme");

            migrationBuilder.RenameTable(
                name: "bolge",
                newName: "Bolge");

            migrationBuilder.RenameTable(
                name: "vardiya_sablon_yer",
                newName: "VardiyaSablonYer");

            migrationBuilder.RenameTable(
                name: "trafik_yonetim_merkezi",
                newName: "TrafikYonetimMerkezi");

            migrationBuilder.RenameTable(
                name: "personel_izin",
                newName: "PersonelIzin");

            migrationBuilder.RenameTable(
                name: "org_birim",
                newName: "OrgBirim");

            migrationBuilder.RenameTable(
                name: "mesai_tur",
                newName: "MesaiTur");

            migrationBuilder.RenameTable(
                name: "izin_tur",
                newName: "IzinTur");

            migrationBuilder.RenameTable(
                name: "istasyon_durum_tur",
                newName: "IstasyonDurumTur");

            migrationBuilder.RenameTable(
                name: "istasyon_durum",
                newName: "IstasyonDurum");

            migrationBuilder.RenameTable(
                name: "istasyon_birim_tur",
                newName: "IstasyonBirimTur");

            migrationBuilder.RenameTable(
                name: "istasyon_birim",
                newName: "IstasyonBirim");

            migrationBuilder.RenameTable(
                name: "gunluk_vardiya_masa",
                newName: "GunlukVardiyaMasa");

            migrationBuilder.RenameTable(
                name: "gunluk_vardiya_istasyon_birim",
                newName: "GunlukVardiyaIstasyonBirim");

            migrationBuilder.RenameTable(
                name: "gorevlendirme_tur",
                newName: "GorevlendirmeTur");

            migrationBuilder.RenameTable(
                name: "gorev_tur",
                newName: "GorevTur");

            migrationBuilder.RenameColumn(
                name: "vardiya_sablon_id",
                table: "Vardiya",
                newName: "VardiyaSablonId");

            migrationBuilder.RenameColumn(
                name: "sira_no",
                table: "Vardiya",
                newName: "SiraNo");

            migrationBuilder.RenameColumn(
                name: "bitis_saat",
                table: "Vardiya",
                newName: "BitisSaat");

            migrationBuilder.RenameColumn(
                name: "baslangic_saat",
                table: "Vardiya",
                newName: "BaslangicSaat");

            migrationBuilder.RenameColumn(
                name: "vardiya_id",
                table: "Vardiya",
                newName: "VardiyaId");

            migrationBuilder.RenameIndex(
                name: "fki_fk_vardiya_vardiya_sablon_id",
                table: "Vardiya",
                newName: "IX_Vardiya_VardiyaSablonId");

            migrationBuilder.RenameColumn(
                name: "soyad",
                table: "Personel",
                newName: "Soyad");

            migrationBuilder.RenameColumn(
                name: "ad",
                table: "Personel",
                newName: "Ad");

            migrationBuilder.RenameColumn(
                name: "tc_kimlik_no",
                table: "Personel",
                newName: "TcKimlikNo");

            migrationBuilder.RenameColumn(
                name: "sicil_no",
                table: "Personel",
                newName: "SicilNo");

            migrationBuilder.RenameColumn(
                name: "personel_no",
                table: "Personel",
                newName: "PersonelNo");

            migrationBuilder.RenameColumn(
                name: "org_birim_kod",
                table: "Personel",
                newName: "OrgBirimKod");

            migrationBuilder.RenameColumn(
                name: "personel_id",
                table: "Personel",
                newName: "PersonelId");

            migrationBuilder.RenameColumn(
                name: "personel_no",
                table: "Mesai",
                newName: "PersonelNo");

            migrationBuilder.RenameColumn(
                name: "mesai_tur_id",
                table: "Mesai",
                newName: "MesaiTurId");

            migrationBuilder.RenameColumn(
                name: "mesai_bitis",
                table: "Mesai",
                newName: "MesaiBitis");

            migrationBuilder.RenameColumn(
                name: "mesai_baslangic",
                table: "Mesai",
                newName: "MesaiBaslangic");

            migrationBuilder.RenameColumn(
                name: "mesai_id",
                table: "Mesai",
                newName: "MesaiId");

            migrationBuilder.RenameIndex(
                name: "IX_mesai_mesai_tur_id",
                table: "Mesai",
                newName: "IX_Mesai_MesaiTurId");

            migrationBuilder.RenameColumn(
                name: "tanim",
                table: "Masa",
                newName: "Tanim");

            migrationBuilder.RenameColumn(
                name: "renk",
                table: "Masa",
                newName: "Renk");

            migrationBuilder.RenameColumn(
                name: "aktif",
                table: "Masa",
                newName: "Aktif");

            migrationBuilder.RenameColumn(
                name: "trafik_yonetim_merkezi_id",
                table: "Masa",
                newName: "TrafikYonetimMerkeziId");

            migrationBuilder.RenameColumn(
                name: "parent_id",
                table: "Masa",
                newName: "ParentId");

            migrationBuilder.RenameColumn(
                name: "is_clone",
                table: "Masa",
                newName: "IsClone");

            migrationBuilder.RenameColumn(
                name: "masa_id",
                table: "Masa",
                newName: "MasaId");

            migrationBuilder.RenameIndex(
                name: "fki_fk_masa_trafik_yonetim_merkezi_id",
                table: "Masa",
                newName: "IX_Masa_TrafikYonetimMerkeziId");

            migrationBuilder.RenameIndex(
                name: "fki_fk_masa_parent_id",
                table: "Masa",
                newName: "IX_Masa_ParentId");

            migrationBuilder.RenameColumn(
                name: "istasyon_kod",
                table: "Istasyon",
                newName: "IstasyonKod");

            migrationBuilder.RenameColumn(
                name: "istasyon_ad",
                table: "Istasyon",
                newName: "IstasyonAd");

            migrationBuilder.RenameColumn(
                name: "guncellenme_tarihi",
                table: "Istasyon",
                newName: "GuncellenmeTarihi");

            migrationBuilder.RenameColumn(
                name: "istasyon_id",
                table: "Istasyon",
                newName: "IstasyonId");

            migrationBuilder.RenameColumn(
                name: "aciklama",
                table: "Gorevlendirme",
                newName: "Aciklama");

            migrationBuilder.RenameColumn(
                name: "personel_id",
                table: "Gorevlendirme",
                newName: "PersonelId");

            migrationBuilder.RenameColumn(
                name: "gorevlendirme_tur_id",
                table: "Gorevlendirme",
                newName: "GorevlendirmeTurId");

            migrationBuilder.RenameColumn(
                name: "gorevlendirme_bitis",
                table: "Gorevlendirme",
                newName: "GorevlendirmeBitis");

            migrationBuilder.RenameColumn(
                name: "gorevlendirme_birim",
                table: "Gorevlendirme",
                newName: "GorevlendirmeBirim");

            migrationBuilder.RenameColumn(
                name: "gorevlendirme_baslangic",
                table: "Gorevlendirme",
                newName: "GorevlendirmeBaslangic");

            migrationBuilder.RenameColumn(
                name: "gorevlendirilecek_personel_no",
                table: "Gorevlendirme",
                newName: "GorevlendirilecekPersonelNo");

            migrationBuilder.RenameColumn(
                name: "gorev_tur_id",
                table: "Gorevlendirme",
                newName: "GorevTurId");

            migrationBuilder.RenameColumn(
                name: "birim_tur",
                table: "Gorevlendirme",
                newName: "BirimTur");

            migrationBuilder.RenameColumn(
                name: "birim_adi",
                table: "Gorevlendirme",
                newName: "BirimAdi");

            migrationBuilder.RenameColumn(
                name: "belgenet_tarih",
                table: "Gorevlendirme",
                newName: "BelgenetTarih");

            migrationBuilder.RenameColumn(
                name: "belgenet_sayi",
                table: "Gorevlendirme",
                newName: "BelgenetSayi");

            migrationBuilder.RenameColumn(
                name: "gorevlendirme_id",
                table: "Gorevlendirme",
                newName: "GorevlendirmeId");

            migrationBuilder.RenameIndex(
                name: "IX_gorevlendirme_personel_id",
                table: "Gorevlendirme",
                newName: "IX_Gorevlendirme_PersonelId");

            migrationBuilder.RenameIndex(
                name: "IX_gorevlendirme_gorevlendirme_tur_id",
                table: "Gorevlendirme",
                newName: "IX_Gorevlendirme_GorevlendirmeTurId");

            migrationBuilder.RenameIndex(
                name: "IX_gorevlendirme_gorev_tur_id",
                table: "Gorevlendirme",
                newName: "IX_Gorevlendirme_GorevTurId");

            migrationBuilder.RenameColumn(
                name: "bolge_kisa_ad",
                table: "Bolge",
                newName: "BolgeKisaAd");

            migrationBuilder.RenameColumn(
                name: "bolge_ad",
                table: "Bolge",
                newName: "BolgeAd");

            migrationBuilder.RenameColumn(
                name: "bolge_id",
                table: "Bolge",
                newName: "BolgeId");

            migrationBuilder.RenameColumn(
                name: "tanim",
                table: "VardiyaSablonYer",
                newName: "Tanim");

            migrationBuilder.RenameColumn(
                name: "max_vardiya",
                table: "VardiyaSablonYer",
                newName: "MaxVardiya");

            migrationBuilder.RenameColumn(
                name: "masa_id",
                table: "VardiyaSablonYer",
                newName: "MasaId");

            migrationBuilder.RenameColumn(
                name: "istasyon_birim_id",
                table: "VardiyaSablonYer",
                newName: "IstasyonBirimId");

            migrationBuilder.RenameColumn(
                name: "gecerlilik_bitis",
                table: "VardiyaSablonYer",
                newName: "GecerlilikBitis");

            migrationBuilder.RenameColumn(
                name: "gecerlilik_baslangic",
                table: "VardiyaSablonYer",
                newName: "GecerlilikBaslangic");

            migrationBuilder.RenameColumn(
                name: "vardiya_sablon_yer_id",
                table: "VardiyaSablonYer",
                newName: "VardiyaSablonYerId");

            migrationBuilder.RenameIndex(
                name: "IX_vardiya_sablon_yer_masa_id",
                table: "VardiyaSablonYer",
                newName: "IX_VardiyaSablonYer_MasaId");

            migrationBuilder.RenameIndex(
                name: "IX_vardiya_sablon_yer_istasyon_birim_id",
                table: "VardiyaSablonYer",
                newName: "IX_VardiyaSablonYer_IstasyonBirimId");

            migrationBuilder.RenameColumn(
                name: "tanim",
                table: "TrafikYonetimMerkezi",
                newName: "Tanim");

            migrationBuilder.RenameColumn(
                name: "aktif",
                table: "TrafikYonetimMerkezi",
                newName: "Aktif");

            migrationBuilder.RenameColumn(
                name: "bolge_id",
                table: "TrafikYonetimMerkezi",
                newName: "BolgeId");

            migrationBuilder.RenameColumn(
                name: "birim_kodu",
                table: "TrafikYonetimMerkezi",
                newName: "BirimKodu");

            migrationBuilder.RenameColumn(
                name: "trafik_yonetim_merkezi_id",
                table: "TrafikYonetimMerkezi",
                newName: "TrafikYonetimMerkeziId");

            migrationBuilder.RenameIndex(
                name: "fki_fk_tym_bolge_id",
                table: "TrafikYonetimMerkezi",
                newName: "IX_TrafikYonetimMerkezi_BolgeId");

            migrationBuilder.RenameColumn(
                name: "aciklama",
                table: "PersonelIzin",
                newName: "Aciklama");

            migrationBuilder.RenameColumn(
                name: "personel_id",
                table: "PersonelIzin",
                newName: "PersonelId");

            migrationBuilder.RenameColumn(
                name: "izin_tur_id",
                table: "PersonelIzin",
                newName: "IzinTurId");

            migrationBuilder.RenameColumn(
                name: "izin_bitis_tarihi",
                table: "PersonelIzin",
                newName: "IzinBitisTarihi");

            migrationBuilder.RenameColumn(
                name: "izin_baslangic_tarihi",
                table: "PersonelIzin",
                newName: "IzinBaslangicTarihi");

            migrationBuilder.RenameColumn(
                name: "personel_izin_id",
                table: "PersonelIzin",
                newName: "PersonelIzinId");

            migrationBuilder.RenameIndex(
                name: "IX_personel_izin_personel_id",
                table: "PersonelIzin",
                newName: "IX_PersonelIzin_PersonelId");

            migrationBuilder.RenameIndex(
                name: "IX_personel_izin_izin_tur_id",
                table: "PersonelIzin",
                newName: "IX_PersonelIzin_IzinTurId");

            migrationBuilder.RenameColumn(
                name: "ust_org_birim_kod",
                table: "OrgBirim",
                newName: "UstOrgBirimKod");

            migrationBuilder.RenameColumn(
                name: "org_birim_tanim",
                table: "OrgBirim",
                newName: "OrgBirimTanim");

            migrationBuilder.RenameColumn(
                name: "org_birim_kod",
                table: "OrgBirim",
                newName: "OrgBirimKod");

            migrationBuilder.RenameColumn(
                name: "org_birim_id",
                table: "OrgBirim",
                newName: "OrgBirimId");

            migrationBuilder.RenameColumn(
                name: "birim",
                table: "MesaiTur",
                newName: "Birim");

            migrationBuilder.RenameColumn(
                name: "mesai_tur_tanim",
                table: "MesaiTur",
                newName: "MesaiTurTanim");

            migrationBuilder.RenameColumn(
                name: "mesai_tur_id",
                table: "MesaiTur",
                newName: "MesaiTurId");

            migrationBuilder.RenameColumn(
                name: "tanim",
                table: "IzinTur",
                newName: "Tanim");

            migrationBuilder.RenameColumn(
                name: "aciklama",
                table: "IzinTur",
                newName: "Aciklama");

            migrationBuilder.RenameColumn(
                name: "izin_tur_id",
                table: "IzinTur",
                newName: "IzinTurId");

            migrationBuilder.RenameColumn(
                name: "tanim",
                table: "IstasyonDurumTur",
                newName: "Tanim");

            migrationBuilder.RenameColumn(
                name: "istasyon_durum_tur_id",
                table: "IstasyonDurumTur",
                newName: "IstasyonDurumTurId");

            migrationBuilder.RenameColumn(
                name: "istasyon_id",
                table: "IstasyonDurum",
                newName: "IstasyonId");

            migrationBuilder.RenameColumn(
                name: "istasyon_durum_tur_id",
                table: "IstasyonDurum",
                newName: "IstasyonDurumTurId");

            migrationBuilder.RenameColumn(
                name: "gecerlilik_bitis",
                table: "IstasyonDurum",
                newName: "GecerlilikBitis");

            migrationBuilder.RenameColumn(
                name: "gecerlilik_baslangic",
                table: "IstasyonDurum",
                newName: "GecerlilikBaslangic");

            migrationBuilder.RenameColumn(
                name: "bitis_zamani",
                table: "IstasyonDurum",
                newName: "BitisZamani");

            migrationBuilder.RenameColumn(
                name: "baslangic_zamani",
                table: "IstasyonDurum",
                newName: "BaslangicZamani");

            migrationBuilder.RenameColumn(
                name: "istasyon_durum_id",
                table: "IstasyonDurum",
                newName: "IstasyonDurumId");

            migrationBuilder.RenameIndex(
                name: "IX_istasyon_durum_istasyon_id",
                table: "IstasyonDurum",
                newName: "IX_IstasyonDurum_IstasyonId");

            migrationBuilder.RenameIndex(
                name: "IX_istasyon_durum_istasyon_durum_tur_id",
                table: "IstasyonDurum",
                newName: "IX_IstasyonDurum_IstasyonDurumTurId");

            migrationBuilder.RenameColumn(
                name: "istasyon_birim_tur_tanim",
                table: "IstasyonBirimTur",
                newName: "IstasyonBirimTurTanim");

            migrationBuilder.RenameColumn(
                name: "istasyon_birim_tur_id",
                table: "IstasyonBirimTur",
                newName: "IstasyonBirimTurId");

            migrationBuilder.RenameColumn(
                name: "istasyon_id",
                table: "IstasyonBirim",
                newName: "IstasyonId");

            migrationBuilder.RenameColumn(
                name: "istasyon_birim_tur_id",
                table: "IstasyonBirim",
                newName: "IstasyonBirimTurId");

            migrationBuilder.RenameColumn(
                name: "istasyon_birim_id",
                table: "IstasyonBirim",
                newName: "IstasyonBirimId");

            migrationBuilder.RenameIndex(
                name: "fki_fk_birim_istasyon_id",
                table: "IstasyonBirim",
                newName: "IX_IstasyonBirim_IstasyonId");

            migrationBuilder.RenameIndex(
                name: "fki_fk_birim_istasyon_birim_tur_id",
                table: "IstasyonBirim",
                newName: "IX_IstasyonBirim_IstasyonBirimTurId");

            migrationBuilder.RenameColumn(
                name: "tarih",
                table: "GunlukVardiyaMasa",
                newName: "Tarih");

            migrationBuilder.RenameColumn(
                name: "vardiya_id",
                table: "GunlukVardiyaMasa",
                newName: "VardiyaId");

            migrationBuilder.RenameColumn(
                name: "personel_id",
                table: "GunlukVardiyaMasa",
                newName: "PersonelId");

            migrationBuilder.RenameColumn(
                name: "masa_id",
                table: "GunlukVardiyaMasa",
                newName: "MasaId");

            migrationBuilder.RenameColumn(
                name: "gunluk_vardiya_id",
                table: "GunlukVardiyaMasa",
                newName: "GunlukVardiyaId");

            migrationBuilder.RenameIndex(
                name: "fki_fk_gunluk_vardiya_personel_id",
                table: "GunlukVardiyaMasa",
                newName: "IX_GunlukVardiyaMasa_PersonelId");

            migrationBuilder.RenameIndex(
                name: "fki_fk_gunluk_vardiya_masa_vardiya_id",
                table: "GunlukVardiyaMasa",
                newName: "IX_GunlukVardiyaMasa_VardiyaId");

            migrationBuilder.RenameIndex(
                name: "fki_fk_gunluk_vardiya_masa_id",
                table: "GunlukVardiyaMasa",
                newName: "IX_GunlukVardiyaMasa_MasaId");

            migrationBuilder.RenameColumn(
                name: "tarih",
                table: "GunlukVardiyaIstasyonBirim",
                newName: "Tarih");

            migrationBuilder.RenameColumn(
                name: "vardiya_id",
                table: "GunlukVardiyaIstasyonBirim",
                newName: "VardiyaId");

            migrationBuilder.RenameColumn(
                name: "personel_id",
                table: "GunlukVardiyaIstasyonBirim",
                newName: "PersonelId");

            migrationBuilder.RenameColumn(
                name: "istasyon_birim_id",
                table: "GunlukVardiyaIstasyonBirim",
                newName: "IstasyonBirimId");

            migrationBuilder.RenameColumn(
                name: "gunluk_vardiya_istasyon_birim_id",
                table: "GunlukVardiyaIstasyonBirim",
                newName: "GunlukVardiyaIstasyonBirimId");

            migrationBuilder.RenameIndex(
                name: "IX_gunluk_vardiya_istasyon_birim_personel_id",
                table: "GunlukVardiyaIstasyonBirim",
                newName: "IX_GunlukVardiyaIstasyonBirim_PersonelId");

            migrationBuilder.RenameIndex(
                name: "fki_fk_gunluk_vardiya_istasyon_vardiya_id",
                table: "GunlukVardiyaIstasyonBirim",
                newName: "IX_GunlukVardiyaIstasyonBirim_VardiyaId");

            migrationBuilder.RenameIndex(
                name: "fki_fk_gunluk_vardiya_istasyon_birim_id",
                table: "GunlukVardiyaIstasyonBirim",
                newName: "IX_GunlukVardiyaIstasyonBirim_IstasyonBirimId");

            migrationBuilder.RenameColumn(
                name: "tanim",
                table: "GorevlendirmeTur",
                newName: "Tanim");

            migrationBuilder.RenameColumn(
                name: "gorevlendirme_tur_id",
                table: "GorevlendirmeTur",
                newName: "GorevlendirmeTurId");

            migrationBuilder.RenameColumn(
                name: "tanim",
                table: "GorevTur",
                newName: "Tanim");

            migrationBuilder.RenameColumn(
                name: "gorev_tur_id",
                table: "GorevTur",
                newName: "GorevTurId");

            migrationBuilder.AlterColumn<string>(
                name: "OrgBirimKod",
                table: "Personel",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AddColumn<long>(
                name: "OrgBirimKodNavigationOrgBirimId",
                table: "Personel",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "PersonelNoNavigationPersonelId",
                table: "Mesai",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GuncellenmeTarihi",
                table: "Istasyon",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "GorevlendirmeBitis",
                table: "Gorevlendirme",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "GorevlendirmeBirim",
                table: "Gorevlendirme",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "org_birim_kod");

            migrationBuilder.AlterColumn<DateTime>(
                name: "GorevlendirmeBaslangic",
                table: "Gorevlendirme",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BelgenetTarih",
                table: "Gorevlendirme",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GecerlilikBitis",
                table: "VardiyaSablonYer",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "GecerlilikBaslangic",
                table: "VardiyaSablonYer",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BirimKodu",
                table: "TrafikYonetimMerkezi",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IzinBitisTarihi",
                table: "PersonelIzin",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "IzinBaslangicTarihi",
                table: "PersonelIzin",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "OrgBirimKod",
                table: "OrgBirim",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Tarih",
                table: "GunlukVardiyaMasa",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Tarih",
                table: "GunlukVardiyaIstasyonBirim",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "Tanim",
                table: "GorevTur",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vardiya",
                table: "Vardiya",
                column: "VardiyaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personel",
                table: "Personel",
                column: "PersonelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mesai",
                table: "Mesai",
                column: "MesaiId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Masa",
                table: "Masa",
                column: "MasaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Istasyon",
                table: "Istasyon",
                column: "IstasyonId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gorevlendirme",
                table: "Gorevlendirme",
                column: "GorevlendirmeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bolge",
                table: "Bolge",
                column: "BolgeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_VardiyaSablonYer",
                table: "VardiyaSablonYer",
                column: "VardiyaSablonYerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrafikYonetimMerkezi",
                table: "TrafikYonetimMerkezi",
                column: "TrafikYonetimMerkeziId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonelIzin",
                table: "PersonelIzin",
                column: "PersonelIzinId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrgBirim",
                table: "OrgBirim",
                column: "OrgBirimId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MesaiTur",
                table: "MesaiTur",
                column: "MesaiTurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IzinTur",
                table: "IzinTur",
                column: "IzinTurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IstasyonDurumTur",
                table: "IstasyonDurumTur",
                column: "IstasyonDurumTurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IstasyonDurum",
                table: "IstasyonDurum",
                column: "IstasyonDurumId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IstasyonBirimTur",
                table: "IstasyonBirimTur",
                column: "IstasyonBirimTurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IstasyonBirim",
                table: "IstasyonBirim",
                column: "IstasyonBirimId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GunlukVardiyaMasa",
                table: "GunlukVardiyaMasa",
                column: "GunlukVardiyaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GunlukVardiyaIstasyonBirim",
                table: "GunlukVardiyaIstasyonBirim",
                column: "GunlukVardiyaIstasyonBirimId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GorevlendirmeTur",
                table: "GorevlendirmeTur",
                column: "GorevlendirmeTurId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GorevTur",
                table: "GorevTur",
                column: "GorevTurId");

            migrationBuilder.CreateIndex(
                name: "IX_Personel_OrgBirimKodNavigationOrgBirimId",
                table: "Personel",
                column: "OrgBirimKodNavigationOrgBirimId");

            migrationBuilder.CreateIndex(
                name: "IX_Mesai_PersonelNoNavigationPersonelId",
                table: "Mesai",
                column: "PersonelNoNavigationPersonelId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevlendirme_GorevTur_GorevTurId",
                table: "Gorevlendirme",
                column: "GorevTurId",
                principalTable: "GorevTur",
                principalColumn: "GorevTurId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevlendirme_GorevlendirmeTur_GorevlendirmeTurId",
                table: "Gorevlendirme",
                column: "GorevlendirmeTurId",
                principalTable: "GorevlendirmeTur",
                principalColumn: "GorevlendirmeTurId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Gorevlendirme_Personel_PersonelId",
                table: "Gorevlendirme",
                column: "PersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_GunlukVardiyaIstasyonBirim_IstasyonBirim_IstasyonBirimId",
                table: "GunlukVardiyaIstasyonBirim",
                column: "IstasyonBirimId",
                principalTable: "IstasyonBirim",
                principalColumn: "IstasyonBirimId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GunlukVardiyaIstasyonBirim_Personel_PersonelId",
                table: "GunlukVardiyaIstasyonBirim",
                column: "PersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GunlukVardiyaIstasyonBirim_Vardiya_VardiyaId",
                table: "GunlukVardiyaIstasyonBirim",
                column: "VardiyaId",
                principalTable: "Vardiya",
                principalColumn: "VardiyaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GunlukVardiyaMasa_Masa_MasaId",
                table: "GunlukVardiyaMasa",
                column: "MasaId",
                principalTable: "Masa",
                principalColumn: "MasaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GunlukVardiyaMasa_Personel_PersonelId",
                table: "GunlukVardiyaMasa",
                column: "PersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GunlukVardiyaMasa_Vardiya_VardiyaId",
                table: "GunlukVardiyaMasa",
                column: "VardiyaId",
                principalTable: "Vardiya",
                principalColumn: "VardiyaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IstasyonBirim_IstasyonBirimTur_IstasyonBirimTurId",
                table: "IstasyonBirim",
                column: "IstasyonBirimTurId",
                principalTable: "IstasyonBirimTur",
                principalColumn: "IstasyonBirimTurId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IstasyonBirim_Istasyon_IstasyonId",
                table: "IstasyonBirim",
                column: "IstasyonId",
                principalTable: "Istasyon",
                principalColumn: "IstasyonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IstasyonDurum_IstasyonDurumTur_IstasyonDurumTurId",
                table: "IstasyonDurum",
                column: "IstasyonDurumTurId",
                principalTable: "IstasyonDurumTur",
                principalColumn: "IstasyonDurumTurId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IstasyonDurum_Istasyon_IstasyonId",
                table: "IstasyonDurum",
                column: "IstasyonId",
                principalTable: "Istasyon",
                principalColumn: "IstasyonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Masa_Masa_ParentId",
                table: "Masa",
                column: "ParentId",
                principalTable: "Masa",
                principalColumn: "MasaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Masa_TrafikYonetimMerkezi_TrafikYonetimMerkeziId",
                table: "Masa",
                column: "TrafikYonetimMerkeziId",
                principalTable: "TrafikYonetimMerkezi",
                principalColumn: "TrafikYonetimMerkeziId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mesai_MesaiTur_MesaiTurId",
                table: "Mesai",
                column: "MesaiTurId",
                principalTable: "MesaiTur",
                principalColumn: "MesaiTurId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mesai_Personel_PersonelNoNavigationPersonelId",
                table: "Mesai",
                column: "PersonelNoNavigationPersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personel_OrgBirim_OrgBirimKodNavigationOrgBirimId",
                table: "Personel",
                column: "OrgBirimKodNavigationOrgBirimId",
                principalTable: "OrgBirim",
                principalColumn: "OrgBirimId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonelIzin_IzinTur_IzinTurId",
                table: "PersonelIzin",
                column: "IzinTurId",
                principalTable: "IzinTur",
                principalColumn: "IzinTurId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PersonelIzin_Personel_PersonelId",
                table: "PersonelIzin",
                column: "PersonelId",
                principalTable: "Personel",
                principalColumn: "PersonelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TrafikYonetimMerkezi_Bolge_BolgeId",
                table: "TrafikYonetimMerkezi",
                column: "BolgeId",
                principalTable: "Bolge",
                principalColumn: "BolgeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vardiya_VardiyaSablonYer_VardiyaSablonId",
                table: "Vardiya",
                column: "VardiyaSablonId",
                principalTable: "VardiyaSablonYer",
                principalColumn: "VardiyaSablonYerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_VardiyaSablonYer_IstasyonBirim_IstasyonBirimId",
                table: "VardiyaSablonYer",
                column: "IstasyonBirimId",
                principalTable: "IstasyonBirim",
                principalColumn: "IstasyonBirimId");

            migrationBuilder.AddForeignKey(
                name: "FK_VardiyaSablonYer_Masa_MasaId",
                table: "VardiyaSablonYer",
                column: "MasaId",
                principalTable: "Masa",
                principalColumn: "MasaId");
        }
    }
}
