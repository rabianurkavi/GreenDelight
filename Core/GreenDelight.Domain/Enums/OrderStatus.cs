using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Enums
{
    public enum OrderStatus
    {
        Pending = 1,        //  bekliyor
        Processed = 2,      //  işlendi
        Shipped = 3,        //  gönderildi
        Delivered = 4,      //  teslim edildi
        Canceled = 5,       //  iptal edildi
        Returned = 6        //  iade edildi
    }
}
