#pragma checksum "D:\GitHub\Dream14\Dream14.WebAdmin\Views\FrontEnd\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d48f7d09767f339d6ea5f1ea286d6f90b30f8dd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FrontEnd_Login), @"mvc.1.0.view", @"/Views/FrontEnd/Login.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FrontEnd/Login.cshtml", typeof(AspNetCore.Views_FrontEnd_Login))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d48f7d09767f339d6ea5f1ea286d6f90b30f8dd4", @"/Views/FrontEnd/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d66911b042d391ea5d66d7f3b135411b6a5ca4e", @"/Views/_ViewImports.cshtml")]
    public class Views_FrontEnd_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dream14.ViewModels.AuthUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/FrontEnd/login-page.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/FrontEnd/demo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgclass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/stock-market.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("username"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("cm-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter your email adress"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("pass"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "password", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Enter your password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("codehim-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\FrontEnd\Login.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(63, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(100, 3222, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f31d5b7a86f4c1d96b7aef02514a6e1", async() => {
                BeginContext(106, 257, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Login</title>
    <meta name=""author"" content=""Codeconvey"" />

    ");
                EndContext();
                BeginContext(363, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79c6d149995e42969b306d0c0b074aad", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(418, 297, true);
                WriteLiteral(@"

    <!-- Font Awesome -->
    <link href=""https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" integrity=""sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN"" crossorigin=""anonymous"">

    <!-- Stylish Login Page CSS -->
    ");
                EndContext();
                BeginContext(715, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ce96ec29cdd458e9224a9d3316a9201", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(777, 60, true);
                WriteLiteral("\r\n\r\n    <!--Only for demo purpose - no need to add.-->\r\n    ");
                EndContext();
                BeginContext(837, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6536a0da590457182c26f7fc3e9363b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(893, 1183, true);
                WriteLiteral(@"

    <style type=""text/css"">

        /* The Modal (background) */
        .modal {
            display: none; /* Hidden by default */
            position: fixed; /* Stay in place */
            z-index: 1; /* Sit on top */
            padding-top: 100px; /* Location of the box */
            left: 0;
            top: 0;
            width: 100%; /* Full width */
            height: 100%; /* Full height */
            overflow: auto; /* Enable scroll if needed */
            background-color: rgb(0,0,0); /* Fallback color */
            background-color: rgba(0,0,0,0.4); /* Black w/ opacity */
        }

        /* Modal Content */
        .modal-content {
            position: relative;
            background-color: #fefefe;
            margin: auto;
            padding: 0;
            border: 1px solid #888;
            width: 50%;
            box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2),0 6px 20px 0 rgba(0,0,0,0.19);
            -webkit-animation-name: animatetop;
            -webk");
                WriteLiteral("it-animation-duration: 0.4s;\r\n            animation-name: animatetop;\r\n            animation-duration: 0.4s\r\n        }\r\n\r\n        /* Add Animation */\r\n        ");
                EndContext();
                BeginContext(2077, 235, true);
                WriteLiteral("@-webkit-keyframes animatetop {\r\n            from {\r\n                top: -300px;\r\n                opacity: 0\r\n            }\r\n\r\n            to {\r\n                top: 0;\r\n                opacity: 1\r\n            }\r\n        }\r\n\r\n        ");
                EndContext();
                BeginContext(2313, 1002, true);
                WriteLiteral(@"@keyframes animatetop {
            from {
                top: -300px;
                opacity: 0
            }

            to {
                top: 0;
                opacity: 1
            }
        }

        /* The Close Button */
        .close {
            color: white;
            float: right;
            font-size: 28px;
            font-weight: bold;
        }

            .close:hover,
            .close:focus {
                color: #000;
                text-decoration: none;
                cursor: pointer;
            }

        .modal-header {
            text-align: center;
            padding: 2px 16px;
            /*background-color: #5cb85c;*/
            color: white;
        }

        .modal-body {
            padding: 2px 16px;
        }

        .modal-footer {
            margin-left: 35%;
            padding: 2px 16px;
            /*background-color: #5cb85c;*/
            color: white;
        }
    </style>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3322, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3324, 8069, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b051c7ae08b04212b012ce74d49e0d8e", async() => {
                BeginContext(3330, 216, true);
                WriteLiteral("\r\n\r\n\r\n    <section>\r\n        <div class=\"rt-container\">\r\n            <div class=\"col-rt-12\">\r\n                <div class=\"Scriptcontent\">\r\n\r\n                    <!-- Stylish Login Page Start -->\r\n                    ");
                EndContext();
                BeginContext(3546, 1409, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b115ddf2eea64f2ea746ec21323729bd", async() => {
                    BeginContext(3592, 207, true);
                    WriteLiteral("\r\n                        <div class=\"form-title\">\r\n                            <div class=\"user-icon gr-bg\">\r\n                                <i class=\"fa fa-user\"></i>\r\n                            </div>\r\n");
                    EndContext();
                    BeginContext(3857, 28, true);
                    WriteLiteral("                            ");
                    EndContext();
                    BeginContext(3885, 56, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "805e9fe4215944f8a7d90f2fc8d570bb", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3941, 34, true);
                    WriteLiteral("\r\n                        </div>\r\n");
                    EndContext();
#line 135 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\FrontEnd\Login.cshtml"
                         if (TempData["UserLoginFailed"] != null)
                        {
                            

#line default
#line hidden
                    BeginContext(4129, 51, true);
                    WriteLiteral("                            <p class=\"error_label\">");
                    EndContext();
                    BeginContext(4181, 27, false);
#line 138 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\FrontEnd\Login.cshtml"
                                              Write(TempData["UserLoginFailed"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(4208, 6, true);
                    WriteLiteral("</p>\r\n");
                    EndContext();
#line 139 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\FrontEnd\Login.cshtml"
                        }

#line default
#line hidden
                    BeginContext(4241, 114, true);
                    WriteLiteral("                        <label for=\"email\"><i class=\"fa fa-envelope\"></i> Email:</label>\r\n                        ");
                    EndContext();
                    BeginContext(4355, 107, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "54a33280539e40f7911ee99a8029306a", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 141 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\FrontEnd\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserName);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4462, 116, true);
                    WriteLiteral("\r\n\r\n                        <label for=\"pass\"><i class=\"fa fa-lock\"></i> Password:</label>\r\n                        ");
                    EndContext();
                    BeginContext(4578, 103, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a548f4cd386041149db5f37e560bbf02", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 144 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\FrontEnd\Login.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Password);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_11.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4681, 267, true);
                    WriteLiteral(@"
                        <button type=""submit"" class=""btn-login  gr-bg"">Login</button>

                        <label style=""float: right; margin-top: 40px;""> Want a Agent ? <a href=""javascript:void(0)"" id=""btnPopUp"">Sign Up Here</a></label>
                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_13.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4955, 6431, true);
                WriteLiteral(@"
                    <!-- Stylish Login Page End -->

                </div>
            </div>
        </div>
    </section>

    <!-- The Modal -->
    <div id=""myModal"" class=""modal"">

        <!-- Modal content -->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <span class=""close"">&times;</span>
                <h2>Register</h2>
            </div>
            <div class=""modal-body"">
                <label for=""name""> Name <span style=""color:red"">*</span></label>
                <input type=""text"" id=""Name"" class=""cm-input"" placeholder=""Enter your name"">
                <span class=""error"" style=""display:none; color:red"" id=""span_Name"">Name is required</span><br />

                <label for=""name""> Mobile Number 1 <span style=""color:red"">*</span></label>
                <input type=""text"" id=""MobNumber1"" class=""cm-input"" placeholder=""Enter your rrimary mobile number"">
                <span class=""error"" style=""display:none; color:red"" i");
                WriteLiteral(@"d=""span_MobNumber1"">Primary mobile number is required</span><br />

                <label for=""name""> Mobile Number 2 <span style=""color:red"">*</span></label>
                <input type=""text"" id=""MobNumber2"" class=""cm-input"" placeholder=""Enter your secondary mobile number"">
                <span class=""error"" style=""display:none; color:red"" id=""span_MobNumber2"">Secondary mobile number is required</span><br />

                <label for=""name""> District/City <span style=""color:red"">*</span></label>
                <input type=""text"" id=""City"" class=""cm-input"" placeholder=""Enter your district"">
                <span class=""error"" style=""display:none; color:red"" id=""span_City"">City is required</span><br />

                <label for=""name""> State <span style=""color:red"">*</span></label>
                <input type=""text"" id=""State"" class=""cm-input"" placeholder=""Enter your state"">
                <span class=""error"" style=""display:none; color:red"" id=""span_State"">State is required</span><br />

                WriteLiteral(@"
                <label for=""name""> Country <span style=""color:red"">*</span></label>
                <input type=""text"" id=""Country"" class=""cm-input"" placeholder=""Enter your country"">
                <span class=""error"" style=""display:none; color:red"" id=""span_Country"">Country is required</span><br />

            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""btnRegister"" style=""width:50%"" class=""btn-login  gr-bg"">Register</button>
            </div>
        </div>

    </div>

    <script>

        $(document).ready(function () {

            $(""#btnRegister"").click(function () {

                if (ValidateRegisterForm() == false) {
                    return false;
                }
                else {
                    $.ajax({
                        type: ""POST"",
                        url: ""/Home/AddUserDetails"",
                        async: false,
                        data: { Name: $('#Name').val(), MobNumber1: $('#MobNumb");
                WriteLiteral(@"er1').val(), MobNumber2: $('#MobNumber2').val(), City: $('#City').val(), State: $('#State').val(), Country: $('#Country').val() },
                        success: function () {
                            alert(""Yours Details Submitted Successfully. We will contact you soon"");
                            window.location.reload();
                        },
                        error: function (e) {
                            alert(e);
                        }
                    });
                }
            });
        });

        // Get the modal
        var modal = document.getElementById(""myModal"");

        // Get the button that opens the modal
        var btn = document.getElementById(""btnPopUp"");

        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName(""close"")[0];

        // When the user clicks the button, open the modal
        btn.onclick = function () {
            modal.style.display = ""block"";
        }

 ");
                WriteLiteral(@"       // When the user clicks on <span> (x), close the modal
        span.onclick = function () {
            modal.style.display = ""none"";
        }

        // When the user clicks anywhere outside of the modal, close it
        //window.onclick = function (event) {
        //    if (event.target == modal) {
        //        modal.style.display = ""none"";
        //    }
        //}

        function ValidateRegisterForm() {

            var isValid = true;


            if ($(""#Name"").val().trim().length == 0) {
                $(""span[id='span_Name']"").show();
                isValid = false;

            }
            else {
                $(""span[id='span_Name']"").hide();
            }


            if ($(""#MobNumber1"").val().trim().length == 0) {
                $(""span[id='span_MobNumber1']"").show();
                isValid = false;
            }
            else {
                $(""span[id='span_MobNumber1']"").hide();
            }


            if ($(""#MobNumbe");
                WriteLiteral(@"r2"").val().trim().length == 0) {
                $(""span[id='span_MobNumber2']"").show();
                isValid = false;

            }
            else {
                $(""span[id='span_MobNumber2']"").hide();
            }


            if ($(""#City"").val().trim().length == 0) {
                $(""span[id='span_City']"").show();
                isValid = false;

            }
            else {
                $(""span[id='span_City']"").hide();
            }


            if ($(""#MobNumber2"").val().trim().length == 0) {
                $(""span[id='span_MobNumber2']"").show();
                isValid = false;

            }
            else {
                $(""span[id='span_MobNumber2']"").hide();
            }


            if ($(""#State"").val().trim().length == 0) {
                $(""span[id='span_State']"").show();
                isValid = false;

            }
            else {
                $(""span[id='span_State']"").hide();
            }

            if ($(""#Cou");
                WriteLiteral(@"ntry"").val().trim().length == 0) {
                $(""span[id='span_Country']"").show();
                isValid = false;

            }
            else {
                $(""span[id='span_Country']"").hide();
            }

            return isValid;
        }
    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(11393, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dream14.ViewModels.AuthUser> Html { get; private set; }
    }
}
#pragma warning restore 1591