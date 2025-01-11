using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class IzinTur
    {
        public short IzinTurId { get; set; }

        public string Tanim { get; set; } = null!;

        public string? Aciklama { get; set; }

        public virtual ICollection<PersonelIzin> PersonelIzin { get; set; } = new List<PersonelIzin>();
    }
}
