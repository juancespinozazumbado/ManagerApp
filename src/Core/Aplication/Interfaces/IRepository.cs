using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Interfaces
{
    public interface IRepository<T> where T : class
    {

        public Task<IList<T>> GetAll();

        public Task<T> GetById(Guid id);

        public Task<List<T>> Get(Expression<Func<T, bool>> filter = null , 
            Func<IQueryable<T> , IOrderedQueryable<T>> orderBy = null, string includeProperties = "" );

        public Task<bool> Insert(T item);

        public Task<bool> Update(T item);

        public Task<bool> Remove(object id);
        public Task<bool> Remove(T item);
        
    }
}
