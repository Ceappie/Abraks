#pragma checksum "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bf116a5974738ae62552917d75e57110380e2ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Abraks.Web.Areas.Dancer.Views.Users.Areas_Dancer_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Dancer/Views/Users/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Dancer/Views/Users/Index.cshtml", typeof(Abraks.Web.Areas.Dancer.Views.Users.Areas_Dancer_Views_Users_Index))]
namespace Abraks.Web.Areas.Dancer.Views.Users
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\_ViewImports.cshtml"
using Abraks.Web.Areas.Identity;

#line default
#line hidden
#line 3 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\_ViewImports.cshtml"
using Abraks.Models;

#line default
#line hidden
#line 4 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\_ViewImports.cshtml"
using Abraks.Common.Admin.ViewModels.Events;

#line default
#line hidden
#line 5 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\_ViewImports.cshtml"
using Abraks.Common.Admin.BindingModels.Events;

#line default
#line hidden
#line 6 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\_ViewImports.cshtml"
using Abraks.Common.Admin.ViewModels.Users;

#line default
#line hidden
#line 7 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\_ViewImports.cshtml"
using Common.Admin.BindingModels.Rewards;

#line default
#line hidden
#line 8 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\_ViewImports.cshtml"
using Common.Admin.ViewModels.Rewards;

#line default
#line hidden
#line 9 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\_ViewImports.cshtml"
using Common.Admin.BindingModels.Comments;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bf116a5974738ae62552917d75e57110380e2ea", @"/Areas/Dancer/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5167f19872b579177361df6b70318605323289e6", @"/Areas/Dancer/Views/_ViewImports.cshtml")]
    public class Areas_Dancer_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UsersViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "All Users";

#line default
#line hidden
            BeginContext(81, 186, true);
            WriteLiteral("\r\n<h2>All Users</h2>\r\n<br/>\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n    <tr>\r\n        <th>Username</th>\r\n        <th>Full Name</th>\r\n    </tr>\r\n    </thead>\r\n    <tbody>\r\n    ");
            EndContext();
            BeginContext(268, 22, false);
#line 16 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\Users\Index.cshtml"
Write(Html.DisplayForModel());

#line default
#line hidden
            EndContext();
            BeginContext(290, 24, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UsersViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
