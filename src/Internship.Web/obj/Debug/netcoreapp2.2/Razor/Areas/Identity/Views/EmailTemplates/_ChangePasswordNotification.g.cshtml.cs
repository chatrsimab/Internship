#pragma checksum "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\EmailTemplates\_ChangePasswordNotification.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3db1c21f08e51680e6e704c91d41545c8218b925"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_EmailTemplates__ChangePasswordNotification), @"mvc.1.0.view", @"/Areas/Identity/Views/EmailTemplates/_ChangePasswordNotification.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Views/EmailTemplates/_ChangePasswordNotification.cshtml", typeof(AspNetCore.Areas_Identity_Views_EmailTemplates__ChangePasswordNotification))]
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
#line 16 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Infrastructure.Services.Contracts.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3db1c21f08e51680e6e704c91d41545c8218b925", @"/Areas/Identity/Views/EmailTemplates/_ChangePasswordNotification.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8855e927cc29baffb9e09864cdbecda77e26a913", @"/Areas/Identity/Views/_ViewImports.cshtml")]
    public class Areas_Identity_Views_EmailTemplates__ChangePasswordNotification : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ChangePasswordNotificationViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("align", new global::Microsoft.AspNetCore.Html.HtmlString("center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("dir", new global::Microsoft.AspNetCore.Html.HtmlString("rtl"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family: Tahoma; font-size: 9pt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\EmailTemplates\_ChangePasswordNotification.cshtml"
  
    Layout = "~/Areas/Identity/Views/EmailTemplates/_EmailsLayout.cshtml";

#line default
#line hidden
            BeginContext(127, 87, true);
            WriteLiteral("&nbsp; با سلام\r\n<br />\r\n&nbsp; کلمه‌ی عبور شما با موفقیت تعویض گردید.\r\n<br />\r\n<br />\r\n");
            EndContext();
            BeginContext(214, 595, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3db1c21f08e51680e6e704c91d41545c8218b9257380", async() => {
                BeginContext(288, 31, true);
                WriteLiteral("\r\n    نام کاربری (جهت لاگین) : ");
                EndContext();
                BeginContext(320, 19, false);
#line 11 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\EmailTemplates\_ChangePasswordNotification.cshtml"
                        Write(Model.User.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(339, 51, true);
                WriteLiteral("\r\n    <br />\r\n    نام مستعار (جهت نمایش در سایت) : ");
                EndContext();
                BeginContext(391, 22, false);
#line 13 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\EmailTemplates\_ChangePasswordNotification.cshtml"
                                Write(Model.User.DisplayName);

#line default
#line hidden
                EndContext();
                BeginContext(413, 148, true);
                WriteLiteral("\r\n    <br />\r\n    <br />\r\n    همچنین در هر زمان برای بازیابی کلمه‌ی عبور فراموش شده خود می‌توانید از آدرس ذیل استفاده\r\n    نمائید:\r\n    <br />\r\n    ");
                EndContext();
                BeginContext(561, 240, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3db1c21f08e51680e6e704c91d41545c8218b9258822", async() => {
                    BeginContext(581, 12, true);
                    WriteLiteral("\r\n        <a");
                    EndContext();
                    BeginWriteAttribute("href", " href=\"", 593, "\"", 727, 1);
#line 20 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\EmailTemplates\_ChangePasswordNotification.cshtml"
WriteAttributeValue("", 600, Url.Action("Index","ForgotPassword", values: new { area = AreaConstants.IdentityArea }, protocol: this.Context.Request.Scheme), 600, 127, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(728, 67, true);
                    WriteLiteral(">\r\n            بازیابی\r\n            کلمه‌ی عبور\r\n        </a>\r\n    ");
                    EndContext();
                }
                );
                __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
                __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(801, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(809, 71, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n&nbsp;با احترام<br />\r\n&nbsp;<a style=\"direction:ltr\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 880, "\"", 981, 1);
#line 29 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\EmailTemplates\_ChangePasswordNotification.cshtml"
WriteAttributeValue("", 887, Url.Action("Index", "Home", values: new { area = "" }, protocol: this.Context.Request.Scheme), 887, 94, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(982, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(984, 20, false);
#line 29 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\EmailTemplates\_ChangePasswordNotification.cshtml"
                                                                                                                                Write(Model.EmailSignature);

#line default
#line hidden
            EndContext();
            BeginContext(1004, 66, true);
            WriteLiteral("</a>\r\n\r\n<br />\r\n<span lang=\"fa\" dir=\"ltr\">\r\n    &nbsp;&nbsp;\r\n    ");
            EndContext();
            BeginContext(1071, 21, false);
#line 34 "D:\GitHub\exir\Internship\src\Internship.Web\Areas\Identity\Views\EmailTemplates\_ChangePasswordNotification.cshtml"
Write(Model.MessageDateTime);

#line default
#line hidden
            EndContext();
            BeginContext(1092, 17, true);
            WriteLiteral("\r\n</span>\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChangePasswordNotificationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
