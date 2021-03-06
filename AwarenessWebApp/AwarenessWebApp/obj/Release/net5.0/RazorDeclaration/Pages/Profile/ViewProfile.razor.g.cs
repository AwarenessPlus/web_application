// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AwarenessWebApp.Pages.Profile
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewProfile/{msg?}")]
    public partial class ViewProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Profile\ViewProfile.razor"
       
    [Parameter]
    public string? Msg { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await getUserInformation();
        try
        {
            var url_medic = "https://databaseservicesawareness.azurewebsites.net/api/medics/" + UserState.UserName;
            HttpResponseMessage response_get = await HttpClient.GetAsync(url_medic);
            string response_body = await response_get.Content.ReadAsStringAsync();
            UserState.stringResponseJsonConvertMedic(response_body);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine(e);
        }
    }
    async Task deleteProfile()
    {
        if (!await AwarenessWebApp.Helpers.JSRuntimeExtensions.Confirm(JSRuntime, "??Esta seguro de eliminar su perfil?"))
            return;
        var url_delete = "https://authenticationserviceawareness.azurewebsites.net/api/authentications/" + UserState.UserName;
        try
        {
            HttpResponseMessage response_delete = await HttpClient.DeleteAsync(url_delete);
            await loginService.Logout();
            NavigationManager.NavigateTo("");
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine(e);
        }
    }
    private async Task getUserInformation()
    {
        if (string.IsNullOrEmpty(UserState.UserName))
        {
            UserState.CurrentProcedureDTO.MedicID = await loginService.GetUserId();
            UserState.UserName = await loginService.GetUserUserName();
            UserState.CurrentStep = "/enterPatientData";
            var url_medic = "https://databaseservicesawareness.azurewebsites.net/api/medics/" + UserState.UserName;
            try
            {
                HttpResponseMessage response_get = await HttpClient.GetAsync(url_medic);
                string response_body = await response_get.Content.ReadAsStringAsync();
                UserState.stringResponseJsonConvertMedic(response_body);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e);
            }
        }
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserState UserState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
