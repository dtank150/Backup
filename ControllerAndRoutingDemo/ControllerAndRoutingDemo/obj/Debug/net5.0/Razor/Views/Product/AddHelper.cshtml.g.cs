#pragma checksum "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e811d384324b3b34a0e2977a7fe2efe58374458"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_AddHelper), @"mvc.1.0.view", @"/Views/Product/AddHelper.cshtml")]
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
#line 1 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\_ViewImports.cshtml"
using ControllerAndRoutingDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\_ViewImports.cshtml"
using ControllerAndRoutingDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e811d384324b3b34a0e2977a7fe2efe58374458", @"/Views/Product/AddHelper.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09bffa1383412f3568d4047e76a3d6543c5ea643", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_AddHelper : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
  
    String title = "Add Product using Helper Method";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 8 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
 using(Html.BeginForm("SaveHelperRequest", "Product",FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>\r\n                    ");
#nullable restore
#line 11 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
               Write(Html.Label("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;\r\n                    ");
#nullable restore
#line 12 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
               Write(Html.TextBox("Id"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    ");
#nullable restore
#line 15 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
               Write(Html.Label("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;\r\n                    ");
#nullable restore
#line 16 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
               Write(Html.TextBox("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    ");
#nullable restore
#line 19 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
               Write(Html.Label("Qty"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;\r\n                    ");
#nullable restore
#line 20 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
               Write(Html.TextBox("Qty"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    ");
#nullable restore
#line 23 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
               Write(Html.Label("Rate"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;\r\n                    ");
#nullable restore
#line 24 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
               Write(Html.TextBox("Rate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <p>\r\n                    <input type=\"submit\" value=\"SAVE\"/>\r\n                </p>\r\n");
#nullable restore
#line 29 "C:\Users\158265\source\repos\ControllerAndRoutingDemo\ControllerAndRoutingDemo\Views\Product\AddHelper.cshtml"
            }

#line default
#line hidden
#nullable disable
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
