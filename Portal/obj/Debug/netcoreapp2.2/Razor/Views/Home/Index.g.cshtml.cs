#pragma checksum "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfab834f987d2854f68d896439e638d4e482c0fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\_ViewImports.cshtml"
using Portal;

#line default
#line hidden
#line 2 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\_ViewImports.cshtml"
using Portal.Domain.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfab834f987d2854f68d896439e638d4e482c0fd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4537094f61b33b315edcda5776326a7fce8506f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex justify-content-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 365, true);
            WriteLiteral(@"<!-- Heading -->
<div class=""card mb-4 wow fadeIn"">

    <!--Card content-->
    <div class=""card-body d-sm-flex justify-content-between"">

        <h4 class=""mb-2 mb-sm-0 pt-1"">
            <a href=""https://mdbootstrap.com/docs/jquery/"" target=""_blank"">Home Page</a>
            <span>/</span>
            <span>Dashboard</span>
        </h4>

        ");
            EndContext();
            BeginContext(365, 349, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfab834f987d2854f68d896439e638d4e482c0fd4038", async() => {
                BeginContext(409, 298, true);
                WriteLiteral(@"
            <!-- Default input -->
            <input type=""search"" placeholder=""Type your query"" aria-label=""Search"" class=""form-control"">
            <button class=""btn btn-primary btn-sm my-0 p"" type=""submit"">
                <i class=""fas fa-search""></i>
            </button>

        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(714, 2685, true);
            WriteLiteral(@"

    </div>

</div>
<!-- Heading -->
<!--Grid row-->
<div class=""row wow fadeIn"">

    <!--Grid column-->
    <div class=""col-md-9 mb-4"">

        <!--Card-->
        <div class=""card"">

            <!--Card content-->
            <div class=""card-body"">

                <canvas id=""myChart""></canvas>

            </div>

        </div>
        <!--/.Card-->

    </div>
    <!--Grid column-->
    <!--Grid column-->
    <div class=""col-md-3 mb-4"">

        <!--Card-->
        <div class=""card mb-4"">

            <!-- Card header -->
            <div class=""card-header text-center"">
                Pie chart
            </div>

            <!--Card content-->
            <div class=""card-body"">

                <canvas id=""pieChart""></canvas>

            </div>

        </div>
        <!--/.Card-->
        <!--Card-->
        <div class=""card mb-4"">

            <!--Card content-->
            <div class=""card-body"">

                <!-- List group links -");
            WriteLiteral(@"->
                <div class=""list-group list-group-flush"">
                    <a class=""list-group-item list-group-item-action waves-effect"">
                        Sales
                        <span class=""badge badge-success badge-pill pull-right"">
                            22%
                            <i class=""fas fa-arrow-up ml-1""></i>
                        </span>
                    </a>
                    <a class=""list-group-item list-group-item-action waves-effect"">
                        Traffic
                        <span class=""badge badge-danger badge-pill pull-right"">
                            5%
                            <i class=""fas fa-arrow-down ml-1""></i>
                        </span>
                    </a>
                    <a class=""list-group-item list-group-item-action waves-effect"">
                        Orders
                        <span class=""badge badge-primary badge-pill pull-right"">14</span>
                    </a>
             ");
            WriteLiteral(@"       <a class=""list-group-item list-group-item-action waves-effect"">
                        Issues
                        <span class=""badge badge-primary badge-pill pull-right"">123</span>
                    </a>
                    <a class=""list-group-item list-group-item-action waves-effect"">
                        Messages
                        <span class=""badge badge-primary badge-pill pull-right"">8</span>
                    </a>
                </div>
                <!-- List group links -->

            </div>

        </div>
        <!--/.Card-->

    </div>
    <!--Grid column-->

</div>

");
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