using GreenDelight.Domain.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class Personel
    {
        public int PersonelId { get; set; }

        public int PersonelNo { get; set; }

        public string Ad { get; set; } = null!;

        public string Soyad { get; set; } = null!;

        public long TcKimlikNo { get; set; }

        public string SicilNo { get; set; } = null!;

        public string OrgBirimKod { get; set; } = null!;

        public virtual ICollection<Gorevlendirme> Gorevlendirme { get; set; } = new List<Gorevlendirme>();

        public virtual ICollection<GunlukVardiyaIstasyonBirim> GunlukVardiyaIstasyonBirim { get; set; } = new List<GunlukVardiyaIstasyonBirim>();

        public virtual ICollection<GunlukVardiyaMasa> GunlukVardiyaMasa { get; set; } = new List<GunlukVardiyaMasa>();

        public virtual ICollection<Mesai> Mesai { get; set; } = new List<Mesai>();

        public virtual OrgBirim OrgBirimKodNavigation { get; set; } = null!;

        public virtual ICollection<PersonelIzin> PersonelIzin { get; set; } = new List<PersonelIzin>();
    }
}
