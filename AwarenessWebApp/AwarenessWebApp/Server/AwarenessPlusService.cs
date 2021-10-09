using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AwarenessWebApp.Server
{
    public class AwarenessPlusService : IAwarenessPlusService
    {
        private readonly HttpClient _httpClient;
        public AwarenessPlusService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetUserAuthentication()
        {
            return await _httpClient.GetFromJsonAsync<string>("api/authentications");
        }
    }
}
