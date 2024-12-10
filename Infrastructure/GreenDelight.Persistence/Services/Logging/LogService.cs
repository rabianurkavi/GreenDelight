using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Application.Interfaces.Services.Logging;
using GreenDelight.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Services.Logging
{
    public class LogService : ILogService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LogService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddLogAsync(ErrorLog errorLog)
        {
            await _unitOfWork.GetGenericRepository<ErrorLog>().AddAsync(errorLog);
            await _unitOfWork.CommitAsync();
        }
    }
}
