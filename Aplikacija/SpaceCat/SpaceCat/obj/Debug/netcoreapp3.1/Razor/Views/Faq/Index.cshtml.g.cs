#pragma checksum "C:\Users\Belma fax\RiderProjects\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Faq\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdd7680eb9c19533b408552de2e9a4ef0d660015"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Faq_Index), @"mvc.1.0.view", @"/Views/Faq/Index.cshtml")]
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
#line 1 "C:\Users\Belma fax\RiderProjects\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\_ViewImports.cshtml"
using SpaceCat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Belma fax\RiderProjects\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\_ViewImports.cshtml"
using SpaceCat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdd7680eb9c19533b408552de2e9a4ef0d660015", @"/Views/Faq/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cfb7ca88e7d849119cde011028e102232e06fef", @"/Views/_ViewImports.cshtml")]
    public class Views_Faq_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SpaceCat.Faq>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Utisak", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-1 style="), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Belma fax\RiderProjects\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Faq\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    body {
        color: snow;
        background-image: url(""https://i.ibb.co/h10jKh0/novapoz.png"");
        height: 100%;
        background-position: center;
        background-repeat: no-repeat;
        background-size: cover;
    }


    .grid-container {
        display: grid;
        grid-template-columns: 1fr 2fr 6fr 2fr 5.5fr 0.5fr;
        grid-template-rows: 1fr 2fr 8fr 0.5fr;
    }

    .pitanje-i-odgovor {
        grid-column: 2 / span 4;
        grid-row: 3 / span 1;
    }

    .spacecat-logo {
        grid-column: 1 / span 2;
        grid-row: 1 / span 1;
    }

    .naslov {
        grid-column: 4 / span 1;
        grid-row: 2 / span 1;
    }

    .button1 {
        grid-column: 6 / span 1;
        grid-row: 4 / span 1;
    }

    .btn {
        width: 10em;
        flex: 1 1 auto;
        margin: 1px;
        padding: 5px;
        text-transform: uppercase;
        transition: 0.5s;
        background-size: 200% auto;
        color: #000");
            WriteLiteral(@"000;
        /* text-shadow: 0px 0px 10px rgba(0,0,0,0.2);*/
        box-shadow: 0 0 20px #eee;
        border-radius: 10px;
        border-style: solid;
        /*border-color:#000000;*/
    }

    .btn:hover {
            background-position: right center; /* change the direction of the change here */
    }

    .btn-1 {
        background-image: linear-gradient(to right, #f6d365 0%, #fda085 51%, #f6d365 100%);
    }

    h1 {
        color: #fff;
        font-family: 'Helvetica Neue', sans-serif;
        font-size: 64px;
        font-weight: bold;
        letter-spacing: -1px;
        line-height: 1;
        text-align: center;
    }

    h2 {
        color: #fff;
        font-family: 'Open Sans', sans-serif;
        font-size: 30px;
        font-weight: 300;
        line-height: 32px;
        margin: 0 0 5px;
        text-align: left;
    }


</style>


<div class=""grid-container"">
    <div class=""spacecat-logo"">
        <img style=""height:5em"" src=""https://i.ibb.");
            WriteLiteral("co/bBFyWZq/Log2o.png\" />\r\n    </div>\r\n    <div class=\"naslov text-center\">\r\n        <h1>FAQ</h1>\r\n    </div>\r\n    <div class=\"pitanje-i-odgovor  text-left\">\r\n");
#nullable restore
#line 100 "C:\Users\Belma fax\RiderProjects\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Faq\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>");
#nullable restore
#line 102 "C:\Users\Belma fax\RiderProjects\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Faq\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Pitanje));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <h5>");
#nullable restore
#line 103 "C:\Users\Belma fax\RiderProjects\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Faq\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Odgovor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <br />\r\n");
#nullable restore
#line 105 "C:\Users\Belma fax\RiderProjects\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Faq\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div class=\"button1\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdd7680eb9c19533b408552de2e9a4ef0d6600158159", async() => {
                WriteLiteral("Utisci");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("background-color:gray\"", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("text-decoration:", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("none", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SpaceCat.Faq>> Html { get; private set; }
    }
}
#pragma warning restore 1591
