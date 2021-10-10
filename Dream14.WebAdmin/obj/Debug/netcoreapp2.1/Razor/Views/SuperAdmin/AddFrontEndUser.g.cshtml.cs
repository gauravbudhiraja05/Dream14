#pragma checksum "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddFrontEndUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "734ee8c129285f8034ea7f0a08217372a08f74ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_AddFrontEndUser), @"mvc.1.0.view", @"/Views/SuperAdmin/AddFrontEndUser.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/AddFrontEndUser.cshtml", typeof(AspNetCore.Views_SuperAdmin_AddFrontEndUser))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"734ee8c129285f8034ea7f0a08217372a08f74ad", @"/Views/SuperAdmin/AddFrontEndUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d66911b042d391ea5d66d7f3b135411b6a5ca4e", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_AddFrontEndUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dream14.ViewModels.SuperAdmin.FrontEndUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formAdmin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("formAdmin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/SuperAdmin/superAdmin.addFrontEndUser.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddFrontEndUser.cshtml"
  
    ViewData["Title"] = "Add FrontEnd User";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(153, 4300, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aca91b539f2b415aafca856b3e53864c", async() => {
                BeginContext(191, 117, true);
                WriteLiteral("\r\n    <div class=\"tab_menu\">\r\n        <div class=\"center_wrap\">\r\n\r\n            <button type=\"button\" class=\"back_btn\"");
                EndContext();
                BeginWriteAttribute("onClick", " onClick=\"", 308, "\"", 382, 3);
                WriteAttributeValue("", 318, "window.location.href=\'", 318, 22, true);
#line 11 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddFrontEndUser.cshtml"
WriteAttributeValue("", 340, Url.Action("FrontEndUsers","SuperAdmin"), 340, 41, false);

#line default
#line hidden
                WriteAttributeValue("", 381, "\'", 381, 1, true);
                EndWriteAttribute();
                BeginContext(383, 1042, true);
                WriteLiteral(@">Back</button>

            <ul class=""tab_list"">
                <li class=""current""><a href=""#tab_1"">FrontEnd User Details</a></li>
            </ul>

            <button type=""button"" id=""Save_FrontEnd_Btn"" class=""btn_field tab_save"">Save</button>

        </div>
    </div>
    <!--End tab_menu-->

    <div class=""full_width"">
        <div class=""center_wrap"">

            <div class=""content_wrap"">

                <div class=""page_heading"">
                    <h1>Add FrontEnd User</h1>
                </div>
                <!--End page_heading-->

                <div class=""form_wrap"">

                    <div class=""tab_content"" id=""tab_1"">

                        <div class=""form_fields_box"">
                            <fieldset>
                                <div class=""form_field"">
                                    <label for=""Id"">User Id</label>
                                    <input type=""text"" disabled>
                                    <input type=""h");
                WriteLiteral("idden\" id=\"UserId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1425, "\"", 1446, 1);
#line 42 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddFrontEndUser.cshtml"
WriteAttributeValue("", 1433, Model.UserId, 1433, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1447, 467, true);
                WriteLiteral(@" />
                                </div>
                                <div class=""form_field"">
                                    <label for=""Name"">
                                        Name*
                                        <small class=""info_icon"" data-toggle=""tooltip"" data-placement=""right"" title=""(Required) Department Name."">Tooltip</small>
                                    </label>
                                    <input id=""Name""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1914, "\"", 1933, 1);
#line 49 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddFrontEndUser.cshtml"
WriteAttributeValue("", 1922, Model.Name, 1922, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1934, 609, true);
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
                BeginWriteAttribute("value", " value=\"", 2543, "\"", 2566, 1);
#line 58 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddFrontEndUser.cshtml"
WriteAttributeValue("", 2551, Model.UserName, 2551, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2567, 775, true);
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
                BeginWriteAttribute("value", " value=\"", 3342, "\"", 3365, 1);
#line 74 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddFrontEndUser.cshtml"
WriteAttributeValue("", 3350, Model.Password, 3350, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3366, 598, true);
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
                BeginWriteAttribute("value", " value=\"", 3964, "\"", 3991, 1);
#line 83 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddFrontEndUser.cshtml"
WriteAttributeValue("", 3972, Model.MobileNumber, 3972, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3992, 454, true);
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
            BeginContext(4453, 27, true);
            WriteLiteral("\r\n<!--End full_width-->\r\n\r\n");
            EndContext();
            BeginContext(4480, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e391738a060d48d081bbec333809df2c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 109 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\AddFrontEndUser.cshtml"
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
            BeginContext(4575, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("DocumentReady", async() => {
                BeginContext(4602, 409, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dream14.ViewModels.SuperAdmin.FrontEndUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
