﻿using Blazor.Client.Services.Contracts;
using Blazor.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Blazor.Client.States
{
    public class IdentityAuthenticationStateProvider : AuthenticationStateProvider, IDisposable
    {
        private readonly IdentityAuthenticationState state;

        public IdentityAuthenticationStateProvider(IdentityAuthenticationState state)
        {
            this.state = state;
            this.state.UserInfoChanged += State_UserInfoChanged;
        }

        private void State_UserInfoChanged(UserInfo obj)
        {
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            try
            {
                var userInfo = await state.GetUserInfo();
                if(userInfo.IsAuthenticated)
                {
                    var claims = new[] { new Claim(ClaimTypes.Name, userInfo.UserName) }.Concat(userInfo.ExposedClaims.Select(c => new Claim(c.Key, c.Value)));
                    identity = new ClaimsIdentity(claims, "Server authentication");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Request failed:" + ex.ToString());
            }

            return new AuthenticationState(new ClaimsPrincipal(identity));
        }

        public void Dispose()
        {
            this.state.UserInfoChanged -= State_UserInfoChanged;
        }
    }
}
