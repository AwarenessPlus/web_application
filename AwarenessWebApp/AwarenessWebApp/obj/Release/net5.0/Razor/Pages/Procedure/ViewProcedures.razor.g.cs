#pragma checksum "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05f7c4e69176bd6e96923a9b4a5ca9bb8d0a64c3"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/viewProcedures")]
    public partial class ViewProcedures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .center-text {\r\n        text-align: center;\r\n        padding-left: 20rem;\r\n        padding-right: 20rem;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(3, "div");
                __builder2.AddAttribute(4, "class", "container");
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "row");
                __builder2.AddMarkupContent(7, "<h1>Ver Procedimientos</h1>");
#nullable restore
#line 22 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                 if (procedures == null)
                {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(8, "<p><em>Loading...</em></p>");
#nullable restore
#line 25 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(9, "table");
                __builder2.AddAttribute(10, "class", "table");
                __builder2.AddMarkupContent(11, @"<thead><tr><th>Nombre del Residente</th>
                                <th>Nombre del Procedimiento</th>
                                <th>Fecha</th>
                                <th>Nombre del Paciente</th></tr></thead>
                        ");
                __builder2.OpenElement(12, "tbody");
#nullable restore
#line 38 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                             foreach (var procedure in procedures)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(13, "tr");
                __builder2.OpenElement(14, "td");
                __builder2.AddContent(15, 
#nullable restore
#line 41 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                                         UserState.LoggedMedic.getFullName()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n                                    ");
                __builder2.OpenElement(17, "td");
                __builder2.AddContent(18, 
#nullable restore
#line 42 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                                         procedure.ProcedureName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                                    ");
                __builder2.OpenElement(20, "td");
                __builder2.AddContent(21, 
#nullable restore
#line 43 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                                         procedure.ProcedureDate.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n                                    ");
                __builder2.OpenElement(23, "td");
                __builder2.AddContent(24, 
#nullable restore
#line 44 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                                         procedure.PatientInfo.getFullName()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n                                    ");
                __builder2.OpenElement(26, "td");
                __builder2.OpenElement(27, "button");
                __builder2.AddAttribute(28, "class", "btn btn-outline-success btn-sm rounded-circle align-self-start p-2 bd-highlight btn-symmetric");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                                                                                                                                                                () => playProcedureVideo(procedure.ProcedureID)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(30, "<span class=\"oi oi-play-circle\" aria-hidden=\"true\" data-toggle=\"tooltip\" title=\"Reproducir Video\"></span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                                        ");
                __builder2.OpenElement(32, "a");
                __builder2.AddAttribute(33, "class", "btn btn-outline-danger btn-sm rounded-circle align-self-start p-2 bd-highlight btn-symmetric");
                __builder2.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                                                                                                                                                          () => deleteProcedure(procedure.ProcedureID)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(35, "href", "home");
                __builder2.AddMarkupContent(36, "<span class=\"oi oi-trash\" aria-hidden=\"true\" data-toggle=\"tooltip\" title=\"Eliminar Video\"></span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 54 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 57 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                     if (!String.IsNullOrEmpty(anyProcedures))
                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "row");
                __builder2.OpenElement(39, "h2");
                __builder2.AddAttribute(40, "class", "center-text");
                __builder2.AddContent(41, 
#nullable restore
#line 60 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                                                     anyProcedures

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 62 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
                     
                }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Procedure\ViewProcedures.razor"
       
    private ProcedureDTO[] procedures;
    private string _str_user_id;
    private string anyProcedures;
    protected override async Task OnInitializedAsync()
    {
        await getUserInformation();
        var user_id = await loginService.GetUserId();
        _str_user_id = user_id.ToString();
        if (!string.IsNullOrEmpty(_str_user_id))
        {
            var url_procedure = "https://databaseservicesawareness.azurewebsites.net/api/procedures/" + _str_user_id;
            try
            {
                HttpResponseMessage response_get = await HttpClient.GetAsync(url_procedure);

                if (response_get.IsSuccessStatusCode)
                {
                    string response_content = await response_get.Content.ReadAsStringAsync();
                    procedures = JsonConvert.DeserializeObject<ProcedureDTO[]>(response_content);
                }
                else
                {
                    procedures = new ProcedureDTO[0];
                    anyProcedures = "No tienes procedimientos asociados";
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e);
            }
        }
    }
    private async Task deleteProcedure(int selectedProcedureID)
    {
        if (!await AwarenessWebApp.Helpers.JSRuntimeExtensions.Confirm(JSRuntime, "??Desea eliminar el procedimiento ?"))
            return;
        var url_delete = "https://databaseservicesawareness.azurewebsites.net/api/procedures/" + selectedProcedureID;
        try
        {
            HttpResponseMessage response_delete = await HttpClient.DeleteAsync(url_delete);
        }
        catch (HttpRequestException e)
        {
            Console.WriteLine(e);
        }
    }
    private void playProcedureVideo(int selectedProcedureID)
    {
        NavigationManager.NavigateTo("/viewProcedureVideo/" + selectedProcedureID);
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
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserState UserState { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient HttpClient { get; set; }
    }
}
#pragma warning restore 1591
