using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.UserDtos
{
    public class UserDto:IDto
    {
        public Guid ID { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
