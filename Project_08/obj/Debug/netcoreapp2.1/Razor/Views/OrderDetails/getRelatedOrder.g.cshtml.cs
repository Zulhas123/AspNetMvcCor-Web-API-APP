#pragma checksum "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15d8df973ccf678d0f6ca7e25d5f61365422e8f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderDetails_getRelatedOrder), @"mvc.1.0.view", @"/Views/OrderDetails/getRelatedOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OrderDetails/getRelatedOrder.cshtml", typeof(AspNetCore.Views_OrderDetails_getRelatedOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15d8df973ccf678d0f6ca7e25d5f61365422e8f9", @"/Views/OrderDetails/getRelatedOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdc753bf4aedff114525d979287aeb262d9de9c8", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderDetails_getRelatedOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_08.Models.CarOrderDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_CarOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_OrderDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(85, 29, true);
            WriteLiteral("\r\n<h1>Car Create</h1>\r\n\r\n\r\n\r\n");
            EndContext();
#line 11 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
 if (Model.CarOrders != null)
{

#line default
#line hidden
            BeginContext(148, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(152, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7fcd236e715642088f898b91d9f5cfcd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
   
}

#line default
#line hidden
            BeginContext(191, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(202, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22bea990498e4461b79bb02ae17f6f79", async() => {
                BeginContext(225, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(239, 10, true);
            WriteLiteral("\r\n</p>\r\n\r\n");
            EndContext();
#line 21 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
 if (Model.OrderDetails != null)
{
    

#line default
#line hidden
            BeginContext(292, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(296, 32, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b8dd931d9d6444af82f1db1084eaafe9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(328, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
}

#line default
#line hidden
            BeginContext(333, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 28 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
 if (Model != null)
{

#line default
#line hidden
            BeginContext(361, 582, true);
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Name
                </th>
                <th>
                    Model
                </th>
                <th>
                   price
                </th>
                <th>
                    IsAvailable
                </th>
                <th>
                    Image
                </th>
                <th>
                    Car Type
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 55 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
             foreach (var item in Model.Cars)
            {

#line default
#line hidden
            BeginContext(1005, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1078, 39, false);
#line 59 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1117, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1197, 40, false);
#line 62 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1317, 40, false);
#line 65 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
            EndContext();
            BeginContext(1357, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1437, 46, false);
#line 68 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1483, 83, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1566, "\"", 1599, 1);
#line 71 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
WriteAttributeValue("", 1572, Url.Content(item.ImageUrl), 1572, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1600, 107, true);
            WriteLiteral(" height=\"100\" width=\"100\" />\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1708, 45, false);
#line 74 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CarType.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1753, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1833, 95, false);
#line 77 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
                   Write(Html.ActionLink("select", "getRelatedOrder", new { GuestId = item.Id }, new { @class = "btn" }));

#line default
#line hidden
            EndContext();
            BeginContext(1928, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2185, 50, true);
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 83 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"
            }

#line default
#line hidden
            BeginContext(2250, 32, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 86 "D:\MDZulhas\AspnetProject\Project_08\Views\OrderDetails\getRelatedOrder.cshtml"

}

#line default
#line hidden
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
