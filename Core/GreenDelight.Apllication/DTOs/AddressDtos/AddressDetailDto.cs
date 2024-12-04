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
        public int ID { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string UserFullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string No { get; set; }
    }
}
