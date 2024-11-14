using GreenDelight.Apllication.Interfaces.Repositories;
using GreenDelight.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Apllication.Interfaces.UnitofWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IBaseRepository<T> GetGenericRepository<T>() where T : class, IEntityBase, new();

        Task CommitAsync();
    }
}
