#pragma checksum "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bc0ed0dd19a95a0c285c16f738e6967910a4d7b"
// <auto-generated/>
#pragma warning disable 1591
namespace AwarenessWebApp.Shared
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
using AuthenticationService.DTO;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<link href=\"https://fonts.googleapis.com/css2?family=Quicksand:wght@400&display=swap\" rel=\"stylesheet\" b-1fcwiuzhuh>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.AddAttribute(3, "b-1fcwiuzhuh");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "sidebar");
            __builder.AddAttribute(6, "b-1fcwiuzhuh");
            __builder.OpenComponent<AwarenessWebApp.Shared.NavMenu>(7);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "main");
            __builder.AddAttribute(11, "b-1fcwiuzhuh");
            __builder.AddMarkupContent(12, @"<div class=""top-row px-4"" b-1fcwiuzhuh><div class=""p-0 bd-highlight"" b-1fcwiuzhuh><div class=""vr"" b-1fcwiuzhuh></div>
                <a class=""btn btn-outline-danger btn-sm rounded-circle align-self-start p-2 bd-highlight btn-symmetric"" href b-1fcwiuzhuh><span class=""oi oi-account-logout"" aria-hidden=""true"" data-toggle=""tooltip"" title=""Cerrar Sesión"" b-1fcwiuzhuh></span></a></div>
            <div class=""p-0 bd-highlight"" b-1fcwiuzhuh><div class=""vr"" b-1fcwiuzhuh></div>
                <a class=""btn btn-outline-warning btn-sm rounded-circle align-self-start p-2 bd-highlight btn-symmetric"" href=""settings"" b-1fcwiuzhuh><span class=""oi oi-cog"" aria-hidden=""true"" data-toggle=""tooltip"" href=""aboutApplication"" title=""Configuración"" b-1fcwiuzhuh></span></a></div>
            <div class=""p-0 bd-highlight"" b-1fcwiuzhuh><div class=""vr"" b-1fcwiuzhuh></div>
                <a class=""btn btn-outline-success btn-sm rounded-circle align-self-start p-2 bd-highlight btn-symmetric"" href=""viewProfile"" b-1fcwiuzhuh><span class=""oi oi-person"" aria-hidden=""true"" data-toggle=""tooltip"" href title=""Ver perfil"" b-1fcwiuzhuh></span></a></div></div>
        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "content px-4");
            __builder.AddAttribute(15, "b-1fcwiuzhuh");
            __builder.AddContent(16, 
#nullable restore
#line 31 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591