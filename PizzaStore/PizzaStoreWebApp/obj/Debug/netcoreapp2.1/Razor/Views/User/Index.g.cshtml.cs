#pragma checksum "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "141016bb79a574000997455096bb276210815e5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"141016bb79a574000997455096bb276210815e5b", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33fb5b1e3147e342a7cabbf69be2b7e408554cf6", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PizzaStoreWebApp.Models.UserModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 51, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n\r\n    <h4>User</h4>\r\n\r\n        ");
            EndContext();
            BeginContext(149, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "afa662ec0954435281d5b1d3b6494037", async() => {
                BeginContext(187, 119, true);
                WriteLiteral("\r\n            Search: <input type=\"search\" name=\"search\"/>\r\n            <button type=\"submit\">Submit</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(313, 23, true);
            WriteLiteral("\r\n        <p>\r\n        ");
            EndContext();
            BeginContext(336, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "018df9dff15f4320aadaaa1d2ee227b2", async() => {
                BeginContext(359, 33, true);
                WriteLiteral("Create New Account to place order");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(396, 122, true);
            WriteLiteral("\r\n        </p>\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(519, 45, false);
#line 24 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(564, 68, true);
            WriteLiteral("\r\n                 </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(633, 44, false);
#line 27 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\User\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(677, 84, true);
            WriteLiteral("\r\n                </th>\r\n              </tr>\r\n           </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 32 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\User\Index.cshtml"
    foreach (var item in Model)
   {

#line default
#line hidden
            BeginContext(800, 45, true);
            WriteLiteral("       <tr>\r\n           <td>\r\n               ");
            EndContext();
            BeginContext(846, 44, false);
#line 36 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\User\Index.cshtml"
          Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(890, 52, true);
            WriteLiteral("\r\n           </td>\r\n           <td>\r\n               ");
            EndContext();
            BeginContext(943, 43, false);
#line 39 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\User\Index.cshtml"
          Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(986, 52, true);
            WriteLiteral("\r\n           </td>\r\n           <td>\r\n               ");
            EndContext();
            BeginContext(1039, 47, false);
#line 42 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\User\Index.cshtml"
          Write(Html.DisplayFor(modelItem => item.MobileNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1086, 86, true);
            WriteLiteral("\r\n           </td>\r\n           <td>\r\n                \r\n              \r\n               ");
            EndContext();
            BeginContext(1173, 59, false);
#line 47 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\User\Index.cshtml"
          Write(Html.ActionLink("Details", "Details", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1232, 21, true);
            WriteLiteral(" |\r\n\r\n               ");
            EndContext();
            BeginContext(1254, 57, false);
#line 49 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\User\Index.cshtml"
          Write(Html.ActionLink("Delete", "Delete", new { id = item.ID }));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 61, true);
            WriteLiteral("\r\n\r\n               \r\n               </td>\r\n           </tr>\r\n");
            EndContext();
#line 54 "E:\Revature\ortiz-rosario-project1\PizzaStore\PizzaStoreWebApp\Views\User\Index.cshtml"
   }

#line default
#line hidden
            BeginContext(1378, 48, true);
            WriteLiteral("           </tbody>\r\n        </table>\r\n\r\n   \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PizzaStoreWebApp.Models.UserModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
