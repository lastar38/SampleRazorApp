#pragma checksum "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c7fc165ca3accc93867ec1bae73e7f8d41dec69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SampleRazorApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{num?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c7fc165ca3accc93867ec1bae73e7f8d41dec69", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f244660bd49706c5fa75e4c94b83bcee43ccbc8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

    string[] data = new[] { "on", "two", "three", "four", "five" };
    Func<dynamic, object> hello = 

#line default
#line hidden
#nullable disable
            item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
                PushWriter(__razor_template_writer);
                WriteLiteral("<p class=\"display-4\">Hello, ");
#nullable restore
#line 7 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Index.cshtml"
                                                          Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral(" !! </p>");
                PopWriter();
            }
            )
#nullable restore
#line 7 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Index.cshtml"
                                                                            ;

    Func<dynamic, object> showList = 

#line default
#line hidden
#nullable disable
            item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
                PushWriter(__razor_template_writer);
                WriteLiteral("<ul class=\"h4\">\r\n");
#nullable restore
#line 10 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Index.cshtml"
     foreach (var ob in item)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <li>");
#nullable restore
#line 12 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Index.cshtml"
       Write(ob);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\t\t \r\n");
#nullable restore
#line 13 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>");
                PopWriter();
            }
            )
#nullable restore
#line 14 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Index.cshtml"
         ;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <p class=\"h4\">");
#nullable restore
#line 18 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Index.cshtml"
             Write(hello("Hanako"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p class=\"h4\">");
#nullable restore
#line 19 "D:\work\SampleRazorApp\SampleRazorApp\SampleRazorApp\Pages\Index.cshtml"
             Write(showList(data));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
