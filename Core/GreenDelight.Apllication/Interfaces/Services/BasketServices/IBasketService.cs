using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.BasketServices
{
    public interface IBasketService
    {
        Task<int> GetOrCreateBasketId(Guid userId);

        Task<IResult> ConfirmBasketAsync(int basketId);

        Task<IDataResult<Basket>> GetBasketAsync(int basketId);
    }
}
