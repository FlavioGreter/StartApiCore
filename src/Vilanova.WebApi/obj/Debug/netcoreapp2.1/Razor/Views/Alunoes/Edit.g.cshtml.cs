#pragma checksum "C:\projetos\csharp\Vilanova\src\Vilanova.WebApi\Views\Alunoes\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aef27566ae9ce7e9f0a5c04a8a816b7a9fa6f936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alunoes_Edit), @"mvc.1.0.view", @"/Views/Alunoes/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alunoes/Edit.cshtml", typeof(AspNetCore.Views_Alunoes_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aef27566ae9ce7e9f0a5c04a8a816b7a9fa6f936", @"/Views/Alunoes/Edit.cshtml")]
    public class Views_Alunoes_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vilanova.ApplicationCore.Entities.Aluno>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\projetos\csharp\Vilanova\src\Vilanova.WebApi\Views\Alunoes\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(90, 1041, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Aluno</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Nome"" class=""control-label""></label>
                <input asp-for=""Nome"" class=""form-control"" />
                <span asp-validation-for=""Nome"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SobreNome"" class=""control-label""></label>
                <input asp-for=""SobreNome"" class=""form-control"" />
                <span asp-validation-for=""SobreNome"" class=""text-danger""></span>
            </div>
            <input type=""hidden"" asp-for=""id"" />
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to Lis");
            WriteLiteral("t</a>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1149, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 38 "C:\projetos\csharp\Vilanova\src\Vilanova.WebApi\Views\Alunoes\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vilanova.ApplicationCore.Entities.Aluno> Html { get; private set; }
    }
}
#pragma warning restore 1591
