using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.PersonelDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MesaiDtos
{
    public class MesaiDto
    {
        public DateTime MesaiBaslangic { get; set; }
        public DateTime MesaiBitis { get; set; }
        public PersonelFiltreDto Personel { get; set; }
    }
}
