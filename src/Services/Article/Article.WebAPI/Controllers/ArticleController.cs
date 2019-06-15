using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Article.Framework.Data.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Article.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        public ArticleController()
        {

        }

        [HttpPost("category")]
        public async Task<IActionResult> GetCategory()
        {
           List<Category>  _category = new List<Category>();
            return Ok(_category);
        }

    }
}