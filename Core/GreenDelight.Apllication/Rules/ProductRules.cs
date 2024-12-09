using GreenDelight.Application.Rules.Exceptions.ProductExceptions;
using GreenDelight.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Rules
{
    public class ProductRules:BaseRules
    {
        public Task ProductTitleMustNotBeSame(IList<Product> products,string productName)
        {
            if (products.Any(x => x.ProductName == productName)) throw new ProductTitleMustNotBeSameException();
            return Task.CompletedTask;
        }
    }
}
