using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using Identity.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Users.Framework.Validation;
using Unititi.Framework.Func;
using Unititi.Framework.Models;
using Unititi.Framework.Helpers;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;

namespace Identity.WebApi.Services
{
    public class IdentityService : IIdentityService
    {
        private readonly AppSettings _appSettings;
        private HashEncrypt _hashEncrypt;
        private Users.Framework.Services.Interface.IUserServices _iUserServices;
        private IFuncIdentity _funcIdentity;



        public IdentityService(IOptions<AppSettings> appSettings, HashEncrypt hashEncrypt, Users.Framework.Services.Interface.IUserServices iUserServices, IConfiguration iConfiguration, IFuncIdentity funcIdentity)
        {
            _appSettings = appSettings.Value;
            _hashEncrypt = hashEncrypt;
            _iUserServices = iUserServices;
            _funcIdentity = funcIdentity;

        }

        public Models.SecurityToken Authenticate(string username, string password, HttpContext context)
        {
            var cUser = _iUserServices.GetUser(username);
            var GlobalKey = _appSettings.Secret;
            if (cUser != null)
            {
                var PasswordUser = _iUserServices.GetPasswords(cUser.UserId).Where(x => x.Active == true).FirstOrDefault();
                if (PasswordUser != null)
                {
                    var salt = _hashEncrypt.CreateSaltPerUser(cUser.AccountName, GlobalKey);
                    var CheckEqual = _hashEncrypt.AreEqual(password, PasswordUser.Password1, salt);
                    if (CheckEqual)
                    {
                        

                        DateTime issueTime = DateTime.UtcNow;

                        List<Claim> claims = new List<Claim>
                          {
                            new Claim(JwtRegisteredClaimNames.Sub, cUser.AccountName),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.Iat, new DateTimeOffset(DateTime.UtcNow).ToUniversalTime().ToUnixTimeSeconds().ToString(), ClaimValueTypes.Integer64),
                            new Claim(JwtRegisteredClaimNames.GivenName, cUser.FullName)
                          };

                        claims.Add(new Claim("http://schemas.microsoft.com/ws/2008/06/identity/claims/role", 
                            ((int)cUser.UserGenderId).ToString(), ClaimValueTypes.Integer32));
                        var expiryLengthInMinutes = Convert.ToInt32(_appSettings.JwtExpiryInMinutes);
                        DateTime now = DateTime.UtcNow;
                        TimeSpan expirationTime = new TimeSpan(0, expiryLengthInMinutes, 0);
                        var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(_appSettings.Secret));
                        var signingCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);

                        var jwt = new JwtSecurityToken(
                             _appSettings.JwtIssuer,
                               _appSettings.JwtIssuer,
                              claims,
                              expires: now.Add(expirationTime),
                              signingCredentials: signingCredentials);

                        var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

                        LoginState(true, username, password, context);
                        return new Models.SecurityToken() { auth_token = encodedJwt, expirationTime = expirationTime };
                    }
                    else
                    {
                        LoginState(false, username, password, context);
                        return null;
                    }
                }
                else
                {
                    LoginState(false, username, password, context);
                    return null;
                }
            }
            else
            {
                LoginState(false, username, password, context);
                return null;
            }
        }

        private void LoginState(bool state, string username, string password, HttpContext context)
        {
            LoginAttempt _loginAttempt = new LoginAttempt();
            _loginAttempt.AccountName = username;
            _loginAttempt.Password = password;
            _loginAttempt.IpAddress = context.Connection.RemoteIpAddress.ToString();
            _loginAttempt.BrowserType = "";
            _loginAttempt.Success = state;

            _iUserServices.Create(_loginAttempt);
        }

    }
}
