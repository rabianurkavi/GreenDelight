using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.OtherProject.VardiyaServices
{
    public interface IVardiyaService
    {
        Task<VardiyaDetaylariDto> GetVardiyaDetaylariByMasaIdAsync(short masaId, DateTime monthDate);
    }
}
