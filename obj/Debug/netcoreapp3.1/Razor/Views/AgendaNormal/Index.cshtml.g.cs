#pragma checksum "C:\Users\Administrador\source\repos\Proyectos\Prueba-Web\Views\AgendaNormal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c68ac969138d3e5af7a518ff2969372287193b8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AgendaNormal_Index), @"mvc.1.0.view", @"/Views/AgendaNormal/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Administrador\source\repos\Proyectos\Prueba-Web\Views\_ViewImports.cshtml"
using Prueba_Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\source\repos\Proyectos\Prueba-Web\Views\_ViewImports.cshtml"
using Prueba_Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c68ac969138d3e5af7a518ff2969372287193b8", @"/Views/AgendaNormal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbc83c24dd06d6738bb250412f789b26b1c243bd", @"/Views/_ViewImports.cshtml")]
    public class Views_AgendaNormal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Administrador\source\repos\Proyectos\Prueba-Web\Views\AgendaNormal\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

    var actividades = ViewBag.actividades;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Agenda</h2>\r\n\r\n<!-- este boton estaba pensando en poder marcar y asi poder crear una marcacion y al mismo tiempo crea una actividad de la cual se pueda ver que ya esta activa\r\n    y ha iniciado a trabajar\r\n    -->\r\n\r\n");
            WriteLiteral(@"

<!--
    El listado en esta tabla debe de ser limitado a la de cada usuario pero por diversos motivos y dificultadas en la persistencia de la informacion del usuario 
    para continuar con la informacion en las siguientes actividades, por ello se muestran todas en general
-->
<div>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    <label>Fecha Actividad</label>
                </th>
                <th>
                    <label>Numero de actividades</label>
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 40 "C:\Users\Administrador\source\repos\Proyectos\Prueba-Web\Views\AgendaNormal\Index.cshtml"
             foreach (var item in actividades)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        <label>");
#nullable restore
#line 44 "C:\Users\Administrador\source\repos\Proyectos\Prueba-Web\Views\AgendaNormal\Index.cshtml"
                          Write(item.Fecha_actividad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                    <td>\r\n                        <label>");
#nullable restore
#line 47 "C:\Users\Administrador\source\repos\Proyectos\Prueba-Web\Views\AgendaNormal\Index.cshtml"
                          Write(item.Actividades);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\Administrador\source\repos\Proyectos\Prueba-Web\Views\AgendaNormal\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
