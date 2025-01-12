using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MasaDtos;
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
    }
}
