using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.TryEntities
{
    public partial class VardiyaSablonIstasyonBirim
    {
        public int VardiyaSablonIstasyonBirimId { get; set; }

        public DateTime BaslangicTarihi { get; set; }

        public DateTime BitisTarihi { get; set; }

        public int VardiyaSablonId { get; set; }

        public int IstasyonBirimId { get; set; }

        public short? VardiyaSayisi { get; set; }

        public virtual IstasyonBirim IstasyonBirim { get; set; } = null!;

        public virtual VardiyaSablon VardiyaSablon { get; set; } = null!;
    }
}
