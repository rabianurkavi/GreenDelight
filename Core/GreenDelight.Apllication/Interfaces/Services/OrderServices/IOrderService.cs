using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.OrderServices
{
    public interface IOrderService
    {
        Task<bool> CreateOrderAsync(int basketId, string address, string phoneNumber, string note);
    }
}
