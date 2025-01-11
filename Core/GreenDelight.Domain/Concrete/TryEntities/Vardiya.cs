using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class Vardiya
    {
        public int VardiyaId { get; set; }

        public int VardiyaSablonId { get; set; }

        public TimeOnly BaslangicSaat { get; set; }

        public TimeOnly BitisSaat { get; set; }

        public short? SiraNo { get; set; }

        public virtual ICollection<GunlukVardiyaIstasyonBirim> GunlukVardiyaIstasyonBirim { get; set; } = new List<GunlukVardiyaIstasyonBirim>();

        public virtual ICollection<GunlukVardiyaMasa> GunlukVardiyaMasa { get; set; } = new List<GunlukVardiyaMasa>();

        public virtual VardiyaSablonYer VardiyaSablon { get; set; } = null!;
    }
}
