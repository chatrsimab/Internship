#pragma checksum "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc03be5df3a341cbbb709cce2f1213f0f1c57d78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_UserCard__UserInfoPart), @"mvc.1.0.view", @"/Areas/Identity/Views/UserCard/_UserInfoPart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Views/UserCard/_UserInfoPart.cshtml", typeof(AspNetCore.Areas_Identity_Views_UserCard__UserInfoPart))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Web.Areas.Identity;

#line default
#line hidden
#line 2 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.Common.IdentityToolkit;

#line default
#line hidden
#line 3 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.Common.PersianToolkit;

#line default
#line hidden
#line 4 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.Entity.Identity;

#line default
#line hidden
#line 5 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Web.Services.Contracts.Identity;

#line default
#line hidden
#line 6 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Web.Services.Contracts;

#line default
#line hidden
#line 7 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity;

#line default
#line hidden
#line 8 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity.Emails;

#line default
#line hidden
#line 9 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity.Settings;

#line default
#line hidden
#line 10 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#line 11 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 12 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 13 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#line 14 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#line 15 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using DNTPersianUtils.Core;

#line default
#line hidden
#line 2 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
using Internship.Infrastructure.Services.Contracts.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc03be5df3a341cbbb709cce2f1213f0f1c57d78", @"/Areas/Identity/Views/UserCard/_UserInfoPart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8855e927cc29baffb9e09864cdbecda77e26a913", @"/Areas/Identity/Views/_ViewImports.cshtml")]
    public class Areas_Identity_Views_UserCard__UserInfoPart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserCardItemViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onerror", new global::Microsoft.AspNetCore.Html.HtmlString("this.style.visibility = \'hidden\';this.width=0; this.height=0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-6"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row mt-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
  
    var user = Model.User;
    var photoUrl = PhotoService.GetUserPhotoUrl(user.PhotoFileName);

#line default
#line hidden
            BeginContext(239, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(241, 3014, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc03be5df3a341cbbb709cce2f1213f0f1c57d788701", async() => {
                BeginContext(259, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(265, 276, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc03be5df3a341cbbb709cce2f1213f0f1c57d789086", async() => {
                    BeginContext(282, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(292, 237, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc03be5df3a341cbbb709cce2f1213f0f1c57d789496", async() => {
                        BeginContext(314, 14, true);
                        WriteLiteral("\r\n            ");
                        EndContext();
                        BeginContext(328, 185, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc03be5df3a341cbbb709cce2f1213f0f1c57d789930", async() => {
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                        __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                        BeginWriteTagHelperAttribute();
#line 12 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                                WriteLiteral(photoUrl);

#line default
#line hidden
                        __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                        __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                        __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 12 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
AddHtmlAttributeValue("", 376, user.DisplayName, 376, 17, false);

#line default
#line hidden
                        EndAddHtmlAttributeValues(__tagHelperExecutionContext);
#line 12 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(513, 10, true);
                        WriteLiteral("\r\n        ");
                        EndContext();
                    }
                    );
                    __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
                    __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(529, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
                __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(541, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(547, 2700, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc03be5df3a341cbbb709cce2f1213f0f1c57d7814979", async() => {
                    BeginContext(569, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(579, 1979, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc03be5df3a341cbbb709cce2f1213f0f1c57d7815391", async() => {
                        BeginContext(601, 186, true);
                        WriteLiteral("\r\n            <ul class=\"list-unstyled\">\r\n                <li>\r\n                    <span aria-hidden=\"true\" class=\"fas fa-user\"></span>\r\n                    <strong>عضو شماره:</strong> ");
                        EndContext();
                        BeginContext(788, 26, false);
#line 21 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                                           Write(user.Id.ToPersianNumbers());

#line default
#line hidden
                        EndContext();
                        BeginContext(814, 219, true);
                        WriteLiteral("\r\n                </li>\r\n                <li>\r\n                    <span aria-hidden=\"true\" class=\"fas fa-clock\"></span>\r\n                    <strong>تاریخ عضویت: </strong><span dir=\"ltr\">\r\n                        <abbr");
                        EndContext();
                        BeginWriteAttribute("title", " title=\"", 1033, "\"", 1118, 1);
#line 26 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
WriteAttributeValue("", 1041, user.CreatedDateTime.Value.ToFriendlyPersianDateTextify().ToPersianNumbers(), 1041, 77, false);

#line default
#line hidden
                        EndWriteAttribute();
                        BeginContext(1119, 31, true);
                        WriteLiteral(">\r\n                            ");
                        EndContext();
                        BeginContext(1151, 99, false);
#line 27 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                       Write(user.CreatedDateTime.Value.ToShortPersianDateString(DateTimeOffsetPart.DateTime).ToPersianNumbers());

#line default
#line hidden
                        EndContext();
                        BeginContext(1250, 89, true);
                        WriteLiteral("\r\n                        </abbr>\r\n                    </span>\r\n                </li>\r\n\r\n");
                        EndContext();
#line 32 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                 if (user.IsEmailPublic)
                {

#line default
#line hidden
                        BeginContext(1400, 132, true);
                        WriteLiteral("                    <li>\r\n                        <span aria-hidden=\"true\" class=\"fas fa-envelope\"></span>\r\n                        ");
                        EndContext();
                        BeginContext(1532, 218, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc03be5df3a341cbbb709cce2f1213f0f1c57d7818347", async() => {
                        }
                        );
                        __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                        __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                        BeginWriteTagHelperAttribute();
#line 36 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                      WriteLiteral(Url.Action(action: "EmailToImage", controller:"UserCard", values: new { id = user.Id }));

#line default
#line hidden
                        __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                        __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                        __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 37 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
                        __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                        BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 38 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
AddHtmlAttributeValue("", 1723, user.DisplayName, 1723, 17, false);

#line default
#line hidden
                        AddHtmlAttributeValue(" ", 1740, "Email", 1741, 6, true);
                        EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(1750, 29, true);
                        WriteLiteral("\r\n                    </li>\r\n");
                        EndContext();
#line 40 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                }

#line default
#line hidden
                        BeginContext(1798, 2, true);
                        WriteLiteral("\r\n");
                        EndContext();
#line 42 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                 if (!string.IsNullOrWhiteSpace(user.Location))
                {

#line default
#line hidden
                        BeginContext(1884, 181, true);
                        WriteLiteral("                    <li>\r\n                        <span aria-hidden=\"true\" class=\"fas fa-home\"></span>\r\n                        <strong>محل اقامت:</strong>\r\n                        ");
                        EndContext();
                        BeginContext(2066, 13, false);
#line 47 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                   Write(user.Location);

#line default
#line hidden
                        EndContext();
                        BeginContext(2079, 29, true);
                        WriteLiteral("\r\n                    </li>\r\n");
                        EndContext();
#line 49 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                }

#line default
#line hidden
                        BeginContext(2127, 2, true);
                        WriteLiteral("\r\n");
                        EndContext();
#line 51 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                 if (user.LastVisitDateTime != null)
                {

#line default
#line hidden
                        BeginContext(2202, 194, true);
                        WriteLiteral("                    <li>\r\n                        <span aria-hidden=\"true\" class=\"fas fa-calendar-check\"></span>\r\n                        <strong>آخرین مراجعه:</strong>\r\n                        ");
                        EndContext();
                        BeginContext(2397, 78, false);
#line 56 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                   Write(user.LastVisitDateTime.Value.ToFriendlyPersianDateTextify().ToPersianNumbers());

#line default
#line hidden
                        EndContext();
                        BeginContext(2475, 29, true);
                        WriteLiteral("\r\n                    </li>\r\n");
                        EndContext();
#line 58 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                }

#line default
#line hidden
                        BeginContext(2523, 29, true);
                        WriteLiteral("            </ul>\r\n\r\n        ");
                        EndContext();
                    }
                    );
                    __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
                    __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2558, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(2568, 667, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc03be5df3a341cbbb709cce2f1213f0f1c57d7825411", async() => {
                        BeginContext(2590, 42, true);
                        WriteLiteral("\r\n            <ul class=\"list-unstyled\">\r\n");
                        EndContext();
#line 64 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                 if (user.BirthDate.HasValue)
                {

#line default
#line hidden
                        BeginContext(2698, 183, true);
                        WriteLiteral("                    <li>\r\n                        <span aria-hidden=\"true\" class=\"fas fa-calendar\"></span>\r\n                        <strong>سن:</strong>\r\n                        <abbr");
                        EndContext();
                        BeginWriteAttribute("title", " title=\"", 2881, "\"", 3040, 3);
#line 69 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
WriteAttributeValue("", 2889, user.BirthDate.Value.ToString("yyyy/MM/dd", CultureInfo.InvariantCulture), 2889, 74, false);

#line default
#line hidden
                        WriteAttributeValue("", 2963, ",", 2963, 1, true);
#line 69 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
WriteAttributeValue(" ", 2964, user.BirthDate.Value.ToShortPersianDateString(DateTimeOffsetPart.DateTime), 2965, 75, false);

#line default
#line hidden
                        EndWriteAttribute();
                        BeginContext(3041, 31, true);
                        WriteLiteral(">\r\n                            ");
                        EndContext();
                        BeginContext(3073, 48, false);
#line 70 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                       Write(user.BirthDate.Value.GetAge().ToPersianNumbers());

#line default
#line hidden
                        EndContext();
                        BeginContext(3121, 62, true);
                        WriteLiteral("\r\n                        </abbr>\r\n                    </li>\r\n");
                        EndContext();
#line 73 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\UserCard\_UserInfoPart.cshtml"
                }

#line default
#line hidden
                        BeginContext(3202, 27, true);
                        WriteLiteral("            </ul>\r\n        ");
                        EndContext();
                    }
                    );
                    __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
                    __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3235, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
                __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3247, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3255, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IUsersPhotoService PhotoService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserCardItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
