using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class,new()
    {
        Task<T>GetByIdAsync(int id);
        IQueryable<T> GetAll(Expression<Func<Task,bool>> expression);
        IQueryable<T> Where(Expression<Func<Task,bool>> expression);
        Task<bool> AnyAsync(Expression<Func<Task,bool>> expression);
        Task AddAsync( T entity);
        Task AddRangeAsync( IEnumerable<T> entity);
        void Update(T entity);
        void Remove(T entity);
        void RemoveRange(IEnumerable<T> entity);

    }
 }
