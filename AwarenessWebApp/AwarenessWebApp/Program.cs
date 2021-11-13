using AwarenessWebApp.Auth;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace AwarenessWebApp
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddScoped<UserState>();
            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<JWTAuthenticationProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider, JWTAuthenticationProvider>(provider => provider.GetRequiredService<JWTAuthenticationProvider>());
            builder.Services.AddScoped<ILoginService, JWTAuthenticationProvider>(provider => provider.GetRequiredService<JWTAuthenticationProvider>());
            await builder.Build().RunAsync();
        }
    }
}
