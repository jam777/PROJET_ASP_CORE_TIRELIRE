<<<<<<< HEAD
#pragma checksum "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f102dfa754546b1f0623aa699acaf8893e364c"
=======
#pragma checksum "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83f3303e62f25aec4b547402c39d0d9ee6f69b3e"
>>>>>>> master
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Login), @"mvc.1.0.view", @"/Views/Account/Login.cshtml")]
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
#line 1 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\_ViewImports.cshtml"
using Tirelire_Jamal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\_ViewImports.cshtml"
using Tirelire_Jamal.Models;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8f102dfa754546b1f0623aa699acaf8893e364c", @"/Views/Account/Login.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83f3303e62f25aec4b547402c39d0d9ee6f69b3e", @"/Views/Account/Login.cshtml")]
>>>>>>> master
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d7c816e9aba37ca09835a49008e68de186ba53", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tirelire_Jamal.ViewModels.LoginViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<<<<<<< HEAD
<style>
    .login {
        height: 100vh !important;
    }
</style>

<div class=""login row m-0 align-items-center justify-content-center"">
    <div class=""col-md-6 "">
=======
<div class=""row justify-content-center"">
    <div class=""col-md-6"">
>>>>>>> master
        <div class=""card"">
            <header class=""card-header mb-2"">
                <h4 class=""card-title mt-2 text-center"">Se Connecter</h4>
            </header>
            <article class=""card-body pt-0"">

");
#nullable restore
<<<<<<< HEAD
#line 17 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml"
=======
#line 11 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml"
>>>>>>> master
                 foreach (var item in ViewContext.ViewData.ModelState)
                {
                    if (item.Key == "login")
                    {
                        var error = item.Value.Errors.FirstOrDefault().ErrorMessage.ToString();

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p class=\"text-danger text-center font-weight-bold mt-3\"> ");
#nullable restore
<<<<<<< HEAD
#line 22 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml"
=======
#line 16 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml"
>>>>>>> master
                                                                             Write(error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
<<<<<<< HEAD
#line 23 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml"
=======
#line 17 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml"
>>>>>>> master
                        break;
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8f102dfa754546b1f0623aa699acaf8893e364c5181", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                    <div class=\"form-group mb-0\">\r\n                        <label class=\"font-weight-bold\">Adresse Email</label>\r\n                        <input type=\"text\" name=\"Email\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1151, "\"", 1165, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div> <!-- form-group end.// -->\r\n                    ");
#nullable restore
#line 33 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml"
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83f3303e62f25aec4b547402c39d0d9ee6f69b3e5074", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                    <div class=\"form-group mb-0\">\r\n                        <label class=\"font-weight-bold\">Adresse Email</label>\r\n                        <input type=\"text\" name=\"Email\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1044, "\"", 1058, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div> <!-- form-group end.// -->\r\n                    ");
#nullable restore
#line 27 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml"
>>>>>>> master
               Write(Html.ValidationMessageFor(x => x.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
                WriteLiteral(@"                    <div class=""form-group mb-0 mt-2"">
                        <label class=""font-weight-bold mt-4"">Password</label>
                        <input class=""form-control"" name=""Password"" type=""password"">
                    </div> <!-- form-group end.// -->
                    ");
#nullable restore
<<<<<<< HEAD
#line 40 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml"
=======
#line 34 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml"
>>>>>>> master
               Write(Html.ValidationMessageFor(x => x.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
                WriteLiteral("                    <div class=\"form-group mt-4\">\r\n                        <button type=\"submit\" class=\"btn btn-primary btn-block\">Se Connecter</button>\r\n                    </div> <!-- form-group// -->\r\n\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </article> <!-- card-body end .// -->\r\n            <div class=\"border-top card-body text-center\">Pas de Compte ?<a");
<<<<<<< HEAD
            BeginWriteAttribute("href", " href=", 2128, "", 2167, 1);
#nullable restore
#line 50 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml"
WriteAttributeValue("", 2134, Url.Action("Register","Account"), 2134, 33, false);
=======
            BeginWriteAttribute("href", " href=", 2021, "", 2060, 1);
#nullable restore
#line 44 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Login.cshtml"
WriteAttributeValue("", 2027, Url.Action("Register","Account"), 2027, 33, false);
>>>>>>> master

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Inscrivez-vous</a></div>\r\n        </div> <!-- card.// -->\r\n    </div> <!-- col.//-->\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tirelire_Jamal.ViewModels.LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
