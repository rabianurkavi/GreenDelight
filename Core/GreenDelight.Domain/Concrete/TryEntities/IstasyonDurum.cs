using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class IstasyonDurum
    {
        public int IstasyonDurumId { get; set; }

        public int IstasyonId { get; set; }

        public DateTime? BaslangicZamani { get; set; }

        public DateTime? BitisZamani { get; set; }

        public int IstasyonDurumTurId { get; set; }

        public DateTime? GecerlilikBaslangic { get; set; }

        public DateTime? GecerlilikBitis { get; set; }

        public virtual Istasyon Istasyon { get; set; } = null!;

        public virtual IstasyonDurumTur IstasyonDurumTur { get; set; } = null!;
    }
}
