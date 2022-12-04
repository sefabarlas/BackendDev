namespace Contracts
{
    public interface IRepositoryWrapper
    {
        ISomeFeatureEntityRepository SomeFeatureEntity { get; }
        ISomeFeatureDetailEntityRepository SomeFeatureDetailEntity { get; }
        ISystemMessageRepository SystemMessage { get; }

        void Save();
    }
}