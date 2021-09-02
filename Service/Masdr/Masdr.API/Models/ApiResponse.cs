using System;
using System.Collections.Generic;
namespace Masdr.API.Models
{
    public class ApiResponse
    {
        public Boolean IsSucess { get; set; }
        public object Result { get; set; }
        public string Message { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}
