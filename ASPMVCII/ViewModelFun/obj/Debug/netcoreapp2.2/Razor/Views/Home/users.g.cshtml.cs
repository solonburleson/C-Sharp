#pragma checksum "E:\C-Sharp\ASPMVCII\ViewModelFun\Views\Home\users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ce844de471ad26a1f3f749b3eaae5a1a11047c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyApp.Namespace.Home.Views_Home_users), @"mvc.1.0.view", @"/Views/Home/users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/users.cshtml", typeof(MyApp.Namespace.Home.Views_Home_users))]
namespace MyApp.Namespace.Home
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 5 "E:\C-Sharp\ASPMVCII\ViewModelFun\Views\Home\users.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#line 6 "E:\C-Sharp\ASPMVCII\ViewModelFun\Views\Home\users.cshtml"
using ViewModelFun.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ce844de471ad26a1f3f749b3eaae5a1a11047c7", @"/Views/Home/users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1d1eb37dc6f0d82250bf784d7ea6a0b75ca51c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\C-Sharp\ASPMVCII\ViewModelFun\Views\Home\users.cshtml"
  
    ViewData["Title"] = "Users";

#line default
#line hidden
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(125, 55, true);
            WriteLiteral("\r\n<h1>Here are some Users!</h1>\r\n<div class=\"border\">\r\n");
            EndContext();
#line 11 "E:\C-Sharp\ASPMVCII\ViewModelFun\Views\Home\users.cshtml"
     foreach (var user in Model)
    {

#line default
#line hidden
            BeginContext(221, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(233, 14, false);
#line 13 "E:\C-Sharp\ASPMVCII\ViewModelFun\Views\Home\users.cshtml"
      Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(247, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(249, 13, false);
#line 13 "E:\C-Sharp\ASPMVCII\ViewModelFun\Views\Home\users.cshtml"
                      Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(262, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 14 "E:\C-Sharp\ASPMVCII\ViewModelFun\Views\Home\users.cshtml"
    }

#line default
#line hidden
            BeginContext(275, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
