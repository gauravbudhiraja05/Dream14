#pragma checksum "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b06d1149a051223a1730123a0820870eeed39cfb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_AdminUsers), @"mvc.1.0.view", @"/Views/SuperAdmin/AdminUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/AdminUsers.cshtml", typeof(AspNetCore.Views_SuperAdmin_AdminUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06d1149a051223a1730123a0820870eeed39cfb", @"/Views/SuperAdmin/AdminUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d66911b042d391ea5d66d7f3b135411b6a5ca4e", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_AdminUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dream14.ViewModels.SuperAdmin.AdminUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/SuperAdmin/superAdmin.adminUsers.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
  
    ViewData["Title"] = "Admin Users";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 163, true);
            WriteLiteral("\r\n<div class=\"top_filter_bar\">\r\n    <div class=\"center_wrap\">\r\n\r\n        <div class=\"top_filter_left\">\r\n            <button type=\"button\" class=\"add_new_list_item\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 318, "\"", 391, 3);
            WriteAttributeValue("", 328, "window.location.href=\'", 328, 22, true);
#line 11 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
WriteAttributeValue("", 350, Url.Action("AddAdminUser","SuperAdmin"), 350, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 390, "\'", 390, 1, true);
            EndWriteAttribute();
            BeginContext(392, 3530, true);
            WriteLiteral(@">Add new</button>
        </div>

        <div class=""top_filter_right"">


            <div class=""form_group"">
                <fieldset>
                    <input type=""text"" id=""txtSearchAdminList"" class=""form-control"" placeholder=""Search"">
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
                <h1>Admin User List </h1>
            </div>
            <!--End page_heading-->

            <div class=""table_wrap"">
                <table id=""tblAdmins"" class=""table"">
                    <thead>
                        <tr>
                            <th style=""width: 70px;"">
                                <div class=""table_checkbox"">
                                    <input type=""checkbox"" id=""checkal");
            WriteLiteral(@"l"" class=""check_all"">
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
                                <button type=""button"" class=""table_title""><i class=""i");
            WriteLiteral(@"con""></i>Mobile Number</button>
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
                            <th>
     ");
            WriteLiteral(@"                           <button type=""button"" class=""table_title""><i class=""icon""></i>BetLock Status</button>
                            </th>
                            <th class=""editEndUser"" style=""width:75px;text-align: center;"">Edit</th>
                            <th class=""editEndUser"" style=""width:75px;text-align: center;"">Deposit / WithDrawl</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 88 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                         foreach (var admin in Model)
                        {

#line default
#line hidden
            BeginContext(4004, 452, true);
            WriteLiteral(@"                            <tr>
                                <td style=""width: 70px;"">
                                    <div class=""table_checkbox"">
                                        <input type=""checkbox"" id=""checkitem1"" class=""check_item"">
                                        <label for=""checkitem1""></label>
                                    </div>
                                </td>
                                <td>");
            EndContext();
            BeginContext(4457, 10, false);
#line 97 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                               Write(admin.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4467, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4511, 14, false);
#line 98 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                               Write(admin.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(4525, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4569, 14, false);
#line 99 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                               Write(admin.UserType);

#line default
#line hidden
            EndContext();
            BeginContext(4583, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4627, 11, false);
#line 100 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                               Write(admin.Limit);

#line default
#line hidden
            EndContext();
            BeginContext(4638, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4682, 18, false);
#line 101 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                               Write(admin.MobileNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4700, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4744, 13, false);
#line 102 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                               Write(admin.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(4757, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4801, 13, false);
#line 103 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                               Write(admin.Deposit);

#line default
#line hidden
            EndContext();
            BeginContext(4814, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4858, 15, false);
#line 104 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                               Write(admin.WithDrawl);

#line default
#line hidden
            EndContext();
            BeginContext(4873, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4917, 16, false);
#line 105 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                               Write(admin.ProfitLoss);

#line default
#line hidden
            EndContext();
            BeginContext(4933, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 106 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                                 if (admin.IsActive)
                                {

#line default
#line hidden
            BeginContext(5029, 93, true);
            WriteLiteral("                                    <td>\r\n                                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5122, "\"", 5181, 3);
            WriteAttributeValue("", 5132, "ChangeAdminUserStatus(\'InActive\',\'", 5132, 34, true);
#line 109 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
WriteAttributeValue("", 5166, admin.UserId, 5166, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 5179, "\')", 5179, 2, true);
            EndWriteAttribute();
            BeginContext(5182, 56, true);
            WriteLiteral(">Active</a>\r\n                                    </td>\r\n");
            EndContext();
#line 111 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(5346, 93, true);
            WriteLiteral("                                    <td>\r\n                                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5439, "\"", 5496, 3);
            WriteAttributeValue("", 5449, "ChangeAdminUserStatus(\'Active\',\'", 5449, 32, true);
#line 115 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
WriteAttributeValue("", 5481, admin.UserId, 5481, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 5494, "\')", 5494, 2, true);
            EndWriteAttribute();
            BeginContext(5497, 58, true);
            WriteLiteral(">InActive</a>\r\n                                    </td>\r\n");
            EndContext();
#line 117 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                                }

#line default
#line hidden
            BeginContext(5590, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 118 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                                 if (admin.IsBetLock)
                                {

#line default
#line hidden
            BeginContext(5680, 93, true);
            WriteLiteral("                                    <td>\r\n                                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5773, "\"", 5832, 3);
            WriteAttributeValue("", 5783, "ChangeAdminUserStatus(\'UnLocked\',\'", 5783, 34, true);
#line 121 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
WriteAttributeValue("", 5817, admin.UserId, 5817, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 5830, "\')", 5830, 2, true);
            EndWriteAttribute();
            BeginContext(5833, 56, true);
            WriteLiteral(">Locked</a>\r\n                                    </td>\r\n");
            EndContext();
#line 123 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(5997, 93, true);
            WriteLiteral("                                    <td>\r\n                                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6090, "\"", 6147, 3);
            WriteAttributeValue("", 6100, "ChangeAdminUserStatus(\'Locked\',\'", 6100, 32, true);
#line 127 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
WriteAttributeValue("", 6132, admin.UserId, 6132, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 6145, "\')", 6145, 2, true);
            EndWriteAttribute();
            BeginContext(6148, 58, true);
            WriteLiteral(">UnLocked</a>\r\n                                    </td>\r\n");
            EndContext();
#line 129 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
                                }

#line default
#line hidden
            BeginContext(6241, 152, true);
            WriteLiteral("                                <td style=\"width:75px;text-align: center;\">\r\n                                    <button type=\"button\" class=\"edit_item\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 6393, "\"", 6491, 3);
            WriteAttributeValue("", 6403, "window.location.href=\'", 6403, 22, true);
#line 131 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
WriteAttributeValue("", 6425, Url.Action("EditAdminUser","SuperAdmin", new { Id=admin.UserId}), 6425, 65, false);

#line default
#line hidden
            WriteAttributeValue("", 6490, "\'", 6490, 1, true);
            EndWriteAttribute();
            BeginContext(6492, 210, true);
            WriteLiteral(">edit</button>\r\n                                </td>\r\n                                <td style=\"width:75px;text-align: center;\">\r\n                                    <button type=\"button\" class=\"deposit_item\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6702, "\"", 6745, 3);
            WriteAttributeValue("", 6712, "OpenOperationPopUp(", 6712, 19, true);
#line 134 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
WriteAttributeValue("", 6731, admin.UserId, 6731, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 6744, ")", 6744, 1, true);
            EndWriteAttribute();
            BeginContext(6746, 103, true);
            WriteLiteral(">Deposit/WithDrawl</button>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 137 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"

                        }

#line default
#line hidden
            BeginContext(6878, 232, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n\r\n\r\n\r\n        </div>\r\n        <!--End content_wrap-->\r\n\r\n\r\n\r\n    </div>\r\n    <!--End center_wrap-->\r\n\r\n</div>\r\n<!--End full_width-->\r\n<!--Modal Popup-->\r\n");
            EndContext();
            BeginContext(7110, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2265fd86ae64e4183451ed4b9b4e2e5", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 157 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AdminUsers.cshtml"
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
            BeginContext(7200, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dream14.ViewModels.SuperAdmin.AdminUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
