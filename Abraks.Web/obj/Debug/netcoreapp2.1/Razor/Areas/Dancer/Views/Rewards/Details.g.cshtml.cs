#pragma checksum "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\Rewards\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "865557cad75b0ab03774e7db5be448b38c7f633e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Abraks.Web.Areas.Dancer.Views.Rewards.Areas_Dancer_Views_Rewards_Details), @"mvc.1.0.view", @"/Areas/Dancer/Views/Rewards/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Dancer/Views/Rewards/Details.cshtml", typeof(Abraks.Web.Areas.Dancer.Views.Rewards.Areas_Dancer_Views_Rewards_Details))]
namespace Abraks.Web.Areas.Dancer.Views.Rewards
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"865557cad75b0ab03774e7db5be448b38c7f633e", @"/Areas/Dancer/Views/Rewards/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5167f19872b579177361df6b70318605323289e6", @"/Areas/Dancer/Views/_ViewImports.cshtml")]
    public class Areas_Dancer_Views_Rewards_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Common.Admin.ViewModels.Rewards.RewardDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\Rewards\Details.cshtml"
  
    ViewData["Title"] = $"Details for {@Model.Name}";

#line default
#line hidden
            BeginContext(125, 18, true);
            WriteLiteral("\r\n<h2>Details for ");
            EndContext();
            BeginContext(144, 10, false);
#line 6 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\Rewards\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(154, 19, true);
            WriteLiteral("</h2>\r\n\r\n<ul>\r\n    ");
            EndContext();
            BeginContext(174, 22, false);
#line 9 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Dancer\Views\Rewards\Details.cshtml"
Write(Html.DisplayForModel());

#line default
#line hidden
            EndContext();
            BeginContext(196, 9, true);
            WriteLiteral("\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Common.Admin.ViewModels.Rewards.RewardDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591