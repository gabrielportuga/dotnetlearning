using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace OasTools.infrastructure.repository.common
{
    public abstract class CommonRepository<TContext, T> : ICommonRepository<T> where T : class where TContext : DbContext
    {
        protected TContext _context;

        public CommonRepository(TContext context) => this._context = context;

        public IQueryable<T> FindAll() => _context.Set<T>();

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression) =>
                _context.Set<T>()
                .Where(expression);


        public IQueryable<T> FindById(string id) =>
                    _context.Set<T>()
                    .Where(t => t.Equals(id));

        public void Create(T entity)
        {
            this._context.Set<T>().Add(entity);
        }

        public void Update(T entity) => _context.Set<T>().Update(entity);

        public void Delete(T entity) => _context.Set<T>().Remove(entity);

        public void SaveChanges() => this._context.SaveChanges();

    }
}