using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.AddressDtos
{
    public class AddressDetailDto
    {
        //adresten fullnameini yazdırmak için adress entitysini service de kullanmadan nasıl eşleştirme yapabilirim?
        public int Id { get; set; }
        public string AdressName { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public int NeighborhoodId { get; set; }
        public Guid UserId { get; set; }
        public string Street { get; set; }
        public string No { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string RecipientFullName { get; set; }
        public string PhoneNumber { get; set; }
        public string NeighborhoodName { get; set; }
    }
}
