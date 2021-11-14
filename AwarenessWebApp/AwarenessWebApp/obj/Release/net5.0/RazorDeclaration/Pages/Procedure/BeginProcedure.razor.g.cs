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
#line 1 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/beginProcedure")]
    public partial class BeginProcedure : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\BeginProcedure.razor"
       
    private bool disabled = true;
    private string errorMessage;
    HttpResponseMessage response_hololens;
    HttpResponseMessage response_monitor;

    private void beginProcedureBtn()
    {
        disabled = false;
    }
    private async void confirmBeginProcedure()
    {
        var url_hololens = "https://hololenscommunicationserviceawareness.azurewebsites.net/api/hololens-communication-service/set-procedure-data?IdProcedure=" + UserState.CurrentProcedureDTO.ProcedureID;
        var url_monitor = "https://awarenessmonitorscomunication.azurewebsites.net/connect";
        try
        {
            response_hololens = await HttpClient.PostAsync(url_hololens, null);
            response_monitor = await HttpClient.GetAsync(url_monitor);
            var response_str_hololens = await response_hololens.Content.ReadAsStringAsync();
            var response_str_monitor = await response_monitor.Content.ReadAsStringAsync();

            if (!string.IsNullOrEmpty(response_str_hololens)) {
                if (!response_hololens.IsSuccessStatusCode || !response_str_hololens.Equals(UserState.CurrentProcedureDTO.ProcedureID.ToString()))
                {
                    errorMessage = "Error al conectar con las gafas, vuelva a intentarlo Codigo de error: "+response_hololens.ReasonPhrase;
                    Console.WriteLine($"There was an error! {errorMessage}");
                    StateHasChanged();
                    return;
                }
            }
            if (!string.IsNullOrEmpty(response_str_monitor))
            {
                if (!response_monitor.IsSuccessStatusCode)
                {
                    errorMessage = "Error al conectar con el monitor, verfique que se halla terminado el procedimiento desde las gafas Codigo de error: " + response_monitor.ReasonPhrase;
                    Console.WriteLine($"There was an error! {errorMessage}");
                    StateHasChanged();
                    return;
                }
            }
            UserState.onlyCurrentStep(5);
            NavigationManager.NavigateTo("/inProgressProcedure");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine(e);
        }
    }
    private void cancelBeginProcedure()
    {
        disabled = true;
    }
    protected override Task OnInitializedAsync()
    {
        if (UserState.ProcedureSteps[4].active != "active")
        {
            NavigationManager.NavigateTo("/enterPatientData");
        }
        return base.OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserState UserState { get; set; }
    }
}
#pragma warning restore 1591
