
using System.Linq.Expressions;

namespace users.infrastructure.repository.common
{
    public interface ICommonRepository<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
        bool trackChanges);
        IQueryable<T> FindById(string id, bool trackChanges);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}