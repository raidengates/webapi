using Article.Framework.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;
using Unititi.Framework.Func;
using System.Linq;
namespace Article.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        ICategoryServices _categoryServices;
        IHttpContextAccessor _context;
        IFuncIdentity _funcIdentity;
        public ArticleController(ICategoryServices categoryServices, IHttpContextAccessor context, IFuncIdentity funcIdentity)
        {
            _categoryServices = categoryServices;
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _funcIdentity = funcIdentity;
        }
        [HttpGet("values")]
        public async Task<IActionResult> index() => Content("hello!")/*Content("hello mother fucker!")*/;

        [HttpPost("getcategory")]
        public async Task<IActionResult> GetCategory()
        {
            try
            {
                string authorizationHeader = _context.HttpContext.Request.Headers["Authorization"];

                if (authorizationHeader != null)
                {
                   var token = authorizationHeader.Split(" ");
                   authorizationHeader = token.Last();
                }

                var accountNumber = _funcIdentity.GetAuthorizationHeader(authorizationHeader);
                if (accountNumber != null)
                {
                    return Ok(await _categoryServices.GetCategoriesRecursive());
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

    }
}