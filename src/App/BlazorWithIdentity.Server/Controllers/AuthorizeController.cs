using Blazor.Server.Models;
using Blazor.Shared;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using System.Net;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;
using Blazor.Shared.Classes;

namespace Blazor.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthorizeController : ControllerBase
    {
        //private readonly UserManager<ApplicationUser> _userManager;
        //private readonly SignInManager<ApplicationUser> _signInManager;

        //private readonly IOptions<Gateway> _gateway;

        //private List<IdentitiesToken> _identitiesToken;
        //static HttpClient client = new HttpClient();
        ApplicationState _applicationState;
        public AuthorizeController(ApplicationState applicationState)
        {
            _applicationState = applicationState;
        }

        string token = string.Empty;
        [HttpPost]
        public async Task Login(LoginParameters parameters)
        {
            await _applicationState.Login(parameters);
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterParameters parameters)
        {
            //if (!ModelState.IsValid) return BadRequest(ModelState.Values.SelectMany(state => state.Errors)
            //                                                            .Select(error => error.ErrorMessage)
            //                                                            .FirstOrDefault());

            //var user = new ApplicationUser();
            //user.UserName = parameters.UserName;
            //var result = await _userManager.CreateAsync(user, parameters.Password);
            //if (!result.Succeeded) return BadRequest(result.Errors.FirstOrDefault()?.Description);

            //return await Login(new LoginParameters
            //{
            //    UserName = parameters.UserName,
            //    Password = parameters.Password
            //});
            return Ok();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            
          
            return Ok();
        }

        [HttpGet]
        public UserInfo UserInfo()
        {
            //var user = await _userManager.GetUserAsync(HttpContext.User);
            //return BuildUserInfo();
            return null;
        }
        public async Task<IActionResult> cate()
        {
            //var all = HttpContext.User.Claims.ToList();
            //Claim accessToken = HttpContext.User.Claims.Where(x => x.Type == "token").SingleOrDefault();
            //if (accessToken != null)
            //{
            //    if (client.BaseAddress == null)
            //    {
            //        client.BaseAddress = new Uri(_gateway.Value.BaseUrl);
            //    }
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken.Value);
            //    var response = await client.PostAsync($"/article/getcategory", null);
            //    if (response.StatusCode == HttpStatusCode.OK)
            //    {
            //        var result = await response.Content.ReadAsStringAsync();
            //        return Ok(result);
            //    }
            //    else
            //    {
            //        return BadRequest("khong the load");
            //    }
            //}
            //else return BadRequest("khong the load");
            return Ok();
        }

        private UserInfo BuildUserInfo()
        {
            return new UserInfo
            {
                IsAuthenticated = User.Identity.IsAuthenticated,
                UserName = User.Identity.Name,
                Token = this.token,
                ExposedClaims = User.Claims
                    //Optionally: filter the claims you want to expose to the client
                    //.Where(c => c.Type == "test-claim")
                    .ToDictionary(c => c.Type, c => c.Value)
            };
        }

        


       
    }
}
