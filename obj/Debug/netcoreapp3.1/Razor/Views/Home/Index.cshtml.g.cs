#pragma checksum "E:\MyWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f52ad7aea986392f60f1dff8bdb7fd307b62720"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f52ad7aea986392f60f1dff8bdb7fd307b62720", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9f1673a5f2983d73e81002570cb059c9cd4e88c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWebApp.Models.CollectionDataModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\MyWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<ul id=""exampleSlider"" class = ""slideshow"">

    <h3 id = ""show""> h</h3>

");
#nullable restore
#line 17 "E:\MyWebApp\Views\Home\Index.cshtml"
     foreach (ImageUp item in Model.Images)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            \r\n");
#nullable restore
#line 22 "E:\MyWebApp\Views\Home\Index.cshtml"
          
               string imageBase64Data = Convert.ToBase64String(item.Datafiles);
                string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
               var imgs = imageDataURL;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img class=\"img2\"");
            BeginWriteAttribute("src", " src=\"", 716, "\"", 727, 1);
#nullable restore
#line 27 "E:\MyWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 722, imgs, 722, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 728, "\"", 734, 0);
            EndWriteAttribute();
            WriteLiteral(" /></li>\r\n");
#nullable restore
#line 28 "E:\MyWebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    
    <!--li><img class=""img2"" src=""~/Images/1.jpg"" alt="""" /></li>
    <li><img class=""img2"" src=""~/Images/2.jpg"" alt="""" /></li>
    <li><img class=""img2"" src=""~/Images/3.jpg"" alt="""" /></li>
    <li><img class=""img2"" src=""~/Images/4.jpg"" alt="""" /></li-->
    
</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWebApp.Models.CollectionDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
