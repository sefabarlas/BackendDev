using Entities.Dtos;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ISystemMessageRepository : IRepositoryBase<SystemMessage>
    {
        IQueryable<SystemMessageViewModel> GetList(SystemMessageFilterModel model);
        SystemMessage GetMessage(string code, string lang);
    }
}