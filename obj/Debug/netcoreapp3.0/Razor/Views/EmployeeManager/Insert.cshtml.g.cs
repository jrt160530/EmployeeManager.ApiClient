#pragma checksum "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bc35f7c04ab4c44baf6e3d40c413d8e98181e74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeManager_Insert), @"mvc.1.0.view", @"/Views/EmployeeManager/Insert.cshtml")]
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
#nullable restore
#line 1 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\_ViewImports.cshtml"
using EmployeeManager.ApiClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\_ViewImports.cshtml"
using EmployeeManager.ApiClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\_ViewImports.cshtml"
using EmployeeManager.ApiClient.Security;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc35f7c04ab4c44baf6e3d40c413d8e98181e74", @"/Views/EmployeeManager/Insert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f39e892bc569e508c5e3f174596be113cfd6b2e", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeManager_Insert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Insert New Employee</h2>\n\n<h3 class=\"message\">");
#nullable restore
#line 5 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
               Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n");
#nullable restore
#line 7 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
 using (Html.BeginForm("Insert", "EmployeeManager", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table border=\"0\">\n    <tr>\n        <td class=\"right\">\n            ");
#nullable restore
#line 12 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.LabelFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\n        </td>\n        <td>\n            ");
#nullable restore
#line 15 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 16 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.ValidationMessageFor(m => m.FirstName, null, new { @class = "message" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td class=\"right\">\n            ");
#nullable restore
#line 21 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.LabelFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\n        </td>\n        <td>\n            ");
#nullable restore
#line 24 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 25 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.ValidationMessageFor(m => m.LastName, null, new { @class = "message" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td class=\"right\">\n            ");
#nullable restore
#line 30 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.LabelFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\n        </td>\n        <td>\n            ");
#nullable restore
#line 33 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.TextBoxFor(m => m.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 34 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.ValidationMessageFor(m => m.Title, null, new { @class = "message" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td class=\"right\">\n            ");
#nullable restore
#line 39 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.LabelFor(m => m.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\n        </td>\n        <td>\n            ");
#nullable restore
#line 42 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.TextBoxFor(m => m.BirthDate, null, new { type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 43 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.ValidationMessageFor(m => m.BirthDate, null, new { @class = "message" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td class=\"right\">\n            ");
#nullable restore
#line 48 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.LabelFor(m => m.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\n        </td>\n        <td>\n            ");
#nullable restore
#line 51 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.TextBoxFor(m => m.HireDate, null, new { type = "date" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 52 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.ValidationMessageFor(m => m.HireDate, null, new { @class = "message" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td class=\"right\">\n            ");
#nullable restore
#line 57 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.LabelFor(m => m.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\n        </td>\n        <td>\n            ");
#nullable restore
#line 60 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.DropDownListFor(m => m.Country, ViewBag.Countries as List<SelectListItem>,"Please select"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 61 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.ValidationMessageFor(m => m.Country, null, new { @class = "message" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td class=\"right\">\n            ");
#nullable restore
#line 66 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.LabelFor(m => m.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral(" :\n        </td>\n        <td>\n            ");
#nullable restore
#line 69 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.TextAreaFor(m => m.Notes, 5, 40, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 70 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
       Write(Html.ValidationMessageFor(m => m.Notes, null, new { @class = "message" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n    </tr>\n    <tr>\n        <td colspan=\"2\">\n            <button type=\"submit\">Save</button>\n        </td>\n    </tr>\n</table>\n");
#nullable restore
#line 79 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<br /><br />\n\n");
#nullable restore
#line 83 "C:\Users\jrt16\source\repos\EmployeeManager.ApiClient\Views\EmployeeManager\Insert.cshtml"
Write(Html.ActionLink("Back to Employee Listing", "List","EmployeeManager"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
