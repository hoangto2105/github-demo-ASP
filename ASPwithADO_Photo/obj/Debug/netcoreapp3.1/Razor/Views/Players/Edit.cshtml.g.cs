#pragma checksum "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1756832d32721db637ecb9f5144707ecb0b8d7c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Players_Edit), @"mvc.1.0.view", @"/Views/Players/Edit.cshtml")]
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
#line 1 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\_ViewImports.cshtml"
using ASPwithADO_Photo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\_ViewImports.cshtml"
using ASPwithADO_Photo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1756832d32721db637ecb9f5144707ecb0b8d7c4", @"/Views/Players/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddb586c6bcac315222b1d0d0ca51907d23e569cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Players_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASPwithADO_Photo.Models.Player>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Edit Player</h1>\r\n<br />\r\n<div>\r\n    ");
#nullable restore
#line 9 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
Write(Html.ActionLink("Back to List", "Index", "Players"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n\r\n");
#nullable restore
#line 13 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
 using (Html.BeginForm("Create", "Players", FormMethod.Post, new { enctype = "multipart/form-data" }))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <div>\r\n            ");
#nullable restore
#line 18 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <label style=\"font-weight:bold\">Player Name</label>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 24 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
       Write(Html.EditorFor(m => m.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 25 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
       Write(Html.ValidationMessageFor(m => m.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            <label style=\"font-weight:bold\">Date of Birth</label>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 32 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
       Write(Html.EditorFor(m => m.DateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 33 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
       Write(Html.ValidationMessageFor(m => m.DateOfBirth, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            <label style=\"font-weight:bold\">Age</label>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 40 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
       Write(Html.EditorFor(m => m.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 41 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
       Write(Html.ValidationMessageFor(m => m.Age, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n            <label style=\"font-weight:bold\">Position</label>\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 48 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
       Write(Html.EditorFor(m => m.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 49 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
       Write(Html.ValidationMessageFor(m => m.Position, "", new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n        <div>\r\n\r\n            ");
#nullable restore
#line 54 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
       Write(Html.LabelFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"file\" name=\"file\" />\r\n\r\n        </div>\r\n        <br />\r\n        <div>\r\n            <input type=\"submit\" value=\"Update\" class=\"btn btn-warning\" onclick=\"return confirm (\'Are you sure\')\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 63 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h2>");
#nullable restore
#line 66 "C:\Users\hoang\source\repos\ASPwithADO\ASPwithADO_Photo\Views\Players\Edit.cshtml"
   Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASPwithADO_Photo.Models.Player> Html { get; private set; }
    }
}
#pragma warning restore 1591
