using Contracts;
using Entities.Models;

namespace WebAPI.Helpers
{
    public class MessageHelper
    {
        private IRepositoryWrapper _repository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MessageHelper(IRepositoryWrapper repository, IHttpContextAccessor httpContextAccessor)
        {
            _repository = repository;
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetSystemMessage(string code)
        {
            string language = "TR";
            //if (_httpContextAccessor is not null && _httpContextAccessor.HttpContext is not null && _httpContextAccessor.HttpContext.User is not null)
            //    lang = _httpContextAccessor.HttpContext.User.GetLanguage() ?? "TR";

            return GetMessage(code, language);
        }

        public string GetSystemMessage(string code, string language)
        {
            return GetMessage(code, language);
        }

        public string GetMessage(string code, string language)
        {
            var message = _repository.SystemMessage.GetMessage(code, language);
            if (message is not null) 
                return message.Value;

            return code;
        }
    }
}
