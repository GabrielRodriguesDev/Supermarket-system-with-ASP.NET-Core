#pragma checksum "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd6b489acca2d0476ac95f7b36a0bce8d0a47534"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_Produtos), @"mvc.1.0.view", @"/Views/Gestao/Produtos.cshtml")]
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
#line 1 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\_ViewImports.cshtml"
using Supermarket_system_with_ASP.NET_Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\_ViewImports.cshtml"
using Supermarket_system_with_ASP.NET_Core.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd6b489acca2d0476ac95f7b36a0bce8d0a47534", @"/Views/Gestao/Produtos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a671f992a32cddb6ef7f6c35d1a2a240ef4faf", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_Produtos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Produto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovoProduto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "produtos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deletar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Produtos</h2>\r\n<hr>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6b489acca2d0476ac95f7b36a0bce8d0a475345722", async() => {
                WriteLiteral(" Criar novo Produto ");
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
            WriteLiteral(@"
<hr>

<script>
    $(document).ready( function () {
        $('#produtos').DataTable({
            ""bInfo"" : false,
            ""language"": {
                ""lengthMenu"": ""Mostrando _MENU_ registros por p??gina"",
                ""zeroRecords"": ""Nada encontrado"",
                ""info"": ""Mostrando p??gina _PAGE_ de _PAGES_"",
                ""infoEmpty"": ""Nenhum registro dispon??vel"",
                ""search"": ""Buscar:"",
                ""paginate"": {
                    ""first"": ""Primeiro"",
                    ""last"": ""??ltimo"",
                    ""next"": ""Pr??ximo"",
                    ""previous"": ""Anterior""
                }
            }
        });
    } );
</script>

<table id=""produtos"" class=""table table-striped- table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Categoria</th>
            <th>Fornecedor</th>
            <th>Pre??o de custo</th>
            <th>Pre??o de venda</th>
            <th>Medi????o</th>
        ");
            WriteLiteral("    <th>A????es</th>\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
         foreach (var produto in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 50 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
               Write(produto.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
               Write(produto.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
               Write(produto.Categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
               Write(produto.Fornecedor.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
               Write(produto.PrecoDeCusto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
               Write(produto.PrecoDeVenda);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 56 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
                     if(@produto.Medicao == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Litro</span>\r\n");
#nullable restore
#line 58 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
                } else if(@produto.Medicao == 1){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Kilo</span>\r\n");
#nullable restore
#line 60 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
                } else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Unidade</span>\r\n");
#nullable restore
#line 62 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    <a class=\"btn btn-outline-primary\" role=\"button\" aria-pressed=\"true\"");
            BeginWriteAttribute("href", " href=\"", 2136, "\"", 2176, 2);
            WriteAttributeValue("", 2143, "/Gestao/Editarproduto/", 2143, 22, true);
#nullable restore
#line 65 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
WriteAttributeValue("", 2165, produto.Id, 2165, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Editar</a> \r\n                    \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd6b489acca2d0476ac95f7b36a0bce8d0a4753412342", async() => {
                WriteLiteral("\r\n                        <input hidden type=\"text\" name=\"id\" id=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2380, "\"", 2399, 1);
#nullable restore
#line 68 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
WriteAttributeValue("", 2388, produto.Id, 2388, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <button class=\"btn btn-outline-danger\" role=\"button\" aria-pressed=\"true\">Deletar</button>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 73 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Produtos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
