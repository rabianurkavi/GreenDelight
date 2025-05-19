using GreenDelight.Application.DTOs.BasketItemDtos;
using GreenDelight.Application.DTOs.CategoryDtos;
using GreenDelight.Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.BasketItemServices
{
    public interface IBasketItemService
    {
        Task<IResult> AddAsync(BasketItemAddDto basketItemAddDto);
    }
}
