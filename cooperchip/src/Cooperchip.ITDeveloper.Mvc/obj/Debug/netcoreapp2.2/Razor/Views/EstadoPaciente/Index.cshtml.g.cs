#pragma checksum "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\EstadoPaciente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad40ded6084e75dade07ac3c07d020ccab92b3e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EstadoPaciente_Index), @"mvc.1.0.view", @"/Views/EstadoPaciente/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/EstadoPaciente/Index.cshtml", typeof(AspNetCore.Views_EstadoPaciente_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad40ded6084e75dade07ac3c07d020ccab92b3e6", @"/Views/EstadoPaciente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed17422105ce2ed29d5735aacbd158dfe7409372", @"/Views/_ViewImports.cshtml")]
    public class Views_EstadoPaciente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cooperchip.ITDeveloper.Domain.Models.EstadoPaciente>>
    {
        private global::AspNetCore.Views_EstadoPaciente_Index.__Generated__CabecalhoViewComponentTagHelper __CabecalhoViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EstadoPaciente", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Cooperchip.ITDeveloper.Mvc.Extentions.TagHelpers.TableGridTagHelper __Cooperchip_ITDeveloper_Mvc_Extentions_TagHelpers_TableGridTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(72, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\EstadoPaciente\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(111, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(113, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:cabecalho", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad40ded6084e75dade07ac3c07d020ccab92b3e64987", async() => {
            }
            );
            __CabecalhoViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_EstadoPaciente_Index.__Generated__CabecalhoViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__CabecalhoViewComponentTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Medical Management-System / Pacientes");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __CabecalhoViewComponentTagHelper.titulo = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("titulo", __CabecalhoViewComponentTagHelper.titulo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("Módulo de Administração do Estado dos Pacientes");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __CabecalhoViewComponentTagHelper.subtitulo = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("subtitulo", __CabecalhoViewComponentTagHelper.subtitulo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(263, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(347, 170, true);
            WriteLiteral("\n<div class=\"panel panel-info panel-controls\">\n    <div>\n        <h3>Lista de Estados do Paciente</h3>\n    </div>\n    \n    <div class=\"panel panel-body\">\n    <p>\n        ");
            EndContext();
            BeginContext(517, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad40ded6084e75dade07ac3c07d020ccab92b3e67288", async() => {
                BeginContext(593, 78, true);
                WriteLiteral("\n            <i class=\"fa fa-plus-circle\"></i>&nbsp; Adicionar Estado\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(675, 23, true);
            WriteLiteral("\n    </p>\n    \n        ");
            EndContext();
            BeginContext(698, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("table-grid", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad40ded6084e75dade07ac3c07d020ccab92b3e69046", async() => {
            }
            );
            __Cooperchip_ITDeveloper_Mvc_Extentions_TagHelpers_TableGridTagHelper = CreateTagHelper<global::Cooperchip.ITDeveloper.Mvc.Extentions.TagHelpers.TableGridTagHelper>();
            __tagHelperExecutionContext.Add(__Cooperchip_ITDeveloper_Mvc_Extentions_TagHelpers_TableGridTagHelper);
#line 25 "C:\Users\Dell\Desktop\Cursos\Udemy\DotNet\cooperchip\src\Cooperchip.ITDeveloper.Mvc\Views\EstadoPaciente\Index.cshtml"
__Cooperchip_ITDeveloper_Mvc_Extentions_TagHelpers_TableGridTagHelper.Items = Model;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("Items", __Cooperchip_ITDeveloper_Mvc_Extentions_TagHelpers_TableGridTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(738, 19, true);
            WriteLiteral("\n\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cooperchip.ITDeveloper.Domain.Models.EstadoPaciente>> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:cabecalho")]
        public class __Generated__CabecalhoViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__CabecalhoViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.String titulo { get; set; }
            public System.String subtitulo { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("Cabecalho", new { titulo, subtitulo });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
