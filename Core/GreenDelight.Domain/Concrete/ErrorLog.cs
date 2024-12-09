using GreenDelight.Domain.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class ErrorLog:BaseEntity
    {
        public string ErrorMessage { get; set; }
        public string StackTrace { get; set; }
        public int ErrorCode { get; set; }
        public string? ErrorDetails { get; set; }
        public string RequestPath { get; set; }
        public string HttpMethod { get; set; }
        public string UserIpAddress { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
