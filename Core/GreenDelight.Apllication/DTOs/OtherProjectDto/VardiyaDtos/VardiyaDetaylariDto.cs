using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.GunlukVardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.PersonelDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos
{
    public class VardiyaDetaylariDto
    {
        public short MasaId { get; set; }
        public string MasaIsmi { get; set; }
        public List<GunlukVardiyaDto> GunlukVardiyalar { get; set; }
    }
}
