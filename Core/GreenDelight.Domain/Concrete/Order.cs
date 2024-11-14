using GreenDelight.Domain.Concrete.BaseEntities;
using GreenDelight.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class Order:AuditableEntity
    {
        public int UserID { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; }

        public virtual User User { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
