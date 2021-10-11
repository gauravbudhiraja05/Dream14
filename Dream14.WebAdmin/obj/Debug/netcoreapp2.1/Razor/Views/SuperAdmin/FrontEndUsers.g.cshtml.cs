#pragma checksum "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "007d10c97e327236ddbc1d13223731682508ee9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_FrontEndUsers), @"mvc.1.0.view", @"/Views/SuperAdmin/FrontEndUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/FrontEndUsers.cshtml", typeof(AspNetCore.Views_SuperAdmin_FrontEndUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"007d10c97e327236ddbc1d13223731682508ee9b", @"/Views/SuperAdmin/FrontEndUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d66911b042d391ea5d66d7f3b135411b6a5ca4e", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_FrontEndUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dream14.ViewModels.SuperAdmin.FrontEndUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/SuperAdmin/superAdmin.frontEndUsers.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
  
	ViewData["Title"] = "FrontEnd Users";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 163, true);
            WriteLiteral("\r\n<div class=\"top_filter_bar\">\r\n    <div class=\"center_wrap\">\r\n\r\n        <div class=\"top_filter_left\">\r\n            <button type=\"button\" class=\"add_new_list_item\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 318, "\"", 394, 3);
            WriteAttributeValue("", 328, "window.location.href=\'", 328, 22, true);
#line 11 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
WriteAttributeValue("", 350, Url.Action("AddFrontEndUser","SuperAdmin"), 350, 43, false);

#line default
#line hidden
            WriteAttributeValue("", 393, "\'", 393, 1, true);
            EndWriteAttribute();
            BeginContext(395, 3541, true);
            WriteLiteral(@">Add new</button>
        </div>

        <div class=""top_filter_right"">


            <div class=""form_group"">
                <fieldset>
                    <input type=""text"" id=""txtSearchFrontEndList"" class=""form-control"" placeholder=""Search"">
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
                <h1>FrontEnd User List </h1>
            </div>
            <!--End page_heading-->

            <div class=""table_wrap"">
                <table id=""tblFrontEnds"" class=""table"">
                    <thead>
                        <tr>
                            <th style=""width: 70px;"">
                                <div class=""table_checkbox"">
                                    <input type=""checkbox"" id");
            WriteLiteral(@"=""checkall"" class=""check_all"">
                                    <label for=""checkall"">Accept</label>
                                </div>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title active""><i class=""icon asc""></i> Name</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>UserName</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>UserType</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Limit</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i");
            WriteLiteral(@" class=""icon""></i>Mobile Number</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Balance</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Deposit</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Withdrawl</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Profit/Loss</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Active Status</button>
                            </th>
                            <t");
            WriteLiteral(@"h>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>BetLock Status</button>
                            </th>
                            <th class=""editEndUser"" style=""width:75px;text-align: center;"">Edit</th>
                            <th class=""editEndUser"" style=""width:75px;text-align: center;"">Deposit / WithDrawl</th>

                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 89 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                         foreach (var frontEnd in Model)
						{

#line default
#line hidden
            BeginContext(4003, 420, true);
            WriteLiteral(@"                        <tr>
                            <td style=""width: 70px;"">
                                <div class=""table_checkbox"">
                                    <input type=""checkbox"" id=""checkitem1"" class=""check_item"">
                                    <label for=""checkitem1""></label>
                                </div>
                            </td>
                            <td>");
            EndContext();
            BeginContext(4424, 13, false);
#line 98 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                           Write(frontEnd.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4437, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4477, 17, false);
#line 99 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                           Write(frontEnd.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(4494, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4534, 17, false);
#line 100 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                           Write(frontEnd.UserType);

#line default
#line hidden
            EndContext();
            BeginContext(4551, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4591, 14, false);
#line 101 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                           Write(frontEnd.Limit);

#line default
#line hidden
            EndContext();
            BeginContext(4605, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4645, 21, false);
#line 102 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                           Write(frontEnd.MobileNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4666, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4706, 16, false);
#line 103 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                           Write(frontEnd.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(4722, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4762, 16, false);
#line 104 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                           Write(frontEnd.Deposit);

#line default
#line hidden
            EndContext();
            BeginContext(4778, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4818, 18, false);
#line 105 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                           Write(frontEnd.WithDrawl);

#line default
#line hidden
            EndContext();
            BeginContext(4836, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4876, 19, false);
#line 106 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                           Write(frontEnd.ProfitLoss);

#line default
#line hidden
            EndContext();
            BeginContext(4895, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 107 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                             if (frontEnd.IsActive)
                            {

#line default
#line hidden
            BeginContext(4986, 85, true);
            WriteLiteral("                                <td>\r\n                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5071, "\"", 5136, 3);
            WriteAttributeValue("", 5081, "ChangeFrontEndUserStatus(\'InActive\',\'", 5081, 37, true);
#line 110 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
WriteAttributeValue("", 5118, frontEnd.UserId, 5118, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 5134, "\')", 5134, 2, true);
            EndWriteAttribute();
            BeginContext(5137, 52, true);
            WriteLiteral(">Active</a>\r\n                                </td>\r\n");
            EndContext();
#line 112 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5285, 85, true);
            WriteLiteral("                                <td>\r\n                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5370, "\"", 5433, 3);
            WriteAttributeValue("", 5380, "ChangeFrontEndUserStatus(\'Active\',\'", 5380, 35, true);
#line 116 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
WriteAttributeValue("", 5415, frontEnd.UserId, 5415, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 5431, "\')", 5431, 2, true);
            EndWriteAttribute();
            BeginContext(5434, 54, true);
            WriteLiteral(">InActive</a>\r\n                                </td>\r\n");
            EndContext();
#line 118 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                            }

#line default
#line hidden
            BeginContext(5519, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 119 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                             if (frontEnd.IsBetLock)
                            {

#line default
#line hidden
            BeginContext(5604, 85, true);
            WriteLiteral("                                <td>\r\n                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5689, "\"", 5754, 3);
            WriteAttributeValue("", 5699, "ChangeFrontEndUserStatus(\'UnLocked\',\'", 5699, 37, true);
#line 122 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
WriteAttributeValue("", 5736, frontEnd.UserId, 5736, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 5752, "\')", 5752, 2, true);
            EndWriteAttribute();
            BeginContext(5755, 52, true);
            WriteLiteral(">Locked</a>\r\n                                </td>\r\n");
            EndContext();
#line 124 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5903, 85, true);
            WriteLiteral("                                <td>\r\n                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5988, "\"", 6051, 3);
            WriteAttributeValue("", 5998, "ChangeFrontEndUserStatus(\'Locked\',\'", 5998, 35, true);
#line 128 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
WriteAttributeValue("", 6033, frontEnd.UserId, 6033, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 6049, "\')", 6049, 2, true);
            EndWriteAttribute();
            BeginContext(6052, 54, true);
            WriteLiteral(">UnLocked</a>\r\n                                </td>\r\n");
            EndContext();
#line 130 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
                            }

#line default
#line hidden
            BeginContext(6137, 144, true);
            WriteLiteral("                            <td style=\"width:75px;text-align: center;\">\r\n                                <button type=\"button\" class=\"edit_item\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 6281, "\"", 6384, 3);
            WriteAttributeValue("", 6291, "window.location.href=\'", 6291, 22, true);
#line 132 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
WriteAttributeValue("", 6313, Url.Action("EditFrontEndUser","SuperAdmin",new { Id=frontEnd.UserId}), 6313, 70, false);

#line default
#line hidden
            WriteAttributeValue("", 6383, "\'", 6383, 1, true);
            EndWriteAttribute();
            BeginContext(6385, 198, true);
            WriteLiteral(">edit</button>\r\n                            </td>\r\n                            <td style=\"width:75px;text-align: center;\">\r\n                                <button type=\"button\" class=\"deposit_item\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6583, "\"", 6629, 3);
            WriteAttributeValue("", 6593, "OpenOperationPopUp(", 6593, 19, true);
#line 135 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
WriteAttributeValue("", 6612, frontEnd.UserId, 6612, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 6628, ")", 6628, 1, true);
            EndWriteAttribute();
            BeginContext(6630, 95, true);
            WriteLiteral(">Deposit/WithDrawl</button>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 138 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"

						}

#line default
#line hidden
            BeginContext(6736, 232, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n\r\n\r\n\r\n        </div>\r\n        <!--End content_wrap-->\r\n\r\n\r\n\r\n    </div>\r\n    <!--End center_wrap-->\r\n\r\n</div>\r\n<!--End full_width-->\r\n<!--Modal Popup-->\r\n");
            EndContext();
            BeginContext(6968, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c61d16b5703f474eb2290fc6279379dc", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 158 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\FrontEndUsers.cshtml"
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
            BeginContext(7061, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dream14.ViewModels.SuperAdmin.FrontEndUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
