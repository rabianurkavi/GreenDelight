using GreenDelight.Domain.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class Cart:AuditableEntity
    {
        public string OrderItem { get; set; }
        public virtual User User { get; set; }

    }
}
