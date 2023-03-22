
using System.Linq.Expressions;

namespace oasTools.infrastructure.repository.common
{
    public interface ICommonRepository<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        IQueryable<T> FindById(string id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}