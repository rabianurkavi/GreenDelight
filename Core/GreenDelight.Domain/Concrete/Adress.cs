using GreenDelight.Domain.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class Adress:AuditableEntity
    {
        public int NeighborhoodId { get; set; }
        public string? AdressName { get; set; }
        public Guid UserId { get; set; }
        public string Street { get; set; }
        public string RecipientFullName { get; set; }
        public string No { get; set; }
        public string PhoneNumber { get; set; }
        public virtual User User { get; set; }
        public virtual Neighborhood Neighborhood { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
