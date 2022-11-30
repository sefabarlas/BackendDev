namespace Contracts
{
    public interface IRepositoryWrapper
    {
        ISomeFeatureEntityRepository SomeFeatureEntity { get; }
        ISomeFeatureDetailEntityRepository SomeFeatureDetailEntity { get; }
        void Save();
    }
}