#pragma checksum "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3d4f2ba10ca69a1babc0d31ab280e423d4fb193"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\_ViewImports.cshtml"
using Investment.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\_ViewImports.cshtml"
using Investment.Service;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\_ViewImports.cshtml"
using Investment.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\_ViewImports.cshtml"
using Investment.Models.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\_ViewImports.cshtml"
using Investment;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3d4f2ba10ca69a1babc0d31ab280e423d4fb193", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a319db96f3c383a7b06a1a32d82b9ac63dcfd78", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TextField>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Home\Index.cshtml"
   ViewBag.Title = Model.MetaTitle;
                ViewBag.Description = Model.MetaDescription;
                ViewBag.Keywords = Model.MetaKeywords; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n\n<div>\n    <h1>\n        ");
#nullable restore
#line 13 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Home\Index.cshtml"
   Write(ViewBag.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </h1>\n    <h1>\n        ");
#nullable restore
#line 16 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Home\Index.cshtml"
   Write(SharedResource["Home"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </h1>\n\n    <h2>\n        ");
#nullable restore
#line 20 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Home\Index.cshtml"
   Write(SharedResource["Txt"].Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </h2>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHtmlHelper Html { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResource> SharedResource { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
    }
}
#pragma warning restore 1591
