using Aplication.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private AplicationDbContext _context;

        public Repository(AplicationDbContext context)
        {
            _context = context;
        }   

        public Task<List<T>> Get(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public Task<IList<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(T item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(object id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Remove(T item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(T item)
        {
            throw new NotImplementedException();
        }
    }
}
