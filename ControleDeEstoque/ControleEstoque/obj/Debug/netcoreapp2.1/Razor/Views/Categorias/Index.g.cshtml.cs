#pragma checksum "C:\Users\ODR\Desktop\ControleDeEstoque\ControleEstoque\Views\Categorias\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af25e71c4e549059cf289730536fcb59087bdf36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categorias_Index), @"mvc.1.0.view", @"/Views/Categorias/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categorias/Index.cshtml", typeof(AspNetCore.Views_Categorias_Index))]
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
#line 1 "C:\Users\ODR\Desktop\ControleDeEstoque\ControleEstoque\Views\_ViewImports.cshtml"
using ControleEstoque;

#line default
#line hidden
#line 2 "C:\Users\ODR\Desktop\ControleDeEstoque\ControleEstoque\Views\_ViewImports.cshtml"
using ControleEstoque.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af25e71c4e549059cf289730536fcb59087bdf36", @"/Views/Categorias/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c37e9670ad116575c9dc8b078fe3e3156578bdb", @"/Views/_ViewImports.cshtml")]
    public class Views_Categorias_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ControleEstoque.Models.Entidades.Categoria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ODR\Desktop\ControleDeEstoque\ControleEstoque\Views\Categorias\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(154, 107, true);
            WriteLiteral("<br />\r\n<div class=\"jumbotron\">\r\n    <h2>Categorias</h2>\r\n</div>\r\n\r\n<div>\r\n    <button class=\"btn-success\">");
            EndContext();
            BeginContext(261, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "986ba3a9956e4791b950873c123459f1", async() => {
                BeginContext(284, 21, true);
                WriteLiteral("Adicionar Categoria +");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(309, 378, true);
            WriteLiteral(@"</button>
</div>
   
<br />
<table class=""table table-striped table-hover "">
    <thead>
        <tr class=""bg-primary"" style="""">
            <th>
                <p>Id Categoria</p>
            </th>
            <th>
                <p>Nome Categoria</p>
            </th>
            <th><p>Ações</p>
            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 31 "C:\Users\ODR\Desktop\ControleDeEstoque\ControleEstoque\Views\Categorias\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(719, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(768, 37, false);
#line 34 "C:\Users\ODR\Desktop\ControleDeEstoque\ControleEstoque\Views\Categorias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(805, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(861, 48, false);
#line 37 "C:\Users\ODR\Desktop\ControleDeEstoque\ControleEstoque\Views\Categorias\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NomeCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(909, 63, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button>");
            EndContext();
            BeginContext(973, 81, false);
#line 40 "C:\Users\ODR\Desktop\ControleDeEstoque\ControleEstoque\Views\Categorias\Index.cshtml"
                   Write(Html.ActionLink("Editar", "Edit", new { id = item.Id  /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 57, true);
            WriteLiteral("</button> |\r\n                 \r\n                <button> ");
            EndContext();
            BeginContext(1112, 85, false);
#line 42 "C:\Users\ODR\Desktop\ControleDeEstoque\ControleEstoque\Views\Categorias\Index.cshtml"
                    Write(Html.ActionLink("Detalhes", "Details", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1197, 38, true);
            WriteLiteral("</button> |\r\n                <button> ");
            EndContext();
            BeginContext(1236, 83, false);
#line 43 "C:\Users\ODR\Desktop\ControleDeEstoque\ControleEstoque\Views\Categorias\Index.cshtml"
                    Write(Html.ActionLink("Excluir", "Delete", new { id = item.Id /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1319, 62, true);
            WriteLiteral("</button>\r\n               \r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 47 "C:\Users\ODR\Desktop\ControleDeEstoque\ControleEstoque\Views\Categorias\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1384, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ControleEstoque.Models.Entidades.Categoria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
