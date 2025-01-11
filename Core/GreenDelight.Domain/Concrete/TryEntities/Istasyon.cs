using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class Istasyon
    {
        public int IstasyonId { get; set; }

        public string IstasyonKod { get; set; } = null!;

        public string IstasyonAd { get; set; } = null!;

        public DateTime? GuncellenmeTarihi { get; set; }

        public virtual ICollection<IstasyonBirim> IstasyonBirim { get; set; } = new List<IstasyonBirim>();

        public virtual ICollection<IstasyonDurum> IstasyonDurum { get; set; } = new List<IstasyonDurum>();
    }
}
