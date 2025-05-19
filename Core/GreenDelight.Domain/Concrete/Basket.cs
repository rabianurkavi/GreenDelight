using GreenDelight.Domain.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class Basket:AuditableEntity
    {
        public Guid UserID { get; set; }            
        public bool IsActive { get; set; } = true;  

        public virtual ICollection<BasketItem> BasketItems { get; set; }
    }
}
