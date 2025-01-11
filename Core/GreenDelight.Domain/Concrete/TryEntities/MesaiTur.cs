using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class MesaiTur
    {
        public short MesaiTurId { get; set; }

        public string MesaiTurTanim { get; set; } = null!;

        public string? Birim { get; set; }

        public virtual ICollection<Mesai> Mesai { get; set; } = new List<Mesai>();
    }
}
