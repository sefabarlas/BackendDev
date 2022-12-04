using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class SomeFeatureEntityRepository : RepositoryBase<SomeFeatureEntity>, ISomeFeatureEntityRepository
    {
        public SomeFeatureEntityRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public SomeFeatureEntity? GetSomeFeatureEntityWithDetails(Guid id)
        {
            return GetAllByCondition(x => x.Id.Equals(id))
                .Include(d => d.SomeFeatureDetailEntities)
                .FirstOrDefault();
        }
    }
}