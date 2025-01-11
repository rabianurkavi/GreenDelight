using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class GorevTur
    {
        public short GorevTurId { get; set; }

        public string Tanim { get; set; } = null!;

        public virtual ICollection<Gorevlendirme> Gorevlendirme { get; set; } = new List<Gorevlendirme>();
    }
}
