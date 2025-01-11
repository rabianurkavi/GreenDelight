using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.PersonelDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos
{
    public class VardiyaDto
    {
        public TimeOnly BaslangicSaat { get; set; }
        public TimeOnly BitisSaat { get; set; }
        public PersonelFiltreDto Personel { get; set; }

    }
}
