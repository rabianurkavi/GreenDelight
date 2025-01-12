using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.GunlukVardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MasaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MesaiDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.PersonelDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.SablonDtos;
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
        public async Task<MasaDto> GetVardiyaDetaylariByMasaIdAsync(short masaId, DateTime monthDate)
        {
            var startDate = new DateTime(monthDate.Year, monthDate.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            // Şablonları alıyoruz
            var vardiyaSablonYerler = await _unitOfWork.GetGenericRepository<VardiyaSablonYer>()
                .GetAllAsync(
                    vsy => vsy.MasaId == masaId &&
                           vsy.GecerlilikBaslangic <= endDate &&
                           vsy.GecerlilikBitis >= startDate,
                    include: query => query
                        .Include(vsy => vsy.Masa)
                        .Include(vsy => vsy.Vardiya)
                        .ThenInclude(v => v.GunlukVardiyaMasa)
                        .ThenInclude(gvm => gvm.Personel)
                );

            if (!vardiyaSablonYerler.Any())
                throw new KeyNotFoundException(" şablon bulunamadı.");

            var masa = vardiyaSablonYerler.First().Masa;
            if (masa == null)
                throw new Exception("yanlış masa bilgisi.");

            var sablonlar = vardiyaSablonYerler.Select(sablon => new SablonDetayDto
            {
                SablonId = sablon.VardiyaSablonYerId,
                SablonTanim = sablon.Tanim,
                SablonBaslangicTarihi = sablon.GecerlilikBaslangic,
                SablonBitisTarihi = sablon.GecerlilikBitis,
                MaxVardiya = sablon.MaxVardiya,
                GunlukVardiyalar = sablon.Vardiya
                    .SelectMany(v => v.GunlukVardiyaMasa)
                    .Where(gvm => gvm.Tarih >= startDate && gvm.Tarih <= endDate)
                    .GroupBy(gvm => gvm.Tarih)
                    .Select(group => new GunlukVardiyaDto
                    {
                        GunlukVardiyaTarih = group.Key,
                        Vardiyalar = group.Select(gvm => new VardiyaDto
                        {
                            BaslangicSaat = new TimeOnly(
                                gvm.Vardiya.BaslangicSaat.Hour, gvm.Vardiya.BaslangicSaat.Minute),
                            BitisSaat = new TimeOnly(
                                gvm.Vardiya.BitisSaat.Hour, gvm.Vardiya.BitisSaat.Minute),
                            Personel = new PersonelFiltreDto
                            {
                                PersonelAd = gvm.Personel.Ad,
                                PersonelSoyad = gvm.Personel.Soyad
                            }
                        }).ToList()
                    }).ToList()
            }).ToList();

            return new MasaDto
            {
                MasaId = masa.MasaId,
                MasaIsmi = masa.Tanim,
                Sablonlar = sablonlar
            };
        }
    }
}
