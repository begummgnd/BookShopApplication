#pragma checksum "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shared\_categories.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "676c502f4964b302889ed18314bce5f339e9171c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__categories), @"mvc.1.0.view", @"/Views/Shared/_categories.cshtml")]
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
#line 2 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\_ViewImports.cshtml"
using BookShopApp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\_ViewImports.cshtml"
using BookShopApp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"676c502f4964b302889ed18314bce5f339e9171c", @"/Views/Shared/_categories.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e3a156c5195c8a9af77a83b7d9a7039c4c0700", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__categories : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\">\r\n    <a href=\"/shop\" class=\"list-group-item list-group-item-action  list-group-item-warning btn-lg\">Alt Kategoriler</a>\r\n");
#nullable restore
#line 5 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shared\_categories.cshtml"
     foreach (var category in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 226, "\"", 284, 4);
            WriteAttributeValue("", 233, "/shop/", 233, 6, true);
#nullable restore
#line 7 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shared\_categories.cshtml"
WriteAttributeValue("", 239, ViewBag.MainCategory, 239, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 260, "/", 260, 1, true);
#nullable restore
#line 7 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shared\_categories.cshtml"
WriteAttributeValue("", 261, category.Url.ToLower(), 261, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n           class=\"list-group-item list-group-item-action btn btn-dark btn-sm\">");
#nullable restore
#line 8 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shared\_categories.cshtml"
                                                                         Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 9 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shared\_categories.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
