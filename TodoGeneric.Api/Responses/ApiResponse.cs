using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoGeneric.Api.Responses
{
    public class ApiResponse<T>
    {
        public ApiResponse( T data)
        {
            Data = data;
        }

        public T Data { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
