using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Masdr.API.Models
{
    public class ApiRequest
    {
        public ApiType Method { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }

    public enum ApiType { GET, POST, PUT, DELETE }
}
