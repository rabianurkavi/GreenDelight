using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.AddressDtos
{
    public class AddressDto
    {
        public int ID { get; set; }
        public string AdressName { get; set; }
        public Guid UserId { get; set; }
        public string RecipientFullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
