using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class Bolge
    {
        public short BolgeId { get; set; }

        public string BolgeAd { get; set; } = null!;

        public string BolgeKisaAd { get; set; } = null!;

        public virtual ICollection<TrafikYonetimMerkezi> TrafikYonetimMerkezi { get; set; } = new List<TrafikYonetimMerkezi>();
    }
}
