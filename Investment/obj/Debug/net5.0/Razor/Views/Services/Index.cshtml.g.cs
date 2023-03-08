#pragma checksum "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85172a03a00c32e10b4a543bf716713c5cf562d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Services_Index), @"mvc.1.0.view", @"/Views/Services/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85172a03a00c32e10b4a543bf716713c5cf562d3", @"/Views/Services/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a319db96f3c383a7b06a1a32d82b9ac63dcfd78", @"/Views/_ViewImports.cshtml")]
    public class Views_Services_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<ServiceItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
  
    TextField textField = ViewBag.TextField;
    if (textField != null)
    {
        ViewBag.Title = textField.MetaTitle;
        ViewBag.Description = textField.MetaDescription;
        ViewBag.Keywords = textField.MetaKeywords;
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 14 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
     if (Model.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"big-image-list\">\r\n");
#nullable restore
#line 17 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
             foreach (ServiceItem entity in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85172a03a00c32e10b4a543bf716713c5cf562d36947", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85172a03a00c32e10b4a543bf716713c5cf562d37226", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 592, "~/images/", 592, 9, true);
#nullable restore
#line 21 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
AddHtmlAttributeValue("", 601, entity.TitleMainImagePath, 601, 26, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
                                                                                  WriteLiteral(entity.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h4>\r\n");
#nullable restore
#line 24 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
                         if (ViewBag.checkEng)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
                       Write(entity.Title);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
                                         ;
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
                       Write(entity.TitleGeo);

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
                                            ;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </h4>\r\n                    <p>\r\n");
#nullable restore
#line 34 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
                         if (ViewBag.checkEng)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
                       Write(entity.Subtitle);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
                                            ;
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
                       Write(entity.SubtitleGeo);

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
                                               ;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\r\n                </li>\r\n");
#nullable restore
#line 44 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 46 "D:\Coding\C#Workspace\ASP.NET\Investment\Investment\Views\Services\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
