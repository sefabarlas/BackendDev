using Azure;
using WebAPI.Helpers;
using static Entities.Enums.ApiEnums;

namespace WebAPI.Models
{
    public class Response<T>
    {
        public Response()
        {
            ServerTime = DateTime.Now;
        }

        public ResponseTypes ResponseType { get; set; }
        public string? Code { get; set; }
        public string? Message { get; set; }
        public DateTime ServerTime { get; set; }
        public int TotalRowCount { get; set; }
        public T? Result { get; set; }

        public Response<T> Success(T t)
        {
            ResponseType = ResponseTypes.Success;
            Code = "RES-0001";
            Message = "İşlem Başarılı";
            Result = t;
            return this;
        }

        public Response<T> NotFound(T t)
        {
            ResponseType = ResponseTypes.Error;
            Code = "RES-0002";
            Message = "Kayıt Bulunamadı";
            Result = t;
            return this;
        }

        public Response<T> AlreadyExist(T t)
        {
            ResponseType = ResponseTypes.Error;
            Code = "RES-0003";
            Message = "Kayıt Mevcut";
            Result = t;
            return this;
        }

        public Response<T> Unauthorized(T t)
        {
            ResponseType = ResponseTypes.Error;
            Code = "RES-0004";
            Message = "Yetkiniz Yok";
            Result = t;
            return this;
        }

        public Response<T> Error(T t, string code)
        {
            Code = code;
            Message = code;
            ResponseType = ResponseTypes.Error;
            Result = t;
            return this;
        }

        public Response<T> Error(T t, string code, MessageHelper _messageHelper)
        {
            Code = code;
            Message = _messageHelper.GetSystemMessage(code);
            ResponseType = ResponseTypes.Error;
            Result = t;
            return this;
        }
    }
}