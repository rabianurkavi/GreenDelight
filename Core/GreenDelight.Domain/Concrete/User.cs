using GreenDelight.Domain.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class User : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Adress> Adresses { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
