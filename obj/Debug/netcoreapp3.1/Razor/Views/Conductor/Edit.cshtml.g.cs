#pragma checksum "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9278323e9eca46c77b277634510dc5fcdc14e49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conductor_Edit), @"mvc.1.0.view", @"/Views/Conductor/Edit.cshtml")]
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
#line 1 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/_ViewImports.cshtml"
using serviceCar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/_ViewImports.cshtml"
using serviceCar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9278323e9eca46c77b277634510dc5fcdc14e49", @"/Views/Conductor/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0543cff94467543fc92cb08d8c6d139b133c69f2", @"/Views/_ViewImports.cshtml")]
    public class Views_Conductor_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<serviceCar.Models.DbModels.Conductor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
  
    Layout = "_UsersLayout";
    ViewData["Title"]="Editer Profil";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9278323e9eca46c77b277634510dc5fcdc14e493977", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Edit</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9278323e9eca46c77b277634510dc5fcdc14e495021", async() => {
                WriteLiteral("\r\n\r\n<h4>Conductor</h4>\r\n<hr />\r\n<div class=\"row\">\r\n\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 23 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
       Write(Html.HiddenFor(model=>model.User));

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"form-group\">\r\n                <div class=\"editor-label\">\r\n                    ");
#nullable restore
#line 30 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
               Write(Html.LabelFor(model=>model.UserNavigation.Login));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"editor-field\">\r\n                    ");
#nullable restore
#line 33 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
               Write(Html.EditorFor(model=>model.UserNavigation.Login));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
                WriteLiteral("            <div class=\"form-group\">\r\n                <div class=\"editor-label\">\r\n                    ");
#nullable restore
#line 39 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
               Write(Html.LabelFor(model=>model.UserNavigation.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"editor-field\">\r\n                    ");
#nullable restore
#line 42 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
               Write(Html.EditorFor(model=>model.UserNavigation.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
                WriteLiteral("            <div class=\"form-group\">\r\n                <div class=\"editor-label\">\r\n                    ");
#nullable restore
#line 49 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
               Write(Html.LabelFor(model=>model.Cin));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"editor-field\">\r\n                    ");
#nullable restore
#line 52 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
               Write(Html.EditorFor(model=>model.Cin));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <div class=\"editor-label\">\r\n                    ");
#nullable restore
#line 57 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
               Write(Html.LabelFor(model=>model.TelephoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"editor-field\">\r\n                    ");
#nullable restore
#line 60 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
               Write(Html.EditorFor(model=>model.TelephoneNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <!--<span asp-validation-for=\"TelephoneNumber\" class=\"text-danger\"></span>-->\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <div class=\"editor-label\">\r\n                    ");
#nullable restore
#line 66 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
               Write(Html.LabelFor(model=>model.Adress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"editor-field\">\r\n                    ");
#nullable restore
#line 69 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
               Write(Html.EditorFor(model=>model.Adress));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <!--<span asp-validation-for=\"Adress\" class=\"text-danger\"></span>-->\r\n            </div>\r\n");
                WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n");
#nullable restore
#line 77 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Views/Conductor/Edit.cshtml"
        
    
        }       

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n    <div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9278323e9eca46c77b277634510dc5fcdc14e4910558", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
