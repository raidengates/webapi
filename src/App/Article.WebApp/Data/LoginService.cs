using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using static Article.WebApp.Data.Models;
using Newtonsoft.Json;

using Microsoft.AspNetCore.Mvc;
using Article.WebApp.Domain;
using Microsoft.Extensions.Configuration;

namespace Article.WebApp.Data
{
    public class LoginService : ControllerBase
    {
       

        public  Task<string> GetGateway()
        {
            return  Task.FromResult("afsdaf");
        }


    }
}
