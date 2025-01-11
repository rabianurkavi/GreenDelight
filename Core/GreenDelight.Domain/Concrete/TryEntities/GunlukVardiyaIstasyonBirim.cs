using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class GunlukVardiyaIstasyonBirim
    {
        public long GunlukVardiyaIstasyonBirimId { get; set; }

        public DateTime Tarih { get; set; }

        public int VardiyaId { get; set; }

        public int IstasyonBirimId { get; set; }

        public int PersonelId { get; set; }

        public virtual IstasyonBirim IstasyonBirim { get; set; } = null!;

        public virtual Personel Personel { get; set; } = null!;

        public virtual Vardiya Vardiya { get; set; } = null!;
    }
}
