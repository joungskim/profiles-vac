#pragma checksum "E:\net-projects\profiles-vac\profiles-vac\Views\Profiles\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc12919fa8ea9a52c774959096bebfd3835b8af5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profiles_Welcome), @"mvc.1.0.view", @"/Views/Profiles/Welcome.cshtml")]
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
#line 1 "E:\net-projects\profiles-vac\profiles-vac\Views\_ViewImports.cshtml"
using profiles_vac;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\net-projects\profiles-vac\profiles-vac\Views\_ViewImports.cshtml"
using profiles_vac.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc12919fa8ea9a52c774959096bebfd3835b8af5", @"/Views/Profiles/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a90888bdce3c46815b4422fe5ef0d02cb1e475f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Profiles_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\net-projects\profiles-vac\profiles-vac\Views\Profiles\Welcome.cshtml"
  
    ViewData["Title"] = "Profiles List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<title>");
#nullable restore
#line 5 "E:\net-projects\profiles-vac\profiles-vac\Views\Profiles\Welcome.cshtml"
  Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Profiles App</title>\r\n<h2>");
#nullable restore
#line 6 "E:\net-projects\profiles-vac\profiles-vac\Views\Profiles\Welcome.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<ul>\r\n");
#nullable restore
#line 9 "E:\net-projects\profiles-vac\profiles-vac\Views\Profiles\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 11 "E:\net-projects\profiles-vac\profiles-vac\Views\Profiles\Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 12 "E:\net-projects\profiles-vac\profiles-vac\Views\Profiles\Welcome.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
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