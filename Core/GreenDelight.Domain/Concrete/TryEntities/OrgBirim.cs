using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class OrgBirim
    {
        public long OrgBirimId { get; set; }

        public string OrgBirimKod { get; set; } = null!;

        public string OrgBirimTanim { get; set; } = null!;

        public string? UstOrgBirimKod { get; set; }

        public virtual ICollection<Personel> Personel { get; set; } = new List<Personel>();
    }
}
