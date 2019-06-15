using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Identity.WebApi.Models;
using Identity.WebApi.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Identity.WebApi.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private Identity.WebApi.Services.IIdentityService _userService;
        private IHttpContextAccessor _httpContextAccessor;
        public UserController(Identity.WebApi.Services.IIdentityService userService, IHttpContextAccessor httpContextAccessor)
        {
            _userService = userService;
            _httpContextAccessor = httpContextAccessor;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] Login loginParam)
        {
            var _context = _httpContextAccessor.HttpContext;
            var token = _userService.Authenticate(loginParam.Username, loginParam.Password, _context);
            if (token == null)
                return BadRequest(new { message = "Username or password is incorrect" });
            return Ok(token);
        }

    }
}