#pragma checksum "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ac74cd1eb85d395ee900484476a2370912727f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Details), @"mvc.1.0.view", @"/Views/Order/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Details.cshtml", typeof(AspNetCore.Views_Order_Details))]
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
#line 1 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Order\Details.cshtml"
using PizzaAppDomain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac74cd1eb85d395ee900484476a2370912727f1", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc15dd9ac112cec217320a8152f12002a6eb2028", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Order\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 132, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n\r\n<div class=\"card\" style=\"width: 18rem;\">\r\n    <div class=\"card-body\">\r\n        <h5 class=\"card-title\">Name: ");
            EndContext();
            BeginContext(213, 20, false);
#line 12 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Order\Details.cshtml"
                                Write(Model.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(233, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(235, 19, false);
#line 12 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Order\Details.cshtml"
                                                      Write(Model.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(254, 66, true);
            WriteLiteral("</h5>\r\n        <h6 class=\"card-subtitle mb-2 text-muted\">Address: ");
            EndContext();
            BeginContext(321, 18, false);
#line 13 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Order\Details.cshtml"
                                                      Write(Model.User.Address);

#line default
#line hidden
            EndContext();
            BeginContext(339, 43, true);
            WriteLiteral("</h6>\r\n        <p class=\"card-text\">Phone: ");
            EndContext();
            BeginContext(383, 16, false);
#line 14 "C:\Users\Asus\Desktop\practicingCoding\MVC\PizzaApp\PizzaApp\Views\Order\Details.cshtml"
                               Write(Model.User.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(399, 28, true);
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
