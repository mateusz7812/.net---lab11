#pragma checksum "C:\Users\Mateusz\Desktop\.net\lab11\lab9\lab9\Views\Shared\_CalculatorForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33737bc1124c12c47570afd3c055a3341b307c26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CalculatorForm), @"mvc.1.0.view", @"/Views/Shared/_CalculatorForm.cshtml")]
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
#line 1 "C:\Users\Mateusz\Desktop\.net\lab11\lab9\lab9\Views\_ViewImports.cshtml"
using lab9;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mateusz\Desktop\.net\lab11\lab9\lab9\Views\_ViewImports.cshtml"
using lab9.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33737bc1124c12c47570afd3c055a3341b307c26", @"/Views/Shared/_CalculatorForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa987364841d628bb5f6d516920a29b1e37a0b4d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__CalculatorForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section>\r\n    <h3>Wpisz wartości funkcji kwadratowej poniżej</h3>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33737bc1124c12c47570afd3c055a3341b307c263307", async() => {
                WriteLiteral("\r\n        <input type=\"number\" id=\"a\" value=\"1\" required/>\r\n        <input type=\"number\" id=\"b\" value=\"2\" required/>\r\n        <input type=\"number\" id=\"c\" value=\"3\" required/>\r\n        <input type=\"submit\" value=\"Oblicz\"/>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onsubmit", 15, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 88, "window.open(\'", 88, 13, true);
#nullable restore
#line 3 "C:\Users\Mateusz\Desktop\.net\lab11\lab9\lab9\Views\Shared\_CalculatorForm.cshtml"
AddHtmlAttributeValue("", 101, Url.Action("Solve", "Tool"), 101, 28, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 129, "/\'", 129, 2, true);
            AddHtmlAttributeValue(" ", 131, "+", 132, 2, true);
            AddHtmlAttributeValue(" ", 133, "document.getElementById(\'a\').value", 134, 35, true);
            AddHtmlAttributeValue(" ", 168, "+\'/\'", 169, 5, true);
            AddHtmlAttributeValue(" ", 173, "+", 174, 2, true);
            AddHtmlAttributeValue(" ", 175, "document.getElementById(\'b\').value", 176, 35, true);
            AddHtmlAttributeValue(" ", 210, "+", 211, 2, true);
            AddHtmlAttributeValue(" ", 212, "\'/\'", 213, 4, true);
            AddHtmlAttributeValue(" ", 216, "+", 217, 2, true);
            AddHtmlAttributeValue(" ", 218, "document.getElementById(\'c\').value,", 219, 36, true);
            AddHtmlAttributeValue(" ", 254, "\'_self\');", 255, 10, true);
            AddHtmlAttributeValue(" ", 264, "return", 265, 7, true);
            AddHtmlAttributeValue(" ", 271, "false;", 272, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
