#pragma checksum "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddMasterUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "880290bbc8c614fb9d4664a9e8070cbd68ccbce3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_AddMasterUser), @"mvc.1.0.view", @"/Views/SuperAdmin/AddMasterUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/AddMasterUser.cshtml", typeof(AspNetCore.Views_SuperAdmin_AddMasterUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"880290bbc8c614fb9d4664a9e8070cbd68ccbce3", @"/Views/SuperAdmin/AddMasterUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d66911b042d391ea5d66d7f3b135411b6a5ca4e", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_AddMasterUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dream14.ViewModels.SuperAdmin.MasterUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Vip", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Normal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formMaster"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formMaster"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/SuperAdmin/superAdmin.addMasterUser.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddMasterUser.cshtml"
  
    ViewData["Title"] = "Add Master User";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(147, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(149, 5101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "efc14ce5094043c19a5c3b3c3a8cadef", async() => {
                BeginContext(189, 117, true);
                WriteLiteral("\r\n    <div class=\"tab_menu\">\r\n        <div class=\"center_wrap\">\r\n\r\n            <button type=\"button\" class=\"back_btn\"");
                EndContext();
                BeginWriteAttribute("onClick", " onClick=\"", 306, "\"", 378, 3);
                WriteAttributeValue("", 316, "window.location.href=\'", 316, 22, true);
#line 11 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddMasterUser.cshtml"
WriteAttributeValue("", 338, Url.Action("MasterUsers","SuperAdmin"), 338, 39, false);

#line default
#line hidden
                WriteAttributeValue("", 377, "\'", 377, 1, true);
                EndWriteAttribute();
                BeginContext(379, 1036, true);
                WriteLiteral(@">Back</button>

            <ul class=""tab_list"">
                <li class=""current""><a href=""#tab_1"">Master User Details</a></li>
            </ul>

            <button type=""button"" id=""Save_Master_Btn"" class=""btn_field tab_save"">Save</button>

        </div>
    </div>
    <!--End tab_menu-->

    <div class=""full_width"">
        <div class=""center_wrap"">

            <div class=""content_wrap"">

                <div class=""page_heading"">
                    <h1>Add Master User</h1>
                </div>
                <!--End page_heading-->

                <div class=""form_wrap"">

                    <div class=""tab_content"" id=""tab_1"">

                        <div class=""form_fields_box"">
                            <fieldset>
                                <div class=""form_field"">
                                    <label for=""Id"">User Id</label>
                                    <input type=""text"" disabled>
                                    <input type=""hidden""");
                WriteLiteral(" id=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1415, "\"", 1436, 1);
#line 42 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddMasterUser.cshtml"
WriteAttributeValue("", 1423, Model.UserId, 1423, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1437, 467, true);
                WriteLiteral(@" />
                                </div>
                                <div class=""form_field"">
                                    <label for=""Name"">
                                        Name*
                                        <small class=""info_icon"" data-toggle=""tooltip"" data-placement=""right"" title=""(Required) Department Name."">Tooltip</small>
                                    </label>
                                    <input id=""Name""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1904, "\"", 1923, 1);
#line 49 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddMasterUser.cshtml"
WriteAttributeValue("", 1912, Model.Name, 1912, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1924, 609, true);
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
                BeginWriteAttribute("value", " value=\"", 2533, "\"", 2556, 1);
#line 58 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddMasterUser.cshtml"
WriteAttributeValue("", 2541, Model.UserName, 2541, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2557, 775, true);
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
                BeginWriteAttribute("value", " value=\"", 3332, "\"", 3355, 1);
#line 74 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddMasterUser.cshtml"
WriteAttributeValue("", 3340, Model.Password, 3340, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3356, 598, true);
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
                BeginWriteAttribute("value", " value=\"", 3954, "\"", 3981, 1);
#line 83 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddMasterUser.cshtml"
WriteAttributeValue("", 3962, Model.MobileNumber, 3962, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3982, 692, true);
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
                BeginContext(4674, 32, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e68b36a0e684c9f9ff48246a61ea767", async() => {
                    BeginContext(4694, 3, true);
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
                BeginContext(4706, 42, true);
                WriteLiteral("\r\n                                        ");
                EndContext();
                BeginContext(4748, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca8a7bc6fc5946ad83f5099ba34274f2", async() => {
                    BeginContext(4791, 6, true);
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
                BeginContext(4806, 437, true);
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
            BeginContext(5250, 27, true);
            WriteLiteral("\r\n<!--End full_width-->\r\n\r\n");
            EndContext();
            BeginContext(5277, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70bfcdf203f34a92b10a1a737d884655", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 122 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddMasterUser.cshtml"
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
            BeginContext(5370, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("DocumentReady", async() => {
                BeginContext(5397, 409, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dream14.ViewModels.SuperAdmin.MasterUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
