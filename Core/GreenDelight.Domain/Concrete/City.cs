using GreenDelight.Domain.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class City:AuditableEntity
    {
        public string CityName { get; set; }
        public virtual ICollection<District> Districts { get; set; }

    }
}
