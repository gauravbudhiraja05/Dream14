#pragma checksum "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdd019fe16404b3ee9b08f511e1f81a32392e479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_AgentUsers), @"mvc.1.0.view", @"/Views/SuperAdmin/AgentUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/AgentUsers.cshtml", typeof(AspNetCore.Views_SuperAdmin_AgentUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdd019fe16404b3ee9b08f511e1f81a32392e479", @"/Views/SuperAdmin/AgentUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d66911b042d391ea5d66d7f3b135411b6a5ca4e", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_AgentUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dream14.ViewModels.SuperAdmin.AgentUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/SuperAdmin/superAdmin.agentUsers.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
  
    ViewData["Title"] = "Agent Users";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(155, 163, true);
            WriteLiteral("\r\n<div class=\"top_filter_bar\">\r\n    <div class=\"center_wrap\">\r\n\r\n        <div class=\"top_filter_left\">\r\n            <button type=\"button\" class=\"add_new_list_item\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 318, "\"", 391, 3);
            WriteAttributeValue("", 328, "window.location.href=\'", 328, 22, true);
#line 11 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
WriteAttributeValue("", 350, Url.Action("AddAgentUser","SuperAdmin"), 350, 40, false);

#line default
#line hidden
            WriteAttributeValue("", 390, "\'", 390, 1, true);
            EndWriteAttribute();
            BeginContext(392, 3348, true);
            WriteLiteral(@">Add new</button>
        </div>

        <div class=""top_filter_right"">


            <div class=""form_group"">
                <fieldset>
                    <input type=""text"" id=""txtSearchAgentList"" class=""form-control"" placeholder=""Search"">
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
                <h1>Agent User List </h1>
            </div>
            <!--End page_heading-->

            <div class=""table_wrap"">
                <table id=""tblAgents"" class=""table"">
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
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Limit</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Mobile Number</button>
                            </th>
                            <th>
                                <button type=""button"" class=""table_title""><i cla");
            WriteLiteral(@"ss=""icon""></i>Balance</button>
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
                                <button type=""button"" class=""table_title""><i class=""icon""></i>BetLock Status</button>
                            </th>
                            <th c");
            WriteLiteral(@"lass=""editEndUser"" style=""width:75px;text-align: center;"">Edit</th>
                            <th class=""editEndUser"" style=""width:75px;text-align: center;"">Deposit / WithDrawl</th>
                        </tr>
                    </thead>
                    <tbody>
");
            EndContext();
#line 85 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                         foreach (var agent in Model)
                        {

#line default
#line hidden
            BeginContext(3822, 452, true);
            WriteLiteral(@"                            <tr>
                                <td style=""width: 70px;"">
                                    <div class=""table_checkbox"">
                                        <input type=""checkbox"" id=""checkitem1"" class=""check_item"">
                                        <label for=""checkitem1""></label>
                                    </div>
                                </td>
                                <td>");
            EndContext();
            BeginContext(4275, 10, false);
#line 94 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                               Write(agent.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4285, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4329, 14, false);
#line 95 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                               Write(agent.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(4343, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4387, 11, false);
#line 96 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                               Write(agent.Limit);

#line default
#line hidden
            EndContext();
            BeginContext(4398, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4442, 18, false);
#line 97 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                               Write(agent.MobileNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4460, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4504, 13, false);
#line 98 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                               Write(agent.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(4517, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4561, 13, false);
#line 99 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                               Write(agent.Deposit);

#line default
#line hidden
            EndContext();
            BeginContext(4574, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4618, 15, false);
#line 100 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                               Write(agent.WithDrawl);

#line default
#line hidden
            EndContext();
            BeginContext(4633, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(4677, 16, false);
#line 101 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                               Write(agent.ProfitLoss);

#line default
#line hidden
            EndContext();
            BeginContext(4693, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 102 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                                 if (agent.IsActive)
                                {

#line default
#line hidden
            BeginContext(4789, 93, true);
            WriteLiteral("                                    <td>\r\n                                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4882, "\"", 4941, 3);
            WriteAttributeValue("", 4892, "ChangeAgentUserStatus(\'InActive\',\'", 4892, 34, true);
#line 105 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
WriteAttributeValue("", 4926, agent.UserId, 4926, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 4939, "\')", 4939, 2, true);
            EndWriteAttribute();
            BeginContext(4942, 56, true);
            WriteLiteral(">Active</a>\r\n                                    </td>\r\n");
            EndContext();
#line 107 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(5106, 93, true);
            WriteLiteral("                                    <td>\r\n                                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5199, "\"", 5256, 3);
            WriteAttributeValue("", 5209, "ChangeAgentUserStatus(\'Active\',\'", 5209, 32, true);
#line 111 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
WriteAttributeValue("", 5241, agent.UserId, 5241, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 5254, "\')", 5254, 2, true);
            EndWriteAttribute();
            BeginContext(5257, 58, true);
            WriteLiteral(">InActive</a>\r\n                                    </td>\r\n");
            EndContext();
#line 113 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                                }

#line default
#line hidden
            BeginContext(5350, 32, true);
            WriteLiteral("                                ");
            EndContext();
#line 114 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                                 if (agent.IsBetLock)
                                {

#line default
#line hidden
            BeginContext(5440, 93, true);
            WriteLiteral("                                    <td>\r\n                                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5533, "\"", 5592, 3);
            WriteAttributeValue("", 5543, "ChangeAgentUserStatus(\'UnLocked\',\'", 5543, 34, true);
#line 117 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
WriteAttributeValue("", 5577, agent.UserId, 5577, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 5590, "\')", 5590, 2, true);
            EndWriteAttribute();
            BeginContext(5593, 56, true);
            WriteLiteral(">Locked</a>\r\n                                    </td>\r\n");
            EndContext();
#line 119 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(5757, 93, true);
            WriteLiteral("                                    <td>\r\n                                        <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5850, "\"", 5907, 3);
            WriteAttributeValue("", 5860, "ChangeAgentUserStatus(\'Locked\',\'", 5860, 32, true);
#line 123 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
WriteAttributeValue("", 5892, agent.UserId, 5892, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 5905, "\')", 5905, 2, true);
            EndWriteAttribute();
            BeginContext(5908, 58, true);
            WriteLiteral(">UnLocked</a>\r\n                                    </td>\r\n");
            EndContext();
#line 125 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
                                }

#line default
#line hidden
            BeginContext(6001, 152, true);
            WriteLiteral("                                <td style=\"width:75px;text-align: center;\">\r\n                                    <button type=\"button\" class=\"edit_item\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 6153, "\"", 6250, 3);
            WriteAttributeValue("", 6163, "window.location.href=\'", 6163, 22, true);
#line 127 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
WriteAttributeValue("", 6185, Url.Action("EditAgentUser","SuperAdmin",new { Id=agent.UserId}), 6185, 64, false);

#line default
#line hidden
            WriteAttributeValue("", 6249, "\'", 6249, 1, true);
            EndWriteAttribute();
            BeginContext(6251, 210, true);
            WriteLiteral(">edit</button>\r\n                                </td>\r\n                                <td style=\"width:75px;text-align: center;\">\r\n                                    <button type=\"button\" class=\"deposit_item\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6461, "\"", 6504, 3);
            WriteAttributeValue("", 6471, "OpenOperationPopUp(", 6471, 19, true);
#line 130 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
WriteAttributeValue("", 6490, agent.UserId, 6490, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 6503, ")", 6503, 1, true);
            EndWriteAttribute();
            BeginContext(6505, 103, true);
            WriteLiteral(">Deposit/WithDrawl</button>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 133 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"

                        }

#line default
#line hidden
            BeginContext(6637, 232, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n\r\n\r\n\r\n        </div>\r\n        <!--End content_wrap-->\r\n\r\n\r\n\r\n    </div>\r\n    <!--End center_wrap-->\r\n\r\n</div>\r\n<!--End full_width-->\r\n<!--Modal Popup-->\r\n");
            EndContext();
            BeginContext(6869, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f60c78bb0b44cbabcc55ddef0bb6f2e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 153 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AgentUsers.cshtml"
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
            BeginContext(6959, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dream14.ViewModels.SuperAdmin.AgentUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
