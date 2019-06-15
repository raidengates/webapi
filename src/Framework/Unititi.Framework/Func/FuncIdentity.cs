using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using Unititi.Framework.Models;
using Unititi.Framework.Types;

namespace Unititi.Framework.Func
{
    public class FuncIdentity : IFuncIdentity
    {
        public string CreateSecurityTokenDescriptor(IdentityModel _identityModel, byte[] SecretKey)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                            {
                            new Claim(StringResources.AccountID, _identityModel.AccountID.ToString()),
                            new Claim(StringResources.AccountName, _identityModel.AccountName),
                            new Claim(StringResources.AccountRoleID, _identityModel.AccountRoleID.ToString()),
                            }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(SecretKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtSecurityToken = tokenHandler.WriteToken(token);
            return jwtSecurityToken;
        }

        /// <summary>
        ///    Giải mã token chứng thực 
        /// </summary>
        /// <param name="authorizationHeader">
        ///     authorizationHeader = _context.HttpContext.Request.Headers["{Authorization}"];
        ///     Authorization = StringResources.AuthorizationHeadersKey
        /// </param>
        /// <returns> IdentityModel </returns>
        public IdentityModel GetAuthorizationHeader(string authorizationHeader)
        {
            if (authorizationHeader != null)
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var token = authorizationHeader.Split(' ')[1];
                var paresedToken = tokenHandler.ReadJwtToken(token);

                int o_AccountID = default(int);
                int o_RoleID = default(int);

                var account = paresedToken.Claims
                 .Where(c => c.Type == StringResources.AccountID)
                 .FirstOrDefault();

                var name = paresedToken.Claims
                  .Where(c => c.Type == StringResources.AccountName)
                  .FirstOrDefault();

                var RoleID = paresedToken.Claims
                   .Where(c => c.Type == StringResources.AccountRoleID)
                   .FirstOrDefault();
                Int32.TryParse(account.Value, out o_AccountID);
                Int32.TryParse(RoleID.Value, out o_RoleID);

                return new IdentityModel()
                {
                    AccountID = o_AccountID,
                    AccountName = name.Value,
                    AccountRoleID = o_RoleID,
                };
            }
            else
            {
                return null;
            }
        }
    }
}
