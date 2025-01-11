using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class Gorevlendirme
    {
        public long GorevlendirmeId { get; set; }

        /// <summary>
        /// org_birim_kod
        /// </summary>
        public string GorevlendirmeBirim { get; set; } = null!;

        public DateTime GorevlendirmeBaslangic { get; set; }

        public DateTime GorevlendirmeBitis { get; set; }

        public int GorevlendirilecekPersonelNo { get; set; }

        public short GorevlendirmeTurId { get; set; }

        public short GorevTurId { get; set; }

        public string? Aciklama { get; set; }

        public DateTime? BelgenetTarih { get; set; }

        public string? BelgenetSayi { get; set; }

        public string? BirimTur { get; set; }

        public string? BirimAdi { get; set; }

        public int? PersonelId { get; set; }

        public virtual GorevTur GorevTur { get; set; } = null!;

        public virtual GorevlendirmeTur GorevlendirmeTur { get; set; } = null!;

        public virtual Personel? Personel { get; set; }
    }
}
