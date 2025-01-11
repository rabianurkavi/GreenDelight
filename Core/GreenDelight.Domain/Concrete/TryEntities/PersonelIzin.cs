using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class PersonelIzin
    {
        public int PersonelIzinId { get; set; }

        public int PersonelId { get; set; }

        public DateTime IzinBaslangicTarihi { get; set; }

        public DateTime? IzinBitisTarihi { get; set; }

        public short IzinTurId { get; set; }

        public string? Aciklama { get; set; }

        public virtual IzinTur IzinTur { get; set; } = null!;

        public virtual Personel Personel { get; set; } = null!;
    }
}
