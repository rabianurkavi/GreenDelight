using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class TrafikYonetimMerkezi
    {
        public short TrafikYonetimMerkeziId { get; set; }

        public string Tanim { get; set; } = null!;

        public bool Aktif { get; set; }

        public short BolgeId { get; set; }

        public string? BirimKodu { get; set; }

        public virtual Bolge Bolge { get; set; } = null!;

        public virtual ICollection<Masa> Masa { get; set; } = new List<Masa>();
    }
}
