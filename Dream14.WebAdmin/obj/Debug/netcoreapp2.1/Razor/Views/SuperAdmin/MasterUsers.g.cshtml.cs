#pragma checksum "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94988067f2768f7515bc75343966aed7b6e97f10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_MasterUsers), @"mvc.1.0.view", @"/Views/SuperAdmin/MasterUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/MasterUsers.cshtml", typeof(AspNetCore.Views_SuperAdmin_MasterUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94988067f2768f7515bc75343966aed7b6e97f10", @"/Views/SuperAdmin/MasterUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d66911b042d391ea5d66d7f3b135411b6a5ca4e", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_MasterUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dream14.ViewModels.SuperAdmin.MasterUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/SuperAdmin/superAdmin.masterUsers.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
  
	ViewData["Title"] = "Master Users";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 145, true);
            WriteLiteral("\r\n<div class=\"top_filter_bar\">\r\n\t<div class=\"center_wrap\">\r\n\r\n\t\t<div class=\"top_filter_left\">\r\n\t\t\t<button type=\"button\" class=\"add_new_list_item\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 296, "\"", 370, 3);
            WriteAttributeValue("", 306, "window.location.href=\'", 306, 22, true);
#line 11 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
WriteAttributeValue("", 328, Url.Action("AddMasterUser","SuperAdmin"), 328, 41, false);

#line default
#line hidden
            WriteAttributeValue("", 369, "\'", 369, 1, true);
            EndWriteAttribute();
            BeginContext(371, 3156, true);
            WriteLiteral(@">Add new</button>
		</div>

		<div class=""top_filter_right"">


			<div class=""form_group"">
				<fieldset>
					<input type=""text"" id=""txtSearchMasterList"" class=""form-control"" placeholder=""Search"">
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
                <h1>Master User List </h1>
			</div>
			<!--End page_heading-->

			<div class=""table_wrap"">
				<table id=""tblMasters"" class=""table"">
					<thead>
                        <tr>
                            <th style=""width: 70px;"">
                                <div class=""table_checkbox"">
                                    <input type=""checkbox"" id=""checkall"" class=""check_all"">
                                    <label for=""checkall"">Accept</label>
                                </div>
                         ");
            WriteLiteral(@"   </th>
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
                                <button type=""button"" class=""table_title""><i class=""icon""></i>Balance</button>
                            </th>
                            <th>
                                <button type=""button"" class=""");
            WriteLiteral(@"table_title""><i class=""icon""></i>Deposit</button>
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
                            <th class=""editEndUser"" style=""width:75px;text-align: center;"">Edit</th>
                            <th class=""editEndUser"" style=""width:75px;text-align: center;"">De");
            WriteLiteral("posit / WithDrawl</th>\r\n                        </tr>\r\n\t\t\t\t\t</thead>\r\n\t\t\t\t\t<tbody>\r\n");
            EndContext();
#line 85 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                         foreach (var master in Model)
						{

#line default
#line hidden
            BeginContext(3574, 420, true);
            WriteLiteral(@"                        <tr>
                            <td style=""width: 70px;"">
                                <div class=""table_checkbox"">
                                    <input type=""checkbox"" id=""checkitem1"" class=""check_item"">
                                    <label for=""checkitem1""></label>
                                </div>
                            </td>
                            <td>");
            EndContext();
            BeginContext(3995, 11, false);
#line 94 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                           Write(master.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4006, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4046, 15, false);
#line 95 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                           Write(master.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(4061, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4101, 12, false);
#line 96 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                           Write(master.Limit);

#line default
#line hidden
            EndContext();
            BeginContext(4113, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4153, 19, false);
#line 97 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                           Write(master.MobileNumber);

#line default
#line hidden
            EndContext();
            BeginContext(4172, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4212, 14, false);
#line 98 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                           Write(master.Balance);

#line default
#line hidden
            EndContext();
            BeginContext(4226, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4266, 14, false);
#line 99 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                           Write(master.Deposit);

#line default
#line hidden
            EndContext();
            BeginContext(4280, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4320, 16, false);
#line 100 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                           Write(master.WithDrawl);

#line default
#line hidden
            EndContext();
            BeginContext(4336, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(4376, 17, false);
#line 101 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                           Write(master.ProfitLoss);

#line default
#line hidden
            EndContext();
            BeginContext(4393, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 102 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                             if (master.IsActive)
                            {

#line default
#line hidden
            BeginContext(4482, 85, true);
            WriteLiteral("                                <td>\r\n                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4567, "\"", 4628, 3);
            WriteAttributeValue("", 4577, "ChangeMasterUserStatus(\'InActive\',\'", 4577, 35, true);
#line 105 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
WriteAttributeValue("", 4612, master.UserId, 4612, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 4626, "\')", 4626, 2, true);
            EndWriteAttribute();
            BeginContext(4629, 52, true);
            WriteLiteral(">Active</a>\r\n                                </td>\r\n");
            EndContext();
#line 107 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(4777, 85, true);
            WriteLiteral("                                <td>\r\n                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4862, "\"", 4921, 3);
            WriteAttributeValue("", 4872, "ChangeMasterUserStatus(\'Active\',\'", 4872, 33, true);
#line 111 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
WriteAttributeValue("", 4905, master.UserId, 4905, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 4919, "\')", 4919, 2, true);
            EndWriteAttribute();
            BeginContext(4922, 54, true);
            WriteLiteral(">InActive</a>\r\n                                </td>\r\n");
            EndContext();
#line 113 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                            }

#line default
#line hidden
            BeginContext(5007, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 114 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                             if (master.IsBetLock)
                            {

#line default
#line hidden
            BeginContext(5090, 85, true);
            WriteLiteral("                                <td>\r\n                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5175, "\"", 5236, 3);
            WriteAttributeValue("", 5185, "ChangeMasterUserStatus(\'UnLocked\',\'", 5185, 35, true);
#line 117 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
WriteAttributeValue("", 5220, master.UserId, 5220, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 5234, "\')", 5234, 2, true);
            EndWriteAttribute();
            BeginContext(5237, 52, true);
            WriteLiteral(">Locked</a>\r\n                                </td>\r\n");
            EndContext();
#line 119 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(5385, 85, true);
            WriteLiteral("                                <td>\r\n                                    <a href=\"#\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5470, "\"", 5529, 3);
            WriteAttributeValue("", 5480, "ChangeMasterUserStatus(\'Locked\',\'", 5480, 33, true);
#line 123 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
WriteAttributeValue("", 5513, master.UserId, 5513, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 5527, "\')", 5527, 2, true);
            EndWriteAttribute();
            BeginContext(5530, 54, true);
            WriteLiteral(">UnLocked</a>\r\n                                </td>\r\n");
            EndContext();
#line 125 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
                            }

#line default
#line hidden
            BeginContext(5615, 144, true);
            WriteLiteral("                            <td style=\"width:75px;text-align: center;\">\r\n                                <button type=\"button\" class=\"edit_item\"");
            EndContext();
            BeginWriteAttribute("onClick", " onClick=\"", 5759, "\"", 5858, 3);
            WriteAttributeValue("", 5769, "window.location.href=\'", 5769, 22, true);
#line 127 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
WriteAttributeValue("", 5791, Url.Action("EditMasterUser","SuperAdmin",new { Id=master.UserId}), 5791, 66, false);

#line default
#line hidden
            WriteAttributeValue("", 5857, "\'", 5857, 1, true);
            EndWriteAttribute();
            BeginContext(5859, 198, true);
            WriteLiteral(">edit</button>\r\n                            </td>\r\n                            <td style=\"width:75px;text-align: center;\">\r\n                                <button type=\"button\" class=\"deposit_item\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6057, "\"", 6101, 3);
            WriteAttributeValue("", 6067, "OpenOperationPopUp(", 6067, 19, true);
#line 130 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
WriteAttributeValue("", 6086, master.UserId, 6086, 14, false);

#line default
#line hidden
            WriteAttributeValue("", 6100, ")", 6100, 1, true);
            EndWriteAttribute();
            BeginContext(6102, 95, true);
            WriteLiteral(">Deposit/WithDrawl</button>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 133 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"

						}

#line default
#line hidden
            BeginContext(6208, 178, true);
            WriteLiteral("\t\t\t\t\t</tbody>\r\n\t\t\t\t</table>\r\n\t\t\t</div>\r\n\r\n\r\n\r\n\r\n\t\t</div>\r\n\t\t<!--End content_wrap-->\r\n\r\n\r\n\r\n\t</div>\r\n\t<!--End center_wrap-->\r\n\r\n</div>\r\n<!--End full_width-->\r\n<!--Modal Popup-->\r\n");
            EndContext();
            BeginContext(6386, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ac1a2a05a2841028357144757d4140d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 153 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\MasterUsers.cshtml"
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
            BeginContext(6477, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dream14.ViewModels.SuperAdmin.MasterUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
