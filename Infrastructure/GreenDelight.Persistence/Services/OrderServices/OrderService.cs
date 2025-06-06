﻿using GreenDelight.Application.DTOs.OrderDtos;
using GreenDelight.Application.DTOs.OrderItemDtos;
using GreenDelight.Application.Interfaces.Services.BasketServices;
using GreenDelight.Application.Interfaces.Services.OrderServices;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Enums;
using GreenDelight.Domain.Results;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Services.OrderServices
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IBasketService _basketService;


        public OrderService(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor, IBasketService basketService)
        {
            _unitOfWork = unitOfWork;
            _httpContextAccessor = httpContextAccessor;
            _basketService = basketService;
        }

        public async Task<IDataResult<int>> CreateOrderAsync(OrderAddDto orderAddDto, int basketId)
        {
            try
            {
                var userId = _httpContextAccessor.HttpContext?.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                var orderRepo = _unitOfWork.GetGenericRepository<Order>();
                var basketItemRepo = _unitOfWork.GetGenericRepository<BasketItem>();
                var orderItemRepo = _unitOfWork.GetGenericRepository<OrderItem>();

                var basketItems = await basketItemRepo.GetAllAsync(
                    x => x.BasketId == basketId && x.Basket.UserID == Guid.Parse(userId),
                    include: x => x.Include(b => b.Product)
                );

                if (basketItems == null || !basketItems.Any())
                    return new ErrorDataResult<int>("Sepette ürün bulunamadı.");

                decimal totalPrice = basketItems.Sum(item => item.Quantity * item.Product.Price);

                var orderDto = new OrderAddDto
                {
                    UserId = Guid.Parse(userId),
                    AdressId = orderAddDto.AdressId,
                    TotalAmount = totalPrice,
                    Status = OrderStatus.PaymentPending,
                    OrderDate = DateTime.Now
                };
                var order = orderDto.Adapt<Order>();
                await orderRepo.AddAsync(order);
                await _unitOfWork.CommitAsync();

                var orderItemDtos = basketItems.Select(x => new OrderItemAddDto
                {
                    ProductID = x.ProductId,
                    Quantity = x.Quantity,
                    UnitPrice = x.UnitPrice,
                    OrderID = order.ID
                }).ToList();

                var orderItemResult = await CreateOrderItemsAsync(orderItemDtos);
                if (!orderItemResult.Success)
                    return new ErrorDataResult<int>("Sipariş kalemleri eklenemedi.");

                await _basketService.BasketIsActiveFalse(basketId);

                return new SuccessDataResult<int>(order.ID, "Sipariş başarıyla oluşturuldu.");
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<int>($"Sipariş oluşturulamadı: {ex.Message}");
            }
        }


        public async Task<Domain.Results.IResult> CreateOrderItemsAsync(List<OrderItemAddDto> orderItems)
        {
            try
            {
                var orderItemRepo = _unitOfWork.GetGenericRepository<OrderItem>();

                if (orderItems == null || !orderItems.Any())
                    return new ErrorResult("OrderItem listesi boş.");

                var entities = orderItems.Select(x => new OrderItem
                {
                    OrderID = x.OrderID,
                    ProductID = x.ProductID,
                    Quantity = x.Quantity,
                    UnitPrice = x.UnitPrice,
                    CreatedOrderItem = DateTime.Now
                }).ToList();

                await orderItemRepo.AddRangeAsync(entities);
                await _unitOfWork.CommitAsync();

                return new SuccessResult("Sipariş ürünleri başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Sipariş ürünleri eklenirken hata oluştu: {ex.Message}");
            }
        }

    }
}
