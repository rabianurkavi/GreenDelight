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
        public string City { get; set; }
        public string District { get; set; }
        public string Neighborhood { get; set; }
        public string Street { get; set; }
        public string No { get; set; }
        public int UserID { get; set; }
        public virtual User User { get; set; }
    }
}
