#pragma checksum "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Shared\ProcedureSteps.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0395ddba969c28089a0413f5de440fc67b31b36b"
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
    public partial class ProcedureSteps : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style></style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "btn-group-vertical");
            __builder.AddAttribute(3, "style", "width: 100%;");
#nullable restore
#line 9 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Shared\ProcedureSteps.razor"
     foreach(var btn_item in UserState.ProcedureSteps){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "a");
            __builder.AddAttribute(5, "class", "btn" + " btn-outline-primary" + " btn-block" + " " + (
#nullable restore
#line 10 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Shared\ProcedureSteps.razor"
                                                     btn_item.status

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 10 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Shared\ProcedureSteps.razor"
                                                                      btn_item.active

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "href", 
#nullable restore
#line 10 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Shared\ProcedureSteps.razor"
                                                                                              btn_item.reference

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(7, 
#nullable restore
#line 10 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Shared\ProcedureSteps.razor"
                                                                                                                   btn_item.msg

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\Sidecil-PC\Documents\Andres\Personal\web_application\AwarenessWebApp\AwarenessWebApp\Shared\ProcedureSteps.razor"
   }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserState UserState { get; set; }
    }
}
#pragma warning restore 1591
