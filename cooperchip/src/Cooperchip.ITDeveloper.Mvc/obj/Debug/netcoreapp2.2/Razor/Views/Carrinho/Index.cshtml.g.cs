#pragma checksum "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31b75d2c279098846c515524144d413d764f7ef5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carrinho_Index), @"mvc.1.0.view", @"/Views/Carrinho/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carrinho/Index.cshtml", typeof(AspNetCore.Views_Carrinho_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31b75d2c279098846c515524144d413d764f7ef5", @"/Views/Carrinho/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"317af3d169d0978a34fddc829f0630be24bfa7ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Carrinho_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cooperchip.ITDeveloper.Mvc.ViewModels.CarrinhoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(107, 8, true);
            WriteLiteral("\r\n\r\n<h3>");
            EndContext();
            BeginContext(116, 14, false);
#line 8 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
Write(Model.Mensagem);

#line default
#line hidden
            EndContext();
            BeginContext(130, 516, true);
            WriteLiteral(@"</h3>

<div class=""row"">
    <div class=""panel panel-heading"">
        <h3>Carrinho de compras</h3>
    </div>
    <div class=""panel panel-body"">
        <table class=""table table-hover"">
            <caption>Protudos no Carrinho</caption>
            <thead>
                <tr>
                    <th>Produtos</th>
                    <th>Valor</th>
                    <th>Estoque</th>
                    <th>Tem em estoque</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 26 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                 foreach(var prod in Model.Produtos)
                {

#line default
#line hidden
            BeginContext(719, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(766, 9, false);
#line 29 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                   Write(prod.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(775, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(807, 10, false);
#line 30 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                   Write(prod.Valor);

#line default
#line hidden
            EndContext();
            BeginContext(817, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(849, 12, false);
#line 31 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                   Write(prod.Estoque);

#line default
#line hidden
            EndContext();
            BeginContext(861, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(893, 13, false);
#line 32 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                   Write(prod.Validade);

#line default
#line hidden
            EndContext();
            BeginContext(906, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(938, 17, false);
#line 33 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                   Write(prod.TemEmEstoque);

#line default
#line hidden
            EndContext();
            BeginContext(955, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 35 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1004, 144, true);
            WriteLiteral("            </tbody>\r\n            <tfoot>\r\n                <tr>\r\n                    <td><strong>Total: </strong></td>\r\n                    <td>");
            EndContext();
            BeginContext(1149, 19, false);
#line 40 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\Carrinho\Index.cshtml"
                   Write(Model.TotalCarrinho);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 88, true);
            WriteLiteral("</td>\r\n                </tr>\r\n            </tfoot>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cooperchip.ITDeveloper.Mvc.ViewModels.CarrinhoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
