using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.VardiyaPersonelDto
{
    public class VardiyaPersonelEkleDto
    {
        public int PersonelId { get; set; }
        public short MasaId { get; set; }
        public int VardiyaId { get; set; }
        public DateTime Tarih { get; set; }
    }
}
