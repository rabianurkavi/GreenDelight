using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Enums
{
    public enum OrderStatus
    {
        Pending = 1,          // bekliyor
        PaymentPending = 2,   // ödeme bekleniyor
        PaymentMade = 3,        // işlendi
        Shipped = 4,          // gönderildi
        Delivered = 5,        // teslim edildi
        Canceled = 6,         // iptal edildi
        Returned = 7          // iade edildi
    }
}
