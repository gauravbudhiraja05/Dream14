#pragma checksum "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EditAdminUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1bca87b43f0f7ee1752280c58c4c1a4aae6d529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_EditAdminUser), @"mvc.1.0.view", @"/Views/SuperAdmin/EditAdminUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/EditAdminUser.cshtml", typeof(AspNetCore.Views_SuperAdmin_EditAdminUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1bca87b43f0f7ee1752280c58c4c1a4aae6d529", @"/Views/SuperAdmin/EditAdminUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d66911b042d391ea5d66d7f3b135411b6a5ca4e", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_EditAdminUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dream14.ViewModels.SuperAdmin.AdminUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAdmin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formAdmin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/SuperAdmin/superAdmin.editAdminUser.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EditAdminUser.cshtml"
  
    ViewData["Title"] = "Edit Admin User";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(146, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(148, 4413, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1517dd8db5f342baaf80df1c68cd19b1", async() => {
                BeginContext(186, 117, true);
                WriteLiteral("\r\n    <div class=\"tab_menu\">\r\n        <div class=\"center_wrap\">\r\n\r\n            <button type=\"button\" class=\"back_btn\"");
                EndContext();
                BeginWriteAttribute("onClick", " onClick=\"", 303, "\"", 374, 3);
                WriteAttributeValue("", 313, "window.location.href=\'", 313, 22, true);
#line 11 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EditAdminUser.cshtml"
WriteAttributeValue("", 335, Url.Action("AdminUsers","SuperAdmin"), 335, 38, false);

#line default
#line hidden
                WriteAttributeValue("", 373, "\'", 373, 1, true);
                EndWriteAttribute();
                BeginContext(375, 958, true);
                WriteLiteral(@">Back</button>

            <ul class=""tab_list"">
                <li class=""current""><a href=""#tab_1"">Admin User Details</a></li>
            </ul>

            <button type=""button"" id=""Update_Admin_Btn"" class=""btn_field tab_save"">Save</button>

        </div>
    </div>
    <!--End tab_menu-->

    <div class=""full_width"">
        <div class=""center_wrap"">

            <div class=""content_wrap"">

                <div class=""page_heading"">
                    <h1>Update Admin User</h1>
                </div>
                <!--End page_heading-->

                <div class=""form_wrap"">

                    <div class=""tab_content"" id=""tab_1"">

                        <div class=""form_fields_box"">
                            <fieldset>
                                <div class=""form_field"">
                                    <label for=""Id"">User Id</label>
                                    <input type=""text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1333, "\"", 1354, 1);
#line 41 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EditAdminUser.cshtml"
WriteAttributeValue("", 1341, Model.UserId, 1341, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1355, 80, true);
                WriteLiteral(" disabled>\r\n                                    <input type=\"hidden\" id=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1435, "\"", 1456, 1);
#line 42 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EditAdminUser.cshtml"
WriteAttributeValue("", 1443, Model.UserId, 1443, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1457, 467, true);
                WriteLiteral(@" />
                                </div>
                                <div class=""form_field"">
                                    <label for=""Name"">
                                        Name*
                                        <small class=""info_icon"" data-toggle=""tooltip"" data-placement=""right"" title=""(Required) Department Name."">Tooltip</small>
                                    </label>
                                    <input id=""Name""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1924, "\"", 1943, 1);
#line 49 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EditAdminUser.cshtml"
WriteAttributeValue("", 1932, Model.Name, 1932, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1944, 609, true);
                WriteLiteral(@" type=""text"">
                                    <span class=""error_label"" id=""Name_Error""></span>
                                </div>

                                <div class=""form_field"">
                                    <label for=""UserName"">
                                        UserName*
                                        <small class=""info_icon"" data-toggle=""tooltip"" data-placement=""right"" title=""(Required) Enter the main phone number for the department."">Tooltip</small>
                                    </label>
                                    <input id=""UserName""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2553, "\"", 2576, 1);
#line 58 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EditAdminUser.cshtml"
WriteAttributeValue("", 2561, Model.UserName, 2561, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2577, 74, true);
                WriteLiteral(" type=\"text\">\r\n                                    <input id=\"hdnUserName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2651, "\"", 2674, 1);
#line 59 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EditAdminUser.cshtml"
WriteAttributeValue("", 2659, Model.UserName, 2659, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2675, 777, true);
                WriteLiteral(@" type=""hidden"">
                                    <span class=""error_label"" id=""UserName_Error""></span>
                                </div>

                            </fieldset>

                        </div>
                        <!--End form_fields_box-->

                        <div class=""form_fields_box"">

                            <div class=""form_field"">
                                <label for=""Password"">
                                    Password*
                                    <small class=""info_icon"" data-toggle=""tooltip"" data-placement=""right"" title=""(Required) Enter the main phone number for the department."">Tooltip</small>
                                </label>
                                <input id=""Password""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3452, "\"", 3475, 1);
#line 75 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EditAdminUser.cshtml"
WriteAttributeValue("", 3460, Model.Password, 3460, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3476, 598, true);
                WriteLiteral(@" type=""password"">
                                <span class=""error_label"" id=""Password_Error""></span>
                            </div>

                            <div class=""form_field"">
                                <label for=""MobileNumber"">
                                    Mobile Number*
                                    <small class=""info_icon"" data-toggle=""tooltip"" data-placement=""right"" title=""(Required) Enter the main phone number for the department."">Tooltip</small>
                                </label>
                                <input id=""MobileNumber""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4074, "\"", 4101, 1);
#line 84 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EditAdminUser.cshtml"
WriteAttributeValue("", 4082, Model.MobileNumber, 4082, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4102, 452, true);
                WriteLiteral(@" type=""text"">
                                <span class=""error_label"" id=""MobileNumber_Error""></span>
                            </div>

                        </div>
                        <!--End form_fields_box-->

                    </div>

                </div>

                <!--End forom_wrap-->


            </div>
            <!--End content_wrap-->


        </div>
        <!--End center_wrap-->
    </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4561, 27, true);
            WriteLiteral("\r\n<!--End full_width-->\r\n\r\n");
            EndContext();
            BeginContext(4588, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f364ee1207f64f9db54cb1f4b42a73a7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 109 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EditAdminUser.cshtml"
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
            BeginContext(4681, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("DocumentReady", async() => {
                BeginContext(4708, 409, true);
                WriteLiteral(@"
    var currentTab = location.hash
    if (currentTab) {
    $("".tab_list li"").removeClass(""current"");
    $("".tab_list li>a[href="" + currentTab + ""]"").closest(""li"").addClass(""current"");
    $("".tab_content"").hide();
    $(currentTab).show();
    $(currentTab + ""_btn"").show()
    }

    //Select Current Menu
    $('.nav-li').removeClass('current');
    $('#menuItemFAQs').addClass('current');
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dream14.ViewModels.SuperAdmin.AdminUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
