using GreenDelight.Apllication.Interfaces.UnitofWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async ValueTask DisposeAsync() => await dbContext.DisposeAsync();
        public async Task<int> SaveAsync() => await dbContext.SaveChangesAsync();


    }
}
