#pragma checksum "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bdf451b9dd364dbb4a618fa921a4c062abe84cd"
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
#line 1 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\_ViewImports.cshtml"
using PizzaStoreWebApp;

#line default
#line hidden
#line 2 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\_ViewImports.cshtml"
using PizzaStoreWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bdf451b9dd364dbb4a618fa921a4c062abe84cd", @"/Views/Order/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33fb5b1e3147e342a7cabbf69be2b7e408554cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaStoreWebApp.Models.OrderModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(88, 124, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>OrderModel</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(213, 43, false);
#line 14 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(256, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(300, 39, false);
#line 17 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderID));

#line default
#line hidden
            EndContext();
            BeginContext(339, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(383, 47, false);
#line 20 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Total_Price));

#line default
#line hidden
            EndContext();
            BeginContext(430, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(474, 43, false);
#line 23 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.Total_Price));

#line default
#line hidden
            EndContext();
            BeginContext(517, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(561, 45, false);
#line 26 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrderTime));

#line default
#line hidden
            EndContext();
            BeginContext(606, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(650, 41, false);
#line 29 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrderTime));

#line default
#line hidden
            EndContext();
            BeginContext(691, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(735, 44, false);
#line 32 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Store_ID));

#line default
#line hidden
            EndContext();
            BeginContext(779, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(823, 40, false);
#line 35 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.Store_ID));

#line default
#line hidden
            EndContext();
            BeginContext(863, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(907, 50, false);
#line 38 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Store_Location));

#line default
#line hidden
            EndContext();
            BeginContext(957, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1001, 46, false);
#line 41 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.Store_Location));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1091, 42, false);
#line 44 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserID));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1177, 38, false);
#line 47 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserID));

#line default
#line hidden
            EndContext();
            BeginContext(1215, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1259, 45, false);
#line 50 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1348, 41, false);
#line 53 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1389, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1433, 44, false);
#line 56 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1477, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1521, 40, false);
#line 59 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\Order\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1561, 53, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    \r\n    ");
            EndContext();
            BeginContext(1614, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08af847def694588a84067ab84e08748", async() => {
                BeginContext(1636, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1652, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaStoreWebApp.Models.OrderModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
