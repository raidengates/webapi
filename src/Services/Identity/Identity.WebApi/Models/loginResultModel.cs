using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.WebApi.Models
{
    public class LoginResultModel
    {
        public int? UserName { get; set; }
        public bool IsSuccessful { get; set; }
        public string Message { get; set; }
    }
}
