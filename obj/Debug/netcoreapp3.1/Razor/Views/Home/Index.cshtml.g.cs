#pragma checksum "E:\MyWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a35c838b4287aecef33daf3ab63df1b4d2ac5aa4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a35c838b4287aecef33daf3ab63df1b4d2ac5aa4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9f1673a5f2983d73e81002570cb059c9cd4e88c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWebApp.Models.CollectionDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" border-radius:3px; text-align: center; width: 300px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/aboutimg2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\MyWebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<p id=""forcheck"" style=""display:none;"">1</p>

<!-- div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<ul id=""exampleSlider"" class = ""slideshow"">



");
#nullable restore
#line 17 "E:\MyWebApp\Views\Home\Index.cshtml"
 foreach (ImageUp item in Model.Images)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n\r\n");
#nullable restore
#line 22 "E:\MyWebApp\Views\Home\Index.cshtml"
          
            string imageBase64Data = Convert.ToBase64String(item.Datafiles);
            string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
            var imgs = imageDataURL;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("                <img class=\"img2\"");
            BeginWriteAttribute("src", " src=\"", 718, "\"", 729, 1);
#nullable restore
#line 27 "E:\MyWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 724, imgs, 724, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 730, "\"", 736, 0);
            EndWriteAttribute();
            WriteLiteral(" /></li>\r\n");
#nullable restore
#line 28 "E:\MyWebApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <li><img class=""img2"" src=""~/Images/1.jpg"" alt="""" /></li>
    <li><img class=""img2"" src=""~/Images/2.jpg"" alt="""" /></li>
    <li><img class=""img2"" src=""~/Images/3.jpg"" alt="""" /></li>
    <li><img class=""img2"" src=""~/Images/4.jpg"" alt="""" /></li>

</ul -->

");
#nullable restore
#line 37 "E:\MyWebApp\Views\Home\Index.cshtml"
 if (Model.Notices != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""noticetable"" style=""background-color: aquamarine;width:1500px; margin-left:-200px;"">

        <marquee style=""background-color: transparent;"" direction=""left"" scrolldelay=""10"" onmouseover=""this.stop();""
        hspace=""120"" loop=""infinite"" onmouseout=""this.start();"">
            <ul>
");
#nullable restore
#line 44 "E:\MyWebApp\Views\Home\Index.cshtml"
                  
                    Notice notice = Model.Notices[Model.Notices.Count-1];

                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n                <li id=\"noticetabletrr\" style=\"margin-top:5px;margin-right:20px;\">\r\n\r\n                    <p style=\"width:200px;height:18px;\"> <b>");
#nullable restore
#line 53 "E:\MyWebApp\Views\Home\Index.cshtml"
                                                       Write(notice.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" :</b> ");
#nullable restore
#line 53 "E:\MyWebApp\Views\Home\Index.cshtml"
                                                                                      Write(notice.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n\r\n\r\n");
            WriteLiteral("\r\n                </li>\r\n\r\n\r\n            </ul>\r\n        </marquee>\r\n    </div>\r\n");
#nullable restore
#line 67 "E:\MyWebApp\Views\Home\Index.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h5 id=\"show\"></h5>\r\n<div class=\"slideshow-container\">\r\n\r\n    <!-- Full-width images with number and caption text -->\r\n\r\n\r\n\r\n");
#nullable restore
#line 77 "E:\MyWebApp\Views\Home\Index.cshtml"
     foreach (ImageUp item in Model.Images)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"mySlides fadee\">\r\n\r\n");
#nullable restore
#line 82 "E:\MyWebApp\Views\Home\Index.cshtml"
              
                string imageBase64Data = Convert.ToBase64String(item.Datafiles);
                string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
                var imgs = imageDataURL;
            

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 2534, "\"", 2545, 1);
#nullable restore
#line 89 "E:\MyWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 2540, imgs, 2540, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 400px;width:100%\">\r\n        </div>\r\n");
#nullable restore
#line 91 "E:\MyWebApp\Views\Home\Index.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<br>\r\n\r\n<div style=\"text-align:center\">\r\n");
#nullable restore
#line 98 "E:\MyWebApp\Views\Home\Index.cshtml"
     foreach (ImageUp item in Model.Images)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span class=\"dot\"></span>\r\n");
#nullable restore
#line 101 "E:\MyWebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<br />

<div class=""aboutmain"">


    <div class=""about"">
        <h1 style=""color: aliceblue;"">About SGIPC</h1>
        <p style=""margin-top:10px;font-size: 15px;color: antiquewhite;"">

            Welcome, to the programming group of <a href=""https://www.kuet.ac.bd/""><b>Khulna University of Engineering &
                    Technology</b></a>. It is a group which is specially created for programmer students who are
            interested in programming specially ACM solve, NCPC programming contest, University programming contest and
            etc.
            SGIPC means Special Group of Interest in Programming Contest. It is mainly a group of programmers who are
            developing their programming skills by learning, solving, practicing & teaching others different types of
            problems.

            This group also organize different programming contest as single and group or team. It has already organized
            many contests and sends teams to National cont");
            WriteLiteral(@"est NCPC and different university festivals programming
            contests.

            If you have any interest on programming and you have already learned basic programming language, you are
            mostly invited to our programming group.

            We are already started to teach the student of schools and colleges who are interested on programming.

            If you have any questions about SGIPC, please mail us to <i>sgipckuet01@gmail.com</i>
        </p>

    </div>
    <div style=""margin-top: 80px; margin-left: 40px; text-align: center; "">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a35c838b4287aecef33daf3ab63df1b4d2ac5aa410919", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n<div class=\"running_problems\">\r\n\r\n    <h4 class=\"textstylei\" >Running Submissions</h4>\r\n\r\n    \r\n");
#nullable restore
#line 148 "E:\MyWebApp\Views\Home\Index.cshtml"
     if (Model.Publish_submission != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"margin-top: 30px;\"></div>\r\n");
            WriteLiteral(@"        <table class=""tableclass"">
            <tr>
                <th style=""padding: 15px"">Name</th>
                <th style=""padding: 15px"">Problem Name</th>
                <th style=""padding: 15px"">Time</th>
                <th style=""padding: 15px"">Verdict</th>
                <th style=""padding: 15px"">Problem Id</th>

            </tr>
");
#nullable restore
#line 162 "E:\MyWebApp\Views\Home\Index.cshtml"
             foreach (publish_submission ps in Model.Publish_submission)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 165 "E:\MyWebApp\Views\Home\Index.cshtml"
                   Write(ps.user_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 166 "E:\MyWebApp\Views\Home\Index.cshtml"
                   Write(ps.problem_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n\r\n");
#nullable restore
#line 169 "E:\MyWebApp\Views\Home\Index.cshtml"
                          

                            string time_ = ps.time_;

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
                            else
                            {
                                result = time_;
                            } /*
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
                            }*/

                            

                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
#nullable restore
#line 221 "E:\MyWebApp\Views\Home\Index.cshtml"
                   Write(ps.time_);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n\r\n                    \r\n");
#nullable restore
#line 225 "E:\MyWebApp\Views\Home\Index.cshtml"
                                if(string.Compare(ps.verdict, "OK")==0)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                   <td style=\"color: #48ff05;font-weight:normal;\">\r\n                                       ACCEPTED\r\n                                    </td>\r\n");
#nullable restore
#line 230 "E:\MyWebApp\Views\Home\Index.cshtml"
                                   
                               }
                        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <td style=\"color: red;\">\r\n                                       ");
#nullable restore
#line 234 "E:\MyWebApp\Views\Home\Index.cshtml"
                                  Write(ps.verdict);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n");
#nullable restore
#line 236 "E:\MyWebApp\Views\Home\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <td>\r\n");
#nullable restore
#line 240 "E:\MyWebApp\Views\Home\Index.cshtml"
                          
                            string url = "https://codeforces.com/problemset/problem/" + @ps.contest_id + "/" + @ps.problem_id;

                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <a");
            BeginWriteAttribute("href", " href=", 8657, "", 8667, 1);
#nullable restore
#line 244 "E:\MyWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 8663, url, 8663, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 245 "E:\MyWebApp\Views\Home\Index.cshtml"
                       Write(ps.contest_id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 245 "E:\MyWebApp\Views\Home\Index.cshtml"
                                      Write(ps.problem_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 248 "E:\MyWebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
#nullable restore
#line 250 "E:\MyWebApp\Views\Home\Index.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>No problem is found</p>\r\n");
#nullable restore
#line 255 "E:\MyWebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
