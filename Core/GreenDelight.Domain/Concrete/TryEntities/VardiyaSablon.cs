using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class VardiyaSablon
    {
        public int VardiyaSablonId { get; set; }

        public string VardiyaSablonTanim { get; set; } = null!;

        public short MaxVardiya { get; set; }

        public virtual ICollection<Vardiya> Vardiya { get; set; } = new List<Vardiya>();

        public virtual ICollection<VardiyaSablonIstasyonBirim> VardiyaSablonIstasyonBirim { get; set; } = new List<VardiyaSablonIstasyonBirim>();

        public virtual ICollection<VardiyaSablonMasa> VardiyaSablonMasa { get; set; } = new List<VardiyaSablonMasa>();
    }
}
