#pragma checksum "C:\Users\hsyna\Desktop\YesilYorem\YesilYörem\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee81c0442c986585eecbae06b58d5b39dc400aea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
#line 1 "C:\Users\hsyna\Desktop\YesilYorem\YesilYörem\Views\_ViewImports.cshtml"
using YesilYörem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hsyna\Desktop\YesilYorem\YesilYörem\Views\_ViewImports.cshtml"
using YesilYörem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\hsyna\Desktop\YesilYorem\YesilYörem\Views\Shared\Components\CategoryList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee81c0442c986585eecbae06b58d5b39dc400aea", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c23212c416f47b7f71775dae19b73e87c2ca362c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"col-lg-3\">\r\n    <h1 class=\"h2 pb-4\">Kategoriler</h1>\r\n    <ul class=\"list-unstyled templatemo-accordion\">\r\n");
#nullable restore
#line 8 "C:\Users\hsyna\Desktop\YesilYorem\YesilYörem\Views\Shared\Components\CategoryList\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"pb-3\">\r\n                <a class=\"collapsed d-flex justify-content-between h3 text-decoration-none\" href=\"#\">\r\n                    ");
#nullable restore
#line 12 "C:\Users\hsyna\Desktop\YesilYorem\YesilYörem\Views\Shared\Components\CategoryList\Default.cshtml"
               Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <i class=\"fa fa-fw fa-chevron-circle-down mt-1\"></i>\r\n                </a>\r\n                <ul class=\"collapse show list-unstyled pl-3\">\r\n                    <li><a class=\"text-decoration-none\" href=\"#\">");
#nullable restore
#line 16 "C:\Users\hsyna\Desktop\YesilYorem\YesilYörem\Views\Shared\Components\CategoryList\Default.cshtml"
                                                            Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                    <li><a class=\"text-decoration-none\" href=\"#\">");
#nullable restore
#line 17 "C:\Users\hsyna\Desktop\YesilYorem\YesilYörem\Views\Shared\Components\CategoryList\Default.cshtml"
                                                            Write(item.CategoryStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                </ul>\r\n            </li>\r\n");
#nullable restore
#line 20 "C:\Users\hsyna\Desktop\YesilYorem\YesilYörem\Views\Shared\Components\CategoryList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
