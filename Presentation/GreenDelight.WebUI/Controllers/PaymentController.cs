using GreenDelight.WebUI.Helper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Stripe.Checkout;
using Stripe;
using GreenDelight.Application.Interfaces.Services.OrderServices;
using GreenDelight.Domain.Enums;

namespace GreenDelight.WebUI.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly StripeSettings _stripeSettings;
        public string SessionId { get; set; }
        
        public PaymentController(IOptions<StripeSettings> stripeSettings,IOrderService orderService)
        {
            _stripeSettings = stripeSettings.Value;
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CreateCheckoutSession(int id)
        {
            var values = _orderService.GetOrderAsync(id);
            var currency = "try";
            var successUrl = Url.Action("Success", "Payment", new { id = id }, Request.Scheme);
            var cancelUrl = "https://localhost:7145/Payment/cancel";
            StripeConfiguration.ApiKey = _stripeSettings.SecretKey;
            var options = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                LineItems = new List<SessionLineItemOptions>()
                {
                    new SessionLineItemOptions
                    {
                        PriceData= new SessionLineItemPriceDataOptions
                        {
                            Currency = currency,
                            UnitAmount=(long)values.Result.Data.TotalAmount * 100, // Stripe expects the amount in cents
                            ProductData = new SessionLineItemPriceDataProductDataOptions
                            {
                              Name = "Green Shop Ödeme Merkezi",
                              Description = "Green Shop Ücret Ödemesi - " + DateTime.Now.ToString("dd.MM.yyyy HH:mm")

                            }

                        },
                       Quantity=1

                    }

                },
                Mode = "payment",
                SuccessUrl = successUrl,
                CancelUrl = cancelUrl

            };
            var service = new SessionService();
            var session = service.Create(options);
            SessionId = session.Id;
            return Redirect(session.Url);
        }
        public async Task<IActionResult> success(int id)
        {
            var orders = _orderService.GetOrderAsync(id);
            orders.Result.Data.Status=OrderStatus.PaymentMade;
            await _orderService.UpdateOrderAsync(orders.Result.Data);
            return RedirectToAction("GetAllOrderByUser", "Order");
        }
        public IActionResult cancel()
        {
            return RedirectToAction("GetAllOrderByUser", "Order");
        }
    }
}
