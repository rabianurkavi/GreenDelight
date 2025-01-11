using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class IstasyonDurumTur
    {
        public int IstasyonDurumTurId { get; set; }

        public string Tanim { get; set; } = null!;

        public virtual ICollection<IstasyonDurum> IstasyonDurum { get; set; } = new List<IstasyonDurum>();
    }
}
