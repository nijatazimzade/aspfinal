#pragma checksum "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Messages\Details.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "125103f4ab727ee772eab7bc5bb7abea734b5e4e62dc97321035cfc4087969ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Admin_Views_Messages_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Messages/Details.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\_ViewImports.cshtml"
using AspFinal

#nullable disable
    ;
#nullable restore
#line 2 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\_ViewImports.cshtml"
using AspFinal.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\_ViewImports.cshtml"
using AspFinal.Areas.Admin.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"125103f4ab727ee772eab7bc5bb7abea734b5e4e62dc97321035cfc4087969ba", @"/Areas/Admin/Views/Messages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"052e1a16c64e673345cf23483f696d9e516fd68c1d4867e927a2afb20a84c285", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Areas_Admin_Views_Messages_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Messages\Details.cshtml"
       AspFinal.Models.Message

#line default
#line hidden
#nullable disable
    >
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Messages\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Message</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 14 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Messages\Details.cshtml"
             Html.DisplayNameFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 17 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Messages\Details.cshtml"
             Html.DisplayFor(model => model.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 20 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Messages\Details.cshtml"
             Html.DisplayNameFor(model => model.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 23 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Messages\Details.cshtml"
             Html.DisplayFor(model => model.Email)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 26 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Messages\Details.cshtml"
             Html.DisplayNameFor(model => model.Subject)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 29 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Messages\Details.cshtml"
             Html.DisplayFor(model => model.Subject)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            Write(
#nullable restore
#line 32 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Messages\Details.cshtml"
             Html.DisplayNameFor(model => model.Text)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            Write(
#nullable restore
#line 35 "C:\nijatazimzade\codeacademy\backend\AspFinal\AspFinal\Areas\Admin\Views\Messages\Details.cshtml"
             Html.DisplayFor(model => model.Text)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "125103f4ab727ee772eab7bc5bb7abea734b5e4e62dc97321035cfc4087969ba7428", async() => {
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspFinal.Models.Message> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
