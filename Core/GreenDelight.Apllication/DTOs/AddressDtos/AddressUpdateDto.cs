using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.AddressDtos
{
    public class AddressUpdateDto
    {
        public int ID { get; set; }
        public string AdressName { get; set; }
        public int NeighborhoodId { get; set; }
        public Guid UserId { get; set; }
        public string RecipientFullName { get; set; }
        public string Street { get; set; }
        public string PhoneNumber { get; set; }
        public string No { get; set; }
    }
}
