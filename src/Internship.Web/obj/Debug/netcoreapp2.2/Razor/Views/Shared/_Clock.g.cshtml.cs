#pragma checksum "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Clock.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a520486d4c391448a8358f45411e38068401fe0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Clock), @"mvc.1.0.view", @"/Views/Shared/_Clock.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Clock.cshtml", typeof(AspNetCore.Views_Shared__Clock))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Web.Areas.Identity;

#line default
#line hidden
#line 2 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.Common.IdentityToolkit;

#line default
#line hidden
#line 3 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.Common.PersianToolkit;

#line default
#line hidden
#line 4 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.Entity.Identity;

#line default
#line hidden
#line 5 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity;

#line default
#line hidden
#line 6 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.ViewModel.Identity.Settings;

#line default
#line hidden
#line 7 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#line 8 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 9 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 10 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#line 11 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#line 13 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Infrastructure.DataLayer.Context;

#line default
#line hidden
#line 14 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\_ViewImports.cshtml"
using Internship.Core.DomainModels.Entity.AuditableEntity;

#line default
#line hidden
#line 1 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Clock.cshtml"
using Alamut.Helpers.DateTime;

#line default
#line hidden
#line 2 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Clock.cshtml"
using DNTPersianUtils.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a520486d4c391448a8358f45411e38068401fe0c", @"/Views/Shared/_Clock.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51872ae7d6162f128a2b528f6a5dce7432e7ca3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Clock : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align: center; margin-top: 25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("digitalClock"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("dir", new global::Microsoft.AspNetCore.Html.HtmlString("ltr"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("direction: ltr;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("canvasClock"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("visibility: hidden;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(63, 153, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a520486d4c391448a8358f45411e38068401fe0c7909", async() => {
                BeginContext(114, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(120, 16, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a520486d4c391448a8358f45411e38068401fe0c8293", async() => {
                    BeginContext(125, 5, true);
                    WriteLiteral("امروز");
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
                BeginContext(136, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(142, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a520486d4c391448a8358f45411e38068401fe0c9572", async() => {
                    BeginContext(148, 54, false);
#line 6 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Clock.cshtml"
    Write(DateTime.Now.GetPersianDateString().ToPersianNumbers());

#line default
#line hidden
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
                BeginContext(208, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(216, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(220, 305, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a520486d4c391448a8358f45411e38068401fe0c11903", async() => {
                BeginContext(270, 126, true);
                WriteLiteral("\r\n    <canvas class=\"canvas center-block\" id=\"analogClock\" width=\"240\" height=\"240\" style=\"max-width: 100%;\"></canvas>\r\n\r\n    ");
                EndContext();
                BeginContext(396, 121, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a520486d4c391448a8358f45411e38068401fe0c12425", async() => {
                    BeginContext(455, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(465, 40, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a520486d4c391448a8358f45411e38068401fe0c12835", async() => {
                        BeginContext(488, 11, true);
                        WriteLiteral("00:00:00 AM");
                        EndContext();
                    }
                    );
                    __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
                    __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(505, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
                __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(517, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Internship.Web.Areas.Identity.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Internship_Web_Areas_Identity_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(525, 4461, true);
            WriteLiteral(@"

<script>
    function drawClock(drawPlace, timestamp) {
        var canvas = document.getElementById(drawPlace),
            context = canvas.getContext(""2d""),
            centerX = canvas.width / 2,
            centerY = canvas.height / 2,
            radius = canvas.width / 2 - 20;

        context.clearRect(0, 0, canvas.width, canvas.height);
        context.lineCap = ""round"";
        context.beginPath();
        context.arc(centerX, centerY, radius - 10, 0, 2 * Math.PI, false);
        context.fillStyle = '#ccc';
        context.fill();
        context.closePath();
        context.restore();

        context.beginPath();
        context.arc(centerX, centerY, radius - 14, 0, 2 * Math.PI, false);
        context.fillStyle = '#fff';
        context.fill();
        context.closePath();
        context.restore();

        // Center Circle
        context.beginPath();
        context.arc(centerX, centerY, 4, 0, 2 * Math.PI, false);
        context.lineWidth = 3;
        context.s");
            WriteLiteral(@"trokeStyle = '#555';
        context.stroke();
        context.closePath();
        context.restore();

        context.translate(centerX, centerY);

        context.fillStyle = '#555';
        context.font = radius * 0.18 + ""px Arial"";
        context.textBaseline = ""middle"";
        context.textAlign = ""center"";
        for (num = 0; num < 12; num++) {
            ang = (num + 1) * Math.PI / 6;
            context.rotate(ang);
            context.translate(0, -radius * 0.60);
            context.rotate(-ang);
            context.fillText((num + 1).toString(), 0, 0);
            context.rotate(ang);
            context.translate(0, radius * 0.60);
            context.rotate(-ang);
        }

        for (var i = 1; i <= 60; i++) {
            angle = Math.PI / 30 * i;
            sineAngle = Math.sin(angle);
            cosAngle = -Math.cos(angle);

            if (i % 5 == 0) {
                context.lineWidth = 2;
                iPointX = sineAngle * (radius - 25);
         ");
            WriteLiteral(@"       iPointY = cosAngle * (radius - 25);
                oPointX = sineAngle * (radius - 20);
                oPointY = cosAngle * (radius - 20);
            } else {
                context.lineWidth = 0.8;
                iPointX = sineAngle * (radius - 22);
                iPointY = cosAngle * (radius - 22);
                oPointX = sineAngle * (radius - 20);
                oPointY = cosAngle * (radius - 20);
            }

            context.beginPath();
            context.moveTo(iPointX, iPointY);
            context.lineTo(oPointX, oPointY);
            context.stroke();
        }

        var now = timestamp,

            hrs = now.getHours(),
            min = now.getMinutes(),
            sec = now.getSeconds();

        // Set Hands Variables
        var sangle = (Math.PI / 30 * sec),
            sPointX = Math.sin(sangle) * (radius - 50),
            sPointY = -Math.cos(sangle) * (radius - 50);

        // Draw seconds hand
        context.beginPath();
        co");
            WriteLiteral(@"ntext.lineWidth = 2;
        context.moveTo(0, 0);
        context.strokeStyle = ""#888"";
        context.lineTo(sPointX, sPointY);
        context.stroke();
        context.closePath();

        // Draw minutes hand
        context.beginPath();
        context.lineWidth = 4;
        context.strokeStyle = ""#555555"";
        sangle = (Math.PI / 30 * (min + (sec / 60)));
        sPointX = Math.sin(sangle) * (radius - 48);
        sPointY = -Math.cos(sangle) * (radius - 48);
        context.moveTo(0, 0);
        context.lineTo(sPointX, sPointY);
        context.stroke();
        context.closePath();

        // Draw hours hand
        context.beginPath();
        context.lineWidth = 6;
        context.strokeStyle = ""#555555"";
        sangle = (Math.PI / 6 * (hrs + (min / 65) + (sec / 3600)));
        sPointX = Math.sin(sangle) * (radius - 65);
        sPointY = -Math.cos(sangle) * (radius - 65);
        context.moveTo(0, 0);
        context.lineTo(sPointX, sPointY);
        context.str");
            WriteLiteral(@"oke();
        context.closePath();

        context.restore();
        context.translate(-centerX, -centerY);
    }

    var duration = 0;
    var delay = 0;
    var year = 0;
    var month = 0;
    var day = 0;
    var hour = 0;
    var minute = 0;
    var second = 0;
    var millisecond = 0;


    function initTime() {
        var result = '");
            EndContext();
            BeginContext(4987, 47, false);
#line 152 "D:\Repose\internship13980630\Internship\src\Internship.Web\Views\Shared\_Clock.cshtml"
                 Write(DateTime.Now.ToString("yyyy MM dd HH mm ss ff"));

#line default
#line hidden
            EndContext();
            BeginContext(5034, 1281, true);
            WriteLiteral(@"';
        // var result = ""2016 05 15 11 53 44 68"";
        var items = result.toString().split(' ');
        year = Number(items[0]);
        month = Number(items[1]);
        day = Number(items[2]);
        hour = Number(items[3]);
        minute = Number(items[4]);
        second = Number(items[5]) + 1;
        millisecond = Number(items[6]);
    }

    initTime();

    setInterval(function () {
        $(""#canvasClock"").css(""visibility"", 'visible');
        var d = new Date(year, month, day, hour, minute, second, millisecond);
        d.setSeconds(d.getSeconds() + duration + delay);

        drawClock('analogClock', d);

        duration = duration + 1;

        var hh = d.getHours();
        var m = d.getMinutes();
        var s = d.getSeconds();

        var dd = ""AM"";
        var h = hh;

        if (h >= 12) {
            h = hh - 12;
            dd = ""PM"";
        }

        if (h == 0) {
            h = 12;
        }

        m = m < 10 ? ""0"" + m : m;
       ");
            WriteLiteral(@" s = s < 10 ? ""0"" + s : s;
        h = h < 10 ? ""0"" + h : h;

        document.getElementById('digitalClock').innerHTML = ('<div style=""font-family: monospace;"">' + h + ':' + m + ':' + s + ' ' + '<span>' + dd + '</span></div>');
    }, 1000);
</script>");
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
