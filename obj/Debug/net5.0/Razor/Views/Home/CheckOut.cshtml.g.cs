#pragma checksum "C:\xampp\htdocs\WebBanMayTinh\Views\Home\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0705e6f25a907a7fd3a07858f85f7e39ad4edd78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CheckOut), @"mvc.1.0.view", @"/Views/Home/CheckOut.cshtml")]
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
#line 1 "C:\xampp\htdocs\WebBanMayTinh\Views\Home\CheckOut.cshtml"
using WebBanMayTinh.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0705e6f25a907a7fd3a07858f85f7e39ad4edd78", @"/Views/Home/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09aa3663d2d885a707d42c8f7f6070edeac7a00d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("login-form-wrap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("login collapse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("coupon-collapse-wrap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout_coupon collapse"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "HN", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "TPHCM", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "CM", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OtherStore", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\xampp\htdocs\WebBanMayTinh\Views\Home\CheckOut.cshtml"
  
    var product = ViewData["product"] as List<Cart>;
    int amountSum = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""product-big-title-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""product-bit-title text-center"">
                    <h2>Shopping Cart</h2>
                </div>
            </div>
        </div>
    </div>
</div>


<div class=""single-product-area"">
    <div class=""zigzag-bottom""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""single-sidebar"">
                    <h2 class=""sidebar-title"">Search Products</h2>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0705e6f25a907a7fd3a07858f85f7e39ad4edd789054", async() => {
                WriteLiteral("\r\n                        <input type=\"text\" placeholder=\"Search products...\">\r\n                        <input type=\"submit\" value=\"Search\">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n\r\n\r\n            </div>\r\n\r\n            <div class=\"col-md-8\">\r\n                <div class=\"product-content-right\">\r\n                    <div class=\"woocommerce\">\r\n");
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0705e6f25a907a7fd3a07858f85f7e39ad4edd7810807", async() => {
                WriteLiteral(@"


                            <p>If you have shopped with us before, please enter your details in the boxes below. If you
                                are a new customer please proceed to the Billing &amp; Shipping section.</p>

                            <p class=""form-row form-row-first"">
                                <label for=""username"">Username or email <span class=""required"">*</span>
                                </label>
                                <input type=""text"" id=""username"" name=""username"" class=""input-text"">
                            </p>
                            <p class=""form-row form-row-last"">
                                <label for=""password"">Password <span class=""required"">*</span>
                                </label>
                                <input type=""password"" id=""password"" name=""password"" class=""input-text"">
                            </p>
                            <div class=""clear""></div>


                            <p class");
                WriteLiteral(@"=""form-row"">
                                <input type=""submit"" value=""Login"" name=""login"" class=""button"">
                                <label class=""inline"" for=""rememberme""><input type=""checkbox"" value=""forever""
                                        id=""rememberme"" name=""rememberme""> Remember me </label>
                            </p>
                            <p class=""lost_password"">
                                <a href=""#"">Lost your password?</a>
                            </p>

                            <div class=""clear""></div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0705e6f25a907a7fd3a07858f85f7e39ad4edd7814175", async() => {
                WriteLiteral("\r\n\r\n                            <p class=\"form-row form-row-first\">\r\n                                <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 3714, "\"", 3722, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""coupon_code"" placeholder=""Coupon code""
                                    class=""input-text"" name=""coupon_code"">
                            </p>

                            <p class=""form-row form-row-last"">
                                <input type=""submit"" value=""Apply Coupon"" name=""apply_coupon"" class=""button"">
                            </p>

                            <div class=""clear""></div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0705e6f25a907a7fd3a07858f85f7e39ad4edd7816548", async() => {
                WriteLiteral(@"

                            <div id=""customer_details"" class=""col2-set"">
                                <div class=""col-1"">
                                    <div class=""woocommerce-billing-fields"">
                                        <h3>Billing Details</h3>
");
                WriteLiteral("\r\n                                        <p id=\"billing_first_name_field\"\r\n                                            class=\"form-row form-row-first validate-required\">\r\n                                            <label");
                BeginWriteAttribute("class", " class=\"", 5956, "\"", 5964, 0);
                EndWriteAttribute();
                WriteLiteral(" for=\"billing_first_name\">Name<abbr title=\"required\"\r\n                                                    class=\"required\">*</abbr>\r\n                                            </label>\r\n                                            <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 6214, "\"", 6222, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 6223, "\"", 6237, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"billing_first_name\"\r\n                                                name=\"nameOther\" class=\"input-text \"");
                BeginWriteAttribute("required", "  required=\"", 6348, "\"", 6360, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </p>

                                        <div class=""clear""></div>

                                        <p id=""billing_address_1_field""
                                            class=""form-row form-row-wide address-field validate-required"">
                                            <label");
                BeginWriteAttribute("class", " class=\"", 6713, "\"", 6721, 0);
                EndWriteAttribute();
                WriteLiteral(" for=\"billing_address_1\">Address <abbr title=\"required\"\r\n                                                    class=\"required\">*</abbr>\r\n                                            </label>\r\n                                            <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 6974, "\"", 6982, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Street address\"\r\n                                                id=\"billing_address_1\" name=\"addressOther\" class=\"input-text \"");
                BeginWriteAttribute("required", "  required=\"", 7124, "\"", 7136, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </p>

                                                                                <p id=""billing_address_1_field""
                                            class=""form-row form-row-wide address-field validate-required"">
                                            <label");
                BeginWriteAttribute("class", " class=\"", 7460, "\"", 7468, 0);
                EndWriteAttribute();
                WriteLiteral(" for=\"billing_address_1\">Note <abbr title=\"required\"\r\n                                                    class=\"required\">*</abbr>\r\n                                            </label>\r\n");
                WriteLiteral("                                            <textarea name=\"noteOther\"");
                BeginWriteAttribute("id", " id=\"", 7952, "\"", 7957, 0);
                EndWriteAttribute();
                WriteLiteral(" cols=\"30\" rows=\"10\" class=\"input-text\"");
                BeginWriteAttribute("required", "  required=\"", 7997, "\"", 8009, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                                        </p>\r\n\r\n");
                WriteLiteral("                                        <div class=\"clear\"></div>\r\n\r\n\r\n");
                WriteLiteral(@"
                                    </div>
                                </div>

                                <div class=""col-2"">
                                    <br>
                                    <br>
                                        <p id=""billing_country_field""
                                            class=""form-row form-row-wide address-field update_totals_on_change validate-required woocommerce-validated"">
                                            <label");
                BeginWriteAttribute("class", " class=\"", 11929, "\"", 11937, 0);
                EndWriteAttribute();
                WriteLiteral(@" for=""billing_country"">City <abbr title=""required""
                                                    class=""required"">*</abbr>
                                            </label>
                                            <select class=""country_to_state country_select"" id=""billing_country""
                                                name=""cityOther"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0705e6f25a907a7fd3a07858f85f7e39ad4edd7822030", async() => {
                    WriteLiteral("Select a country…");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0705e6f25a907a7fd3a07858f85f7e39ad4edd7823313", async() => {
                    WriteLiteral("Hà Nội");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0705e6f25a907a7fd3a07858f85f7e39ad4edd7824585", async() => {
                    WriteLiteral("Thành phố Hồ Chí Minh");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0705e6f25a907a7fd3a07858f85f7e39ad4edd7825872", async() => {
                    WriteLiteral("Cà Mau");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </select>
                                        </p>

                                        <div class=""clear""></div>

                                        <p id=""billing_email_field""
                                            class=""form-row form-row-first validate-required validate-email"">
                                            <label");
                BeginWriteAttribute("class", " class=\"", 13069, "\"", 13077, 0);
                EndWriteAttribute();
                WriteLiteral(" for=\"billing_email\">Email Address <abbr title=\"required\"\r\n                                                    class=\"required\">*</abbr>\r\n                                            </label>\r\n                                            <input type=\"email\"");
                BeginWriteAttribute("value", " value=\"", 13333, "\"", 13341, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 13342, "\"", 13356, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"billing_email\"\r\n                                                name=\"emailOther\" class=\"input-text \"");
                BeginWriteAttribute("required", "  required=\"", 13463, "\"", 13475, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </p>

                                        <p id=""billing_phone_field""
                                            class=""form-row form-row-last validate-required validate-phone"">
                                            <label");
                BeginWriteAttribute("class", " class=\"", 13756, "\"", 13764, 0);
                EndWriteAttribute();
                WriteLiteral(" for=\"billing_phone\">Phone <abbr title=\"required\"\r\n                                                    class=\"required\">*</abbr>\r\n                                            </label>\r\n                                            <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 14011, "\"", 14019, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 14020, "\"", 14034, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"billing_phone\"\r\n                                                name=\"phoneOther\" class=\"input-text \"");
                BeginWriteAttribute("required", "  required=\"", 14141, "\"", 14153, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </p>
                                                                                <p id=""billing_phone_field""
                                            class=""form-row form-row-last validate-required validate-phone"">
                                            <label");
                BeginWriteAttribute("class", " class=\"", 14472, "\"", 14480, 0);
                EndWriteAttribute();
                WriteLiteral(" for=\"billing_phone\">Distrist <abbr title=\"required\"\r\n                                                    class=\"required\">*</abbr>\r\n                                            </label>\r\n                                            <input type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 14730, "\"", 14738, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 14739, "\"", 14753, 0);
                EndWriteAttribute();
                WriteLiteral(" id=\"billing_phone\"\r\n                                                name=\"distristOther\" class=\"input-text \"");
                BeginWriteAttribute("required", "  required=\"", 14863, "\"", 14875, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </p>
                                </div>

                            </div>

                            <h3 id=""order_review_heading"">Your order</h3>

                            <div id=""order_review"" style=""position: relative;"">
                                <table class=""shop_table"">
                                    <thead>
                                        <tr>
                                            <th class=""product-name"">Product</th>
                                            <th class=""product-total"">Total</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 250 "C:\xampp\htdocs\WebBanMayTinh\Views\Home\CheckOut.cshtml"
                                         foreach (var item in product)
                                        {
                                            var value = new sanphamContext().Products.Find(item.IdProduct);
                                            var amount = value.Price * item.Amount;
                                            amountSum += amount;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr class=\"cart_item\">\r\n                                                <td class=\"product-name\">\r\n                                                    ");
#nullable restore
#line 257 "C:\xampp\htdocs\WebBanMayTinh\Views\Home\CheckOut.cshtml"
                                               Write(value.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <strong class=\"product-quantity\">× ");
#nullable restore
#line 257 "C:\xampp\htdocs\WebBanMayTinh\Views\Home\CheckOut.cshtml"
                                                                                              Write(item.Amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong> </td>\r\n                                                <td class=\"product-total\">\r\n                                                    <span class=\"amount\">");
#nullable restore
#line 259 "C:\xampp\htdocs\WebBanMayTinh\Views\Home\CheckOut.cshtml"
                                                                    Write(amount);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 262 "C:\xampp\htdocs\WebBanMayTinh\Views\Home\CheckOut.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </tbody>
                                    <tfoot>

                                        <tr class=""cart-subtotal"">
                                            <th>Cart Subtotal</th>
                                            <td><span class=""amount"">");
#nullable restore
#line 268 "C:\xampp\htdocs\WebBanMayTinh\Views\Home\CheckOut.cshtml"
                                                                Write(amountSum);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                            </td>
                                        </tr>

                                        <tr class=""shipping"">
                                            <th>Shipping and Handling</th>
                                            <td>

                                                Free Shipping
                                                <input type=""hidden"" class=""shipping_method"" value=""free_shipping""
                                                    id=""shipping_method_0"" data-index=""0"" name=""shipping_method[0]"">
                                            </td>
                                        </tr>


                                        <tr class=""order-total"">
                                            <th>Order Total</th>
                                            <td><strong><span class=""amount"">");
#nullable restore
#line 285 "C:\xampp\htdocs\WebBanMayTinh\Views\Home\CheckOut.cshtml"
                                                                        Write(amountSum);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></strong> </td>\r\n                                        </tr>\r\n\r\n                                    </tfoot>\r\n                                </table>\r\n\r\n\r\n                                <div id=\"payment\">\r\n");
                WriteLiteral(@"
                                    <div class=""form-row place-order"">

                                        <input type=""submit"" data-value=""Place order"" value=""Mua hàng""
                                            id=""place_order"" name=""woocommerce_checkout_place_order"" class=""button alt"">


                                    </div>

                                    <div class=""clear""></div>

                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<script>\r\n    $(\'.active\').removeClass(\'active\');\r\n    $(\'.check_out\').addClass(\'active\');\r\n</script>\r\n");
            DefineSection("parse", async() => {
                WriteLiteral(@"
    <script>
        let x = document.querySelectorAll("".amount"");
        for (let i = 0, len = x.length; i < len; i++) {
            let num = Number(x[i].innerHTML)
                      .toLocaleString('en');
            x[i].innerHTML = num +' VND';
        }
");
                WriteLiteral("    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
