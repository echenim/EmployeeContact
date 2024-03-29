#pragma checksum "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7abaace2c1d04729c3ef52bc3c07b7c1ceee7b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkStation__list), @"mvc.1.0.view", @"/Views/WorkStation/_list.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WorkStation/_list.cshtml", typeof(AspNetCore.Views_WorkStation__list))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7abaace2c1d04729c3ef52bc3c07b7c1ceee7b6", @"/Views/WorkStation/_list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4537094f61b33b315edcda5776326a7fce8506f", @"/Views/_ViewImports.cshtml")]
    public class Views_WorkStation__list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Portal.Domain.ViewModels.DepartmentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml"
  
    ViewData["Title"] = "_list";

#line default
#line hidden
            BeginContext(109, 1084, true);
            WriteLiteral(@"
<!-- Heading -->
<div class=""card mb-4 wow fadeIn"">

    <!--Card content-->
    <div class=""card-body d-sm-flex justify-content-between"">

        <h4 class=""mb-2 mb-sm-0 pt-1"">
            <a href=#"" target=""_blank"">Department</a>
            <span>/</span>
            <span>  <a asp-action=""Add"">Add Department</a></span>
        </h4>

        <form class=""d-flex justify-content-center"">
            <!-- Default input -->
            <input name=""SearchString"" type=""search"" placeholder=""Type your query"" aria-label=""Search"" class=""form-control"">
            <button class=""btn btn-primary btn-sm my-0 p"" type=""submit"">
                <i class=""fas fa-search""></i>
            </button>

        </form>

    </div>

</div>
<!-- Heading -->
<!--Card-->
<div class=""card"">

    <!--Card content-->
    <div class=""card-body"">

        <!-- Table  -->
        <table class=""table table-hover"">
            <!-- Table head -->
            <thead class=""blue lighten-4"">
            ");
            WriteLiteral("    <tr>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1194, 21, false);
#line 44 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml"
                   Write(Html.DisplayName("#"));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1295, 40, false);
#line 47 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1335, 79, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
            EndContext();
            BeginContext(1415, 34, false);
#line 50 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml"
                   Write(Html.DisplayName("No of Employee"));

#line default
#line hidden
            EndContext();
            BeginContext(1449, 126, true);
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 56 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1640, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1713, 37, false);
#line 60 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1750, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1830, 39, false);
#line 63 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1869, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1949, 48, false);
#line 66 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ResourceCount));

#line default
#line hidden
            EndContext();
            BeginContext(1997, 83, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n\r\n\r\n                        ");
            EndContext();
            BeginContext(2081, 57, false);
#line 71 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml"
                   Write(Html.ActionLink("View", "Resource", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2138, 27, true);
            WriteLiteral("|\r\n                        ");
            EndContext();
            BeginContext(2166, 53, false);
#line 72 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2219, 27, true);
            WriteLiteral("|\r\n                        ");
            EndContext();
            BeginContext(2247, 57, false);
#line 73 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(2304, 54, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 77 "D:\WorksCali\Microsoft\EmployeeContacts\Portal\Views\WorkStation\_list.cshtml"
                }

#line default
#line hidden
            BeginContext(2377, 104, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <!-- Table  -->\r\n\r\n    </div>\r\n\r\n</div>\r\n<!--/.Card-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Portal.Domain.ViewModels.DepartmentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
