using GreenDelight.Application.Constants;
using GreenDelight.Application.DTOs.ContactDtos;
using GreenDelight.Application.DTOs.OrderItemDtos;
using GreenDelight.Application.Interfaces.Services.OrterItemServices;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Services.OrderItemServices
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderItemService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> AddAsync(OrderItemAddDto orderItemAddDto)
        {
            var contact = orderItemAddDto.Adapt<OrderItem>();

            if (contact == null)
            {
                return new ErrorDataResult<bool>("Ürün sepetinize eklenemedi");
            }
            await _unitOfWork.GetGenericRepository<OrderItem>().AddAsync(contact);
            await _unitOfWork.CommitAsync();

            return new SuccessDataResult<bool>(true, Messages.OrderItemAdded);
        }
    }
}
