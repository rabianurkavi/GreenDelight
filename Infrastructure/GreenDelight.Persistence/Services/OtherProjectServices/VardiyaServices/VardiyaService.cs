using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.GunlukVardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MesaiDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.PersonelDtos;
using GreenDelight.Application.Interfaces.Services.OtherProject.VardiyaServices;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Domain.Concrete.TryEntities;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Services.OtherProjectServices.VardiyaServices
{
    public class VardiyaService : IVardiyaService
    {
        private readonly IUnitOfWork _unitOfWork;
        public VardiyaService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<VardiyaDetaylariDto> GetVardiyaDetaylariByMasaIdAsync(short masaId, DateTime monthDate)
        {
            var startDate = new DateTime(monthDate.Year, monthDate.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1); // Ayın son günü

            var gunlukVardiyaMasalar = await _unitOfWork.GetGenericRepository<GunlukVardiyaMasa>()
                .GetAllAsync(
                    gvm => gvm.MasaId == masaId && gvm.Tarih >= startDate && gvm.Tarih <= endDate,
                    include: query => query
                        .Include(gvm => gvm.Masa)
                        .Include(gvm => gvm.Vardiya)
                        .Include(gvm => gvm.Personel)
                );

            if (!gunlukVardiyaMasalar.Any())
                throw new KeyNotFoundException("Belirtilen kriterlere uygun vardiya bulunamadı.");

            var vardiyaDetaylariDto = new VardiyaDetaylariDto
            {
                MasaId = masaId,
                MasaIsmi = gunlukVardiyaMasalar.First().Masa.Tanim,
                GunlukVardiyalar = gunlukVardiyaMasalar
                    .GroupBy(gvm => gvm.Tarih)
                    .Select(group => new GunlukVardiyaDto
                    {
                        GunlukVardiyaTarih = group.Key,
                        Vardiyalar = group
                            .Select(gvm => new VardiyaDto
                            {
                                BaslangicSaat = new TimeOnly(
                                    gvm.Vardiya.BaslangicSaat.Hour, gvm.Vardiya.BaslangicSaat.Minute),
                                BitisSaat = new TimeOnly(
                                    gvm.Vardiya.BitisSaat.Hour, gvm.Vardiya.BitisSaat.Minute),
                                Personel = gvm.Personel.Adapt<PersonelFiltreDto>()
                            })
                            .ToList()
                    })
                    .ToList()
            };

            return vardiyaDetaylariDto;
        }
    }
}
