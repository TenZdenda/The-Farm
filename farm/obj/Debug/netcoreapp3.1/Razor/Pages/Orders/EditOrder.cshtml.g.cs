#pragma checksum "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5bc020b00d00d7c54bd2c7d42854e8ca8e6d487"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(farm.Pages.Orders.Pages_Orders_EditOrder), @"mvc.1.0.razor-page", @"/Pages/Orders/EditOrder.cshtml")]
namespace farm.Pages.Orders
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
#line 1 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/_ViewImports.cshtml"
using farm;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5bc020b00d00d7c54bd2c7d42854e8ca8e6d487", @"/Pages/Orders/EditOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b977339cb2b29adf36c40151b9adbdf84c31e009", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Orders_EditOrder : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-white px-3 py-2 rounded-md text-sm font-medium"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Products/GetAllProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-gray-900 text-gray-300 hover:bg-gray-700 hover:text-white px-3 py-2 rounded-md text-sm font-medium"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Orders/GetAllOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-gray-300 hover:bg-gray-700 hover:text-white px-3 py-2 rounded-md text-sm font-medium"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "GetAllOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-gray-800 text-white text-center w-48 p-3 mb-10 rounded hover:bg-gray-600 block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
  
    ViewData["Title"] = "Admin order detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
 if (Model.validUser != 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Please login..</p>\n");
#nullable restore
#line 10 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div>
        <nav class=""bg-gray-800"">
            <div class=""max-w-7xl mx-auto px-4 sm:px-6 lg:px-8"">
                <div class=""flex items-center justify-between h-16"">
                    <div class=""flex items-center"">
                        <div class=""flex-shrink-0"">
                            <img class=""h-8 w-8"" src=""https://tailwindui.com/img/logos/workflow-mark-indigo-500.svg"" alt=""Workflow"">
                        </div>
                        <div class=""hidden md:block"">
                            <div class=""ml-10 flex items-baseline space-x-4"">
                                <!-- Current: ""bg-gray-900 text-white"", Default: ""text-gray-300 hover:bg-gray-700 hover:text-white"" -->
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5bc020b00d00d7c54bd2c7d42854e8ca8e6d4877526", async() => {
                WriteLiteral("Dashboard");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5bc020b00d00d7c54bd2c7d42854e8ca8e6d4878978", async() => {
                WriteLiteral("Products");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5bc020b00d00d7c54bd2c7d42854e8ca8e6d48710429", async() => {
                WriteLiteral("Orders");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </nav>

        <header class=""bg-white shadow"">
            <div class=""max-w-7xl mx-auto py-6 px-4 sm:px-6 lg:px-8"">
                <h1 class=""text-3xl font-bold leading-tight text-gray-900"">
                    Orders
                </h1>
            </div>
        </header>
        <main>
            <div class=""max-w-7xl mx-auto py-6 sm:px-6 lg:px-8"">
                <div class=""px-4 py-6 sm:px-0"">
                    <div class=""flex flex-col"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5bc020b00d00d7c54bd2c7d42854e8ca8e6d48712481", async() => {
                WriteLiteral("\n                            <i class=\"uil uil-arrow-left\"></i> Go back\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        <h2 class=\"text-xl font-bold leading-tight text-gray-900 mb-10\">Delete a product with ID - ");
#nullable restore
#line 50 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
                                                                                                              Write(Model.Order.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n                        <div>\n                            <p class=\"block text-xl mb-10\">\n                                Customer name: ");
#nullable restore
#line 54 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
                                          Write(Model.Order.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </p>\n\n                            <p class=\"block text-xl mb-10\">\n                                Customer phone: ");
#nullable restore
#line 58 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
                                           Write(Model.Order.Customer.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </p>\n\n                            <p class=\"block text-xl mb-10\">\n                                Customer address: ");
#nullable restore
#line 62 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
                                             Write(Model.Order.Customer.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </p>\n\n                            <h3 class=\"text-lg font-bold leading-tight text-gray-900 mt-5 mb-2\"></h3>\n\n");
#nullable restore
#line 67 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
                             foreach (var item in @Model.Order.List)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p class=\"block text-xl mb-10\">\n                                    <ul>\n                                        <li>Product name: ");
#nullable restore
#line 71 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
                                                     Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                        <li>Product name: ");
#nullable restore
#line 72 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                        <li>Product name: ");
#nullable restore
#line 73 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
                                                     Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                    </ul>\n                                </p>\n");
#nullable restore
#line 76 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            <p class=\"block text-xl mb-10\">\n                                Datetime: ");
#nullable restore
#line 79 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
                                     Write(Model.Order.DateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                            </p>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </main>\n    </div>\n");
#nullable restore
#line 87 "/Users/zdenekpasek/www/The-Farm-2.0/farm/Pages/Orders/EditOrder.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<farm.Pages.Orders.EditOrderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<farm.Pages.Orders.EditOrderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<farm.Pages.Orders.EditOrderModel>)PageContext?.ViewData;
        public farm.Pages.Orders.EditOrderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
