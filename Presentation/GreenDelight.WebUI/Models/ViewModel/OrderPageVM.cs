using GreenDelight.Application.DTOs.AddressDtos;
using GreenDelight.Application.DTOs.BasketItemDtos;

namespace GreenDelight.WebUI.Models.ViewModel
{
    public class OrderPageVM
    {
        public int BasketId { get; set; }
        public List<AddressDto> Adresses { get; set; }
        public List<BasketItemDto> BasketItems { get; set; }
        public decimal TotalPrice { get; set; }
        public int SelectedAdressId { get; set; }
    }
}
