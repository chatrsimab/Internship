#pragma checksum "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\Shared\_PickupFolder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce206275713ec860ba21e7e07f21fc9c17f9cc89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_Shared__PickupFolder), @"mvc.1.0.view", @"/Areas/Identity/Views/Shared/_PickupFolder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Views/Shared/_PickupFolder.cshtml", typeof(AspNetCore.Areas_Identity_Views_Shared__PickupFolder))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Web.Areas.Identity;

#line default
#line hidden
#line 2 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.Common.IdentityToolkit;

#line default
#line hidden
#line 3 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.Common.PersianToolkit;

#line default
#line hidden
#line 4 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.Entity.Identity;

#line default
#line hidden
#line 5 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Web.Services.Contracts.Identity;

#line default
#line hidden
#line 6 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Web.Services.Contracts;

#line default
#line hidden
#line 7 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity;

#line default
#line hidden
#line 8 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity.Emails;

#line default
#line hidden
#line 9 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity.Settings;

#line default
#line hidden
#line 10 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#line 11 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 12 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 13 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#line 14 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#line 15 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using DNTPersianUtils.Core;

#line default
#line hidden
#line 16 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\_ViewImports.cshtml"
using Internship.Infrastructure.Services.Contracts.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce206275713ec860ba21e7e07f21fc9c17f9cc89", @"/Areas/Identity/Views/Shared/_PickupFolder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8855e927cc29baffb9e09864cdbecda77e26a913", @"/Areas/Identity/Views/_ViewImports.cshtml")]
    public class Areas_Identity_Views_Shared__PickupFolder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\Shared\_PickupFolder.cshtml"
 if (SiteSettings.Value.Smtp.UsePickupFolder)
{

#line default
#line hidden
            BeginContext(105, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(109, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce206275713ec860ba21e7e07f21fc9c17f9cc896344", async() => {
                BeginContext(114, 96, true);
                WriteLiteral("با توجه به تنظیم بودن استفاده‌ی از PickupFolder جهت ذخیره‌ی محلی ایمیل‌ها، این ایمیل را در مسیر ");
                EndContext();
                BeginContext(211, 36, false);
#line 5 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\Shared\_PickupFolder.cshtml"
                                                                                                    Write(SiteSettings.Value.Smtp.PickupFolder);

#line default
#line hidden
                EndContext();
                BeginContext(247, 23, true);
                WriteLiteral(" می‌توانید مشاهده کنید.");
                EndContext();
            }
            );
            __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(276, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Repose\internship13980630\Internship\src\Internship.Web\Areas\Identity\Views\Shared\_PickupFolder.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IOptionsSnapshot<SiteSettings> SiteSettings { get; private set; }
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
