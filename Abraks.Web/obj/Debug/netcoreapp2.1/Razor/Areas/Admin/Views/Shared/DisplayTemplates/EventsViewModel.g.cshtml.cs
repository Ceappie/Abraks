#pragma checksum "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\Shared\DisplayTemplates\EventsViewModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bf8c975543a4c39e3a4f9014546a07de3d1bf84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Abraks.Web.Areas.Admin.Views.Shared.DisplayTemplates.Areas_Admin_Views_Shared_DisplayTemplates_EventsViewModel), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/DisplayTemplates/EventsViewModel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/DisplayTemplates/EventsViewModel.cshtml", typeof(Abraks.Web.Areas.Admin.Views.Shared.DisplayTemplates.Areas_Admin_Views_Shared_DisplayTemplates_EventsViewModel))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bf8c975543a4c39e3a4f9014546a07de3d1bf84", @"/Areas/Admin/Views/Shared/DisplayTemplates/EventsViewModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea90e5ba6b7e2333ae611a16f811a64deee56f4", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_DisplayTemplates_EventsViewModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\Shared\DisplayTemplates\EventsViewModel.cshtml"
  
    ViewData["Title"] = "Events";

#line default
#line hidden
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(305, 10, true);
            WriteLiteral("<li>\r\n    ");
            EndContext();
            BeginContext(315, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39c815f6ab8b4b46aeb2e9a95f505c30", async() => {
                BeginContext(406, 10, false);
#line 18 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\Shared\DisplayTemplates\EventsViewModel.cshtml"
                                                                                         Write(Model.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 18 "E:\Projects\SoftUni\Abraks\Abraks\Abraks.Web\Areas\Admin\Views\Shared\DisplayTemplates\EventsViewModel.cshtml"
                                                                       WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(420, 9, true);
            WriteLiteral("\r\n</li>\r\n");
            EndContext();
            BeginContext(631, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
