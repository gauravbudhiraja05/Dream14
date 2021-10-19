#pragma checksum "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "510ddd87928389027b18476240ff67fa2eea5cbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserList), @"mvc.1.0.view", @"/Views/Home/UserList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserList.cshtml", typeof(AspNetCore.Views_Home_UserList))]
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
#line 1 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\_ViewImports.cshtml"
using Dream14.WebAdmin;

#line default
#line hidden
#line 2 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\_ViewImports.cshtml"
using Dream14.WebAdmin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"510ddd87928389027b18476240ff67fa2eea5cbb", @"/Views/Home/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d66911b042d391ea5d66d7f3b135411b6a5ca4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dream14.ViewModels.FrontEnd.UserDetail>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/SuperAdmin/superAdmin.UserList.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
  
    ViewData["Title"] = "UserList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(153, 2597, true);
            WriteLiteral(@"
<div class=""top_filter_bar"">
    <div class=""center_wrap"">

        <div class=""top_filter_right"">


            <div class=""form_group"">
                <fieldset>
                    <input type=""text"" id=""txtSearchUserList"" class=""form-control"" placeholder=""Search"">
                    <input type=""button"" class=""search_btn"" value=""go"" />
                </fieldset>
            </div>
        </div>

    </div>
</div>
<!--End top_filter_bar-->


<div class=""full_width"">
    <div class=""center_wrap"">

        <div class=""content_wrap"">

            <div class=""page_heading"">
                <h1>User List </h1>
            </div>
            <!--End page_heading-->

            <div class=""table_wrap"">
                <table id=""tblUsers"" class=""table"">
                    <thead>
                        <tr>
                            <th style=""width: 70px;"">
                                <div class=""table_checkbox"">
                                    <input type=""c");
            WriteLiteral(@"heckbox"" id=""checkall"" class=""check_all"">
                                    <label for=""checkall"">Accept</label>
                                </div>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title active""><i class=""icon asc""></i> Name</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Mobile Number 1</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Mobile Number 2</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>City</button>
                            </th>
                            <th>
                                <button type=""button");
            WriteLiteral(@""" class=""table_title""><i class=""icon""></i>State</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Country</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Seen Status</button>
                            </th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 71 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
                         foreach (var user in Model)
                        {

#line default
#line hidden
            BeginContext(2831, 452, true);
            WriteLiteral(@"                            <tr>
                                <td style=""width: 70px;"">
                                    <div class=""table_checkbox"">
                                        <input type=""checkbox"" id=""checkitem1"" class=""check_item"">
                                        <label for=""checkitem1""></label>
                                    </div>
                                </td>
                                <td>");
            EndContext();
            BeginContext(3284, 9, false);
#line 80 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
                               Write(user.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3293, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3337, 18, false);
#line 81 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
                               Write(user.MobileNumber1);

#line default
#line hidden
            EndContext();
            BeginContext(3355, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3399, 18, false);
#line 82 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
                               Write(user.MobileNumber2);

#line default
#line hidden
            EndContext();
            BeginContext(3417, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3461, 9, false);
#line 83 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
                               Write(user.City);

#line default
#line hidden
            EndContext();
            BeginContext(3470, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3514, 10, false);
#line 84 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
                               Write(user.State);

#line default
#line hidden
            EndContext();
            BeginContext(3524, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(3568, 12, false);
#line 85 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
                               Write(user.Country);

#line default
#line hidden
            EndContext();
            BeginContext(3580, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 86 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
                                 if (!user.IsRead)
                                {

#line default
#line hidden
            BeginContext(3674, 93, true);
            WriteLiteral("                                    <td>\r\n                                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 3767, "\"", 3803, 3);
            WriteAttributeValue("", 3777, "ChangeUserStatus(", 3777, 17, true);
#line 89 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
WriteAttributeValue("", 3794, user.Id, 3794, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 3802, ")", 3802, 1, true);
            EndWriteAttribute();
            BeginContext(3804, 57, true);
            WriteLiteral(">Un-Seen</a>\r\n                                    </td>\r\n");
            EndContext();
#line 91 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(3969, 51, true);
            WriteLiteral("                                    <td>Seen</td>\r\n");
            EndContext();
#line 95 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
                                }

#line default
#line hidden
            BeginContext(4055, 35, true);
            WriteLiteral("                            </tr>\r\n");
            EndContext();
#line 97 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"

                        }

#line default
#line hidden
            BeginContext(4119, 232, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n\r\n\r\n\r\n        </div>\r\n        <!--End content_wrap-->\r\n\r\n\r\n\r\n    </div>\r\n    <!--End center_wrap-->\r\n\r\n</div>\r\n<!--End full_width-->\r\n<!--Modal Popup-->\r\n");
            EndContext();
            BeginContext(4351, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "902dc3fee60846bdbae2c7f3f39a8431", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 117 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Home\UserList.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4439, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dream14.ViewModels.FrontEnd.UserDetail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
