#pragma checksum "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Categorias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e2fd26f146f79e116d0751d4b0b12800cc41817"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestao_Categorias), @"mvc.1.0.view", @"/Views/Gestao/Categorias.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e2fd26f146f79e116d0751d4b0b12800cc41817", @"/Views/Gestao/Categorias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79a671f992a32cddb6ef7f6c35d1a2a240ef4faf", @"/Views/_ViewImports.cshtml")]
    public class Views_Gestao_Categorias : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gestao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "NovaCategoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Categorias.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Categorias</h2>\r\n<hr>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e2fd26f146f79e116d0751d4b0b12800cc418174528", async() => {
                WriteLiteral(" Criar nova Categoria ");
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
        $('#categorias').DataTable();
        console.log(""Salve"");
    } );
</script>

<table id=""categorias"" class=""table table-striped- table-bordered"">
    <thead>
        <tr>
            <th>Id</th>
            <th>Nome</th>
            <th>Ações</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Categorias.cshtml"
         foreach (var categoria in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 31 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Categorias.cshtml"
               Write(categoria.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 32 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Categorias.cshtml"
               Write(categoria.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>\r\n                    <button class=\"btn btn-primary\">Editar</button> <button class=\"btn btn-danger\">Deletar</button>\r\n                </th>\r\n            </tr>\r\n");
#nullable restore
#line 37 "D:\Technology\Sistemas\Gabriel\ASPNET\SchoolOfNet\Supermarket-system-with-ASP.NET-Core\Views\Gestao\Categorias.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
