using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class Masa
    {
        public short MasaId { get; set; }

        public string Tanim { get; set; } = null!;

        public bool Aktif { get; set; }

        public short TrafikYonetimMerkeziId { get; set; }

        public bool? IsClone { get; set; }

        public short? ParentId { get; set; }

        public string? Renk { get; set; }

        public virtual ICollection<GunlukVardiyaMasa> GunlukVardiyaMasa { get; set; } = new List<GunlukVardiyaMasa>();

        public virtual ICollection<Masa> InverseParent { get; set; } = new List<Masa>();

        public virtual Masa? Parent { get; set; }

        public virtual TrafikYonetimMerkezi TrafikYonetimMerkezi { get; set; } = null!;

        public virtual ICollection<VardiyaSablonYer> VardiyaSablonYer { get; set; } = new List<VardiyaSablonYer>();
    }
}
