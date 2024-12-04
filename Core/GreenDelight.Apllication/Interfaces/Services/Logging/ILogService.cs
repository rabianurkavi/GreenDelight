using GreenDelight.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.Logging
{
    public interface ILogService
    {
        Task AddLogAsync(ErrorLog errorLog);
    }
}
