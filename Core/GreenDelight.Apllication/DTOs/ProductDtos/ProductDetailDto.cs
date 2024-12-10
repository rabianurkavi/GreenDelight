using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.ProductDtos
{
    public class ProductDetailDto:IDto
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Quantity { get; set; }

        public bool InStock { get; set; }
        public string ImageUrls { get; set; }
        public string CategoryName { get; set; } // Category ilişkisi için
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
