#pragma checksum "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_CustomAction.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfb74dc5ddf5b0b90550341ddde26d0c6a35fbc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Routine2__CustomAction), @"mvc.1.0.view", @"/Views/Shared/_Routine2/_CustomAction.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Routine2/_CustomAction.cshtml", typeof(AspNetCore.Views_Shared__Routine2__CustomAction))]
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
#line 2 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_CustomAction.cshtml"
using Internship.Web.Helpers;

#line default
#line hidden
#line 3 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_CustomAction.cshtml"
using Research.City.Admin.Toolkit;

#line default
#line hidden
#line 4 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_CustomAction.cshtml"
using Internship.Core.DomainModels.DTO.Forest;

#line default
#line hidden
#line 5 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_CustomAction.cshtml"
using Internship.Core.DomainModels.SSOT;

#line default
#line hidden
#line 6 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_CustomAction.cshtml"
using Internship.Core.DomainModels.ViewModel.Routine2;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb74dc5ddf5b0b90550341ddde26d0c6a35fbc0", @"/Views/Shared/_Routine2/_CustomAction.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51872ae7d6162f128a2b528f6a5dce7432e7ca3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Routine2__CustomAction : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(215, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 10 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_CustomAction.cshtml"
 try
{
    if (Model.Entity.RoutineStep == Model.Step)
    {
        

#line default
#line hidden
            BeginContext(295, 49, false);
#line 14 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_CustomAction.cshtml"
   Write(Html.Partial($"_CustomActions/_Step{Model.Step}"));

#line default
#line hidden
            EndContext();
#line 14 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_CustomAction.cshtml"
                                                          
    }
}
catch (Exception ex)
{

#line default
#line hidden
            BeginContext(381, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(389, 10, false);
#line 19 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_CustomAction.cshtml"
  Write(ex.Message);

#line default
#line hidden
            EndContext();
            BeginContext(399, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 20 "I:\02\NewInternship\Internship.Web\Views\Shared\_Routine2\_CustomAction.cshtml"
}

#line default
#line hidden
            BeginContext(408, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
