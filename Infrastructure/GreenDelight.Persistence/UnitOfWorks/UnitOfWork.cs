using GreenDelight.Apllication.Interfaces.Repositories;
using GreenDelight.Apllication.Interfaces.UnitofWorks;
using GreenDelight.Persistence.Contexts;
using GreenDelight.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GreenDelightDbContext _dbContext;

        public UnitOfWork(GreenDelightDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async ValueTask DisposeAsync() => await _dbContext.DisposeAsync();
        public async Task CommitAsync() => await _dbContext.SaveChangesAsync();


        IBaseRepository<T> IUnitOfWork.GetGenericRepository<T>()=> new BaseRepository<T>(_dbContext);

    }
}
