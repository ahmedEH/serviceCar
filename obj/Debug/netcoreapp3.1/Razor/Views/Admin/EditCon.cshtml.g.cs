#pragma checksum "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d1601db7690001990b308b017a0c6cd01168781"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditCon), @"mvc.1.0.view", @"/Views/Admin/EditCon.cshtml")]
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
#line 1 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\_ViewImports.cshtml"
using serviceCar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\_ViewImports.cshtml"
using serviceCar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d1601db7690001990b308b017a0c6cd01168781", @"/Views/Admin/EditCon.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2d5013255d33914c0bbaaa6a41d109f2acbd59f", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditCon : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<serviceCar.Models.DbModels.Conductor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
  
    ViewBag.Title = "Edit Conductor";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>EditCon</h2>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-horizontal\">\r\n    <h4>Conductor</h4>\r\n    <hr />\r\n    ");
#nullable restore
#line 17 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
Write(Html.HiddenFor(model => model.User));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
   Write(Html.LabelFor(model => model.UserNavigation.FName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.EditorFor(model => model.UserNavigation.FName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserNavigation.FName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 29 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
   Write(Html.LabelFor(model => model.UserNavigation.LName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.EditorFor(model => model.UserNavigation.LName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 32 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserNavigation.LName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 37 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
   Write(Html.LabelFor(model => model.UserNavigation.Login, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 39 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.EditorFor(model => model.UserNavigation.Login, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 40 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserNavigation.Login, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 45 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
   Write(Html.LabelFor(model => model.UserNavigation.Password, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.EditorFor(model => model.UserNavigation.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 48 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.ValidationMessageFor(model => model.UserNavigation.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 53 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
   Write(Html.LabelFor(model => model.UserNavigation.IsAdmin, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <div class=\"checkbox\">\r\n                ");
#nullable restore
#line 56 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
           Write(Html.EditorFor(model => model.UserNavigation.IsAdmin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 57 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
           Write(Html.ValidationMessageFor(model => model.UserNavigation.IsAdmin, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 63 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
   Write(Html.LabelFor(model => model.Cin, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.EditorFor(model => model.Cin, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 66 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.ValidationMessageFor(model => model.Cin, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 71 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
   Write(Html.LabelFor(model => model.TelephoneNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 73 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.EditorFor(model => model.TelephoneNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 74 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.ValidationMessageFor(model => model.TelephoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 79 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
   Write(Html.LabelFor(model => model.Adress, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 81 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.EditorFor(model => model.Adress, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 82 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
       Write(Html.ValidationMessageFor(model => model.Adress, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 87 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
   Write(Html.LabelFor(model => model.Active, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            <div class=\"checkbox\">\r\n                ");
#nullable restore
#line 90 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
           Write(Html.EditorFor(model => model.Active));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 91 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
           Write(Html.ValidationMessageFor(model => model.Active, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Save\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 102 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    ");
#nullable restore
#line 105 "C:\Users\hilia\OneDrive\Bureau\c# project\serviceCar\Views\Admin\EditCon.cshtml"
Write(Html.ActionLink("Back to List", "DisplayCon"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<serviceCar.Models.DbModels.Conductor> Html { get; private set; }
    }
}
#pragma warning restore 1591
