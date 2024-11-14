using GreenDelight.Domain.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class Category:AuditableEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
