#pragma checksum "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa1e7779b6f46b862a0a1aed517e386e0237d628"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Edit), @"mvc.1.0.view", @"/Views/Product/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa1e7779b6f46b862a0a1aed517e386e0237d628", @"/Views/Product/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09aa3663d2d885a707d42c8f7f6070edeac7a00d", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
  
    Layout = "_LayoutAdmin";
    var brands = ViewData["brand"] as List<Brand>;
    var product = ViewData["product"] as Product;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 7 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-md-8\">\r\n        <div class=\"card-header\">\r\n\r\n        </div>\r\n        <div class=\"card-body\">\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa1e7779b6f46b862a0a1aed517e386e0237d6285949", async() => {
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label for=\"title\">Tên sản phẩm</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"name\"");
                BeginWriteAttribute("id", " id=\"", 655, "\"", 660, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Tên sản phẩm...\"");
                BeginWriteAttribute("value", " value=\"", 691, "\"", 712, 1);
#nullable restore
#line 18 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
WriteAttributeValue("", 699, product.Name, 699, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 713, "\"", 724, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"title\">Hình ảnh</label>\r\n                    <input type=\"file\" class=\"form-control\" name=\"image\"");
                BeginWriteAttribute("id", " id=\"", 857, "\"", 862, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"title\">Giá tiền</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"price\"");
                BeginWriteAttribute("id", " id=\"", 995, "\"", 1000, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Gía tiền...\"");
                BeginWriteAttribute("value", " value=\"", 1027, "\"", 1049, 1);
#nullable restore
#line 22 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1035, product.Price, 1035, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1050, "\"", 1061, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"title\">Giá tiền sau sales</label>\r\n                    <input type=\"text\" class=\"form-control\" name=\"discount_price\"");
                BeginWriteAttribute("id", " id=\"", 1213, "\"", 1218, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Gía tiền sau sales...\"");
                BeginWriteAttribute("value", " value=\"", 1255, "\"", 1285, 1);
#nullable restore
#line 24 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
WriteAttributeValue("", 1263, product.DiscountPrice, 1263, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1286, "\"", 1297, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <label for=\"title\">Hãng</label>\r\n                    <select class=\"form-control\" name=\"brand\"");
                BeginWriteAttribute("id", " id=\"", 1415, "\"", 1420, 0);
                EndWriteAttribute();
                BeginWriteAttribute("required", " required=\"", 1421, "\"", 1432, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 27 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
                         foreach (var brand in brands)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
                             if(product.Brand == brand.Id) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa1e7779b6f46b862a0a1aed517e386e0237d6289893", async() => {
#nullable restore
#line 30 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
                                                                          Write(brand.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
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
#line 31 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
                            }
                            else {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa1e7779b6f46b862a0a1aed517e386e0237d62812127", async() => {
#nullable restore
#line 33 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
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
#line 33 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
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
#line 34 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                    <label for=\"title\">Mô tả ngắn</label>\r\n                    <textarea class=\"form-control\" name=\"short_desc\" id=\"exampleFormControlTextarea1\" rows=\"3\"");
                BeginWriteAttribute("required", " required=\"", 2087, "\"", 2098, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 38 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
                                                                                                                      Write(product.ShortDesc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                    <label for=\"title\">Mô tả</label>\r\n                    <textarea class=\"form-control\" name=\"desc\" id=\"exampleFormControlTextarea1\" rows=\"3\"");
                BeginWriteAttribute("required", " required=\"", 2289, "\"", 2300, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 40 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
                                                                                                                Write(product.Desc);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                    <input type=\"submit\" class=\"btn btn-primary mt-2\" value=\"Sửa\">\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\xampp\htdocs\WebBanMayTinh\Views\Product\Edit.cshtml"
                                                                                     WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
