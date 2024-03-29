#pragma checksum "C:\Users\158265\source\repos\Sales_DB\Sales\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4c91902140bbf8a0c8b584778b3156293839895"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
#line 1 "C:\Users\158265\source\repos\Sales_DB\Sales\Views\_ViewImports.cshtml"
using Sales;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\158265\source\repos\Sales_DB\Sales\Views\_ViewImports.cshtml"
using Sales.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4c91902140bbf8a0c8b584778b3156293839895", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f1e7de7ae305c24dcbd5c5649434984226fed7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\158265\source\repos\Sales_DB\Sales\Views\Category\Index.cshtml"
  
    ViewBag.Title = "Category List";
    int no = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<nav class=""navbar navbar-light mt-1"">
    <a class=""navbar-brand btn btn-outline-light"" data-bs-toggle=""modal"" data-bs-target=""#AddCategoryModel"">Add</a>
</nav>
<div class=""modal fade"" id=""AddCategoryModel"" tabindex=""-1"" aria-labelledby=""AddCategory"" aria-hidden=""true"">
    <div class=""true"">
        <div class=""modal-dialog"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLable"">Add Category</h5>
                    <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    <div class=""row m-2"">
                        <div class=""col-sm-12"">
                            <input type=""text"" class=""from-control"" id=""txtCategory"" name=""category"" placeholder=""New Category"" />
                            <div class=""text-danger"" id=""divCategoryError""></div>
                        </di");
            WriteLiteral(@"v>
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-bs-dismiss=""modal"">Close</button>
                    <button type=""button"" id=""btnAddCategory"" class=""btn btn-primary"">Add Category</button>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""border border-1 rounded border-secondary bg-dark text-white p-1 m-1"">
    <div class=""row fs-5 fw-bold"">
        <div class=""col-sm-2 m-1"">Sr.No</div>
        <div class=""col-sm-4  m-1"">Name</div>
    </div>


");
#nullable restore
#line 41 "C:\Users\158265\source\repos\Sales_DB\Sales\Views\Category\Index.cshtml"
     foreach (Category each in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row border border-1 rounded m-1 align-content-center fs-6 word-wrap bg-dark\">\r\n            <div class=\"col-sm-2 align-text-top pt-1\">");
#nullable restore
#line 44 "C:\Users\158265\source\repos\Sales_DB\Sales\Views\Category\Index.cshtml"
                                                 Write(no);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col-sm-4 pt-1\">");
#nullable restore
#line 45 "C:\Users\158265\source\repos\Sales_DB\Sales\Views\Category\Index.cshtml"
                                  Write(each.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n            <div class=\"col-sm-3 pt-1\">\r\n                ");
#nullable restore
#line 48 "C:\Users\158265\source\repos\Sales_DB\Sales\Views\Category\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", "Category", new { id = each.Id },
               new { @class = "btn btn-outline-info m-1" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4c91902140bbf8a0c8b584778b31562938398957703", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\158265\source\repos\Sales_DB\Sales\Views\Category\Index.cshtml"
                                       WriteLiteral(each.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4c91902140bbf8a0c8b584778b31562938398959941", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\158265\source\repos\Sales_DB\Sales\Views\Category\Index.cshtml"
                                         WriteLiteral(each.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 53 "C:\Users\158265\source\repos\Sales_DB\Sales\Views\Category\Index.cshtml"
              
                no = no + 1;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 57 "C:\Users\158265\source\repos\Sales_DB\Sales\Views\Category\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
    function IsBlank(input) {
        let value = input.val().trim();
        if (value == undefined || value == '')
            return true;
        return false;
    }
    function IsOnlyNumeric(input) {
        let value = input.val().trim();
        return isNaN(value);
    }
    $(document).ready(function () {
        $(""#btnAddCategory"").on(""click"", function () {
            $(""#divCategoryError"").text("""");
            let category = $(""#txtCategory"");
            let blank = IsBlank(category);
            if (!blank) {
                if (!IsOnlyNumeric(category)) {
                    $(""#divCategoryError"").text(""Only numbers are not allowed"");
                    return;
                }
                else {
                    $.post(""/Category/AddCategory"",
                        { name: category.val().trim() },
                        function (data) {
                            if (data) {
                                alert(""Sucess"");
                ");
                WriteLiteral(@"                window.location.href = ""/Category/Index"";

                            }
                            else {
                                alert(""Duplicate Category not allowed"");
                            }
                        });
                }
            }
            else {
                $(""#divCategoryError"").text(""Category Should not empty"");
                return;
            }
        })
    })
</script>
 ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
