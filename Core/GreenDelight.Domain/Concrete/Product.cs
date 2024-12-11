using GreenDelight.Domain.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class Product:AuditableEntity
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int  CategoryID { get; set; }
        public string Quantity { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public string ImageUrls { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<Comment> Comments { get; set; }


    }
}
