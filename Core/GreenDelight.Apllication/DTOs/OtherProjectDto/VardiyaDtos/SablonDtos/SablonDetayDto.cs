using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.GunlukVardiyaDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.SablonDtos
{
    public class SablonDetayDto
    {
        public int SablonId { get; set; }
        public string SablonTanim { get; set; }
        public DateTime? SablonBaslangicTarihi { get; set; }
        public DateTime? SablonBitisTarihi { get; set; }
        public short MaxVardiya { get; set; }
        public List<VardiyaDetaylariDto> Vardiyalar { get; set; } = new List<VardiyaDetaylariDto>();
        public List<GunlukVardiyaDto> GunlukVardiyalar { get; set; } = new List<GunlukVardiyaDto>();
    }
}
