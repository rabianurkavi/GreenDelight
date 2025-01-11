using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class Mesai
    {
        public long MesaiId { get; set; }

        public short? MesaiTurId { get; set; }

        public int? PersonelNo { get; set; }

        public DateTime? MesaiBaslangic { get; set; }

        public DateTime? MesaiBitis { get; set; }

        public virtual MesaiTur? MesaiTur { get; set; }

        public virtual Personel? PersonelNoNavigation { get; set; }
    }
}
