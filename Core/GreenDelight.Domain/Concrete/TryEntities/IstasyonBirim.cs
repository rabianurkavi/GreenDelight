using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class IstasyonBirim
    {
        public int IstasyonBirimId { get; set; }

        public int IstasyonId { get; set; }

        public short IstasyonBirimTurId { get; set; }

        public virtual ICollection<GunlukVardiyaIstasyonBirim> GunlukVardiyaIstasyonBirim { get; set; } = new List<GunlukVardiyaIstasyonBirim>();

        public virtual Istasyon Istasyon { get; set; } = null!;

        public virtual IstasyonBirimTur IstasyonBirimTur { get; set; } = null!;

        public virtual ICollection<VardiyaSablonYer> VardiyaSablonYer { get; set; } = new List<VardiyaSablonYer>();
    }
}
