#pragma checksum "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be4b72c6f5d63ba694a591a321f25ec8f94b3ba2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kamar_Details), @"mvc.1.0.view", @"/Views/Kamar/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Kamar/Details.cshtml", typeof(AspNetCore.Views_Kamar_Details))]
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
#line 1 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\_ViewImports.cshtml"
using UAS_20170140120_DeckyAprianto;

#line default
#line hidden
#line 2 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\_ViewImports.cshtml"
using UAS_20170140120_DeckyAprianto.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be4b72c6f5d63ba694a591a321f25ec8f94b3ba2", @"/Views/Kamar/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13479ecdc3f6b044740b8f5926e59f3105bab89f", @"/Views/_ViewImports.cshtml")]
    public class Views_Kamar_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UAS_20170140120_DeckyAprianto.Models.Kamar>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(96, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Kamar</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(216, 45, false);
#line 14 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TypeKamar));

#line default
#line hidden
            EndContext();
            BeginContext(261, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(305, 41, false);
#line 17 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml"
       Write(Html.DisplayFor(model => model.TypeKamar));

#line default
#line hidden
            EndContext();
            BeginContext(346, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(390, 43, false);
#line 20 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NoKamar));

#line default
#line hidden
            EndContext();
            BeginContext(433, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(477, 39, false);
#line 23 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml"
       Write(Html.DisplayFor(model => model.NoKamar));

#line default
#line hidden
            EndContext();
            BeginContext(516, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(560, 42, false);
#line 26 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Lantai));

#line default
#line hidden
            EndContext();
            BeginContext(602, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(646, 38, false);
#line 29 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml"
       Write(Html.DisplayFor(model => model.Lantai));

#line default
#line hidden
            EndContext();
            BeginContext(684, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(728, 41, false);
#line 32 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Biaya));

#line default
#line hidden
            EndContext();
            BeginContext(769, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(813, 37, false);
#line 35 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml"
       Write(Html.DisplayFor(model => model.Biaya));

#line default
#line hidden
            EndContext();
            BeginContext(850, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(894, 42, false);
#line 38 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(936, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(980, 38, false);
#line 41 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1065, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59aad0391f4b424fb5734b7a46563453", async() => {
                BeginContext(1116, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "D:\ZAAHID\College\PKW\ASU\UAS_20170140120_DeckyAprianto_ver.2\UAS_20170140120_DeckyAprianto\Views\Kamar\Details.cshtml"
                           WriteLiteral(Model.IdKamar);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1124, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1132, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4e36343765e435398c3223af0a05ab3", async() => {
                BeginContext(1154, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1170, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UAS_20170140120_DeckyAprianto.Models.Kamar> Html { get; private set; }
    }
}
#pragma warning restore 1591