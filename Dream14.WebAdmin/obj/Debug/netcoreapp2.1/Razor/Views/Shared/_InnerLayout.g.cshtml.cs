#pragma checksum "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Shared\_InnerLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4315a634efbe6a43a15f98abb609e0a4a5bcadac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__InnerLayout), @"mvc.1.0.view", @"/Views/Shared/_InnerLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_InnerLayout.cshtml", typeof(AspNetCore.Views_Shared__InnerLayout))]
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
#line 1 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Shared\_InnerLayout.cshtml"
using System.Security.Claims;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4315a634efbe6a43a15f98abb609e0a4a5bcadac", @"/Views/Shared/_InnerLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d66911b042d391ea5d66d7f3b135411b6a5ca4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__InnerLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/FrontEnd/layout.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/FrontEnd/login-page.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/FrontEnd/demo.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FrontEnd/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FrontEnd/jquery.backtotop.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FrontEnd/jquery.mobilemenu.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/FrontEnd/commonFE.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sweetalert2.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sweetalert2.promise.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Shared\_InnerLayout.cshtml"
  
    var roles = HttpContextAccessor.HttpContext.User.Claims?.Where(c => c.Type == ClaimTypes.Role).Select(r => r.Value).ToList();

#line default
#line hidden
            BeginContext(246, 453, true);
            WriteLiteral(@"
<!DOCTYPE html>
<!--
Template Name: Pentwist
Author: <a href=""https://www.os-templates.com/"">OS Templates</a>
Author URI: https://www.os-templates.com/
Copyright: OS-Templates.com
Licence: Free to use under our free template licence terms
Licence URI: https://www.os-templates.com/template-terms
-->
<html lang="""">
<!-- To declare your language - read more here: https://www.w3.org/International/questions/qa-html-language-declarations -->
");
            EndContext();
            BeginContext(699, 3043, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95a7a4ea67794684be68b68ecdcb8223", async() => {
                BeginContext(705, 172, true);
                WriteLiteral("\r\n    <title>Dream 14</title>\r\n    <meta charset=\"utf-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no\">\r\n");
                EndContext();
                BeginContext(970, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(974, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bec7bc6b569d4654b670b2f274f84a6f", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                BeginContext(1032, 45, true);
                WriteLiteral("\r\n\r\n    <!-- Stylish Login Page CSS -->\r\n    ");
                EndContext();
                BeginContext(1077, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "636e05731a0b46e79261dfbfbddafc56", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1139, 60, true);
                WriteLiteral("\r\n\r\n    <!--Only for demo purpose - no need to add.-->\r\n    ");
                EndContext();
                BeginContext(1199, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "32ce69c8fcec4a6cb09413e30009bdc7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1255, 1183, true);
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
                BeginContext(2439, 235, true);
                WriteLiteral("@-webkit-keyframes animatetop {\r\n            from {\r\n                top: -300px;\r\n                opacity: 0\r\n            }\r\n\r\n            to {\r\n                top: 0;\r\n                opacity: 1\r\n            }\r\n        }\r\n\r\n        ");
                EndContext();
                BeginContext(2675, 1003, true);
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
            color: #000;
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
                BeginContext(3678, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "667764487a9e480aae2b1e65005e38ca", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3733, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(3742, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3744, 5451, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03d3ff2f6f3a4596a1c9baa417dde8dc", async() => {
                BeginContext(3759, 149, true);
                WriteLiteral("\r\n    <div class=\"wrapper row1\">\r\n        <header id=\"header\" class=\"hoc clear\">\r\n            <div id=\"logo\" class=\"fl_left\">\r\n                <h1><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 3908, "\"", 3946, 1);
#line 127 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Shared\_InnerLayout.cshtml"
WriteAttributeValue("", 3915, Url.Action("Index","FrontEnd"), 3915, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3947, 150, true);
                WriteLiteral(">Dream 14</a></h1>\r\n            </div>\r\n            <nav id=\"mainav\" class=\"fl_right\">\r\n                <ul class=\"clear\">\r\n                    <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 4097, "\"", 4135, 1);
#line 131 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Shared\_InnerLayout.cshtml"
WriteAttributeValue("", 4104, Url.Action("Index","FrontEnd"), 4104, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4136, 62, true);
                WriteLiteral(">Home</a></li>\r\n                    <li><a href=\"#\">Balance : ");
                EndContext();
                BeginContext(4199, 94, false);
#line 132 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Shared\_InnerLayout.cshtml"
                                         Write(HttpContextAccessor.HttpContext.User.Claims?.FirstOrDefault(c => c.Type == "FEBalance")?.Value);

#line default
#line hidden
                EndContext();
                BeginContext(4293, 58, true);
                WriteLiteral("</a></li>\r\n                    <li><a href=\"#\">Exposure : ");
                EndContext();
                BeginContext(4352, 94, false);
#line 133 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Shared\_InnerLayout.cshtml"
                                          Write(HttpContextAccessor.HttpContext.User.Claims?.FirstOrDefault(c => c.Type == "FEBalance")?.Value);

#line default
#line hidden
                EndContext();
                BeginContext(4446, 86, true);
                WriteLiteral("</a></li>\r\n                    <li>\r\n                        <a class=\"drop\" href=\"#\">");
                EndContext();
                BeginContext(4533, 95, false);
#line 135 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Shared\_InnerLayout.cshtml"
                                            Write(HttpContextAccessor.HttpContext.User.Claims?.FirstOrDefault(c => c.Type == "FEFullName")?.Value);

#line default
#line hidden
                EndContext();
                BeginContext(4628, 591, true);
                WriteLiteral(@"</a>
                        <ul>
                            <li><a href=""#"">Account Statement</a></li>
                            <li><a href=""#"">Profit/Loss Report</a></li>
                            <li><a href=""#"">Bet History</a></li>
                            <li><a href=""#"">Casino Report History</a></li>
                            <li><a href=""#"">Unsetteled Bet</a></li>
                            <li><a href=""#"">Set Button Values</a></li>
                            <li><a id=""btnChangePassword"" href=""#"">Change Password</a></li>
                            <li><a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 5219, "\"", 5259, 1);
#line 144 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Shared\_InnerLayout.cshtml"
WriteAttributeValue("", 5226, Url.Action("Logout", "FrontEnd"), 5226, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5260, 265, true);
                WriteLiteral(@">Logout</a></li>
                        </ul>
                    </li>
                </ul>
            </nav>
        </header>
    </div>
    <div class=""wrapper row3"">
        <main class=""hoc container clear"">
            <section>
                ");
                EndContext();
                BeginContext(5526, 12, false);
#line 154 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\Shared\_InnerLayout.cshtml"
           Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(5538, 3098, true);
                WriteLiteral(@"
            </section>
            <div class=""clear""></div>
        </main>
    </div>
    <div class=""wrapper row5"">
        <div id=""copyright"" class=""hoc clear"">
            <p class=""fl_left"">Copyright &copy; 2021 - All Rights Reserved - <a href=""#"">Dream 14</a></p>
        </div>
    </div>
    <a id=""backtotop"" href=""#top""><i class=""fas fa-chevron-up""></i></a>

    <!-- The Modal -->
    <div id=""myModal"" class=""modal"">

        <!-- Modal content -->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <span class=""close"">&times;</span>
                <h2 style=""background-color: #001240;color: white;padding: 10px;margin-top: 20px;text-align: left;"">Change Password</h2>
            </div>
            <div class=""modal-body"">
                <label style=""border:none;""> Old Password <span style=""color:red"">*</span></label>
                <input type=""password"" id=""OldPassword"" class=""cm-input"" placeholder=""Enter your old password"">
      ");
                WriteLiteral(@"          <span class=""error"" style=""display:none; color:red"" id=""span_OldPassword"">Old Password is required</span><br />

                <label style=""border:none;""> New Password <span style=""color:red"">*</span></label>
                <input type=""password"" id=""NewPassword"" class=""cm-input"" placeholder=""Enter your new password"">
                <span class=""error"" style=""display:none; color:red"" id=""span_NewPassword"">New Password is required</span><br />

                <label style=""border:none;""> Confirm Password <span style=""color:red"">*</span></label>
                <input type=""password"" id=""Confirmassword"" class=""cm-input"" placeholder=""Confirm your new password"">
                <span class=""error"" style=""display:none; color:red"" id=""span_ConfirmPassword"">Confirm Password is required</span><br />

            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""btnPassword"" style=""width:50%"" class=""btn-login  gr-bg"">Change Password</button>
          ");
                WriteLiteral(@"  </div>
        </div>
    </div>

    <script>
        // Get the modal
        var modal = document.getElementById(""myModal"");

        // Get the button that opens the modal
        var btn = document.getElementById(""btnChangePassword"");

        // Get the <span> element that closes the modal
        var span = document.getElementsByClassName(""close"")[0];

        // When the user clicks the button, open the modal
        btn.onclick = function () {
            modal.style.display = ""block"";
        }

        // When the user clicks on <span> (x), close the modal
        span.onclick = function () {
            modal.style.display = ""none"";
        }

                    // When the user clicks anywhere outside of the modal, close it
                    //window.onclick = function (event) {
                    //    if (event.target == modal) {
                    //        modal.style.display = ""none"";
                    //    }
                    //}
    </script>


");
                WriteLiteral("    <!-- JAVASCRIPTS -->\r\n");
                EndContext();
                BeginContext(8698, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(8702, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddddca3e8fa84f458cbd1f6d22f0d6f0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8753, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(8823, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(8827, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "97a4581c976c41c7b549345494397bdd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8884, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(8955, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(8959, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5460628a57ef43f49836840732711d0c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9017, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(9025, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c421c476cda54008bbbccd8170c4b025", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9074, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(9082, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56eb43c8e6ea4f4f8e63cb6a25988a9b", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9125, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(9131, 55, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8d58fce89644bdb8236b75095ab9832", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9186, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9195, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
