using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.ProductDtos
{
    public class ProductAddDto:IDto
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public string Quantity { get; set; }

        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public string ImageUrls { get; set; }
    }
}
