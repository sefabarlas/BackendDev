using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _repositoryContext { get; set; }

        public RepositoryBase(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IQueryable<T> GetAll() => _repositoryContext.Set<T>().AsNoTracking();

        public IQueryable<T> GetAllByCondition(Expression<Func<T, bool>> expression) => _repositoryContext.Set<T>().Where(expression).AsNoTracking();

        public T? GetByGuidId(Guid id) => _repositoryContext.Set<T>().Find(id);

        public T? GetByIntId(int id) => _repositoryContext.Set<T>().Find(id);

        public void Create(T entity) => _repositoryContext.Set<T>().Add(entity);

        public void Update(T entity) => _repositoryContext.Set<T>().Update(entity);

        public void Delete(T entity) => _repositoryContext.Set<T>().Remove(entity);
    }
}