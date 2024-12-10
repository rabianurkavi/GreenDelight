using FluentValidation;
using GreenDelight.Application.DTOs.ProductDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Apllication.Validator.ProductValidators
{
    public class ProductCreateValidator : AbstractValidator<ProductUpdateDto>
    {
        public ProductCreateValidator()
        {
            
        }
    }
}
