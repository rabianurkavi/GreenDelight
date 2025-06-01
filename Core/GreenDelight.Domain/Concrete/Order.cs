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
        public Guid UserId { get; set; }
        public int AdressId { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;

        public virtual User User { get; set; }
        public virtual Adress Adress { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
