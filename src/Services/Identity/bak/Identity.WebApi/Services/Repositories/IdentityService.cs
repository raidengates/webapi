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
                        LoginState(true, username, password, context);
                        var tokenHandler = new JwtSecurityTokenHandler();
                        var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                        IdentityModel _IdentityModel = new IdentityModel() { AccountID = cUser.UserId, AccountName = cUser.AccountName, AccountRoleID = (int)cUser.UserGenderId };
                        var jwtSecurityToken = _funcIdentity.CreateSecurityTokenDescriptor(_IdentityModel, key);
                        return new Models.SecurityToken() { auth_token = jwtSecurityToken };
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
