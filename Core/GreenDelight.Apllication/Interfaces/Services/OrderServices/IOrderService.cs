using GreenDelight.Application.DTOs.OrderDtos;
using GreenDelight.Application.DTOs.OrderItemDtos;
using GreenDelight.Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.OrderServices
{
    public interface IOrderService
    {
        #region Order
        Task<IDataResult<int>> CreateOrderAsync(OrderAddDto orderAddDto, int basketId);
        Task<IDataResult<OrderDto>> GetOrderAsync(int id);
        #endregion
        #region OrderItem
        Task<IResult> CreateOrderItemsAsync(List<OrderItemAddDto> orderItems);
        #endregion
    }
}
