using Contracts;
using Entities;
using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SystemMessageRepository : RepositoryBase<SystemMessage>, ISystemMessageRepository
    {
        public SystemMessageRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        public IQueryable<SystemMessageViewModel> GetList(SystemMessageFilterModel model)
        {
            return _repositoryContext.SystemMessages.Where(s =>
                (string.IsNullOrWhiteSpace(model.Code) || s.Code.Equals(model.Code)) &&
                (string.IsNullOrWhiteSpace(model.Language) || s.LanguageCode.Equals(model.Language))).Select(s => new SystemMessageViewModel
                {
                    Code = s.Code,
                    Value = s.Value,
                    LanguageCode = s.LanguageCode
                });
        }

        public SystemMessage GetMessage(string code, string lang)
        {
            return _repositoryContext.SystemMessages.FirstOrDefault(s => s.Code.Equals(code) && s.LanguageCode.Equals(lang));
        }
    }
}
