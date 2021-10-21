#pragma checksum "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EventList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45b8b2fa48045d06dddc67045ac0031c421c88be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SuperAdmin_EventList), @"mvc.1.0.view", @"/Views/SuperAdmin/EventList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SuperAdmin/EventList.cshtml", typeof(AspNetCore.Views_SuperAdmin_EventList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45b8b2fa48045d06dddc67045ac0031c421c88be", @"/Views/SuperAdmin/EventList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d66911b042d391ea5d66d7f3b135411b6a5ca4e", @"/Views/_ViewImports.cshtml")]
    public class Views_SuperAdmin_EventList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/SuperAdmin/superAdmin.eventList.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EventList.cshtml"
  
    ViewData["Title"] = "EventList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(94, 2897, true);
            WriteLiteral(@"
<style>
    .table-css {
        font-family: Arial, Helvetica, sans-serif;
        border-collapse: collapse;
        width: 100%;
        border: 1px solid;
        margin-bottom: 20px;
        text-align: center;
    }

        .table-css tr td.left-text {
            text-align: left;
        }

        .table-css td, #table-css th {
            border: 1px solid black;
            padding: 8px;
        }

        .table-css tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        .table-css tr:hover {
            background-color: #ddd;
        }

        .table-css th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #1e2c69;
            color: #fff;
            padding-left: 10px;
        }

    /* The Close Button */
    .close {
        color: #000;
        float: right;
        font-size: 28px;
        font-weight: bold;
    }

        .close:hover,
      ");
            WriteLiteral(@"  .close:focus {
            color: #000;
            text-decoration: none;
            cursor: pointer;
        }

    .red-color {
        color: red
    }

    .gray-color {
        background-color: #CCCCCC;
        /* color: gray; */
        text-align: center;
    }

    .modal label {
        border: 1px solid black;
        margin: 12px;
        padding: 5px;
        font: caption;
    }

    .modal-body {
        height: 400px;
        overflow: auto;
    }

    .sub-header {
        color: white;
        background-color: #ff5000;
        padding: 11px;
        font-weight: 900;
        text-align: left;
    }

    .modal h3 {
        background-color: #001240;
        color: white;
        padding: 10px;
        margin-top: 20px;
        text-align: left;
    }

    .modal-content {
        width: 85%;
    }

    /*.close {
        color: white;
        margin: 19px;
        margin-top: 28px;
        margin-right: 10px;
    }*/

    .table-css");
            WriteLiteral(@" a:hover {
        text-decoration: underline;
        text-decoration-color: black;
    }
</style>


<div class=""top_filter_bar"">
    <div class=""center_wrap"">
        <div class=""top_filter_right"">
            <div class=""form_group"">
            </div>
        </div>
    </div>
</div>
<!--End top_filter_bar-->


<div class=""full_width"">
    <div class=""center_wrap"">

        <div class=""content_wrap"">

            <div class=""page_heading"">
                <h1>Event List </h1>
            </div>
            <!--End page_heading-->

            <div class=""table_wrap"">
                <table id=""tblEvents"" class=""table-css"">
                </table>
            </div>




        </div>
        <!--End content_wrap-->



    </div>
    <!--End center_wrap-->

</div>
<!--End full_width-->

");
            EndContext();
            BeginContext(2991, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a046fc5af9e0449f8cb29c3f8868459b", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 154 "D:\GitHub\Dream14\Dream14.WebAdmin\Views\SuperAdmin\EventList.cshtml"
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
            BeginContext(3080, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591