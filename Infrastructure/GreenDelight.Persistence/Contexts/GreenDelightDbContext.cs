using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Concrete.TryEntities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Contexts
{
    public partial class GreenDelightDbContext : IdentityDbContext<User, UserRole, Guid>
    {
        public GreenDelightDbContext()
        {

        }
        public GreenDelightDbContext(DbContextOptions options) : base(options)
        {

        }
        DbSet<Adress> Adresses { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderItem> Items { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserRole> UserRoles { get; set; }
        DbSet<Product> Products { get; set; }

        DbSet<ErrorLog> ErrorLogs { get; set; }
        DbSet<Comment> Comments { get; set; }
        DbSet<Contact> Contacts { get; set; }
        DbSet<About> Abouts { get; set; }

        //ÖRNEKTİR
        public virtual DbSet<Bolge> Bolge { get; set; }

        public virtual DbSet<GorevTur> GorevTur { get; set; }

        public virtual DbSet<Gorevlendirme> Gorevlendirme { get; set; }

        public virtual DbSet<GorevlendirmeTur> GorevlendirmeTur { get; set; }

        public virtual DbSet<GunlukVardiyaIstasyonBirim> GunlukVardiyaIstasyonBirim { get; set; }

        public virtual DbSet<GunlukVardiyaMasa> GunlukVardiyaMasa { get; set; }

        public virtual DbSet<Istasyon> Istasyon { get; set; }

        public virtual DbSet<IstasyonBirim> IstasyonBirim { get; set; }

        public virtual DbSet<IstasyonBirimTur> IstasyonBirimTur { get; set; }

        public virtual DbSet<IstasyonDurum> IstasyonDurum { get; set; }

        public virtual DbSet<IstasyonDurumTur> IstasyonDurumTur { get; set; }

        public virtual DbSet<IzinTur> IzinTur { get; set; }

        public virtual DbSet<Masa> Masa { get; set; }

        public virtual DbSet<Mesai> Mesai { get; set; }

        public virtual DbSet<MesaiTur> MesaiTur { get; set; }

        public virtual DbSet<OrgBirim> OrgBirim { get; set; }

        public virtual DbSet<Personel> Personel { get; set; }

        public virtual DbSet<PersonelIzin> PersonelIzin { get; set; }

        public virtual DbSet<TrafikYonetimMerkezi> TrafikYonetimMerkezi { get; set; }

        public virtual DbSet<Vardiya> Vardiya { get; set; }

        public virtual DbSet<VardiyaSablonYer> VardiyaSablonYer { get; set; }
        public virtual DbSet<VardiyaSablon> VardiyaSablon { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Base metodu çağırarak Identity yapılandırmalarını koruyun

            // Identity tablolarının anahtar türünü belirtin
            modelBuilder.Entity<IdentityUser<Guid>>().HasKey(u => u.Id);
            modelBuilder.Entity<IdentityRole<Guid>>().HasKey(r => r.Id);
            modelBuilder.Entity<IdentityUserLogin<Guid>>().HasKey(ul => ul.UserId);
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasKey(ur => new { ur.UserId, ur.RoleId });
            modelBuilder.Entity<IdentityUserClaim<Guid>>().HasKey(uc => uc.Id);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().HasKey(rc => rc.Id);

            modelBuilder.Entity<Bolge>(entity =>
            {
                entity.HasKey(e => e.BolgeId).HasName("bolge_pk");

                entity.ToTable("bolge");

                entity.Property(e => e.BolgeId).HasColumnName("bolge_id");
                entity.Property(e => e.BolgeAd)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("bolge_ad");
                entity.Property(e => e.BolgeKisaAd)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("bolge_kisa_ad");
            });

            modelBuilder.Entity<GorevTur>(entity =>
            {
                entity.HasKey(e => e.GorevTurId).HasName("gorev_tur_pk");

                entity.ToTable("gorev_tur");

                entity.HasIndex(e => e.Tanim, "gorev_tur_un").IsUnique();

                entity.Property(e => e.GorevTurId)
                    .UseIdentityColumn()
                    .HasColumnName("gorev_tur_id");
                entity.Property(e => e.Tanim)
                    .HasColumnType("nvarchar(255)")
                    .HasColumnName("tanim");
            });

            modelBuilder.Entity<Gorevlendirme>(entity =>
            {
                entity.HasKey(e => e.GorevlendirmeId).HasName("gorevlendirme_pk");

                entity.ToTable("gorevlendirme");

                entity.Property(e => e.GorevlendirmeId)
                    .UseIdentityColumn()
                    .HasColumnName("gorevlendirme_id");
                entity.Property(e => e.Aciklama)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("aciklama");
                entity.Property(e => e.BelgenetSayi)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("belgenet_sayi");
                entity.Property(e => e.BelgenetTarih)
                    .HasColumnType("datetime")
                    .HasColumnName("belgenet_tarih");
                entity.Property(e => e.BirimAdi)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("birim_adi");
                entity.Property(e => e.BirimTur)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("birim_tur");
                entity.Property(e => e.GorevTurId).HasColumnName("gorev_tur_id");
                entity.Property(e => e.GorevlendirilecekPersonelNo).HasColumnName("gorevlendirilecek_personel_no");
                entity.Property(e => e.GorevlendirmeBaslangic)
                    .HasDefaultValueSql("GETDATE()")
                    .HasColumnType("datetime")
                    .HasColumnName("gorevlendirme_baslangic");
                entity.Property(e => e.GorevlendirmeBirim)
                    .HasComment("org_birim_kod")
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("gorevlendirme_birim");
                entity.Property(e => e.GorevlendirmeBitis)
                    .HasColumnType("datetime")
                    .HasColumnName("gorevlendirme_bitis");
                entity.Property(e => e.GorevlendirmeTurId).HasColumnName("gorevlendirme_tur_id");
                entity.Property(e => e.PersonelId).HasColumnName("personel_id");

                entity.HasOne(d => d.GorevTur).WithMany(p => p.Gorevlendirme)
                    .HasForeignKey(d => d.GorevTurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gorevlendirme_fk2");

                entity.HasOne(d => d.GorevlendirmeTur).WithMany(p => p.Gorevlendirme)
                    .HasForeignKey(d => d.GorevlendirmeTurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gorevlendirme_fk");

                entity.HasOne(d => d.Personel).WithMany(p => p.Gorevlendirme)
                    .HasForeignKey(d => d.PersonelId)
                    .HasConstraintName("gorevlendirme_personel_fk");
            });

            modelBuilder.Entity<GorevlendirmeTur>(entity =>
            {
                entity.HasKey(e => e.GorevlendirmeTurId).HasName("gorevlendirme_tur_pk");

                entity.ToTable("gorevlendirme_tur");

                entity.Property(e => e.GorevlendirmeTurId)
                    .UseIdentityColumn()
                    .HasColumnName("gorevlendirme_tur_id");
                entity.Property(e => e.Tanim)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("tanim");
            });

            modelBuilder.Entity<GunlukVardiyaIstasyonBirim>(entity =>
            {
                entity.HasKey(e => e.GunlukVardiyaIstasyonBirimId).HasName("gunluk_vardiya_istasyon_pkey_1");

                entity.ToTable("gunluk_vardiya_istasyon_birim");

                entity.HasIndex(e => e.IstasyonBirimId, "fki_fk_gunluk_vardiya_istasyon_birim_id");

                entity.HasIndex(e => e.VardiyaId, "fki_fk_gunluk_vardiya_istasyon_vardiya_id");

                entity.Property(e => e.GunlukVardiyaIstasyonBirimId)
                    .UseIdentityColumn()
                    .HasColumnName("gunluk_vardiya_istasyon_birim_id");
                entity.Property(e => e.IstasyonBirimId).HasColumnName("istasyon_birim_id");
                entity.Property(e => e.PersonelId).HasColumnName("personel_id");
                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih");
                entity.Property(e => e.VardiyaId).HasColumnName("vardiya_id");

                entity.HasOne(d => d.IstasyonBirim).WithMany(p => p.GunlukVardiyaIstasyonBirim)
                    .HasForeignKey(d => d.IstasyonBirimId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_gunluk_vardiya_istasyon_birim_id");

                entity.HasOne(d => d.Personel).WithMany(p => p.GunlukVardiyaIstasyonBirim)
                    .HasForeignKey(d => d.PersonelId)
                    .HasConstraintName("gunluk_vardiya_istasyon_birim_fk");

                entity.HasOne(d => d.Vardiya).WithMany(p => p.GunlukVardiyaIstasyonBirim)
                    .HasForeignKey(d => d.VardiyaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_gunluk_vardiya_istasyon_vardiya_id");
            });

            modelBuilder.Entity<GunlukVardiyaMasa>(entity =>
            {
                entity.HasKey(e => e.GunlukVardiyaId).HasName("gunluk_vardiya_pkey");

                entity.ToTable("gunluk_vardiya_masa");

                entity.HasIndex(e => e.MasaId, "fki_fk_gunluk_vardiya_masa_id");

                entity.HasIndex(e => e.VardiyaId, "fki_fk_gunluk_vardiya_masa_vardiya_id");

                entity.HasIndex(e => e.PersonelId, "fki_fk_gunluk_vardiya_personel_id");

                entity.Property(e => e.GunlukVardiyaId)
                    .UseIdentityColumn()
                    .HasColumnName("gunluk_vardiya_id");
                entity.Property(e => e.MasaId).HasColumnName("masa_id");
                entity.Property(e => e.PersonelId).HasColumnName("personel_id");
                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("tarih");
                entity.Property(e => e.VardiyaId).HasColumnName("vardiya_id");

                entity.HasOne(d => d.Masa).WithMany(p => p.GunlukVardiyaMasa)
                    .HasForeignKey(d => d.MasaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_gunluk_vardiya_masa_id");

                entity.HasOne(d => d.Personel).WithMany(p => p.GunlukVardiyaMasa)
                    .HasForeignKey(d => d.PersonelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("gunluk_vardiya_masa_fk");

                entity.HasOne(d => d.Vardiya).WithMany(p => p.GunlukVardiyaMasa)
                    .HasForeignKey(d => d.VardiyaId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_gunluk_vardiya_masa_vardiya_id");
            });
            modelBuilder.Entity<Istasyon>(entity =>
            {
                entity.HasKey(e => e.IstasyonId).HasName("istasyon_pk");

                entity.ToTable("istasyon");

                entity.Property(e => e.IstasyonId).HasColumnName("istasyon_id");
                entity.Property(e => e.GuncellenmeTarihi)
                    .HasDefaultValueSql("GETDATE()")
                    .HasColumnType("datetime2")
                    .HasColumnName("guncellenme_tarihi");
                entity.Property(e => e.IstasyonAd)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("istasyon_ad");
                entity.Property(e => e.IstasyonKod)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("istasyon_kod");
            });

            modelBuilder.Entity<IstasyonBirim>(entity =>
            {
                entity.HasKey(e => e.IstasyonBirimId).HasName("istasyon_birim_pk");

                entity.ToTable("istasyon_birim");

                entity.HasIndex(e => e.IstasyonBirimTurId, "fki_fk_birim_istasyon_birim_tur_id");
                entity.HasIndex(e => e.IstasyonId, "fki_fk_birim_istasyon_id");

                entity.Property(e => e.IstasyonBirimId)
                    .UseIdentityColumn()
                    .HasColumnName("istasyon_birim_id");
                entity.Property(e => e.IstasyonBirimTurId).HasColumnName("istasyon_birim_tur_id");
                entity.Property(e => e.IstasyonId).HasColumnName("istasyon_id");

                entity.HasOne(d => d.IstasyonBirimTur).WithMany(p => p.IstasyonBirim)
                    .HasForeignKey(d => d.IstasyonBirimTurId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_birim_istasyon_birim_tur_id");

                entity.HasOne(d => d.Istasyon).WithMany(p => p.IstasyonBirim)
                    .HasForeignKey(d => d.IstasyonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_birim_istasyon_id");
            });

            modelBuilder.Entity<IstasyonBirimTur>(entity =>
            {
                entity.HasKey(e => e.IstasyonBirimTurId).HasName("istasyon_birim_tur_pk");

                entity.ToTable("istasyon_birim_tur");

                entity.Property(e => e.IstasyonBirimTurId)
                    .UseIdentityColumn()
                    .HasColumnName("istasyon_birim_tur_id");
                entity.Property(e => e.IstasyonBirimTurTanim)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("istasyon_birim_tur_tanim");
            });

            modelBuilder.Entity<IstasyonDurum>(entity =>
            {
                entity.HasKey(e => e.IstasyonDurumId).HasName("istasyon_durum_pkey");

                entity.ToTable("istasyon_durum");

                entity.Property(e => e.IstasyonDurumId)
                    .UseIdentityColumn()
                    .HasColumnName("istasyon_durum_id");
                entity.Property(e => e.BaslangicZamani)
                    .HasColumnType("datetime2")
                    .HasColumnName("baslangic_zamani");
                entity.Property(e => e.BitisZamani)
                    .HasColumnType("datetime2")
                    .HasColumnName("bitis_zamani");
                entity.Property(e => e.GecerlilikBaslangic)
                    .HasColumnType("datetime2")
                    .HasColumnName("gecerlilik_baslangic");
                entity.Property(e => e.GecerlilikBitis)
                    .HasColumnType("datetime2")
                    .HasColumnName("gecerlilik_bitis");
                entity.Property(e => e.IstasyonDurumTurId).HasColumnName("istasyon_durum_tur_id");
                entity.Property(e => e.IstasyonId).HasColumnName("istasyon_id");

                entity.HasOne(d => d.IstasyonDurumTur).WithMany(p => p.IstasyonDurum)
                    .HasForeignKey(d => d.IstasyonDurumTurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("istasyon_durum_fk");

                entity.HasOne(d => d.Istasyon).WithMany(p => p.IstasyonDurum)
                    .HasForeignKey(d => d.IstasyonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("istasyon_istasyon_durum_fk");
            });

            modelBuilder.Entity<IstasyonDurumTur>(entity =>
            {
                entity.HasKey(e => e.IstasyonDurumTurId).HasName("istasyon_durum_tur_pkey");

                entity.ToTable("istasyon_durum_tur");

                entity.Property(e => e.IstasyonDurumTurId)
                    .UseIdentityColumn()
                    .HasColumnName("istasyon_durum_tur_id");
                entity.Property(e => e.Tanim)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("tanim");
            });

            modelBuilder.Entity<IzinTur>(entity =>
            {
                entity.HasKey(e => e.IzinTurId).HasName("izin_tur_pk");

                entity.ToTable("izin_tur");

                entity.Property(e => e.IzinTurId)
                    .UseIdentityColumn()
                    .HasColumnName("izin_tur_id");
                entity.Property(e => e.Aciklama)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("aciklama");
                entity.Property(e => e.Tanim)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("tanim");
            });

            modelBuilder.Entity<Masa>(entity =>
            {
                entity.HasKey(e => e.MasaId).HasName("masa_pkey");

                entity.ToTable("masa");

                entity.HasIndex(e => e.ParentId, "fki_fk_masa_parent_id");
                entity.HasIndex(e => e.TrafikYonetimMerkeziId, "fki_fk_masa_trafik_yonetim_merkezi_id");

                entity.Property(e => e.MasaId).HasColumnName("masa_id");
                entity.Property(e => e.Aktif).HasColumnName("aktif");
                entity.Property(e => e.IsClone).HasColumnName("is_clone");
                entity.Property(e => e.ParentId).HasColumnName("parent_id");
                entity.Property(e => e.Renk)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("renk");
                entity.Property(e => e.Tanim)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("tanim");
                entity.Property(e => e.TrafikYonetimMerkeziId).HasColumnName("trafik_yonetim_merkezi_id");

                entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_masa_parent_id");

                entity.HasOne(d => d.TrafikYonetimMerkezi).WithMany(p => p.Masa)
                    .HasForeignKey(d => d.TrafikYonetimMerkeziId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_masa_trafik_yonetim_merkezi_id");
            });

            modelBuilder.Entity<Mesai>(entity =>
            {
                entity.HasKey(e => e.MesaiId).HasName("mesai_pk");

                entity.ToTable("mesai");

                entity.Property(e => e.MesaiId)
                    .UseIdentityColumn()
                    .HasColumnName("mesai_id");
                entity.Property(e => e.MesaiBaslangic)
                    .HasColumnType("datetime2")
                    .HasColumnName("mesai_baslangic");
                entity.Property(e => e.MesaiBitis)
                    .HasColumnType("datetime2")
                    .HasColumnName("mesai_bitis");
                entity.Property(e => e.MesaiTurId).HasColumnName("mesai_tur_id");
                entity.Property(e => e.PersonelNo).HasColumnName("personel_no");

                entity.HasOne(d => d.MesaiTur).WithMany(p => p.Mesai)
                    .HasForeignKey(d => d.MesaiTurId)
                    .HasConstraintName("mesai_fk");

                entity.HasOne(d => d.PersonelNoNavigation).WithMany(p => p.Mesai)
                    .HasPrincipalKey(p => p.PersonelNo)
                    .HasForeignKey(d => d.PersonelNo)
                    .HasConstraintName("mesai_fk2");

                entity.Ignore(e => e.PersonelNoNavigation);
            });

            modelBuilder.Entity<MesaiTur>(entity =>
            {
                entity.HasKey(e => e.MesaiTurId).HasName("mesai_tur_pk");

                entity.ToTable("mesai_tur");

                entity.Property(e => e.MesaiTurId)
                    .UseIdentityColumn()
                    .HasColumnName("mesai_tur_id");
                entity.Property(e => e.Birim)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("birim");
                entity.Property(e => e.MesaiTurTanim)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("mesai_tur_tanim");
            });
            modelBuilder.Entity<OrgBirim>(entity =>
            {
                entity.HasKey(e => e.OrgBirimId).HasName("org_birim_pk");

                entity.ToTable("org_birim");

                entity.HasIndex(e => e.OrgBirimKod, "org_birim_un").IsUnique();

                entity.Property(e => e.OrgBirimId).HasColumnName("org_birim_id");
                entity.Property(e => e.OrgBirimKod)
                    .HasColumnType("nvarchar(255)")  // Uzunluğu belirledik
                    .HasColumnName("org_birim_kod")
                    .IsRequired(); // Nullable olmayan alan
                entity.Property(e => e.OrgBirimTanim)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("org_birim_tanim");
                entity.Property(e => e.UstOrgBirimKod)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("ust_org_birim_kod");
            });

            modelBuilder.Entity<Personel>(entity =>
            {
                entity.HasKey(e => e.PersonelId).HasName("personel_pk");

                entity.ToTable("personel");

                entity.HasIndex(e => e.PersonelNo, "personel_un").IsUnique();

                entity.Property(e => e.PersonelId).HasColumnName("personel_id");
                entity.Property(e => e.Ad)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("ad");
                entity.Property(e => e.OrgBirimKod)
                    .HasColumnType("nvarchar(255)") // Uzunluğu belirledik
                    .HasColumnName("org_birim_kod");
                entity.Property(e => e.PersonelNo).HasColumnName("personel_no");
                entity.Property(e => e.SicilNo)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("sicil_no");
                entity.Property(e => e.Soyad)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("soyad");
                entity.Property(e => e.TcKimlikNo).HasColumnName("tc_kimlik_no");

                entity.HasOne(d => d.OrgBirimKodNavigation).WithMany(p => p.Personel)
                    .HasPrincipalKey(p => p.OrgBirimKod)
                    .HasForeignKey(d => d.OrgBirimKod)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("personel_fk");
            });

            modelBuilder.Entity<PersonelIzin>(entity =>
            {
                entity.HasKey(e => e.PersonelIzinId).HasName("personel_izin_pk");

                entity.ToTable("personel_izin");

                entity.Property(e => e.PersonelIzinId)
                    .UseIdentityColumn()
                    .HasColumnName("personel_izin_id");
                entity.Property(e => e.Aciklama)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("aciklama");
                entity.Property(e => e.IzinBaslangicTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("izin_baslangic_tarihi");
                entity.Property(e => e.IzinBitisTarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("izin_bitis_tarihi");
                entity.Property(e => e.IzinTurId).HasColumnName("izin_tur_id");
                entity.Property(e => e.PersonelId).HasColumnName("personel_id");

                entity.HasOne(d => d.IzinTur).WithMany(p => p.PersonelIzin)
                    .HasForeignKey(d => d.IzinTurId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("personel_izin_fk");

                entity.HasOne(d => d.Personel).WithMany(p => p.PersonelIzin)
                    .HasForeignKey(d => d.PersonelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("personel_personel_izin_fk");
            });

            modelBuilder.Entity<TrafikYonetimMerkezi>(entity =>
            {
                entity.HasKey(e => e.TrafikYonetimMerkeziId).HasName("trafik_yonetim_merkezi_pkey");

                entity.ToTable("trafik_yonetim_merkezi");

                entity.HasIndex(e => e.BolgeId, "fki_fk_trafik_yonetim_merkezi_bolge");

                entity.HasIndex(e => e.BolgeId, "fki_fk_tym_bolge_id");

                entity.HasIndex(e => e.BirimKodu, "trafik_yonetim_merkezi_un").IsUnique();

                entity.Property(e => e.TrafikYonetimMerkeziId).HasColumnName("trafik_yonetim_merkezi_id");
                entity.Property(e => e.Aktif).HasColumnName("aktif");
                entity.Property(e => e.BirimKodu)
                    .HasColumnType("nvarchar(255)")
                    .HasColumnName("birim_kodu");
                entity.Property(e => e.BolgeId).HasColumnName("bolge_id");
                entity.Property(e => e.Tanim)
                    .HasColumnType("nvarchar(max)")
                    .HasColumnName("tanim");

                entity.HasOne(d => d.Bolge).WithMany(p => p.TrafikYonetimMerkezi)
                    .HasForeignKey(d => d.BolgeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("trafik_yonetim_merkezi_fk");
            });

            modelBuilder.Entity<Vardiya>(entity =>
            {
                entity.HasKey(e => e.VardiyaId).HasName("vardiya_pkey");

                entity.ToTable("vardiya");

                entity.HasIndex(e => e.VardiyaSablonId, "fki_fk_vardiya_vardiya_sablon_id");

                entity.Property(e => e.VardiyaId)
                    .UseIdentityColumn()
                    .HasColumnName("vardiya_id");
                entity.Property(e => e.BaslangicSaat).HasColumnName("baslangic_saat");
                entity.Property(e => e.BitisSaat).HasColumnName("bitis_saat");
                entity.Property(e => e.SiraNo).HasColumnName("sira_no");
                entity.Property(e => e.VardiyaSablonId).HasColumnName("vardiya_sablon_id");

                entity.HasOne(d => d.VardiyaSablon).WithMany(p => p.Vardiya)
                    .HasForeignKey(d => d.VardiyaSablonId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("fk_vardiya_vardiya_sablon_id");
            });

            modelBuilder.Entity<VardiyaSablonYer>(entity =>
            {
                entity.HasKey(e => e.VardiyaSablonYerId).HasName("vardiya_sablon_pkey");

                entity.ToTable("vardiya_sablon_yer");

                entity.Property(e => e.VardiyaSablonYerId)
                    .UseIdentityColumn()
                    .HasColumnName("vardiya_sablon_yer_id");
                entity.Property(e => e.GecerlilikBaslangic)
                    .HasColumnType("datetime")
                    .HasColumnName("gecerlilik_baslangic");
                entity.Property(e => e.GecerlilikBitis)
                    .HasColumnType("datetime")
                    .HasColumnName("gecerlilik_bitis");
                entity.Property(e => e.IstasyonBirimId).HasColumnName("istasyon_birim_id");
                entity.Property(e => e.MasaId).HasColumnName("masa_id");


                entity.HasOne(d => d.IstasyonBirim).WithMany(p => p.VardiyaSablonYer)
                    .HasForeignKey(d => d.IstasyonBirimId).IsRequired(false)
                    .HasConstraintName("vardiya_sablon_yer_fk_1");

                entity.HasOne(d => d.Masa).WithMany(p => p.VardiyaSablonYer)
                    .HasForeignKey(d => d.MasaId).IsRequired(false)
                    .HasConstraintName("vardiya_sablon_yer_fk");

                entity.HasOne(d => d.VardiyaSablon).WithMany(p => p.VardiyaSablonYer)
                    .HasForeignKey(d => d.VardiyaSablonId)
                    .HasConstraintName("vardiya_sablon_yer_fk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
