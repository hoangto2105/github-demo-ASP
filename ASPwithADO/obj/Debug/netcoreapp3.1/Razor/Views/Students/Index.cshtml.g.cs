#pragma checksum "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\Students\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "926afec964976169857b1ac5ba7650266c44fd92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Index), @"mvc.1.0.view", @"/Views/Students/Index.cshtml")]
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
#line 1 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\_ViewImports.cshtml"
using ASPwithADO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\_ViewImports.cshtml"
using ASPwithADO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"926afec964976169857b1ac5ba7650266c44fd92", @"/Views/Students/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f34100c27cbcc92cf2f6f56ae0d7df085d2fb862", @"/Views/_ViewImports.cshtml")]
    public class Views_Students_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ASPwithADO.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\Students\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Student List</h1>\r\n<br />\r\n<div>\r\n    ");
#nullable restore
#line 9 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\Students\Index.cshtml"
Write(Html.ActionLink("Create New","Create","Students"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<br />
<div>
    <table class=""table"">
        <tr>
            <th>Student ID</th>
            <th>Student Name</th>
            <th>Student Address</th>
            <th>Gender</th>
            <th>Birthday</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 22 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\Students\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\Students\Index.cshtml"
       Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\Students\Index.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\Students\Index.cshtml"
       Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\Students\Index.cshtml"
       Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\Students\Index.cshtml"
       Write(item.Birthday);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>\r\n            ");
#nullable restore
#line 31 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\Students\Index.cshtml"
       Write(Html.ActionLink("Remove", "Delete", new { id = item.Id }, new { @class = "btn btn-info", onclick = "return confirm('Are you sure')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\r\n            ");
#nullable restore
#line 32 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\Students\Index.cshtml"
       Write(Html.ActionLink("Update", "Edit", new { id = item.Id }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 36 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO\Views\Students\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ASPwithADO.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
