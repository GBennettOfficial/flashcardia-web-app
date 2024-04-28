using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flashcardia.Global.Models
{
    public class ServiceResponse<T> : ServiceResponse
        where T : class
    {
        public ServiceResponse(bool isSuccess, T? value, string? message, Exception? exception)
            : base(isSuccess, message, exception)
        {
            IsSuccess = isSuccess;
            Message = message;
            Exception = exception;
        }

        T? Value { get; set; }
    }

    public class ServiceResponse
    {
        public ServiceResponse(bool isSuccess, string? message, Exception? exception)
        {
            IsSuccess = isSuccess;
            Message = message;
            Exception = exception;
        }

        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public Exception? Exception { get; set; }
    }
}
