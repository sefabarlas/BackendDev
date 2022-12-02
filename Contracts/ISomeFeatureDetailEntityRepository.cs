using Entities.Models;

namespace Contracts
{
    public interface ISomeFeatureDetailEntityRepository : IRepositoryBase<SomeFeatureDetailEntity>
    {
        IEnumerable<SomeFeatureDetailEntity> GetAllBySomeFeature(Guid someFeatureId);
    }
}