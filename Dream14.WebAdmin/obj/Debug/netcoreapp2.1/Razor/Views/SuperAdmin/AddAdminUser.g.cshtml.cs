#pragma checksum "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddAdminUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25fa154dba4ac733aa8fae2144b52f4fca78425a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_AddAdminUser), @"mvc.1.0.view", @"/Views/SuperAdmin/AddAdminUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/AddAdminUser.cshtml", typeof(AspNetCore.Views_SuperAdmin_AddAdminUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25fa154dba4ac733aa8fae2144b52f4fca78425a", @"/Views/SuperAdmin/AddAdminUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d66911b042d391ea5d66d7f3b135411b6a5ca4e", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_AddAdminUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dream14.ViewModels.SuperAdmin.AdminUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Vip", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Normal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAdmin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formAdmin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/SuperAdmin/superAdmin.addAdminUser.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddAdminUser.cshtml"
  
    ViewData["Title"] = "Add Admin User";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(147, 5091, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9d5b3993a3d42529169f5403cd882e6", async() => {
                BeginContext(185, 117, true);
                WriteLiteral("\r\n    <div class=\"tab_menu\">\r\n        <div class=\"center_wrap\">\r\n\r\n            <button type=\"button\" class=\"back_btn\"");
                EndContext();
                BeginWriteAttribute("onClick", " onClick=\"", 302, "\"", 373, 3);
                WriteAttributeValue("", 312, "window.location.href=\'", 312, 22, true);
#line 11 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddAdminUser.cshtml"
WriteAttributeValue("", 334, Url.Action("AdminUsers","SuperAdmin"), 334, 38, false);

#line default
#line hidden
                WriteAttributeValue("", 372, "\'", 372, 1, true);
                EndWriteAttribute();
                BeginContext(374, 1033, true);
                WriteLiteral(@">Back</button>

            <ul class=""tab_list"">
                <li class=""current""><a href=""#tab_1"">Admin User Details</a></li>
            </ul>

            <button type=""button"" id=""Save_Admin_Btn"" class=""btn_field tab_save"">Save</button>

        </div>
    </div>
    <!--End tab_menu-->

    <div class=""full_width"">
        <div class=""center_wrap"">

            <div class=""content_wrap"">

                <div class=""page_heading"">
                    <h1>Add Admin User</h1>
                </div>
                <!--End page_heading-->

                <div class=""form_wrap"">

                    <div class=""tab_content"" id=""tab_1"">

                        <div class=""form_fields_box"">
                            <fieldset>
                                <div class=""form_field"">
                                    <label for=""Id"">User Id</label>
                                    <input type=""text"" disabled>
                                    <input type=""hidden"" id");
                WriteLiteral("=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1407, "\"", 1428, 1);
#line 42 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddAdminUser.cshtml"
WriteAttributeValue("", 1415, Model.UserId, 1415, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1429, 467, true);
                WriteLiteral(@" />
                                </div>
                                <div class=""form_field"">
                                    <label for=""Name"">
                                        Name*
                                        <small class=""info_icon"" data-toggle=""tooltip"" data-placement=""right"" title=""(Required) Department Name."">Tooltip</small>
                                    </label>
                                    <input id=""Name""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1896, "\"", 1915, 1);
#line 49 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddAdminUser.cshtml"
WriteAttributeValue("", 1904, Model.Name, 1904, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1916, 609, true);
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
                BeginWriteAttribute("value", " value=\"", 2525, "\"", 2548, 1);
#line 58 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddAdminUser.cshtml"
WriteAttributeValue("", 2533, Model.UserName, 2533, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2549, 775, true);
                WriteLiteral(@" type=""text"">
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
                BeginWriteAttribute("value", " value=\"", 3324, "\"", 3347, 1);
#line 74 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddAdminUser.cshtml"
WriteAttributeValue("", 3332, Model.Password, 3332, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3348, 598, true);
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
                BeginWriteAttribute("value", " value=\"", 3946, "\"", 3973, 1);
#line 83 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddAdminUser.cshtml"
WriteAttributeValue("", 3954, Model.MobileNumber, 3954, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3974, 692, true);
                WriteLiteral(@" type=""text"">
                                <span class=""error_label"" id=""MobileNumber_Error""></span>
                            </div>

                            <div class=""form_field"">
                                <label for=""DropDown"">
                                    User Type*
                                    <small class=""info_icon"" data-toggle=""tooltip"" data-placement=""right"" title=""(Required) Enter the main phone number for the department."">Tooltip</small>
                                </label>
                                <div class=""select_div"">
                                    <select id=""UserType"">
                                        ");
                EndContext();
                BeginContext(4666, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce23837e3e7146fea98a5f855659194d", async() => {
                    BeginContext(4686, 3, true);
                    WriteLiteral("Vip");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4698, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(4740, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b865a99e88dc432fbb6fdb007e974859", async() => {
                    BeginContext(4783, 6, true);
                    WriteLiteral("Normal");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4798, 433, true);
                WriteLiteral(@"
                                    </select>
                                </div>
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5238, 27, true);
            WriteLiteral("\r\n<!--End full_width-->\r\n\r\n");
            EndContext();
            BeginContext(5265, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe923a52dddb41f28a6e82ac85197cb4", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 120 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddAdminUser.cshtml"
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
            BeginContext(5357, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("DocumentReady", async() => {
                BeginContext(5384, 409, true);
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
