#pragma checksum "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3ba0bf0118ec97319f245e5fa0922d8451eb006"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Details), @"mvc.1.0.view", @"/Views/Shop/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3ba0bf0118ec97319f245e5fa0922d8451eb006", @"/Views/Shop/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e3a156c5195c8a9af77a83b7d9a7039c4c0700", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "list", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info m-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"card my-3 w-25\"> \r\n        <div class=\"card-body\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b3ba0bf0118ec97319f245e5fa0922d8451eb0064841", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 138, "~/img/", 138, 6, true);
#nullable restore
#line 6 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
AddHtmlAttributeValue("", 144, Model.Product.ResimUrl, 144, 23, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>        \r\n    </div>\r\n    <div class=\"col-md-9 text-muted\">\r\n        <div class=\"fs-2 shadow-sm bg-light ml-1 mt-2 p-4 w-50 \">\r\n           ");
#nullable restore
#line 11 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
      Write(Model.Product.KitapAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 13 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
         foreach (var item in Model.Categories)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row ml-2\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3ba0bf0118ec97319f245e5fa0922d8451eb0067094", async() => {
#nullable restore
#line 15 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
                                                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-category", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
                                                                              WriteLiteral(item.Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-category", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
           
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"mb-3 w-50\">\r\n            <div class=\"ml-4\">\r\n                <i class=\"fas fa-lira-sign pl-0 mb-2\">Fiyat: ");
#nullable restore
#line 21 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
                                                        Write(Model.Product.Ucret);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </i>\r\n                <p class=\"fw-lighter\">Yazar: ");
#nullable restore
#line 22 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
                                        Write(Model.Product.Yazar);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 23 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
                 if (Model.Product.Cevirmen != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"fw-lighter\">Çevirmen: ");
#nullable restore
#line 25 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
                                               Write(Model.Product.Cevirmen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 26 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"fw-lighter\">Yayınevi: ");
#nullable restore
#line 27 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
                                           Write(Model.Product.YayınEvi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"fw-lighter\">Baskı Yılı: ");
#nullable restore
#line 28 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
                                             Write(Model.Product.BaskiYili);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"fw-lighter\">Sayfa Sayısı: ");
#nullable restore
#line 29 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
                                               Write(Model.Product.SayfaSayisi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"fw-lighter\">Dili: ");
#nullable restore
#line 30 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
                                       Write(Model.Product.Dil);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"fw-lighter\">İçerik: ");
#nullable restore
#line 31 "C:\Users\bb\Desktop\BookShopApp\BookShopApp.webui\Views\Shop\Details.cshtml"
                                         Write(Model.Product.Icerik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-danger btn-lg ml-2\">Sepete Ekle</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n   \r\n  \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
