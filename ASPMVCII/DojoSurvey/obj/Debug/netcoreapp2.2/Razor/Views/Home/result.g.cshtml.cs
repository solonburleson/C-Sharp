#pragma checksum "E:\C-Sharp\ASPMVCII\DojoSurvey\Views\Home\result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f66142957a520eed2082004561c7947e7d21f1ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_result), @"mvc.1.0.view", @"/Views/Home/result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/result.cshtml", typeof(MyApp.Namespace.Home.Views_Home_result))]
namespace MyApp.Namespace.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 5 "E:\C-Sharp\ASPMVCII\DojoSurvey\Views\Home\result.cshtml"
using DojoSurvey.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f66142957a520eed2082004561c7947e7d21f1ec", @"/Views/Home/result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18a173f1bb81d3faa72696fd2b0847cca3eba7d2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\C-Sharp\ASPMVCII\DojoSurvey\Views\Home\result.cshtml"
  
    ViewData["Title"] = "Dojo Survey Results";

#line default
#line hidden
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(98, 44, true);
            WriteLiteral("\r\n<h1>Submitted Info</h1>\r\n<p>Name:</p>\r\n<p>");
            EndContext();
            BeginContext(143, 10, false);
#line 10 "E:\C-Sharp\ASPMVCII\DojoSurvey\Views\Home\result.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(153, 32, true);
            WriteLiteral("</p>\r\n<p>Dojo Location:</p>\r\n<p>");
            EndContext();
            BeginContext(186, 14, false);
#line 12 "E:\C-Sharp\ASPMVCII\DojoSurvey\Views\Home\result.cshtml"
Write(Model.Location);

#line default
#line hidden
            EndContext();
            BeginContext(200, 36, true);
            WriteLiteral("</p>\r\n<p>Favorite Language:</p>\r\n<p>");
            EndContext();
            BeginContext(237, 14, false);
#line 14 "E:\C-Sharp\ASPMVCII\DojoSurvey\Views\Home\result.cshtml"
Write(Model.Language);

#line default
#line hidden
            EndContext();
            BeginContext(251, 27, true);
            WriteLiteral("</p>\r\n<p>Comments:</p>\r\n<p>");
            EndContext();
            BeginContext(279, 13, false);
#line 16 "E:\C-Sharp\ASPMVCII\DojoSurvey\Views\Home\result.cshtml"
Write(Model.Comment);

#line default
#line hidden
            EndContext();
            BeginContext(292, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
