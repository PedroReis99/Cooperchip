#pragma checksum "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc60b3ccaa5fb532f3f1935742be90bdd45ee72c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_EstadoEstavel_Default), @"mvc.1.0.view", @"/Views/Shared/Components/EstadoEstavel/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/EstadoEstavel/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_EstadoEstavel_Default))]
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
#line 1 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc;

#line default
#line hidden
#line 2 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\_ViewImports.cshtml"
using Cooperchip.ITDeveloper.Mvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc60b3ccaa5fb532f3f1935742be90bdd45ee72c", @"/Views/Shared/Components/EstadoEstavel/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed17422105ce2ed29d5735aacbd158dfe7409372", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_EstadoEstavel_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cooperchip.ITDeveloper.Mvc.ViewComponents.Helpers.ContadorEstadoPaciente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(81, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 87, "\"", 116, 1);
#line 3 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
WriteAttributeValue("", 95, Model.ClassContainer, 95, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(117, 95, true);
            WriteLiteral(">\r\n    <!-- Start .panel -->\r\n    <div class=\"panel-heading\">\r\n        <h4 class=\"panel-title\">");
            EndContext();
            BeginContext(213, 12, false);
#line 6 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
                           Write(Model.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(225, 147, true);
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"panel-body pt0\">\r\n        <div class=\"progressbar-stats-1\">\r\n            <div class=\"stats\">\r\n                <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 372, "\"", 397, 1);
#line 11 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
WriteAttributeValue("", 380, Model.IconeLarge, 380, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(398, 71, true);
            WriteLiteral("></i>\r\n                <div class=\"stats-number\" data-from=\"0\" data-to=");
            EndContext();
            BeginContext(470, 13, false);
#line 12 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
                                                           Write(Model.Parcial);

#line default
#line hidden
            EndContext();
            BeginContext(483, 244, true);
            WriteLiteral(">0</div>\r\n            </div>\r\n            <div class=\"progress animated-bar flat transparent progress-bar-xs mb10 mt0\">\r\n                <div class=\"progress-bar progress-bar-white\" role=\"progressbar\" \r\n                     data-transitiongoal=");
            EndContext();
            BeginContext(728, 14, false);
#line 16 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
                                    Write(Model.Progress);

#line default
#line hidden
            EndContext();
            BeginContext(742, 100, true);
            WriteLiteral("></div>\r\n            </div>\r\n            <div class=\"comparison\">\r\n                <p class=\"mb0\"><i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 842, "\"", 867, 1);
#line 19 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
WriteAttributeValue("", 850, Model.IconeSmall, 850, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(868, 6, true);
            WriteLiteral("></i> ");
            EndContext();
            BeginContext(875, 16, false);
#line 19 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Shared\Components\EstadoEstavel\Default.cshtml"
                                                            Write(Model.Percentual);

#line default
#line hidden
            EndContext();
            BeginContext(891, 74, true);
            WriteLiteral("% de pacientes</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cooperchip.ITDeveloper.Mvc.ViewComponents.Helpers.ContadorEstadoPaciente> Html { get; private set; }
    }
}
#pragma warning restore 1591
