#pragma checksum "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6cb9dcb5fca15fef7073371e430e3c8332c18c7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cb9dcb5fca15fef7073371e430e3c8332c18c7e", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e3a156c5195c8a9af77a83b7d9a7039c4c0700", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"navbar bg-danger navbar-dark navbar-expand-sm\">\r\n    <div class=\"container\">\r\n        <a href=\"/\" class=\"navbar-brand\">Okaliptüs Kitabevi</a>\r\n        <ul class=\"navbar-nav mr-auto\">\r\n            <li class=\"nav-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 249, "\"", 256, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link\">Üye Ol</a>\r\n            </li>\r\n            <li class=\"nav-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 359, "\"", 366, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""nav-link"">Sepet</a>
            </li>
            <li class=""nav-item"">
                <a href=""/admin/products"" class=""nav-link"">Admin Ürünleri</a>
            </li>
            <li class=""nav-item"">
                <a href=""/admin/categories"" class=""nav-link"">Admin Kategorileri</a>
            </li>
        </ul>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
