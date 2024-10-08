#pragma checksum "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Dashboard\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "073ec69fd1b48c22c16a1ea67efc35b340b0e5110ab005f16451a2fa6b3443ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\_ViewImports.cshtml"
using AspFinal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\_ViewImports.cshtml"
using AspFinal.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\_ViewImports.cshtml"
using AspFinal.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"073ec69fd1b48c22c16a1ea67efc35b340b0e5110ab005f16451a2fa6b3443ad", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"052e1a16c64e673345cf23483f696d9e516fd68c1d4867e927a2afb20a84c285", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h1 class=""h3 mb-0 text-gray-800"">Dashboard</h1>
</div>

<div class=""row"">
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Banners
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">
                            ");
#nullable restore
#line 17 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Dashboard\Index.cshtml"
                       Write(Model.BannerCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-user fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Fields
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">
                            ");
#nullable restore
#line 36 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Dashboard\Index.cshtml"
                       Write(Model.FieldCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-user fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Groups
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">
                            ");
#nullable restore
#line 55 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Dashboard\Index.cshtml"
                       Write(Model.GroupCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-user fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Students
                        </div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">
                            ");
#nullable restore
#line 74 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Dashboard\Index.cshtml"
                       Write(Model.StudentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-user fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
