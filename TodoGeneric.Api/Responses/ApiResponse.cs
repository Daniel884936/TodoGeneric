using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace TodoGeneric.Api.Responses
{
    public class ApiResponse<T>
    {
        public ApiResponse( T data, HttpStatusCode status)
        {
            Data = data;
            Status = (int)status;
        }

        public T Data { get; set; }
        public string Title { get;  set; }
        public int Status { get; private set; }
        public string Message { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
