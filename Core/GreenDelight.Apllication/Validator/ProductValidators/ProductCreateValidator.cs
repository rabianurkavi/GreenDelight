using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Apllication.Validator.ProductValidators
{
    public class ProductCreateValidator : AbstractValidator<>
    {
        public ProductCreateValidator()
        {
            RuleFor(a => a.EkipmanNo)
                .GreaterThan(0).WithMessage("Ekipman numarası 0'dan büyük olmalıdır.");

            RuleFor(a => a.Adi)
                .NotEmpty().WithMessage("Araç adı boş bırakılamaz.")
                .Length(2, 50).WithMessage("Araç adı 2 ile 50 karakter arasında olmalıdır.");
        }
    }
}
