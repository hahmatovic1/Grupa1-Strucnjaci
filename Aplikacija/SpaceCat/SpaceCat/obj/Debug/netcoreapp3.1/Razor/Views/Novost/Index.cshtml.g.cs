#pragma checksum "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Novost\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "042ab38832fb9f75d558d504f4cb11602d9a2fff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Novost_Index), @"mvc.1.0.view", @"/Views/Novost/Index.cshtml")]
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
#line 1 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\_ViewImports.cshtml"
using SpaceCat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\_ViewImports.cshtml"
using SpaceCat.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Novost\Index.cshtml"
using SpaceCat.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"042ab38832fb9f75d558d504f4cb11602d9a2fff", @"/Views/Novost/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cfb7ca88e7d849119cde011028e102232e06fef", @"/Views/_ViewImports.cshtml")]
    public class Views_Novost_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SpaceCat.Novost>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dodaj"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Novost\Index.cshtml"
  
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

    #bijelitekst {
        color: snow;
    }

    #naslov {
        background-color: #043240;
    }

    #tekst {
        background-color: #1f4c64;
    }

    #opcije {
        background-color: #043240;
    }

    #naziv {
        text-align: center;
    }

    #dodaj:link, #e:link, #del:link, #det:link, #e:visited, #del:visited, #det:visited, #dodaj:visited {
        color: white;
        text-decoration: none;
    }

    #dodaj:hover, #e:hover, #del:hover, #det:hover {
        color: cadetblue;
        text-decoration: none;
    }

    #tekst_dodaj {
        text-align: center;
    }
</style>
<h1 id=""naziv"">Novosti</h1>
");
#nullable restore
#line 52 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Novost\Index.cshtml"
 if (User.IsInRole("admin"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p id=\"tekst_dodaj\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "042ab38832fb9f75d558d504f4cb11602d9a2fff5436", async() => {
                WriteLiteral("Dodaj novost");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 57 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Novost\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""carouselExampleCaptions"" class=""carousel slide"" data-ride=""carousel"">
    
    <div class=""carousel-inner"">
        <div class=""carousel slide"" data-ride=""carousel"" data-interval=""5000"" style=""width:100%;"">
            <div class=""carousel-inner"">
");
#nullable restore
#line 64 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Novost\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 1516, "\"", 1569, 2);
            WriteAttributeValue("", 1524, "carousel-item", 1524, 13, true);
#nullable restore
#line 66 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Novost\Index.cshtml"
WriteAttributeValue(" ", 1537, item.ID == 1 ? "active" : "", 1538, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">

                    <img src=""https://www.thevintagenews.com/wp-content/uploads/2020/02/space_cat.jpg"" class=""d-block w-100"" alt=""..."" />
                    
                   

                       <div class=""carousel-caption d-none d-md-block"">

                        <h5>");
#nullable restore
#line 74 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Novost\Index.cshtml"
                              Html.DisplayFor(modelItem => item.Naslov);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p>\r\n                            ");
#nullable restore
#line 76 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Novost\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 81 "C:\Users\anesa\Source\Repos\Grupa1-Strucnjaci\Aplikacija\SpaceCat\SpaceCat\Views\Novost\Index.cshtml"
                 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>



       
        





        <a class=""carousel-control-prev"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleCaptions"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
 
  </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SpaceCat.Novost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
