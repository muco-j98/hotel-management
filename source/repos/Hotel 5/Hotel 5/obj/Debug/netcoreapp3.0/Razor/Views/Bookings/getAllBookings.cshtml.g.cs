#pragma checksum "C:\Users\johan\source\repos\Hotel 5\Hotel 5\Views\Bookings\getAllBookings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fcf2eee17a6b62b705a6f4609014c9423ca53ede"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookings_getAllBookings), @"mvc.1.0.view", @"/Views/Bookings/getAllBookings.cshtml")]
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
#line 1 "C:\Users\johan\source\repos\Hotel 5\Hotel 5\Views\_ViewImports.cshtml"
using Hotel_5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\johan\source\repos\Hotel 5\Hotel 5\Views\_ViewImports.cshtml"
using Hotel_5.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\johan\source\repos\Hotel 5\Hotel 5\Views\_ViewImports.cshtml"
using Hotel_5.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcf2eee17a6b62b705a6f4609014c9423ca53ede", @"/Views/Bookings/getAllBookings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57c59973c826d9a8c7a2db0e0651a80654416fc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookings_getAllBookings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Hotel_5.Controllers.BookingsController.UserBooking>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\johan\source\repos\Hotel 5\Hotel 5\Views\Bookings\getAllBookings.cshtml"
  
    ViewData["Title"] = "All Guests in Rooms";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>All Guests in Rooms</h1>\r\n\r\n<div>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <td>Guest</td>\r\n            <td>Room Nr.</td>\r\n            <td>Checked in date</td>\r\n            <td>Check out date</td>\r\n        </tr>\r\n");
#nullable restore
#line 16 "C:\Users\johan\source\repos\Hotel 5\Hotel 5\Views\Bookings\getAllBookings.cshtml"
         foreach (var v in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 20 "C:\Users\johan\source\repos\Hotel 5\Hotel 5\Views\Bookings\getAllBookings.cshtml"
               Write(v.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 23 "C:\Users\johan\source\repos\Hotel 5\Hotel 5\Views\Bookings\getAllBookings.cshtml"
               Write(v.roomId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 26 "C:\Users\johan\source\repos\Hotel 5\Hotel 5\Views\Bookings\getAllBookings.cshtml"
               Write(v.checkInDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "C:\Users\johan\source\repos\Hotel 5\Hotel 5\Views\Bookings\getAllBookings.cshtml"
               Write(v.checkOutDate.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\johan\source\repos\Hotel 5\Hotel 5\Views\Bookings\getAllBookings.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Hotel_5.Controllers.BookingsController.UserBooking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
