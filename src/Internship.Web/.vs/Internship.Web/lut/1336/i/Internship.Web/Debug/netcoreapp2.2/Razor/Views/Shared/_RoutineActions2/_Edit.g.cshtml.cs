#pragma checksum "I:\02\NewInternship\Internship.Web\Views\Shared\_RoutineActions2\_Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9137be49bcc572b48810313e784c50641fac99c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__RoutineActions2__Edit), @"mvc.1.0.view", @"/Views/Shared/_RoutineActions2/_Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_RoutineActions2/_Edit.cshtml", typeof(AspNetCore.Views_Shared__RoutineActions2__Edit))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Web.Areas.Identity;

#line default
#line hidden
#line 2 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.Common.IdentityToolkit;

#line default
#line hidden
#line 3 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.Common.PersianToolkit;

#line default
#line hidden
#line 4 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.Entity.Identity;

#line default
#line hidden
#line 5 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity;

#line default
#line hidden
#line 6 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity.Settings;

#line default
#line hidden
#line 7 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#line 8 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 9 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 10 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#line 11 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#line 12 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using DNTPersianUtils.Core;

#line default
#line hidden
#line 13 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Infrastructure.DataLayer.Context;

#line default
#line hidden
#line 14 "I:\02\NewInternship\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.Entity.AuditableEntity;

#line default
#line hidden
#line 1 "I:\02\NewInternship\Internship.Web\Views\Shared\_RoutineActions2\_Edit.cshtml"
using Internship.Core.DomainModels.SSOT;

#line default
#line hidden
#line 3 "I:\02\NewInternship\Internship.Web\Views\Shared\_RoutineActions2\_Edit.cshtml"
using Internship.Core.DomainModels.Entity.Routine2;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9137be49bcc572b48810313e784c50641fac99c4", @"/Views/Shared/_RoutineActions2/_Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51872ae7d6162f128a2b528f6a5dce7432e7ca3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__RoutineActions2__Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<int, int>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-role", new global::Microsoft.AspNetCore.Html.HtmlString("routine-ajax-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-role", new global::Microsoft.AspNetCore.Html.HtmlString("popover-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(119, 21, true);
            WriteLiteral("<button type=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 140, "\"", 184, 2);
            WriteAttributeValue("", 145, "routine_record_action_Edit_", 145, 27, true);
#line 4 "I:\02\NewInternship\Internship.Web\Views\Shared\_RoutineActions2\_Edit.cshtml"
WriteAttributeValue("", 172, Model.Item1, 172, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(185, 35, true);
            WriteLiteral(" data-popover=\"Routine_Action_Edit_");
            EndContext();
            BeginContext(221, 11, false);
#line 4 "I:\02\NewInternship\Internship.Web\Views\Shared\_RoutineActions2\_Edit.cshtml"
                                                                                                Write(Model.Item1);

#line default
#line hidden
            EndContext();
            BeginContext(232, 174, true);
            WriteLiteral("\" class=\"text-warning exir--transparent-btn\" style=\"display: none;\">\r\n    <i class=\"pe-7s-attention largeicon\" title=\"نیاز به اصلاح\" data-toggle=\"tooltip\"></i>\r\n</button>\r\n\r\n");
            EndContext();
            BeginContext(406, 524, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9137be49bcc572b48810313e784c50641fac99c47497", async() => {
                BeginContext(477, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(483, 439, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9137be49bcc572b48810313e784c50641fac99c47882", async() => {
                    BeginContext(519, 40, true);
                    WriteLiteral("\r\n        <input type=\"hidden\" name=\"Id\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 559, "\"", 579, 1);
#line 10 "I:\02\NewInternship\Internship.Web\Views\Shared\_RoutineActions2\_Edit.cshtml"
WriteAttributeValue("", 567, Model.Item1, 567, 12, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(580, 47, true);
                    WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"Action\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 627, "\"", 655, 1);
#line 11 "I:\02\NewInternship\Internship.Web\Views\Shared\_RoutineActions2\_Edit.cshtml"
WriteAttributeValue("", 635, RoutineActions.Edit, 635, 20, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(656, 52, true);
                    WriteLiteral(" />\r\n        <input type=\"hidden\" name=\"CurrentStep\"");
                    EndContext();
                    BeginWriteAttribute("value", " value=\"", 708, "\"", 728, 1);
#line 12 "I:\02\NewInternship\Internship.Web\Views\Shared\_RoutineActions2\_Edit.cshtml"
WriteAttributeValue("", 716, Model.Item2, 716, 12, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(729, 186, true);
                    WriteLiteral(" />\r\n\r\n        <input type=\"text\" class=\"form-control\" name=\"Description\" required />\r\n        <button type=\"submit\" class=\"btn btn-warning btn-block m-t-xs\">نیاز به اصلاح</button>\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(922, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 443, "Routine_Action_Edit_", 443, 20, true);
#line 8 "I:\02\NewInternship\Internship.Web\Views\Shared\_RoutineActions2\_Edit.cshtml"
AddHtmlAttributeValue("", 463, Model.Item1, 463, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(930, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<int, int>> Html { get; private set; }
    }
}
#pragma warning restore 1591
