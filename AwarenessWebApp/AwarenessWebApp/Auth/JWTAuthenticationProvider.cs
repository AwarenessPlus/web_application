using AwarenessWebApp.Helpers;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;

namespace AwarenessWebApp.Auth
{

    public class JWTAuthenticationProvider : AuthenticationStateProvider, ILoginService
    {
        private readonly IJSRuntime _js;
        private readonly HttpClient httpClient;
        public static readonly string Tokenkey = "a27b0cd6fd2bff05e1620531af3ef000";
        public static readonly string User_ID = "USER_ID";
        private AuthenticationState _defaultUser => new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

        public JWTAuthenticationProvider(IJSRuntime js, HttpClient httpClient)
        {
            this._js = js;
            this.httpClient = httpClient;
        }
        public async Task<string> GetToken()
        {
            var token = await _js.GetFromLocalStorage(Tokenkey);
            return token;
        }
        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var token = await _js.GetFromLocalStorage(Tokenkey);
            if (string.IsNullOrEmpty(token))
            {
                return _defaultUser;
            }

            return ConstructAuthenticationState(token);
        }
        public async Task Login(string token, int medic_id)
        {
            await _js.SetInLocalStorage(User_ID, medic_id.ToString());
            await _js.SetInLocalStorage(Tokenkey, token);
            var authState = ConstructAuthenticationState(token);
            NotifyAuthenticationStateChanged(Task.FromResult(authState));
        }
        public async Task Logout()
        {
            httpClient.DefaultRequestHeaders.Authorization = null;
            await _js.RemoveItem(Tokenkey);
            await _js.RemoveItem(User_ID);
            NotifyAuthenticationStateChanged(Task.FromResult(_defaultUser));
        }

        public async Task<int> GetUserId()
        {
            var id = await _js.GetFromLocalStorage(User_ID);
            if (string.IsNullOrEmpty(id))
            {
                return -1;
            }
            return int.Parse(id);
        }

        private AuthenticationState ConstructAuthenticationState(string token)
        {
            token = token.Trim('\"');
            this.httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            return new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity(ParseClaimsFromJwt(token), "jwt")));
        }
        private IEnumerable<Claim> ParseClaimsFromJwt(string jwt)
        {
            var claims = new List<Claim>();
            var payload = jwt.Split('.')[1];
            var jsonBytes = ParseBase64WithoutPadding(payload);
            var keyValuePairs = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonBytes);

            keyValuePairs.TryGetValue(ClaimTypes.Role, out object roles);

            if (roles != null)
            {
                if (roles.ToString().Trim().StartsWith("["))
                {
                    var parsedRoles = JsonSerializer.Deserialize<string[]>(roles.ToString());

                    foreach (var parsedRole in parsedRoles)
                    {
                        claims.Add(new Claim(ClaimTypes.Role, parsedRole));
                    }
                }
                else
                {
                    claims.Add(new Claim(ClaimTypes.Role, roles.ToString()));
                }

                keyValuePairs.Remove(ClaimTypes.Role);
            }

            claims.AddRange(keyValuePairs.Select(kvp => new Claim(kvp.Key, kvp.Value.ToString())));

            return claims;
        }

        private byte[] ParseBase64WithoutPadding(string base64)
        {
            switch (base64.Length % 4)
            {
                case 2: base64 += "=="; break;
                case 3: base64 += "="; break;
            }
            return Convert.FromBase64String(base64);
        }


    }
}
