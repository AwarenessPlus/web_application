// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AwarenessWebApp.Pages.Procedure
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/monitorConnection")]
    public partial class MonitorConnection : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\MonitorConnection.razor"
       
    private string monitorStatus = "disconnected";
    private string errorMessage;
    private async void monitorConnection()
    {
        monitorStatus = "connecting";
        var url = "https://hololenscommunicationserviceawareness.azurewebsites.net/api/hololens-communication-service/hololens-connection-status";
        HttpResponseMessage response_get = await HttpClient.GetAsync(url);
        if (response_get.IsSuccessStatusCode)
        {
            monitorStatus = "connected";
        }
        else
        {
            errorMessage = response_get.ReasonPhrase;
            Console.WriteLine($"There was an error! {errorMessage}");
            return;
        }
    }
    private void disconnectMonitor()
    {
        monitorStatus = "confirmDisconnect";

    }
    private void confirmDisconnectMonitor()
    {
        monitorStatus = "disconnected";

    }
    private void cancelDisconnectMonitor()
    {
        monitorStatus = "connected";
    }
    protected override Task OnInitializedAsync()
    {
        //Set active procedure step
        UserState.nextStepActive(2);

        return base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserState UserState { get; set; }
    }
}
#pragma warning restore 1591