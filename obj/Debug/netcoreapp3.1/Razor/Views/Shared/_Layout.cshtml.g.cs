#pragma checksum "D:\Проекты c#\Helga_portfolio\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe8d19f3340724edd039082b1e937b0cc09aa617"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 4 "D:\Проекты c#\Helga_portfolio\Views\_ViewImports.cshtml"
using Helga_portfolio.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe8d19f3340724edd039082b1e937b0cc09aa617", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a087df66349e43eb54c0addb13ae5e035bde9ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("is-preload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE HTML>\r\n<!--\r\n    Massively by HTML5 UP\r\n    html5up.net | \r\n    Free for personal and commercial use under the CCA 3.0 license (html5up.net/license)\r\n-->\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe8d19f3340724edd039082b1e937b0cc09aa6173540", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 9 "D:\Проекты c#\Helga_portfolio\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("MetatagsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 10 "D:\Проекты c#\Helga_portfolio\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("CssPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe8d19f3340724edd039082b1e937b0cc09aa6174968", async() => {
                WriteLiteral("\r\n    <!-- Wrapper -->\r\n    <div id=\"wrapper\" class=\"fade-in\">\r\n        ");
#nullable restore
#line 15 "D:\Проекты c#\Helga_portfolio\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("IntroPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 16 "D:\Проекты c#\Helga_portfolio\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("HeaderPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
#nullable restore
#line 17 "D:\Проекты c#\Helga_portfolio\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("NavPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- Main -->\r\n        <div id=\"main\">\r\n            ");
#nullable restore
#line 20 "D:\Проекты c#\Helga_portfolio\Views\Shared\_Layout.cshtml"
       Write(await Html.PartialAsync("PostsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 21 "D:\Проекты c#\Helga_portfolio\Views\Shared\_Layout.cshtml"
       Write(await Html.PartialAsync("FeaturedPostPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 22 "D:\Проекты c#\Helga_portfolio\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(" <!--Posts and featured post-->\r\n        </div>\r\n        ");
#nullable restore
#line 24 "D:\Проекты c#\Helga_portfolio\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("FooterPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n    ");
#nullable restore
#line 26 "D:\Проекты c#\Helga_portfolio\Views\Shared\_Layout.cshtml"
Write(await Html.PartialAsync("ScriptsPartial"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
