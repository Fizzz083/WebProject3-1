#pragma checksum "E:\MyWebApp\Views\Contest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3da33a222a7c627cee45788b5373b217eae34e13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contest_Index), @"mvc.1.0.view", @"/Views/Contest/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3da33a222a7c627cee45788b5373b217eae34e13", @"/Views/Contest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9f1673a5f2983d73e81002570cb059c9cd4e88c", @"/Views/_ViewImports.cshtml")]
    public class Views_Contest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyWebApp.Models.result>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\MyWebApp\Views\Contest\Index.cshtml"
  
    var timee = DateTimeOffset.Now.ToUnixTimeSeconds();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>\n    <h3>Upcoming Contest</h3>\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th></b>Id</th>\n            <th>Name</th>\n            <th>Duration</th>\n            <th>Start Time</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 20 "E:\MyWebApp\Views\Contest\Index.cshtml"
 foreach ( var item in Model ) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\MyWebApp\Views\Contest\Index.cshtml"
     if(item.startTimeSeconds!>= timee)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 25 "E:\MyWebApp\Views\Contest\Index.cshtml"
           Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 28 "E:\MyWebApp\Views\Contest\Index.cshtml"
           Write(item.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 31 "E:\MyWebApp\Views\Contest\Index.cshtml"
           Write(TimeSpan.FromSeconds(@item.durationSeconds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 34 "E:\MyWebApp\Views\Contest\Index.cshtml"
                  
                    
                  //var time = TimeSpan.FromMilliseconds(@item.startTimeSeconds*1000) ;

                    //var time__ = new DateTime(time.Ticks).ToLocalTime;

                    var time__ = DateTimeOffset.FromUnixTimeSeconds(@item.startTimeSeconds).DateTime.ToLocalTime();
                   
            
                    //DateTime dateTime = New DateTime (long.Parse(@item.durationSeconds));
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
#nullable restore
#line 45 "E:\MyWebApp\Views\Contest\Index.cshtml"
           Write(time__);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td> \n        </tr>\n");
#nullable restore
#line 48 "E:\MyWebApp\Views\Contest\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "E:\MyWebApp\Views\Contest\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyWebApp.Models.result>> Html { get; private set; }
    }
}
#pragma warning restore 1591
