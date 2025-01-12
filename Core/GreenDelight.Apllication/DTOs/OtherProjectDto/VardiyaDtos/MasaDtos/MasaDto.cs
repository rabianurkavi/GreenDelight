using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.GunlukVardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.SablonDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MasaDtos
{
    public class MasaDto
    {
        public short MasaId { get; set; }
        public string MasaIsmi { get; set; }
        public List<SablonDetayDto> Sablonlar { get; set; } = new List<SablonDetayDto>();
    }
}
