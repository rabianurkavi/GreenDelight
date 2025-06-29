using GreenDelight.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.OrderDtos
{
    public class OrderUpdateDto
    {
        public int ID { get; set; }
        public Guid UserId { get; set; }
        public int AdressId { get; set; }
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
