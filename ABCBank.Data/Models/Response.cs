using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBank.Data
{
    public class Response<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public int ResponseCode { get; set; }
        public int StatusCode { get; set; }
        public T Data { get; set; }
    }
}
