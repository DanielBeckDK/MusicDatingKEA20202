#pragma checksum "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ea0ffc66471db70c4962a9ea634d2303ccd7a03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProfilePage_Index), @"mvc.1.0.view", @"/Views/ProfilePage/Index.cshtml")]
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
#line 1 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\_ViewImports.cshtml"
using MusicDating;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\_ViewImports.cshtml"
using MusicDating.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
using MusicDating.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ea0ffc66471db70c4962a9ea634d2303ccd7a03", @"/Views/ProfilePage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3d2075c5ee8eacf2d275f3b315994fddd217e0", @"/Views/_ViewImports.cshtml")]
    public class Views_ProfilePage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MusicDating.Models.Entities.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddInstrument", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateEnsemble", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditEnsemble", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
  
    ViewData["Title"] = "Profile Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea0ffc66471db70c4962a9ea634d2303ccd7a036157", async() => {
                WriteLiteral("View Data");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea0ffc66471db70c4962a9ea634d2303ccd7a037679", async() => {
                WriteLiteral("Add a new Instrument to Profile!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea0ffc66471db70c4962a9ea634d2303ccd7a038860", async() => {
                WriteLiteral("Create a new Ensemble!");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
  foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <div>\r\n     <p>");
#nullable restore
#line 15 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
   Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 16 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
      foreach (var Ensemble in item.OwnedEnsembles)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <p>");
#nullable restore
#line 18 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
       Write(Ensemble.EnsembleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n         <p>");
#nullable restore
#line 19 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
       Write(Ensemble.EnsembleDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ea0ffc66471db70c4962a9ea634d2303ccd7a0311390", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
                                        WriteLiteral(Ensemble.EnsembleId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
     }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
      foreach (var Instrument in item.UserInstruments)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <div>\r\n             <p> Instrument Name: ");
#nullable restore
#line 25 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
                             Write(Instrument.Instrument.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 25 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
                                                          Write(Instrument.Level);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n             <div id=\"genreBox\">\r\n                 <p>\r\n");
#nullable restore
#line 28 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
                 foreach (var G in Instrument.UserInstrumentGenres)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span>");
#nullable restore
#line 30 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
                         Write(G.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", </span>\r\n");
#nullable restore
#line 31 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </p>\r\n             </div>\r\n             \r\n         </div>\r\n");
#nullable restore
#line 36 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
         
     }

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n");
#nullable restore
#line 39 "C:\Users\Søren Rembøll\Desktop\WebDev\.NET\.Net.code\MusicDatingKEA20202\Views\ProfilePage\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MusicDating.Models.Entities.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
