#pragma checksum "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a3804c7e8663152f0fbb68bfe824c42fecc4551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SampleRazorApp.Pages.Pages_Other), @"mvc.1.0.razor-page", @"/Pages/Other.cshtml")]
namespace SampleRazorApp.Pages
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
#line 1 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\_ViewImports.cshtml"
using SampleRazorApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a3804c7e8663152f0fbb68bfe824c42fecc4551", @"/Pages/Other.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f244660bd49706c5fa75e4c94b83bcee43ccbc8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Other : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
  
    ViewData["Title"] = "Other";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h1 class=\"display-4 mb-4\">Ohter page</h1>\r\n    <p class=\"h4\">");
#nullable restore
#line 9 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
             Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 10 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            <label class=\"col-form-label h5\">\r\n                ");
#nullable restore
#line 14 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
           Write(Html.CheckBox("check", true, new { @class = "form-check-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 15 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
           Write(Html.DisplayName("Checkbox1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"col-form-label h5\">\r\n                ");
#nullable restore
#line 20 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
           Write(Html.RadioButton("gender", Gender.male, true, new { @class = "form-check-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
           Write(Html.DisplayName("male"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"col-form-label h5\">\r\n                ");
#nullable restore
#line 26 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
           Write(Html.RadioButton("gender", Gender.female, false, new { @class = "form-check-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
           Write(Html.DisplayName("female"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"form-check h5\">\r\n                ");
#nullable restore
#line 32 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
           Write(Html.DisplayName("PC"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 33 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
           Write(Html.DropDownList("pc", new SelectList(Enum.GetValues(typeof(Platform))), new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label class=\"form-label h5\">\r\n                ");
#nullable restore
#line 38 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
           Write(Html.DisplayName("PC2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 39 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
           Write(Html.ListBox("pc2", new MultiSelectList(Enum.GetValues(typeof(Platform))), new { @class = "form-control", size = 5 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n        </div>\r\n        <div><input type=\"submit\" /></div>\r\n");
#nullable restore
#line 43 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Other.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SampleRazorApp.Pages.OtherModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SampleRazorApp.Pages.OtherModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SampleRazorApp.Pages.OtherModel>)PageContext?.ViewData;
        public SampleRazorApp.Pages.OtherModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
