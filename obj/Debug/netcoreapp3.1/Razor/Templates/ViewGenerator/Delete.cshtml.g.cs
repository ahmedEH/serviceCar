#pragma checksum "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fef101f628cc5460e91db962b25c8834a978580b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Templates_ViewGenerator_Delete), @"mvc.1.0.view", @"/Templates/ViewGenerator/Delete.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
using Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fef101f628cc5460e91db962b25c8834a978580b", @"/Templates/ViewGenerator/Delete.cshtml")]
    public class Templates_ViewGenerator_Delete : Microsoft.VisualStudio.Web.CodeGeneration.Templating.RazorTemplateBase
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("@model ");
#nullable restore
#line 5 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
   Write(Model.ViewDataTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
  
    if (Model.IsPartialView)
    {
    }
    else if (Model.IsLayoutPageSelected)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@{\r\n    ");
            WriteLiteral("ViewData[\"Title\"] = \"");
#nullable restore
#line 14 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
                      Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 15 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
        if (!string.IsNullOrEmpty(Model.LayoutPageFile))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("Layout = \"");
#nullable restore
#line 17 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
           Write(Model.LayoutPageFile);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n");
#nullable restore
#line 18 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<h1>");
#nullable restore
#line 21 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
 Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 23 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("@{\r\n    ");
            WriteLiteral("Layout = null;\r\n");
            WriteLiteral("}\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<!DOCTYPE html>\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("<html>\r\n");
            WriteLiteral("<head>\r\n    ");
            WriteLiteral("<meta name=\"viewport\" content=\"width=device-width\" />\r\n    ");
            WriteLiteral("<title>");
#nullable restore
#line 35 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
        Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</title>\r\n");
            WriteLiteral("</head>\r\n");
            WriteLiteral("<body>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 39 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
        //    PushIndent("    ");
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>");
#nullable restore
#line 44 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
   Write(Model.ViewDataTypeShortName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n");
#nullable restore
#line 47 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
  
    Dictionary<string, IPropertyMetadata> propertyLookup = ((IModelMetadata)Model.ModelMetadata).Properties.ToDictionary(x => x.PropertyName, x => x);
    Dictionary<string, INavigationMetadata> navigationLookup = ((IModelMetadata)Model.ModelMetadata).Navigations.ToDictionary(x => x.AssociationPropertyName, x => x);

    foreach (var item in Model.ModelMetadata.ModelType.GetProperties())
    {
        if (propertyLookup.TryGetValue(item.Name, out IPropertyMetadata property)
            && property.Scaffold && !property.IsForeignKey && !property.IsPrimaryKey)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 57 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
                                            Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            WriteLiteral("@Html.DisplayFor(model => model.");
#nullable restore
#line 60 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
                                        Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dd>\r\n");
#nullable restore
#line 62 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
        }
        else if (navigationLookup.TryGetValue(item.Name, out INavigationMetadata navigation))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <dt class = \"col-sm-2\">\r\n            ");
            WriteLiteral("@Html.DisplayNameFor(model => model.");
#nullable restore
#line 66 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
                                            Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            WriteLiteral("@Html.DisplayFor(model => model.");
#nullable restore
#line 69 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
                                        Write(GetValueExpression(navigation));

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 69 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
                                                                        Write(navigation.DisplayPropertyName);

#line default
#line hidden
#nullable disable
            WriteLiteral(")\r\n        </dd class>\r\n");
#nullable restore
#line 71 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral("</dl>\r\n    ");
            WriteLiteral("\r\n    ");
            WriteLiteral("<form asp-action=\"");
#nullable restore
#line 75 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
                   Write(Model.ViewName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n");
#nullable restore
#line 76 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
        foreach (var property in Model.ModelMetadata.Properties)
        {
            if(property.IsPrimaryKey){

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("<input type=\"hidden\" asp-for=\"");
#nullable restore
#line 79 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
                                   Write(GetValueExpression(property));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" />\r\n");
#nullable restore
#line 80 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("<input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
            WriteLiteral("<a asp-action=\"Index\">Back to List</a>\r\n    ");
            WriteLiteral("</form>\r\n");
            WriteLiteral("</div>\r\n");
#nullable restore
#line 86 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
    if (!Model.IsPartialView && !Model.IsLayoutPageSelected)
    {
        //ClearIndent();

#line default
#line hidden
#nullable disable
            WriteLiteral("</body>\r\n");
            WriteLiteral("</html>\r\n");
#nullable restore
#line 91 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "/media/hmd377/#Workspace/#Web_Workspace/#asp_workspace/serviceCar/Templates/ViewGenerator/Delete.cshtml"
 
    string GetValueExpression(IPropertyMetadata property)
    {
        return property.PropertyName;
    }

    string GetValueExpression(INavigationMetadata navigation)
    {
        return navigation.AssociationPropertyName;
    }

#line default
#line hidden
#nullable disable
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
