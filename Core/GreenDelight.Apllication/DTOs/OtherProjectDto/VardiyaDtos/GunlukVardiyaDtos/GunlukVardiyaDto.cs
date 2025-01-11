using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MasaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MesaiDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.GunlukVardiyaDtos
{
    public class GunlukVardiyaDto
    {
        public DateTime GunlukVardiyaTarih { get; set; }
        public List<VardiyaDto> Vardiyalar { get; set; }
    }
}
