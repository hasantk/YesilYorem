#pragma checksum "C:\Users\hsyna\Desktop\YesilYöremWeb\YesilYörem\YesilYörem\Views\Shared\Components\ProductWithCategory\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0df5fb6e45a591f953402d4e1c1255a359dc0eca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ProductWithCategory_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ProductWithCategory/Default.cshtml")]
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
#line 1 "C:\Users\hsyna\Desktop\YesilYöremWeb\YesilYörem\YesilYörem\Views\_ViewImports.cshtml"
using YesilYörem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hsyna\Desktop\YesilYöremWeb\YesilYörem\YesilYörem\Views\_ViewImports.cshtml"
using YesilYörem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0df5fb6e45a591f953402d4e1c1255a359dc0eca", @"/Views/Shared/Components/ProductWithCategory/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23212c416f47b7f71775dae19b73e87c2ca362c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_ProductWithCategory_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container py-5"">
    <div class=""row text-center py-3"">
        <div class=""col-lg-6 m-auto"">
            <h1 class=""h1"">Featured Product</h1>
            <p>
                Reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.
                Excepteur sint occaecat cupidatat non proident.
            </p>
        </div>
    </div>
    <div class=""row"">
");
#nullable restore
#line 13 "C:\Users\hsyna\Desktop\YesilYöremWeb\YesilYörem\YesilYörem\Views\Shared\Components\ProductWithCategory\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-md-4 mb-3\">\r\n                <div class=\"card h-30\">\r\n                    <a href=\"shop-single.html\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 670, "\"", 690, 1);
#nullable restore
#line 18 "C:\Users\hsyna\Desktop\YesilYöremWeb\YesilYörem\YesilYörem\Views\Shared\Components\ProductWithCategory\Default.cshtml"
WriteAttributeValue("", 676, item.ImageUrl, 676, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"  class=""card-img-top"" alt=""..."">
                    </a>
                    <div class=""card-body"">
                        <ul class=""list-unstyled d-flex justify-content-between"">
                            <li>
                                <i class=""text-warning fa fa-star""></i>
                                <i class=""text-warning fa fa-star""></i>
                                <i class=""text-warning fa fa-star""></i>
                                <i class=""text-muted fa fa-star""></i>
                                <i class=""text-muted fa fa-star""></i>
                            </li>
                            <li class=""text-muted text-right"">");
#nullable restore
#line 29 "C:\Users\hsyna\Desktop\YesilYöremWeb\YesilYörem\YesilYörem\Views\Shared\Components\ProductWithCategory\Default.cshtml"
                                                         Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("₺</li>\r\n                        </ul>\r\n                        <a href=\"shop-single.html\" class=\"h2 text-decoration-none text-dark\">");
#nullable restore
#line 31 "C:\Users\hsyna\Desktop\YesilYöremWeb\YesilYörem\YesilYörem\Views\Shared\Components\ProductWithCategory\Default.cshtml"
                                                                                        Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        <p class=\"card-text\">\r\n                           ");
#nullable restore
#line 33 "C:\Users\hsyna\Desktop\YesilYöremWeb\YesilYörem\YesilYörem\Views\Shared\Components\ProductWithCategory\Default.cshtml"
                      Write(item.ProductDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <p class=\"text-muted\">");
#nullable restore
#line 35 "C:\Users\hsyna\Desktop\YesilYöremWeb\YesilYörem\YesilYörem\Views\Shared\Components\ProductWithCategory\Default.cshtml"
                                         Write(item.categories.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 39 "C:\Users\hsyna\Desktop\YesilYöremWeb\YesilYörem\YesilYörem\Views\Shared\Components\ProductWithCategory\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
