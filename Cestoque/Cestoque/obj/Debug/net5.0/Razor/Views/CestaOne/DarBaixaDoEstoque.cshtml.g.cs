#pragma checksum "D:\dev-smichelle\Cestoque\Cestoque\Cestoque\Views\CestaOne\DarBaixaDoEstoque.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f16bf59550b5f3c1c0c8b8671e8c816660782c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CestaOne_DarBaixaDoEstoque), @"mvc.1.0.view", @"/Views/CestaOne/DarBaixaDoEstoque.cshtml")]
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
#line 1 "D:\dev-smichelle\Cestoque\Cestoque\Cestoque\Views\_ViewImports.cshtml"
using Cestoque;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dev-smichelle\Cestoque\Cestoque\Cestoque\Views\_ViewImports.cshtml"
using Cestoque.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f16bf59550b5f3c1c0c8b8671e8c816660782c24", @"/Views/CestaOne/DarBaixaDoEstoque.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a273c6464af37dbf546cddc48cff8657fcb8ff", @"/Views/_ViewImports.cshtml")]
    public class Views_CestaOne_DarBaixaDoEstoque : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cestas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"


<ul class=""list-group"">
    <li class=""list-group-item d-flex justify-content-between align-items-center"">
        Arroz
        <div class=""justify-content-between align-items-center"">
            <span class=""badge badge-warning badge-pill"">3</span>
            <span class=""badge badge-dark badge-pill"" data-toggle=""tooltip"" data-placement=""top"" title=""Disponível em estoque"">87</span>
        </div>

        <div>
            <a href=""#"" class=""badge badge-primary"" data-toggle=""tooltip"" data-placement=""top"" title=""Adicionar a cesta"">+</a>
            <a href=""#"" class=""badge badge-danger"" data-toggle=""tooltip"" data-placement=""top"" title=""Remover da cesta"">-</a>
        </div>
    </li>
    <li class=""list-group-item d-flex justify-content-between align-items-center"">
        Feijão

        <div class=""justify-content-between align-items-center"">
            <span class=""badge badge-warning badge-pill"">3</span>
            <span class=""badge badge-dark badge-pill"" data-toggle=""tooltip");
            WriteLiteral(@""" data-placement=""top"" title=""Disponível em estoque"">7</span>
        </div>
        <div>
            <a href=""#"" class=""badge badge-primary"" data-toggle=""tooltip"" data-placement=""top"" title=""Adicionar a cesta"">+</a>
            <a href=""#"" class=""badge badge-danger"" data-toggle=""tooltip"" data-placement=""top"" title=""Remover da cesta"">-</a>
        </div>

    </li>
    <li class=""list-group-item d-flex justify-content-between align-items-center"">
        Açucar
        <div class=""justify-content-between align-items-center"">
            <span class=""badge badge-warning badge-pill"">3</span>
            <span class=""badge badge-dark badge-pill"" data-toggle=""tooltip"" data-placement=""top"" title=""Disponível em estoque"">100</span>
        </div>
        <div>
            <a href=""#"" class=""badge badge-primary"" data-toggle=""tooltip"" data-placement=""top"" title=""Adicionar a cesta"">+</a>
            <a href=""#"" class=""badge badge-danger"" data-toggle=""tooltip"" data-placement=""top"" title=""Remover da cest");
            WriteLiteral(@"a"">-</a>
        </div>
    </li>
    <li class=""list-group-item d-flex justify-content-between align-items-center"">
        Açucar
        <div class=""justify-content-between align-items-center"">
            <span class=""badge badge-warning badge-pill"">3</span>
            <span class=""badge badge-dark badge-pill"" data-toggle=""tooltip"" data-placement=""top"" title=""Disponível em estoque"">100</span>
        </div>
        <div>
            <a href=""#"" class=""badge badge-primary"" data-toggle=""tooltip"" data-placement=""top"" title=""Adicionar a cesta"">+</a>
            <a href=""#"" class=""badge badge-danger"" data-toggle=""tooltip"" data-placement=""top"" title=""Remover da cesta"">-</a>
        </div>
    </li>
    <br />
    <p>Valor: R$ 50,00</p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f16bf59550b5f3c1c0c8b8671e8c816660782c247434", async() => {
                WriteLiteral("Salvar Alterações");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n   \r\n</ul>");
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
