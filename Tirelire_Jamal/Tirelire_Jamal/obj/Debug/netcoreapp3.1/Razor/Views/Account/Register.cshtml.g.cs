#pragma checksum "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b57d9b76b0cfa274576cec2dc332270b68a77cb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b57d9b76b0cfa274576cec2dc332270b68a77cb6", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d7c816e9aba37ca09835a49008e68de186ba53", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tirelire_Jamal.ViewModels.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "false", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""row justify-content-center"">   

    <div class=""col-md-6"">
        <div class=""card"">
            <header class=""card-header"">               
                <h4 class=""card-title mt-2 text-center"">Inscription</h4>
            </header>

            <article class=""card-body register"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b57d9b76b0cfa274576cec2dc332270b68a77cb64683", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("                    <div class=\"col form-group px-0\">\r\n                        <label>UserName</label>\r\n                        <input type=\"text\" name=\"UserName\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 618, "\"", 632, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div> <!-- form-group end.// -->\r\n");
                WriteLiteral("                    <div class=\"col form-group px-0\">\r\n                        <label>Mot de Passe</label>\r\n                        <input type=\"password\" name=\"Password\" class=\"form-control\" placeholder=\" \">\r\n                        ");
#nullable restore
#line 22 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                   Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div> <!-- form-row end.// -->\r\n\r\n                    <div class=\"form-row\">\r\n");
                WriteLiteral("                        <div class=\"col form-group\">\r\n                            <label>Prenom</label>\r\n                            <input type=\"text\" name=\"Prenom\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1341, "\"", 1355, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div> <!-- form-group end.// -->\r\n");
                WriteLiteral(@"                        <div class=""col form-group"">
                            <label>Nom</label>
                            <input type=""text"" name=""Nom"" class=""form-control"" placeholder="" "">
                        </div> <!-- form-group end.// -->
                    </div> <!-- form-row end.// -->

                    <div class=""form-group"">
");
                WriteLiteral("                        <label>Adresse Email</label>\r\n                        <input type=\"text\" name=\"Email\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1975, "\"", 1989, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div> <!-- form-group end.// -->                    \r\n\r\n                    <div class=\"form-row\">\r\n");
                WriteLiteral(@"                        <div class=""form-group col-md-6"">
                            <label>Date de Naissance</label>
                            <input type=""date"" name=""DateNaissance "" class=""form-control"">
                        </div> <!-- form-group end.// -->
");
                WriteLiteral("                        <div class=\"form-group col-md-6\">\r\n                            <label>Genre</label>\r\n                            <select id=\"inputState\" name=\"Genre\" class=\"form-control\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b57d9b76b0cfa274576cec2dc332270b68a77cb68039", async() => {
                    WriteLiteral("Homme");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b57d9b76b0cfa274576cec2dc332270b68a77cb69293", async() => {
                    WriteLiteral("Femme");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </select>\r\n                        </div> <!-- form-group end.// -->\r\n                    </div> <!-- form-row.// -->\r\n");
                WriteLiteral(@"                    <div class=""form-group"">
                        <label>Téléphone</label>
                        <input type=""tel"" id=""phone"" name=""Telephone"" class=""form-control""
                               pattern=""[0-9]{2}-[0-9]{2}-[0-9]{2}-[0-9]{2}-[0-9]{2}""
                               required>

                        <small>Format: 01-23-45-67-89</small>
                    </div> <!-- form-group end.// -->
");
                WriteLiteral("                    <div class=\"col form-group px-0\">\r\n                        <label>Adresse de Livraison</label>\r\n                        <textarea name=\"AdresseLivraison\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3654, "\"", 3668, 0);
                EndWriteAttribute();
                WriteLiteral("></textarea>\r\n                    </div> <!-- form-group end.// -->\r\n");
                WriteLiteral(@"                    <div class=""col form-group px-0"">
                        <label>Adresse de Facturation</label>
                        <textarea name=""AdresseFacturation"" class=""form-control"" placeholder="" ""></textarea>
                    </div> <!-- form-group end.// -->

                    <div class=""form-group"">
                        <button type=""submit"" class=""btn btn-primary btn-block""> Register  </button>
                    </div> <!-- form-group// -->

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </article> <!-- card-body end .// -->\r\n            <div class=\"border-top card-body text-center\">Vous avez un compte ? <a");
            BeginWriteAttribute("href", " href=", 4429, "", 4465, 1);
#nullable restore
#line 85 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
WriteAttributeValue("", 4435, Url.Action("Login","Account"), 4435, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Se Connecter</a></div>\r\n        </div> <!-- card.// -->\r\n    </div> <!-- col.//-->\r\n\r\n</div> <!-- row.//-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tirelire_Jamal.ViewModels.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
