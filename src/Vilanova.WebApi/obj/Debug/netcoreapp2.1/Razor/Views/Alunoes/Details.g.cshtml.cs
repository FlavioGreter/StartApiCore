#pragma checksum "C:\projetos\csharp\Vilanova\src\Vilanova.WebApi\Views\Alunoes\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3632aaf803d96e2c23cc8c9ca27b874e8a586ebd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alunoes_Details), @"mvc.1.0.view", @"/Views/Alunoes/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alunoes/Details.cshtml", typeof(AspNetCore.Views_Alunoes_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3632aaf803d96e2c23cc8c9ca27b874e8a586ebd", @"/Views/Alunoes/Details.cshtml")]
    public class Views_Alunoes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Vilanova.ApplicationCore.Entities.Aluno>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\projetos\csharp\Vilanova\src\Vilanova.WebApi\Views\Alunoes\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Aluno</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(213, 40, false);
#line 14 "C:\projetos\csharp\Vilanova\src\Vilanova.WebApi\Views\Alunoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(253, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(297, 36, false);
#line 17 "C:\projetos\csharp\Vilanova\src\Vilanova.WebApi\Views\Alunoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(333, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(377, 45, false);
#line 20 "C:\projetos\csharp\Vilanova\src\Vilanova.WebApi\Views\Alunoes\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SobreNome));

#line default
#line hidden
            EndContext();
            BeginContext(422, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(466, 41, false);
#line 23 "C:\projetos\csharp\Vilanova\src\Vilanova.WebApi\Views\Alunoes\Details.cshtml"
       Write(Html.DisplayFor(model => model.SobreNome));

#line default
#line hidden
            EndContext();
            BeginContext(507, 67, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 574, "\"", 598, 1);
#line 28 "C:\projetos\csharp\Vilanova\src\Vilanova.WebApi\Views\Alunoes\Details.cshtml"
WriteAttributeValue("", 589, Model.id, 589, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(599, 65, true);
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Vilanova.ApplicationCore.Entities.Aluno> Html { get; private set; }
    }
}
#pragma warning restore 1591
