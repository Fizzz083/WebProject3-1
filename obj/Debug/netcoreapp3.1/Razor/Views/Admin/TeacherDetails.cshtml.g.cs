#pragma checksum "E:\MyWebApp\Views\Admin\TeacherDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba00e83797b2d66f41f3127f28ade8adcbb6460d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_TeacherDetails), @"mvc.1.0.view", @"/Views/Admin/TeacherDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba00e83797b2d66f41f3127f28ade8adcbb6460d", @"/Views/Admin/TeacherDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9f1673a5f2983d73e81002570cb059c9cd4e88c", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_TeacherDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWebApp.Models.Teacher>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\MyWebApp\Views\Admin\TeacherDetails.cshtml"
  
    ViewData["Title"] = "Coach Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"textstylei\">Coach\'s Information</h1>\r\n\r\n\r\n");
            WriteLiteral(@"

<span></span>
<div>

    <!-- h4>Users</h4 -->
    <hr />
    <div class=""profront"">
        <div class=""proback"">

            <div class=""profiledetails"">
                <dl class=""row prodetailsin"" style=""margin-top: 80px;"">

                    <dt class=""col-sm-2 infohead"">
                        Full Name:
                    </dt>
                    <dd class=""col-sm-10 info"">
                        ");
#nullable restore
#line 33 "E:\MyWebApp\Views\Admin\TeacherDetails.cshtml"
                   Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    \r\n                    <dt class=\"col-sm-2 infohead\">\r\n                        Phone :\r\n                    </dt>\r\n                    <dd class=\"col-sm-10 info\">\r\n                        ");
#nullable restore
#line 40 "E:\MyWebApp\Views\Admin\TeacherDetails.cshtml"
                   Write(Html.DisplayFor(model => model.PhoneNUmber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2 infohead\">\r\n                        Email :\r\n                    </dt>\r\n                    <dd class=\"col-sm-10 info\">\r\n                        ");
#nullable restore
#line 46 "E:\MyWebApp\Views\Admin\TeacherDetails.cshtml"
                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n\r\n\r\n            </div>\r\n        </div>\r\n        <div class=\"procard\">\r\n\r\n            <div class=\"prolog-boxcoach\">\r\n                <div class=\"procardfront\">\r\n");
#nullable restore
#line 56 "E:\MyWebApp\Views\Admin\TeacherDetails.cshtml"
                     if (ViewData["ImageData"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img class=\"propic\"");
            BeginWriteAttribute("src", " src=\"", 1611, "\"", 1635, 1);
#nullable restore
#line 58 "E:\MyWebApp\Views\Admin\TeacherDetails.cshtml"
WriteAttributeValue("", 1617, ViewBag.ImageData, 1617, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 61 "E:\MyWebApp\Views\Admin\TeacherDetails.cshtml"
                                     
                    }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"proname\"> ");
#nullable restore
#line 64 "E:\MyWebApp\Views\Admin\TeacherDetails.cshtml"
                                   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n            </div>\r\n\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 75 "E:\MyWebApp\Views\Admin\TeacherDetails.cshtml"
  await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWebApp.Models.Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591
