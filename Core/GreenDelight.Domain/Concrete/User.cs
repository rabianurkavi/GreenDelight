using GreenDelight.Domain.Concrete.BaseEntities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class User : IdentityUser<Guid>
    {
        public string FullName { get; set; }
        public string? ImageUrl { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public ICollection<Adress> Adresses { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<BasketItem> BasketItems { get; set; }
    }
}
