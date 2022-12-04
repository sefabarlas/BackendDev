using System.Linq.Expressions;

namespace Contracts
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> GetAll();

        IQueryable<T> GetAllByCondition(Expression<Func<T, bool>> expression);

        T? GetByGuidId(Guid id);

        T? GetByIntId(int id);

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}