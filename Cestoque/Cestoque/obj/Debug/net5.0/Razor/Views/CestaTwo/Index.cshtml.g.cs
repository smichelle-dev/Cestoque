#pragma checksum "D:\dev-smichelle\Cestoque\Cestoque\Cestoque\Views\CestaTwo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9d10824a00dd765ce1543aecda55f20150a64a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CestaTwo_Index), @"mvc.1.0.view", @"/Views/CestaTwo/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d10824a00dd765ce1543aecda55f20150a64a5", @"/Views/CestaTwo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a273c6464af37dbf546cddc48cff8657fcb8ff", @"/Views/_ViewImports.cshtml")]
    public class Views_CestaTwo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container"">
    <div class=""row justify-content-center align-items-center"">
        <div class=""card"" style=""width: 20rem;"">

            <div class=""card-body"">
                <h5 class=""card-title"">Cesta One</h5>
                <div class=""modal fade"" id=""exampleModalToggle"" aria-hidden=""true"" aria-labelledby=""exampleModalToggleLabel"" tabindex=""-1"">
                    <div class=""modal-dialog modal-dialog-centered"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title"" id=""exampleModalToggleLabel"">Atualmente essa cesta possui os ítems abaixo:</h5>
                                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                            </div>
                            <div class=""modal-body"">
                                <ul>
                                    <li>2- Arroz</li>
                        ");
            WriteLiteral(@"            <li>3- Feijão</li>
                                    <li>1- Suco</li>
                                    <li>2- Arroz</li>
                                    <li>6- Cuscuz</li>
                                    <li>2- Óleo</li>
                                    <li>1- Farinha</li>
                                    <li>4- Pão</li>
                                    <li>5- Leite</li>
                                    <li>1- Chocolate</li>
                                    <li>2- Açucar</li>
                                    <li>7- Milho</li>
                                    <li>2- temperos</li>
                                    <li>6- Biscoito</li>
                                    <li>10- Maioneze</li>
                                </ul>
                            </div>
                            <div class=""modal-footer"">
                                <button class=""btn btn-primary"" data-bs-target=""#exampleModalToggle2"" data-bs-toggle=""modal"">Adicion");
            WriteLiteral(@"ar quantidade da cesta?</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""modal fade"" id=""exampleModalToggle2"" aria-hidden=""true"" aria-labelledby=""exampleModalToggleLabel2"" tabindex=""-1"">
                    <div class=""modal-dialog modal-dialog-centered"">
                        <div class=""modal-content"">
                            <div class=""modal-header"">
                                <h5 class=""modal-title"" id=""exampleModalToggleLabel2"">Modal 2</h5>
                                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                            </div>
                            <div class=""modal-body"">
                                <label for=""floatingInputGrid"">Quantidade:</label>
                                <input type=""text"" class=""form-control"" id=""floatingInputGrid"">

                            </div>
             ");
            WriteLiteral(@"               <div class=""modal-footer"">
                                <button class=""btn btn-primary"" data-bs-target=""#exampleModalToggle"" data-bs-toggle=""modal"">Voltar</button>
                                <button class=""btn btn-primary"" data-bs-target=""#exampleModalToggle"" data-bs-toggle=""modal"">Fechar</button>
                                <button class=""btn btn-primary"" data-bs-target=""#exampleModalToggle"" data-bs-toggle=""modal"">Salvar</button>
                            </div>
                        </div>
                    </div>
                </div>
                <a class=""btn btn-primary"" data-bs-toggle=""modal"" href=""#exampleModalToggle"" role=""button"">Adicionar</a>
            </div>
        </div>



            
    </div>
    </div>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>
");
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
