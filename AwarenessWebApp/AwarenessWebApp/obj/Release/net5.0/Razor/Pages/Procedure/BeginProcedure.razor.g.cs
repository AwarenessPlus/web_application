#pragma checksum "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\BeginProcedure.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a534fe00a1dfb41198bb64bf3f2ac69f35ec7fd8"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/beginProcedure")]
    public partial class BeginProcedure : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>

    .shape-button {
        display: table-cell;
        background: #6368B0;
        width: 28rem;
        height: 28rem;
        border-radius: 23% 77% 65% 35% / 30% 44% 56% 70%;
        margin: 0 auto;
        vertical-align: middle;
    }

    .shape-button-invert {
        display: table-cell;
        background: #ffffff;
        width: 28rem;
        height: 28rem;
        border-radius: 23% 77% 65% 35% / 30% 44% 56% 70%;
        margin: 0 auto;
        vertical-align: middle;
        transform: rotateY(180deg);
    }

        .shape-button-invert:hover {
            background: #C2E0B1;
        }

    .xl-icon {
        transform: rotateY(180deg);
        vertical-align: middle;
        font-size: 10rem;
        color: #6368B0;
    }

    h1 {
        transform: rotateY(180deg);
        font-size: 2rem;
        color: #6368B0;
    }
</style>
");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "container");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "row");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-xl-5 my-auto");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "procedureSteps");
                __builder2.OpenComponent<AwarenessWebApp.Shared.ProcedureSteps>(11);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "col-xl-7 my-auto");
#nullable restore
#line 57 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\BeginProcedure.razor"
                     if (disabled == true)
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "shape-button");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "shape-button-invert");
                __builder2.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\BeginProcedure.razor"
                                                                       beginProcedureBtn

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(20, "<center><span class=\"oi oi-media-play xl-icon\" aria-hidden=\"true\" data-toggle=\"tooltip\" title=\"Iniciar \"></span>\r\n                                    <br>\r\n                                    <h1>Iniciar Procedimiento</h1></center>");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 68 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\BeginProcedure.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(21, "<h2 style=\"text-align: center;\">¿Está seguro?</h2>\r\n                        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "d-flex justify-content-around bd-highlight");
                __builder2.OpenElement(24, "a");
                __builder2.AddAttribute(25, "class", "btn btn-success p-2 bd-highlight");
                __builder2.AddAttribute(26, "href", "inProgressProcedure");
                __builder2.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\BeginProcedure.razor"
                                                                                                             confirmBeginProcedure

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(28, "Continuar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "btn btn-danger p-2 bd-highlight");
                __builder2.AddAttribute(32, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\BeginProcedure.razor"
                                                                                   cancelBeginProcedure

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(33, "Cancelar");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 76 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\BeginProcedure.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "D:\U\2021\2021-02\Tesis\Ultima semana\WebApp v2.0\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\BeginProcedure.razor"
       
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
        var url_hololens = "https://hololenscommunicationserviceawareness.azurewebsites.net/api/hololens-communication-service/set-procedure-data?IdProcedure=" + UserState.ProcedureId;
        var url_monitor = "http://10.195.23.82/AwarenessPlus/MonitorService/connect";
        response_hololens = await HttpClient.PostAsync(url_hololens, null);
        response_monitor = await HttpClient.GetAsync(url_monitor);

        if (!response_hololens.IsSuccessStatusCode) {
            errorMessage = response_hololens.ReasonPhrase;
            Console.WriteLine($"There was an error! {errorMessage}");
            return;
        }
        if (!response_monitor.IsSuccessStatusCode){
            errorMessage = response_monitor.ReasonPhrase;
            Console.WriteLine($"There was an error! {errorMessage}");
            return;
        }
    }

    private void cancelBeginProcedure()
    {
        disabled = true;
    }
    protected override Task OnInitializedAsync()
    {
        //Set active procedure step
        UserState.nextStepActive(4);

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