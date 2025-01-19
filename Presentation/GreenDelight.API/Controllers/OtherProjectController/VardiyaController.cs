using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.MasaDtos;
using GreenDelight.Application.DTOs.OtherProjectDto.VardiyaDtos.VardiyaPersonelDto;
using GreenDelight.Application.Interfaces.Services.OtherProject.VardiyaServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenDelight.API.Controllers.OtherProjectController
{
    [Route("api/[controller]")]
    [ApiController]
    public class VardiyaController : ControllerBase
    {
        private readonly IVardiyaService _vardiyaService;
        public VardiyaController(IVardiyaService vardiyaService)
        {
            _vardiyaService = vardiyaService;
        }
        [HttpGet("GetVardiyaDetaylari")]
        public async Task<ActionResult<VardiyaDetaylariDto>> GetVardiyaDetaylariByMasaIdAsync([FromQuery] short masaId, [FromQuery] DateTime monthDate)
        {
            try
            {
                var vardiyaDetaylari = await _vardiyaService.GetVardiyaDetaylariByMasaIdAsync(masaId, monthDate);
                return Ok(vardiyaDetaylari);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Sunucu hatası: " + ex.Message);
            }
        }
        [HttpPost("personel-ekle")]
        public async Task<IActionResult> VardiyaPersonelEkle([FromBody] VardiyaPersonelEkleDto vardiyaPersonelEkleDto)
        {

            if (vardiyaPersonelEkleDto == null)
                return BadRequest("Geçersiz veri.");

            var eklenenPersonelId = await _vardiyaService.VardiyaPersonelEkleAsync(vardiyaPersonelEkleDto);

            return Ok(eklenenPersonelId);
        }
    }
}
