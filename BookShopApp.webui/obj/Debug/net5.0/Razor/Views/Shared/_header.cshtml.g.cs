#pragma checksum "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shared\_header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5a2dc434880708fe9880a91164c78e2cdfa1004"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__header), @"mvc.1.0.view", @"/Views/Shared/_header.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5a2dc434880708fe9880a91164c78e2cdfa1004", @"/Views/Shared/_header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e3a156c5195c8a9af77a83b7d9a7039c4c0700", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header>
    <div class=""jumbotron jumbotron-fluid"">

        <div class=""container"">
            <h1 class=""display-4"">Okaliptüs Kitabevi</h1>
            <p class=""lead"">         Dünyanın En Büyük Kitap Pazarı</p>
        </div>
    </div>
</header>
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
