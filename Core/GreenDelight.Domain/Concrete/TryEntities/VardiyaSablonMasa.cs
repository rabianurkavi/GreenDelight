using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class VardiyaSablonMasa
    {
        public short VardiyaSablonMasaId { get; set; }

        public DateTime BaslangicTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }

        public int VardiyaSablonId { get; set; }

        public short MasaId { get; set; }

        public short? VardiyaSayisi { get; set; }

        public virtual Masa Masa { get; set; } = null!;

        public virtual VardiyaSablon VardiyaSablon { get; set; } = null!;
    }
}
