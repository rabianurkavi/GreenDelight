using GreenDelight.Domain.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class Neighborhood: AuditableEntity
    {
        public string NeighborhoodName { get; set; }
        public int DistrictId { get; set; }
        public virtual District District { get; set; }
        public virtual ICollection<Adress> Adresses { get; set; }

    }
}
