using Azure.Core;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.GunlukVardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MasaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MesaiDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.PersonelDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.SablonDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.VardiyaPersonelDto;
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

            var vardiyaSablonYerler = await _unitOfWork.GetGenericRepository<VardiyaSablonYer>()
                .GetAllAsync(
                    vsy => vsy.MasaId == masaId &&
                           vsy.GecerlilikBaslangic <= endDate &&
                           vsy.GecerlilikBitis >= startDate,
                    include: query => query
                        .Include(vsy => vsy.Masa)
                        .Include(vsy => vsy.VardiyaSablon)
                        .ThenInclude(vs => vs.Vardiya)
                        .ThenInclude(v => v.GunlukVardiyaMasa)
                        .ThenInclude(gvm => gvm.Personel)
                );

            if (!vardiyaSablonYerler.Any())
                throw new KeyNotFoundException("Şablon bulunamadı.");
            var masa = vardiyaSablonYerler.First().Masa;
            if (masa == null)
                throw new Exception("Yanlış masa bilgisi.");

            var sablonlar = vardiyaSablonYerler.Select(sablonYer =>
            {
                var sablon = sablonYer.VardiyaSablon;

                var sablonStartDate = sablonYer.GecerlilikBaslangic.GetValueOrDefault().Date;
                var sablonEndDate = sablonYer.GecerlilikBitis.GetValueOrDefault().Date;

                var tarihAraligi = Enumerable.Range(0, (int)(sablonEndDate - sablonStartDate).TotalDays + 1)
                    .Select(offset => sablonStartDate.AddDays(offset))
                    .ToList();

                var gunlukVardiyalar = tarihAraligi.Select(tarih =>
                {
                    var personelGrubu = sablon.Vardiya
                        .SelectMany(v => v.GunlukVardiyaMasa)
                        .Where(gvm => gvm.Tarih == tarih)
                        .Select(gvm => new PersonelFiltreDto
                        {
                            PersonelId = gvm.Personel.PersonelId,
                            PersonelAd = gvm.Personel.Ad,
                            PersonelSoyad = gvm.Personel.Soyad
                        })
                        .ToList();

                    return new GunlukVardiyaDto
                    {
                        GunlukVardiyaTarih = tarih,
                        Personeller = personelGrubu
                    };
                }).ToList();

                return new SablonDetayDto
                {
                    SablonId = sablonYer.VardiyaSablonId,
                    SablonTanim = sablon.VardiyaSablonTanim,
                    SablonBaslangicTarihi = sablonYer.GecerlilikBaslangic,
                    SablonBitisTarihi = sablonYer.GecerlilikBitis,
                    MaxVardiya = sablon.MaxVardiya,
                    Vardiyalar = sablon.Vardiya.Select(v => new VardiyaDetaylariDto
                    {
                        Id = v.VardiyaId,
                        BaslangicSaat = v.BaslangicSaat.ToString("HH:mm:ss"),
                        BitisSaat = v.BitisSaat.ToString("HH:mm:ss")
                    }).ToList(),
                    GunlukVardiyalar = gunlukVardiyalar
                };
            }).ToList();

            return new MasaDto
            {
                MasaId = masa.MasaId,
                MasaIsmi = masa.Tanim,
                Sablonlar = sablonlar
            };
        }


        public async Task<int?> VardiyaPersonelEkleAsync(VardiyaPersonelEkleDto vardiyaPersonelEkleDto)
        {
            var mevcutKayit = await _unitOfWork.GetGenericRepository<GunlukVardiyaMasa>()
                .GetAsync(x => x.MasaId == vardiyaPersonelEkleDto.MasaId && x.VardiyaId == vardiyaPersonelEkleDto.VardiyaId && x.Tarih == vardiyaPersonelEkleDto.Tarih);

            if (mevcutKayit!=null)
            {
                return null; 
            }

            var yeniKayit = new GunlukVardiyaMasa
            {
                PersonelId = vardiyaPersonelEkleDto.PersonelId,
                MasaId = vardiyaPersonelEkleDto.MasaId,
                VardiyaId = vardiyaPersonelEkleDto.VardiyaId,
                Tarih = vardiyaPersonelEkleDto.Tarih
            };

            await _unitOfWork.GetGenericRepository<GunlukVardiyaMasa>().AddAsync(yeniKayit);

            await _unitOfWork.CommitAsync();

            return vardiyaPersonelEkleDto.PersonelId; 
        }

    }
}
