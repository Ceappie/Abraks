#pragma checksum "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\Shared\DisplayTemplates\EventDetailsViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d09c1adad94f97a0fbfb722f1d40436515fad40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Abraks.Web.Areas.Admin.Views.Shared.DisplayTemplates.Areas_Admin_Views_Shared_DisplayTemplates_EventDetailsViewModel), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/DisplayTemplates/EventDetailsViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/DisplayTemplates/EventDetailsViewModel.cshtml", typeof(Abraks.Web.Areas.Admin.Views.Shared.DisplayTemplates.Areas_Admin_Views_Shared_DisplayTemplates_EventDetailsViewModel))]
namespace Abraks.Web.Areas.Admin.Views.Shared.DisplayTemplates
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Abraks.Web.Areas.Identity;

#line default
#line hidden
#line 3 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Abraks.Models;

#line default
#line hidden
#line 4 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Abraks.Common.Admin.ViewModels.Events;

#line default
#line hidden
#line 5 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Abraks.Common.Admin.BindingModels.Events;

#line default
#line hidden
#line 6 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Abraks.Common.Admin.ViewModels.Users;

#line default
#line hidden
#line 7 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Common.Admin.BindingModels.Rewards;

#line default
#line hidden
#line 8 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\_ViewImports.cshtml"
using Common.Admin.ViewModels.Rewards;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d09c1adad94f97a0fbfb722f1d40436515fad40", @"/Areas/Admin/Views/Shared/DisplayTemplates/EventDetailsViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea90e5ba6b7e2333ae611a16f811a64deee56f4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_DisplayTemplates_EventDetailsViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\Shared\DisplayTemplates\EventDetailsViewModel.cshtml"
  
    ViewData["Title"] = "Event Details";

#line default
#line hidden
            BeginContext(79, 64, true);
            WriteLiteral("\r\n<div class=\"container-fluid\">\r\n    <div class=\"row content\">\r\n");
            EndContext();
            BeginContext(276, 53, true);
            WriteLiteral("\r\n        <div class=\"col-sm-9\">\r\n            <p><h1>");
            EndContext();
            BeginContext(330, 10, false);
#line 13 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\Shared\DisplayTemplates\EventDetailsViewModel.cshtml"
              Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(340, 42, true);
            WriteLiteral("</h1></p>\r\n            <p><h4>Take Place: ");
            EndContext();
            BeginContext(383, 11, false);
#line 14 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\Shared\DisplayTemplates\EventDetailsViewModel.cshtml"
                          Write(Model.Place);

#line default
#line hidden
            EndContext();
            BeginContext(394, 30, true);
            WriteLiteral("</h4></p>\r\n            <p><h4>");
            EndContext();
            BeginContext(425, 13, false);
#line 15 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\Shared\DisplayTemplates\EventDetailsViewModel.cshtml"
              Write(Model.Address);

#line default
#line hidden
            EndContext();
            BeginContext(438, 49, true);
            WriteLiteral("</h4></p>\r\n            <p><strong>From:</strong> ");
            EndContext();
            BeginContext(488, 15, false);
#line 16 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\Shared\DisplayTemplates\EventDetailsViewModel.cshtml"
                                 Write(Model.StartDate);

#line default
#line hidden
            EndContext();
            BeginContext(503, 42, true);
            WriteLiteral("</p>\r\n            <p><strong>TO:</strong> ");
            EndContext();
            BeginContext(546, 13, false);
#line 17 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\Shared\DisplayTemplates\EventDetailsViewModel.cshtml"
                               Write(Model.EndDate);

#line default
#line hidden
            EndContext();
            BeginContext(559, 44, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591