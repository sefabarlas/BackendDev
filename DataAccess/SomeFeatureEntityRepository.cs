using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class SomeFeatureEntityRepository : RepositoryBase<SomeFeatureEntity>, ISomeFeatureEntityRepository
    {
        public SomeFeatureEntityRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}