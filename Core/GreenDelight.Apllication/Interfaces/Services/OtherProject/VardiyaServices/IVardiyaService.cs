using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MasaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.VardiyaPersonelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.OtherProject.VardiyaServices
{
    public interface IVardiyaService
    {
        Task<MasaDto> GetVardiyaDetaylariByMasaIdAsync(short masaId, DateTime monthDate);
        Task<int?> VardiyaPersonelEkleAsync(VardiyaPersonelEkleDto vardiyaPersonelEkleDto);
    }
}
