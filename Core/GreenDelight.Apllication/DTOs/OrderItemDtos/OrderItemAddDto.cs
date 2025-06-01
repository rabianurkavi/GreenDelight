using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.OrderItemDtos
{
    public class OrderItemAddDto
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public short Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime CreatedOrderItem { get; set; } = DateTime.Now;

    }
}
