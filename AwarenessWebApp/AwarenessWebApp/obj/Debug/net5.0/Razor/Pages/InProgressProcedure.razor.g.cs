#pragma checksum "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\Pages\InProgressProcedure.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37cf3c6e35d2c77d2bbb81338254c7203dcc51a1"
// <auto-generated/>
#pragma warning disable 1591
namespace AwarenessWebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\_Imports.razor"
using AwarenessWebApp.Auth;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/inProgressProcedure")]
    public partial class InProgressProcedure : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .center {\r\n        display: block;\r\n        margin-left: auto;\r\n        margin-right: auto;\r\n        width: 50%;\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-xl-5 my-auto");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "procedureSteps");
            __builder.OpenComponent<AwarenessWebApp.Shared.ProcedureSteps>(9);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-xl-7 my-auto");
#nullable restore
#line 19 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\Pages\InProgressProcedure.razor"
            if (!finalized)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(13, "<h1 style=\"text-align: center;\"> Procedimiento en curso</h1>\r\n                    <img src=\"./img/loadingButton-unscreen.gif\" class=\"img-fluid center\">\r\n                    <br>\r\n                    ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "class", "btn btn-warning btn-lg btn-block");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\Pages\InProgressProcedure.razor"
                                                                          endProcedure

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(17, " Terminar Procedimiento");
            __builder.CloseElement();
#nullable restore
#line 25 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\Pages\InProgressProcedure.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(18, "<h2 style=\"text-align: center;\"> ¿Desea terminar el procedimiento?</h2>\r\n                    ");
            __builder.AddMarkupContent(19, "<h2 style=\"text-align: center;\"> Si lo hace se guardarán los cambios</h2>\r\n                    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "d-flex justify-content-around bd-highlight");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "class", "btn btn-success p-2 bd-highlight");
            __builder.AddAttribute(24, "href", "home");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\Pages\InProgressProcedure.razor"
                                                                                          confirmEndProcedure

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, " Si");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "btn btn-danger p-2 bd-highlight");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\Pages\InProgressProcedure.razor"
                                                                               cancelEndProcedure

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(31, " No");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\Pages\InProgressProcedure.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\Pages\InProgressProcedure.razor"
       
private bool finalized=false;

private void endProcedure()
{
    finalized = true;
}

private void confirmEndProcedure()
{

}
private void cancelEndProcedure()
{
    finalized = false;
}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
