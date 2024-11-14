using GreenDelight.Domain.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Apllication.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class, IEntityBase, new()
    {
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,//ilişkili tablolar için gerekli
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,//istediğimiz bir propertye göre price a göre priortye göre sıralama yapmak istediğimde en yeni olanlar gibi vs.
            bool enableTracking = false);
        Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
            bool enableTracking = false, int currentPage = 1, int pageSize = 3); //mevcut sayfada gördüğüm ilk 3 veriyi alacağım.

        Task<T> GetAsync(Expression<Func<T, bool>> predicate, //geybyid için de kullanılabilir
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            bool enableTracking = false);

        IQueryable<T> Find(Expression<Func<T, bool>> predicate, bool enableTracking = false);//sorguyu hemen veri tabanına göndermez bu da sorgunun daha sonra işlenmesine filtrelenmesine veya sıralanmasına olanak tanır.
        Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);
        Task AddAsync(T entity);
        Task AddRangeAsync(IList<T> entities);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(IList<T> entities);
    }
}
