#pragma checksum "C:\Users\kurtulusocL\Desktop\RoleBasedAuthentication\Views\Account\AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61aba0046a3913a72c2cad1b0174642d4599ec6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_AccessDenied), @"mvc.1.0.view", @"/Views/Account/AccessDenied.cshtml")]
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
#line 1 "C:\Users\kurtulusocL\Desktop\RoleBasedAuthentication\Views\_ViewImports.cshtml"
using RoleBasedAuthentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kurtulusocL\Desktop\RoleBasedAuthentication\Views\_ViewImports.cshtml"
using RoleBasedAuthentication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kurtulusocL\Desktop\RoleBasedAuthentication\Views\_ViewImports.cshtml"
using RoleBasedAuthentication.Core.CrossCuttingConcern.Dtos.AccountDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kurtulusocL\Desktop\RoleBasedAuthentication\Views\_ViewImports.cshtml"
using RoleBasedAuthentication.Core.CrossCuttingConcern.Dtos.MenageDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kurtulusocL\Desktop\RoleBasedAuthentication\Views\_ViewImports.cshtml"
using RoleBasedAuthentication.Core.Utilities.Identity.Microsoft;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61aba0046a3913a72c2cad1b0174642d4599ec6f", @"/Views/Account/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a75d1c2f6ec6e1bf789a159d3056e6561da9789a", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kurtulusocL\Desktop\RoleBasedAuthentication\Views\Account\AccessDenied.cshtml"
  
    ViewData["Title"] = "Access denied";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<header>\r\n    <h2 class=\"text-danger\">");
#nullable restore
#line 6 "C:\Users\kurtulusocL\Desktop\RoleBasedAuthentication\Views\Account\AccessDenied.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p class=\"text-danger\">You do not have access to this resource.</p>\r\n</header>\r\n");
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
