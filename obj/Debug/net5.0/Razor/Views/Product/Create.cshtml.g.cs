#pragma checksum "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ecd66564b8062c5bc8b00f9c498b680f3d8d30e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
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
#line 1 "C:\xampp\htdocs\WebBanMayTinh\Views\_ViewImports.cshtml"
using WebBanMayTinh;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\WebBanMayTinh\Views\_ViewImports.cshtml"
using WebBanMayTinh.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ecd66564b8062c5bc8b00f9c498b680f3d8d30e", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09aa3663d2d885a707d42c8f7f6070edeac7a00d", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Store", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Create.cshtml"
  
    Layout = "_LayoutAdmin";
    var brands = ViewData["brand"] as List<Brand>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-md-8\">\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ecd66564b8062c5bc8b00f9c498b680f3d8d30e5325", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label for=\"title\">Tên sản phẩm</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"name\"");
                BeginWriteAttribute("id", " id=\"", 551, "\"", 556, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Tên sản phẩm...\"");
                BeginWriteAttribute("required", " required=\"", 587, "\"", 598, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"title\">Hình ảnh</label>\r\n                    <input type=\"file\" class=\"form-control\" name=\"image\"");
                BeginWriteAttribute("id", " id=\"", 731, "\"", 736, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 737, "\"", 748, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"title\">Giá tiền</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"price\"");
                BeginWriteAttribute("id", " id=\"", 881, "\"", 886, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Gía tiền...\"");
                BeginWriteAttribute("required", " required=\"", 913, "\"", 924, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"title\">Giá tiền sau sales</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"discount_price\"");
                BeginWriteAttribute("id", " id=\"", 1076, "\"", 1081, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Gía tiền sau sales...\"");
                BeginWriteAttribute("required", " required=\"", 1118, "\"", 1129, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"title\">Hãng</label>\r\n                    <select class=\"form-control\" name=\"brand\"");
                BeginWriteAttribute("id", " id=\"", 1247, "\"", 1252, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1253, "\"", 1264, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 25 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Create.cshtml"
                         foreach (var brand in brands)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ecd66564b8062c5bc8b00f9c498b680f3d8d30e8195", async() => {
#nullable restore
#line 27 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Create.cshtml"
                                                 Write(brand.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Create.cshtml"
                               WriteLiteral(brand.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 28 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Create.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </select>\r\n                    <label for=\"title\">Mô tả ngắn</label>\r\n                    <textarea class=\"form-control\" name=\"short_desc\" id=\"exampleFormControlTextarea1\" rows=\"3\"");
                BeginWriteAttribute("required", " required=\"", 1656, "\"", 1667, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                    <label for=\"title\">Mô tả</label>\r\n                    <textarea class=\"form-control\" name=\"desc\" id=\"exampleFormControlTextarea1\" rows=\"3\"");
                BeginWriteAttribute("required", " required=\"", 1840, "\"", 1851, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                    <input type=\"submit\" class=\"btn btn-primary mt-2\" value=\"Thêm\">\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
