#pragma checksum "E:\MyWebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e7fa6c65b96e407c618a04ee4e9c762def69d48"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e7fa6c65b96e407c618a04ee4e9c762def69d48", @"/Views/Home/Index.cshtml")]
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
            WriteLiteral("            <li>\r\n\r\n");
#nullable restore
#line 22 "E:\MyWebApp\Views\Home\Index.cshtml"
          
            string imageBase64Data = Convert.ToBase64String(item.Datafiles);
            string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
            var imgs = imageDataURL;
        

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img class=\"img2\"");
            BeginWriteAttribute("src", " src=\"", 675, "\"", 686, 1);
#nullable restore
#line 27 "E:\MyWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 681, imgs, 681, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 687, "\"", 693, 0);
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

<h5 id=""show""></h5>
<div class=""slideshow-container"" >

    <!-- Full-width images with number and caption text -->
    

        
");
#nullable restore
#line 44 "E:\MyWebApp\Views\Home\Index.cshtml"
         foreach (ImageUp item in Model.Images)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("           <div class=\"mySlides fadee\">\r\n\r\n");
#nullable restore
#line 49 "E:\MyWebApp\Views\Home\Index.cshtml"
                  
                    string imageBase64Data = Convert.ToBase64String(item.Datafiles);
                    string imageDataURL = string.Format("data:image/png;base64,{0}", imageBase64Data);
                    var imgs = imageDataURL;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                \r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1533, "\"", 1544, 1);
#nullable restore
#line 56 "E:\MyWebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1539, imgs, 1539, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 400px;width:100%\">\r\n           </div>\r\n");
#nullable restore
#line 58 "E:\MyWebApp\Views\Home\Index.cshtml"
                
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<br>\r\n\r\n<div style=\"text-align:center\">\r\n");
#nullable restore
#line 65 "E:\MyWebApp\Views\Home\Index.cshtml"
      foreach (ImageUp item in Model.Images)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span class=\"dot\" ></span>\r\n");
#nullable restore
#line 68 "E:\MyWebApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<br/>


<h3 style=""width:600px;margin-left: -50px;margin-top:20px;text-align: center;"">About</h3>
<div class=""about"">
    <p>
    Articles are found in many Indo-European languages, Semitic languages (only the definite article), and Polynesian languages; however, they are formally absent from many of the world's major languages including: Chinese, Japanese, Korean, Mongolian, many Turkic languages (incl. Tatar, Bashkir, Tuvan and Chuvash), many Uralic languages (incl. Finnic[a] and Saami languages), Indonesian, Hindi-Urdu, Punjabi, Tamil, the Baltic languages, the majority of Slavic languages, the Bantu languages (incl. Swahili) and Yoruba. In some languages that do have articles, such as some North Caucasian languages, the use of articles is optional; however, in others like English and German it is mandatory in all cases.

Linguists believe the common ancestor of the Indo-European languages, Proto-Indo-European, did not have articles. Most of the languages in this family do not have defini");
            WriteLiteral(@"te or indefinite articles: there is no article in Latin or Sanskrit, nor in some modern Indo-European languages, such as the families of Slavic languages (except for Bulgarian and Macedonian, which are rather distinctive among the Slavic languages in their grammar, and some Northern Russian dialects[7]), Baltic languages and many Indo-Aryan languages. Although Classical Greek had a definite article (which has survived into Modern Greek and which bears strong functional resemblance to the German definite article, which it is related to), the earlier Homeric Greek used this article largely as a pronoun or demonstrative, whereas the earliest known form of Greek known as Mycenaean Greek did not have any articles. Articles developed independently in several language families.

Not all languages have both definite and indefinite articles, and some languages have different types of definite and indefinite articles to distinguish finer shades of meaning: for example, French and Italian have a partitive article used");
            WriteLiteral(@" for indefinite mass nouns, whereas Colognian has two distinct sets of definite articles indicating focus and uniqueness, and Macedonian uses definite articles in a demonstrative sense, with a tripartite distinction (proximal, medial, distal) based on distance from the speaker or interlocutor. The words this and that (and their plurals, these and those) can be understood in English as, ultimately, forms of the definite article the (whose declension in Old English included thaes, an ancestral form of this/that and these/those).

In many languages, the form of the article may vary according to the gender, number, or case of its noun. In some languages the article may be the only indication of the case. Many languages do not use articles at all, and may use other ways of indicating old versus new information, such as topic–comment constructions.
    </p>

</div>


<div class=""tableheader"">
    <h3 style=""text-align:center"">Notice</h3>
</div>


<div class=""fornotice"" style=""background-color: aquamari");
            WriteLiteral("ne;\" >\r\n    <p>\r\n       \r\n");
#nullable restore
#line 97 "E:\MyWebApp\Views\Home\Index.cshtml"
         if(Model.Notices !=null)
        {
           
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"noticetable\" style=\"background-color: aquamarine;\">\r\n            <marquee direction=\"up\" scrolldelay=\"1\" onmouseover=\"this.stop();\" onmouseout=\"this.start();\">\r\n        <ul >\r\n           \r\n");
#nullable restore
#line 105 "E:\MyWebApp\Views\Home\Index.cshtml"
              foreach (Notice notice in Model.Notices)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li id=\"noticetabletr\" style=\" background-color: azure;;margin-right:20px;\">\r\n                        \r\n                        <h6 style=\"width:200px;height:30px;margin-left:30px;\">");
#nullable restore
#line 109 "E:\MyWebApp\Views\Home\Index.cshtml"
                                                                         Write(notice.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <p style=\"width:100px;height:30px;;margin-top:-40px;margin-left:300px;\">");
#nullable restore
#line 110 "E:\MyWebApp\Views\Home\Index.cshtml"
                                                                                           Write(notice.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p style=\"margin-left:30px;width: 400px;height:100%;margin-top:20px;\">");
#nullable restore
#line 111 "E:\MyWebApp\Views\Home\Index.cshtml"
                                                                                         Write(notice.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
            WriteLiteral("                      \r\n                    </li>\r\n");
#nullable restore
#line 119 "E:\MyWebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n        </marquee>\r\n        </div>\r\n");
#nullable restore
#line 123 "E:\MyWebApp\Views\Home\Index.cshtml"

            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>No Notice is added</p>\r\n");
#nullable restore
#line 128 "E:\MyWebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n</div>\r\n\r\n\r\n<div>\r\n\r\n<h4  style=\"text-align:center\">Teacher info</h4>\r\n");
#nullable restore
#line 137 "E:\MyWebApp\Views\Home\Index.cshtml"
 if(Model.Publish_submission !=null)
{
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table >
    <tr>
        <th  style=""padding: 15px""  >Name</th>
        <th  style=""padding: 15px""  >Problem Name</th>
        <th  style=""padding: 15px"" >Time</th>
        <th  style=""padding: 15px"" >Verdict</th>
        <th  style=""padding: 15px"" >Problem Id</th>

    </tr>
");
#nullable restore
#line 149 "E:\MyWebApp\Views\Home\Index.cshtml"
     foreach (publish_submission ps in Model.Publish_submission)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr >\r\n            <td>");
#nullable restore
#line 152 "E:\MyWebApp\Views\Home\Index.cshtml"
           Write(ps.user_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 153 "E:\MyWebApp\Views\Home\Index.cshtml"
           Write(ps.problem_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 154 "E:\MyWebApp\Views\Home\Index.cshtml"
           Write(ps.time_);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 155 "E:\MyWebApp\Views\Home\Index.cshtml"
           Write(ps.verdict);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 157 "E:\MyWebApp\Views\Home\Index.cshtml"
                  
                    string url =   "https://codeforces.com/problemset/problem/"+@ps.contest_id+"/"+@ps.problem_id;

                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=", 6989, "", 6995, 0);
            EndWriteAttribute();
            WriteLiteral(" ");
#nullable restore
#line 161 "E:\MyWebApp\Views\Home\Index.cshtml"
                    Write(url);

#line default
#line hidden
#nullable disable
            WriteLiteral(">\r\n                    ");
#nullable restore
#line 162 "E:\MyWebApp\Views\Home\Index.cshtml"
               Write(ps.contest_id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 162 "E:\MyWebApp\Views\Home\Index.cshtml"
                              Write(ps.problem_id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr> \r\n");
#nullable restore
#line 165 "E:\MyWebApp\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 167 "E:\MyWebApp\Views\Home\Index.cshtml"

}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No problem is found</p>\r\n");
#nullable restore
#line 172 "E:\MyWebApp\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
