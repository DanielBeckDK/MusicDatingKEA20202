#pragma checksum "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26f0aa3c54fd5d08887a948312522c7b769cd88c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ApplicationUser_index), @"mvc.1.0.view", @"/Views/ApplicationUser/index.cshtml")]
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
#line 1 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\_ViewImports.cshtml"
using MusicDating;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\_ViewImports.cshtml"
using MusicDating.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
using MusicDating.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f0aa3c54fd5d08887a948312522c7b769cd88c", @"/Views/ApplicationUser/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3d2075c5ee8eacf2d275f3b315994fddd217e0", @"/Views/_ViewImports.cshtml")]
    public class Views_ApplicationUser_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserInstrumentVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onchange", new global::Microsoft.AspNetCore.Html.HtmlString("this.form.submit()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-title\">Find musiker</div>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
 using (Html.BeginForm("Index", "ApplicationUser", FormMethod.Post))
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f0aa3c54fd5d08887a948312522c7b769cd88c5210", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f0aa3c54fd5d08887a948312522c7b769cd88c5478", async() => {
                    WriteLiteral("Select instrument");
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 13 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.InstrumentName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 13 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Instruments;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div class=\"form-group\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f0aa3c54fd5d08887a948312522c7b769cd88c8683", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f0aa3c54fd5d08887a948312522c7b769cd88c8951", async() => {
                    WriteLiteral("Select genre");
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
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 18 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.GenreName);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 18 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Genres;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 22 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container pre-scrollable\"> \r\n    <div class=\"row\">\r\n");
#nullable restore
#line 27 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
         foreach (var item in Model.User) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card col col-12 col-md-6\">\r\n            <div class=\"card-body\">\r\n                <div class=\"d-flex justify-content-between\">\r\n                    <h5 class=\"card-title\">\r\n                        ");
#nullable restore
#line 32 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
                   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 32 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
                                   Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h5>\r\n                    <a href=\"#\" class=\"btn btn-secondary\">Vis profil</a>\r\n                </div>\r\n                <div class=\"card-text\">\r\n");
#nullable restore
#line 37 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
                     foreach (var userInstrument in item.UserInstruments){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"d-flex justify-content-between\">\r\n                        <h5");
            BeginWriteAttribute("class", " class=\"", 1359, "\"", 1367, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
                                Write(userInstrument.Instrument.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <div");
            BeginWriteAttribute("class", " class=\"", 1435, "\"", 1443, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div>\r\n                                <h6>Erfaring <span class=\"badge badge-primary\">");
#nullable restore
#line 42 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
                                                                          Write(userInstrument.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h6>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div>\r\n");
#nullable restore
#line 47 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
                         foreach (var genre in userInstrument.UserInstrumentGenres)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"badge badge-secondary\">");
#nullable restore
#line 49 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
                                                           Write(genre.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 50 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n");
#nullable restore
#line 52 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>           \r\n");
#nullable restore
#line 56 "C:\Users\Daniel\Desktop\Onedrive\Kea-Web-Dev\dotNet\Code\MusicDatingKEA20202\Views\ApplicationUser\index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>       \r\n</div>       \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserInstrumentVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
