﻿using Blazor.Client.Services.Contracts;
using Blazor.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Blazor.Client.Services.Implementations
{
    public class AuthorizeApi : IAuthorizeApi
    {
        private readonly HttpClient _httpClient;

        public AuthorizeApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserInfo> Login(LoginParameters loginParameters)
        {
            var stringContent = new StringContent(JsonSerializer.ToString(loginParameters), Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("api/Authorize/Login", stringContent);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
                throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
            return JsonSerializer.Parse<UserInfo>(await result.Content.ReadAsStringAsync());
        }

        public async Task Logout()
        {
            var result = await _httpClient.PostAsync("api/Authorize/Logout", null);
            result.EnsureSuccessStatusCode();
        }

        public async Task<UserInfo> Register(RegisterParameters registerParameters)
        {
            var stringContent = new StringContent(JsonSerializer.ToString(registerParameters), Encoding.UTF8, "application/json");
            var result = await _httpClient.PostAsync("api/Authorize/Register", stringContent);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();

            return JsonSerializer.Parse<UserInfo>(await result.Content.ReadAsStringAsync());
        }

        public async Task<UserInfo> GetUserInfo()
        {
            var result = await _httpClient.GetJsonAsync<UserInfo>("api/Authorize/UserInfo");
            return result;
        }

        public async Task<string> cate()
        {
            var result = await _httpClient.GetJsonAsync<string>("api/Authorize/cate");
            return result;
        }
    }
}
