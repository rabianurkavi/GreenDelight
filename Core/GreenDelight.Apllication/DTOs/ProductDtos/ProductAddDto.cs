using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Apllication.DTOs.ProductDtos
{
    public class ProductAddDto
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; }
        public string ImageUrls { get; set; }
    }
}
