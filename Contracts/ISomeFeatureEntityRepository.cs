using Entities.Models;

namespace Contracts
{
    public interface ISomeFeatureEntityRepository : IRepositoryBase<SomeFeatureEntity>
    {
        SomeFeatureEntity? GetSomeFeatureEntityWithDetails(Guid id);
    }
}