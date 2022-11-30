using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repositoryContext;
        private ISomeFeatureEntityRepository _someFeatureEntity;
        private ISomeFeatureDetailEntityRepository _someFeatureDetailEntity;

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public ISomeFeatureEntityRepository SomeFeatureEntity
        {
            get
            {
                if (_someFeatureEntity == null)
                {
                    _someFeatureEntity = new SomeFeatureEntityRepository(_repositoryContext);
                }

                return _someFeatureEntity;
            }
        }

        public ISomeFeatureDetailEntityRepository SomeFeatureDetailEntity
        {
            get
            {
                if (_someFeatureDetailEntity == null)
                {
                    _someFeatureDetailEntity = new SomeFeatureDetailEntityRepository(_repositoryContext);
                }

                return _someFeatureDetailEntity;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}
