#pragma checksum "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\_CarOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a26316b6e2d269403e181bc1d66282bdd6c38e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetails__CarOrders), @"mvc.1.0.view", @"/Views/OrderDetails/_CarOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderDetails/_CarOrders.cshtml", typeof(AspNetCore.Views_OrderDetails__CarOrders))]
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
#line 1 "D:\MDZulhas\AspnetProject\Project_08\Views\_ViewImports.cshtml"
using Project_08;

#line default
#line hidden
#line 2 "D:\MDZulhas\AspnetProject\Project_08\Views\_ViewImports.cshtml"
using Project_08.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43a26316b6e2d269403e181bc1d66282bdd6c38e", @"/Views/OrderDetails/_CarOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdc753bf4aedff114525d979287aeb262d9de9c8", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderDetails__CarOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_08.Models.CarOrderDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 433, true);
            WriteLiteral(@"

    <table class=""table"">
        <thead>
            <tr>
                <th>
                    OrderNo
                </th>
                <th>
                    Name
                </th>
                <th>
                    Email
                </th>
                <th>
                    Address
                </th>
                <th>
                    OrderDate
                </th>
");
            EndContext();
            BeginContext(506, 54, true);
            WriteLiteral("            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 26 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\_CarOrders.cshtml"
             foreach (var item in Model.CarOrders)
            {

#line default
#line hidden
            BeginContext(627, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(700, 42, false);
#line 30 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\_CarOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderNo));

#line default
#line hidden
            EndContext();
            BeginContext(742, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(822, 39, false);
#line 33 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\_CarOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(861, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(941, 40, false);
#line 36 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\_CarOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(981, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1061, 42, false);
#line 39 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\_CarOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1183, 44, false);
#line 42 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\_CarOrders.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(1227, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
            BeginContext(1564, 23, true);
            WriteLiteral("                </tr>\r\n");
            EndContext();
#line 50 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\_CarOrders.cshtml"
            }

#line default
#line hidden
            BeginContext(1602, 30, true);
            WriteLiteral("        </tbody>\r\n    </table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project_08.Models.CarOrderDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
