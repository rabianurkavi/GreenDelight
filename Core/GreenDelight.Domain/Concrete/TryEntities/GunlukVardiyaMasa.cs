using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class GunlukVardiyaMasa
    {
        public long GunlukVardiyaId { get; set; }

        public DateTime Tarih { get; set; }

        public int VardiyaId { get; set; }

        public short MasaId { get; set; }

        public int PersonelId { get; set; }

        public virtual Masa Masa { get; set; } = null!;

        public virtual Personel Personel { get; set; } = null!;

        public virtual Vardiya Vardiya { get; set; } = null!;
    }
}
