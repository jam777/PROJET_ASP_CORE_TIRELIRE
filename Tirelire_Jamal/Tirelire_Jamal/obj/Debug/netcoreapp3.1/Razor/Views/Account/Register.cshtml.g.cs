#pragma checksum "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60a26aa9dc109ca22fc8e941395e798ddc9da78d"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a26aa9dc109ca22fc8e941395e798ddc9da78d", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72d7c816e9aba37ca09835a49008e68de186ba53", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tirelire_Jamal.ViewModels.RegisterViewModel>
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"<div class=""row justify-content-center"">

    <div class=""col-md-6"">
        <div class=""card"">
            <header class=""card-header"">
                <h4 class=""card-title mt-2 text-center"">Inscription</h4>
            </header>

            <article class=""card-body register"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60a26aa9dc109ca22fc8e941395e798ddc9da78d4018", async() => {
                WriteLiteral("\r\n\r\n");
                WriteLiteral("\r\n                    <div class=\"col form-group px-0\">\r\n                        <label>UserName</label>\r\n                        <input type=\"text\" name=\"UserName\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 808, "\"", 822, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=", 823, "", 888, 1);
#nullable restore
#line 28 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
WriteAttributeValue("", 830, (Model!=null)? validChp("UserName",Model.UserName) : "", 830, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
#nullable restore
#line 29 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.UserName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div> <!-- form-group end.// -->\r\n");
                WriteLiteral("                    <div class=\"col form-group px-0\">\r\n                        <label>Mot de Passe</label>\r\n                        <input type=\"text\" name=\"Password\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1272, "\"", 1286, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=", 1287, "", 1352, 1);
#nullable restore
#line 34 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
WriteAttributeValue("", 1294, (Model!=null)? validChp("Password",Model.Password) : "", 1294, 58, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
#nullable restore
#line 35 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                         foreach (var item in ViewContext.ViewData.ModelState)
                        {
                            if (item.Key == "ErrorPassword")
                            {
                                foreach (var error in item.Value.Errors)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div class=\"text-danger\">");
#nullable restore
#line 42 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                                                        Write(error.ErrorMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 43 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                                }
                            }
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div> <!-- form-row end.// -->\r\n\r\n                    <div class=\"form-row\">\r\n");
                WriteLiteral("                        <div class=\"col form-group\">\r\n                            <label>Prenom</label>\r\n                            <input type=\"text\" name=\"Prenom\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 2275, "\"", 2289, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=", 2290, "", 2351, 1);
#nullable restore
#line 54 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
WriteAttributeValue("", 2297, (Model!=null)? validChp("Prenom",Model.Prenom) : "", 2297, 54, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 55 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Prenom, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div> <!-- form-group end.// -->\r\n");
                WriteLiteral("                        <div class=\"col form-group\">\r\n                            <label>Nom</label>\r\n\r\n                            <input type=\"text\" name=\"Nom\" class=\"form-control\" placeholder=\" \"");
                BeginWriteAttribute("value", " value=", 2753, "", 2808, 1);
#nullable restore
#line 62 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
WriteAttributeValue("", 2760, (Model!=null)? validChp("Nom",Model.Nom) : "", 2760, 48, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 63 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Nom, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div> <!-- form-group end.// -->\r\n                    </div> <!-- form-row end.// -->\r\n\r\n                    <div class=\"form-group\">\r\n");
                WriteLiteral("                        <label>Adresse Email</label>\r\n                        <input type=\"text\" name=\"Email\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 3242, "\"", 3256, 0);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=", 3257, "", 3316, 1);
#nullable restore
#line 71 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
WriteAttributeValue("", 3264, (Model!=null)? validChp("Email",Model.Email) : "", 3264, 52, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
#nullable restore
#line 72 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div> <!-- form-group end.// -->\r\n\r\n                    <div class=\"form-row\">\r\n");
                WriteLiteral("                        <div class=\"form-group col-md-6\">\r\n                            <label>Date de Naissance</label>\r\n                            <input type=\"date\" name=\"DateNaissance\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=", 3771, "", 3846, 1);
#nullable restore
#line 80 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
WriteAttributeValue("", 3778, (Model!=null)? validChp("DateNaissance",Model.DateNaissance) : "", 3778, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 81 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                       Write(Html.ValidationMessageFor(x => x.DateNaissance, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div> <!-- form-group end.// -->\r\n");
                WriteLiteral("                        <div class=\"form-group col-md-6\">\r\n                            <label>Genre</label>\r\n\r\n");
#nullable restore
#line 88 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                              
                                var h = (Model != null && Model.Genre == true) ? "selected" : "";
                                var f = (Model != null && Model.Genre == false) ? "selected" : "";
                                var r = (Model != null && Model.Genre);
                            

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <select id=\"inputState\" name=\"Genre\" class=\"form-control\">\r\n\r\n                                <");
                WriteLiteral("option value=\"true\" ");
#nullable restore
#line 95 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                                                 Write(h);

#line default
#line hidden
#nullable disable
                WriteLiteral(">Homme</");
                WriteLiteral("option>\r\n                                <");
                WriteLiteral("option value=\"false\" ");
#nullable restore
#line 96 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                                                  Write(f);

#line default
#line hidden
#nullable disable
                WriteLiteral(">Femme</");
                WriteLiteral("option>\r\n\r\n\r\n                            </select>\r\n                            ");
#nullable restore
#line 100 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                       Write(Html.ValidationMessageFor(x => x.Genre, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                        </div> <!-- form-group end.// -->\r\n\r\n                    </div> <!-- form-row.// -->\r\n");
                WriteLiteral("                    <div class=\"form-group\">\r\n                        <label>Téléphone</label>\r\n                        <input type=\"text\" id=\"phone\" name=\"Telephone\" placeholder=\"01-02-03-04-05\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=", 5256, "", 5324, 1);
#nullable restore
#line 108 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
WriteAttributeValue("", 5263, (Model!=null)? validChp("Telephone",Model.Telephone) : "" , 5263, 61, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
#nullable restore
#line 109 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.Telephone, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div> <!-- form-group end.// -->\r\n");
                WriteLiteral("                    <div class=\"col form-group px-0\">\r\n                        <label>Adresse de Livraison</label>\r\n                        <textarea name=\"AdresseLivraison\" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 5730, "\"", 5744, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 115 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                                                                                          Write((Model!=null)? validChp("AdresseLivraison", Model.AdresseLivraison) : "");

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                        ");
#nullable restore
#line 116 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.AdresseLivraison, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </div> <!-- form-group end.// -->\r\n");
                WriteLiteral("                    <div class=\"col form-group px-0\">\r\n                        <label>Adresse de Facturation</label>\r\n                        <textarea name=\"AdresseFacturation\" class=\"form-control\" placeholder=\" \">");
#nullable restore
#line 122 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                                                                                             Write((Model!=null)? validChp("AdresseFacturation", Model.AdresseFacturation) : "");

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                        ");
#nullable restore
#line 123 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
                   Write(Html.ValidationMessageFor(x => x.AdresseFacturation, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </article> <!-- card-body end .// -->\r\n            <div class=\"border-top card-body text-center\">Vous avez un compte ? <a");
            BeginWriteAttribute("href", " href=", 6891, "", 6927, 1);
#nullable restore
#line 133 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
WriteAttributeValue("", 6897, Url.Action("Login","Account"), 6897, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Se Connecter</a></div>\r\n        </div> <!-- card.// -->\r\n    </div> <!-- col.//-->\r\n\r\n</div> <!-- row.//-->\r\n");
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\jamel\Desktop\Tirelire_Jam_ASP\Tirelire_Jamal\Tirelire_Jamal\Views\Account\Register.cshtml"
            
    public string validChp(string chp, string value)
    {
        return (Model != null && ViewBag.validChp[chp] == "Valid") ? value : "";
    }

#line default
#line hidden
#nullable disable
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
