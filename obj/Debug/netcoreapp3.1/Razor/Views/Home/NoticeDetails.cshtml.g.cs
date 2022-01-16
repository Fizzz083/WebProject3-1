#pragma checksum "E:\MyWebApp\Views\Home\NoticeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8c80f68dad825d524a000ee76b70a568497d35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NoticeDetails), @"mvc.1.0.view", @"/Views/Home/NoticeDetails.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\MyWebApp\Views\_ViewImports.cshtml"
using MyWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MyWebApp\Views\_ViewImports.cshtml"
using MyWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8c80f68dad825d524a000ee76b70a568497d35", @"/Views/Home/NoticeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9f1673a5f2983d73e81002570cb059c9cd4e88c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NoticeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWebApp.Models.Notice>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\MyWebApp\Views\Home\NoticeDetails.cshtml"
  
    ViewData["Title"] = "Notice Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "E:\MyWebApp\Views\Home\NoticeDetails.cshtml"
  

    string time_= Model.Time;
    
    //time_ = time_.Substring(0, time_.Length - 2);
    DateTime oDate = Convert.ToDateTime(time_);
    string result = string.Empty;

    var timeSpan = DateTime.Now.Subtract(oDate);

    if (timeSpan <= TimeSpan.FromSeconds(60))
    {
        result = string.Format("{0} seconds ago", timeSpan.Seconds);
    }
    else if (timeSpan <= TimeSpan.FromMinutes(60))
    {
        result = timeSpan.Minutes > 1 ?
        String.Format("about {0} minutes ago", timeSpan.Minutes) :
        "about a minute ago";
    }
    else if (timeSpan <= TimeSpan.FromHours(24))
    {
        result = timeSpan.Hours > 1 ?
        String.Format("about {0} hours ago", timeSpan.Hours) :
        "about an hour ago";
    }
    else if (timeSpan <= TimeSpan.FromDays(30))
    {
        result = timeSpan.Days > 1 ?
        String.Format("about {0} days ago", timeSpan.Days) :
        "yesterday";
    }
    else if (timeSpan <= TimeSpan.FromDays(365))
    {
        result = timeSpan.Days > 30 ?
        String.Format("about {0} months ago", timeSpan.Days / 30) :
        "about a month ago";
    }
    else
    {
        result = timeSpan.Days > 365 ?
        String.Format("about {0} years ago", timeSpan.Days / 365) :
        "about a year ago";
    }

    time_ = result;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"noticedetails\">\r\n");
#nullable restore
#line 58 "E:\MyWebApp\Views\Home\NoticeDetails.cshtml"
     if(Model!=null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3 class=\"noticehead\">");
#nullable restore
#line 60 "E:\MyWebApp\Views\Home\NoticeDetails.cshtml"
                              Write(Model.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
            WriteLiteral("            <p style=\"color:#a7c2cf ;\">:");
#nullable restore
#line 62 "E:\MyWebApp\Views\Home\NoticeDetails.cshtml"
                                   Write(result);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <br>\r\n");
            WriteLiteral("            <p style=\"color: white;\">");
#nullable restore
#line 65 "E:\MyWebApp\Views\Home\NoticeDetails.cshtml"
                                Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 66 "E:\MyWebApp\Views\Home\NoticeDetails.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Technical error. Try again</p>\r\n");
#nullable restore
#line 70 "E:\MyWebApp\Views\Home\NoticeDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n    window.onload = function () {\r\n\r\n        \r\n\r\n        };\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWebApp.Models.Notice> Html { get; private set; }
    }
}
#pragma warning restore 1591