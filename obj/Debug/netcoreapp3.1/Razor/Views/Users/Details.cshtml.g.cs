#pragma checksum "E:\MyWebApp\Views\Users\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b38bbfb348c97a8b2c2cd1c3183f4eaf59471629"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b38bbfb348c97a8b2c2cd1c3183f4eaf59471629", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9f1673a5f2983d73e81002570cb059c9cd4e88c", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MyWebApp.Models.CollectionDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn2 btn2up"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "AddProblem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Resource", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResourceDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ResourceDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\MyWebApp\Views\Users\Details.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"textstylei\">My Profile</h1>\r\n\r\n");
#nullable restore
#line 9 "E:\MyWebApp\Views\Users\Details.cshtml"
 if (ViewData["ImageData"] != null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\MyWebApp\Views\Users\Details.cshtml"
             
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<span></span>

<div>

    <!-- h4>Users</h4 -->
    <hr />
    <div class=""profront"">
        <div class=""proback"">

            <div class=""profiledetails"">
                <dl class=""row prodetailsin"">
                    
                    <dt class=""col-sm-2 infohead"">
                        Full Name:
                    </dt>
                    <dd class=""col-sm-10 info"">
                        ");
#nullable restore
#line 32 "E:\MyWebApp\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.users.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2 infohead\">\r\n                        Email: \r\n                    </dt>\r\n                    <dd class=\"col-sm-10 info\" >\r\n                        ");
#nullable restore
#line 38 "E:\MyWebApp\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.users.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2 infohead\">\r\n                        Phone :\r\n                    </dt>\r\n                    <dd class=\"col-sm-10 info\">\r\n                        ");
#nullable restore
#line 44 "E:\MyWebApp\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.users.PhoneNUmber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2 infohead\">\r\n                        Codeforces :\r\n                    </dt>\r\n                    <dd class=\"col-sm-10 info\">\r\n                        ");
#nullable restore
#line 50 "E:\MyWebApp\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.users.CfId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2 infohead\">\r\n                        LightOj :\r\n                    </dt>\r\n                    <dd class=\"col-sm-10 info\" >\r\n                        ");
#nullable restore
#line 56 "E:\MyWebApp\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.users.LightOjId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2 infohead\">\r\n                        CodeChef :\r\n                    </dt>\r\n                    <dd class=\"col-sm-10 info\">\r\n                        ");
#nullable restore
#line 62 "E:\MyWebApp\Views\Users\Details.cshtml"
                   Write(Html.DisplayFor(model => model.users.CodechefId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n                        <div style=\"display: flex; justify-content: flex-end; margin-top:100px;\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b38bbfb348c97a8b2c2cd1c3183f4eaf594716299244", async() => {
                WriteLiteral("Update Profile");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "E:\MyWebApp\Views\Users\Details.cshtml"
                                                                                                      WriteLiteral(Model.users.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" 
                            <!-- a asp-action=""Index"">Back to List</a -->
                        </div>

            </div>
        </div>
        <div class=""procard"">

            <div class=""prolog-box"">
                <div class=""procardfront"">
");
#nullable restore
#line 76 "E:\MyWebApp\Views\Users\Details.cshtml"
                     if (ViewData["ImageData"] != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img class=\"propic\"");
            BeginWriteAttribute("src", " src=\"", 2856, "\"", 2880, 1);
#nullable restore
#line 78 "E:\MyWebApp\Views\Users\Details.cshtml"
WriteAttributeValue("", 2862, ViewBag.ImageData, 2862, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 81 "E:\MyWebApp\Views\Users\Details.cshtml"
                                     
                    }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <p class=\"proname\"> ");
#nullable restore
#line 84 "E:\MyWebApp\Views\Users\Details.cshtml"
                                   Write(Html.DisplayFor(model => model.users.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
        


            </div>


        </div>
    </div>
</div>

<div>

<div style=""margin-top: 40px;"">
<h3 class=""textstylei"">Problems Added By Me</h3>
<table class =""tableclass"" style=""width: 900px; height:auto;"">
    <tr>
        <th style=""padding: 15px"">
            Problem Name
        </th>
        <th style=""padding: 15px"">
            Tag
        </th>
        <th style=""padding: 15px"">
           Hint
        </th>
        <th style=""padding: 15px"">
           Added By
        </th>
        <th style=""padding: 15px"">
           Link
        </th>
         <th style=""padding: 15px"">
          
        </th>
    </tr>

");
#nullable restore
#line 122 "E:\MyWebApp\Views\Users\Details.cshtml"
     if(Model.AddProblems.Count()==0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>No problems found.</h4>\r\n");
#nullable restore
#line 125 "E:\MyWebApp\Views\Users\Details.cshtml"
    }
    else
    {
        foreach(var item in Model.AddProblems)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 132 "E:\MyWebApp\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 135 "E:\MyWebApp\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PTag));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 138 "E:\MyWebApp\Views\Users\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.PIdea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                           ");
#nullable restore
#line 141 "E:\MyWebApp\Views\Users\Details.cshtml"
                      Write(Html.DisplayFor(modelItem => item.PAddedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 4817, "\"", 4865, 1);
#nullable restore
#line 144 "E:\MyWebApp\Views\Users\Details.cshtml"
WriteAttributeValue("", 4824, Html.DisplayFor(modelItem => item.PLink), 4824, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" > Try to solve</a>\r\n                           \r\n                        </td>\r\n                        <td>\r\n                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b38bbfb348c97a8b2c2cd1c3183f4eaf5947162916062", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 148 "E:\MyWebApp\Views\Users\Details.cshtml"
                                                                               WriteLiteral(item.Pid);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 151 "E:\MyWebApp\Views\Users\Details.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n\r\n</div>\r\n    \r\n\r\n\r\n\r\n\r\n<div>\r\n    <div style=\"margin-top: 100px;\"></div>\r\n<h4  class=\"textstylei\">Resource Added By Me</h4>\r\n");
#nullable restore
#line 166 "E:\MyWebApp\Views\Users\Details.cshtml"
 if(Model.Resources !=null)
{
 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""tableclass"" style=""width: 800px;"" >
    <tr>
        <th  style=""padding: 15px""  >Topic</th>
        <th  style=""padding: 15px""  >Short Description</th>
        <th  style=""padding: 15px"" >Added By</th>
        <th  style=""padding: 15px"" >Details</th>
        <th  style=""padding: 15px""></th>

    </tr>
");
#nullable restore
#line 178 "E:\MyWebApp\Views\Users\Details.cshtml"
     foreach (Resource ps in Model.Resources)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr >\r\n            <td>");
#nullable restore
#line 181 "E:\MyWebApp\Views\Users\Details.cshtml"
           Write(ps.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 182 "E:\MyWebApp\Views\Users\Details.cshtml"
           Write(ps.ShortDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 183 "E:\MyWebApp\Views\Users\Details.cshtml"
           Write(ps.AddedBy);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b38bbfb348c97a8b2c2cd1c3183f4eaf5947162920245", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 185 "E:\MyWebApp\Views\Users\Details.cshtml"
                                                                             WriteLiteral(ps.RId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \r\n            </td>\r\n            <td>\r\n            \r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b38bbfb348c97a8b2c2cd1c3183f4eaf5947162922673", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 189 "E:\MyWebApp\Views\Users\Details.cshtml"
                                                                           WriteLiteral(ps.RId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr> \r\n");
#nullable restore
#line 192 "E:\MyWebApp\Views\Users\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 194 "E:\MyWebApp\Views\Users\Details.cshtml"

}

#line default
#line hidden
#nullable disable
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
