#pragma checksum "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Pizza\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a39bae2ac79f152d9b434e4802c3eedb3244ab9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Details), @"mvc.1.0.view", @"/Views/Pizza/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizza/Details.cshtml", typeof(AspNetCore.Views_Pizza_Details))]
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
#line 1 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\_ViewImports.cshtml"
using PizzaApp;

#line default
#line hidden
#line 2 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\_ViewImports.cshtml"
using PizzaApp.Models;

#line default
#line hidden
#line 1 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Pizza\Details.cshtml"
using PizzaAppDomain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a39bae2ac79f152d9b434e4802c3eedb3244ab9e", @"/Views/Pizza/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc15dd9ac112cec217320a8152f12002a6eb2028", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pizza>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Pizza\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 126, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n\r\n<div class=\"card\" style=\"width: 18rem;\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">");
            EndContext();
            BeginContext(207, 15, false);
#line 12 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Pizza\Details.cshtml"
                          Write(Model.PizzaName);

#line default
#line hidden
            EndContext();
            BeginContext(222, 63, true);
            WriteLiteral("</h5>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">Price:");
            EndContext();
            BeginContext(286, 26, false);
#line 13 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Pizza\Details.cshtml"
                                                   Write(Model.GetPrice(Model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(312, 36, true);
            WriteLiteral("</h6>\r\n        <p class=\"card-text\">");
            EndContext();
            BeginContext(349, 17, false);
#line 14 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Pizza\Details.cshtml"
                        Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(366, 26, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pizza> Html { get; private set; }
    }
}
#pragma warning restore 1591
