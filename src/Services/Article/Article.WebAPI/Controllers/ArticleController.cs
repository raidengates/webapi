using Article.Framework.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Article.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        ICategoryServices _categoryServices;
        public ArticleController(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }
        [HttpGet("values")]
        public async Task<IActionResult> index() => Content("hello mother fucker!");

        [HttpPost("getcategory")]
        public async Task<IActionResult> GetCategory() => Ok(await _categoryServices.GetCategoriesRecursive());

    }
}