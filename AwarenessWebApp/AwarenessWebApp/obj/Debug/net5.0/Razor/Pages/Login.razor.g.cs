#pragma checksum "D:\U\2021\2021-02\Tesis\web_application\AwarenessWebApp\AwarenessWebApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc84e380c69c589d5137b38da220f457be489a1"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(LoginLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<center><div class=\"card-holder\"><div class=\"card col-lg-4 rounded-lg\"><div><div class=\"d-flex justify-content-between bd-highlight mb-3\"><div class=\"p-2 bd-highlight\"></div>\r\n                    <div class=\"row col-8 p-2 bd-highlight\"><img src=\"./img/logo.png\" class=\"img-fluid\"></div>\r\n                    <button type=\"button\" class=\"btn btn-outline-warning btn-sm rounded-circle align-self-start p-2 bd-highlight btn-symmetric\" href=\"about\"><span class=\"oi oi-info\" aria-hidden=\"true\" data-toggle=\"tooltip\" title=\"Acerca del software\"></span></button></div>\r\n                <hr>\r\n\r\n                <h3>Iniciar Sesión</h3>\r\n                <form><div class=\"form-group\"><label class=\"d-flex justify-content-start\" for=\"inputUser\">Usuario</label>\r\n                        <input type=\"text\" class=\"form-control\" id=\"inputUser\" aria-describedby=\"emailHelp\" placeholder=\"Ingresa el usuario\"></div>\r\n                    <div class=\"form-group\"><label class=\"d-flex justify-content-start\" for=\"inputPassword\">Contraseña</label>\r\n                        <input type=\"password\" class=\"form-control\" id=\"inputPassword\" placeholder=\"Contraseña\"></div>\r\n                    <div class=\"d-flex\"><div class=\"form-check mr-auto p-4\"><input type=\"radio\" class=\"form-check-input\" id=\"exampleCheck1\">\r\n                            <label class=\"form-check-label\" for=\"exampleCheck1\">Recuerdame</label></div>\r\n                        <div class=\"form-check p-4\"><a href=\"/singup\" class=\"link-primary\">No tengo cuenta</a></div></div>\r\n                    <a class=\"btn btn-outline-primary rounded-pill btn-block\" href=\"home\" role=\"button\">Iniciar Sesión</a></form></div></div></div></center>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
