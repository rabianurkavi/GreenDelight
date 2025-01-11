using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class VardiyaSablonYer
    {
        public int VardiyaSablonYerId { get; set; }

        public string Tanim { get; set; } = null!;

        public short MaxVardiya { get; set; }

        public DateTime? GecerlilikBaslangic { get; set; }

        public DateTime? GecerlilikBitis { get; set; }

        public short? MasaId { get; set; }

        public int? IstasyonBirimId { get; set; }

        public virtual IstasyonBirim? IstasyonBirim { get; set; }

        public virtual Masa? Masa { get; set; }

        public virtual ICollection<Vardiya> Vardiya { get; set; } = new List<Vardiya>();
    }
}
