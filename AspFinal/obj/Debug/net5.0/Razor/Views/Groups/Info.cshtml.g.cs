#pragma checksum "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\Groups\Info.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4b6bfaf16374af7811dbe9b1df2b2247e6bd9f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Groups_Info), @"mvc.1.0.view", @"/Views/Groups/Info.cshtml")]
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
#line 1 "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\_ViewImports.cshtml"
using AspFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\_ViewImports.cshtml"
using AspFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4b6bfaf16374af7811dbe9b1df2b2247e6bd9f2", @"/Views/Groups/Info.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fde8490a5d3e07df9545e135349c167f5286f95", @"/Views/_ViewImports.cshtml")]
    public class Views_Groups_Info : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Group>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"breadcrumbs\">\r\n    <div class=\"container\">\r\n        <div class=\"row align-items-center\">\r\n            <div class=\"col-md-12\">\r\n                <div class=\"breadcrumbs-content\">\r\n                    <h1 class=\"page-title\">");
#nullable restore
#line 7 "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\Groups\Info.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"page-title\">Müəllim: ");
#nullable restore
#line 8 "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\Groups\Info.cshtml"
                                              Write(Model.Teacher);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"page-title\">Tələbə sayı: ");
#nullable restore
#line 9 "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\Groups\Info.cshtml"
                                                  Write(Model.StudCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"page-title\">Qrup sahəsi: ");
#nullable restore
#line 10 "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\Groups\Info.cshtml"
                                                  Write(Model.Field.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>
        </div>
    </div>
</section>

<div class=""groups"" style=""background-color: #f4f5f8;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""d-flex justify-content-start mt-5"">
                    <h3>
                        Tələbələr:
                    </h3>
                </div>
            </div>
            <div class=""col-md-12"">
                <div class=""row"">
");
#nullable restore
#line 29 "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\Groups\Info.cshtml"
                     foreach (Student item in Model.Students)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"stud-wrapper col-md-4 mt-5\">\r\n                            <div class=\"card stud-card\" style=\"width: 18rem;\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1269, "\"", 1291, 2);
            WriteAttributeValue("", 1275, "/img/", 1275, 5, true);
#nullable restore
#line 33 "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\Groups\Info.cshtml"
WriteAttributeValue("", 1280, item.Image, 1280, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\">\r\n                                <div class=\"card-body\">\r\n                                    <h3 class=\"card-title text-center\">");
#nullable restore
#line 35 "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\Groups\Info.cshtml"
                                                                  Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                                    <p class=\"card-text text-center m-0\">");
#nullable restore
#line 36 "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\Groups\Info.cshtml"
                                                                    Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <div class=\"d-flex justify-content-center mt-3\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1683, "\"", 1713, 2);
            WriteAttributeValue("", 1690, "/students/info/", 1690, 15, true);
#nullable restore
#line 38 "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\Groups\Info.cshtml"
WriteAttributeValue("", 1705, item.Id, 1705, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"more-btn btn btn-success\">Ətraflı</a>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 43 "C:\Nicat\codeacademy\backend\AspFinal\AspFinal\Views\Groups\Info.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Group> Html { get; private set; }
    }
}
#pragma warning restore 1591
