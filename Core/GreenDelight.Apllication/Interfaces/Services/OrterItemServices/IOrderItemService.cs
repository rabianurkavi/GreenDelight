using GreenDelight.Application.DTOs.CategoryDtos;
using GreenDelight.Application.DTOs.OrderItemDtos;
using GreenDelight.Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.OrterItemServices
{
    public interface IOrderItemService
    {
        Task<IResult> AddAsync(OrderItemAddDto orderItemAddDto);
    }
}
