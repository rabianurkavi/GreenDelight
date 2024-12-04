using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.AddressDtos
{
    internal class AddressDto
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public Guid UserId { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string No { get; set; }
    }
}
