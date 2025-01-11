using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class IstasyonBirimTur
    {
        public short IstasyonBirimTurId { get; set; }

        public string IstasyonBirimTurTanim { get; set; } = null!;

        public virtual ICollection<IstasyonBirim> IstasyonBirim { get; set; } = new List<IstasyonBirim>();
    }
}
