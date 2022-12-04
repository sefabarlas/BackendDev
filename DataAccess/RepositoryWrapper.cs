using Contracts;
using Entities;

namespace Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repositoryContext;
        private ISomeFeatureEntityRepository _someFeatureEntity;
        private ISomeFeatureDetailEntityRepository _someFeatureDetailEntity;
        private ISystemMessageRepository _systemMessage;

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

        public ISystemMessageRepository SystemMessage
        {
            get
            {
                if (_systemMessage == null)
                {
                    _systemMessage = new SystemMessageRepository(_repositoryContext);
                }

                return _systemMessage;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}