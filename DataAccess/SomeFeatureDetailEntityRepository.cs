using Contracts;
using Entities;
using Entities.Models;

namespace Repository
{
    public class SomeFeatureDetailEntityRepository : RepositoryBase<SomeFeatureDetailEntity>, ISomeFeatureDetailEntityRepository
    {
        public SomeFeatureDetailEntityRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<SomeFeatureDetailEntity> GetAllBySomeFeature(Guid someFeatureId)
        {
            return GetAllByCondition(x => x.SomeFeatureEntityId.Equals(someFeatureId)).ToList();
        }
    }
}