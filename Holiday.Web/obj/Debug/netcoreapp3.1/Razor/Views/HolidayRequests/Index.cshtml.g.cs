#pragma checksum "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef9d923a5f264eaa83e8a0773d6e3c0849f4bffb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HolidayRequests_Index), @"mvc.1.0.view", @"/Views/HolidayRequests/Index.cshtml")]
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
#line 1 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\_ViewImports.cshtml"
using Holiday.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\_ViewImports.cshtml"
using Holiday.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef9d923a5f264eaa83e8a0773d6e3c0849f4bffb", @"/Views/HolidayRequests/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b92c5a79a913f2e88ea5be6d706164b41b138bc", @"/Views/_ViewImports.cshtml")]
    public class Views_HolidayRequests_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Holiday.Web.ViewModels.HolidayPageViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pad-left-10 color-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
  
    ViewData["Title"] = "My Holidays";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6 row\">\r\n        <h5>My Holidays</h5>\r\n");
#nullable restore
#line 11 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
         if (Model.EmployeeTotalDaysLeft > 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef9d923a5f264eaa83e8a0773d6e3c0849f4bffb6483", async() => {
                WriteLiteral("<i class=\"fas fa-plus-circle\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
    <div class=""col-sm-6"">
        <input type=""text"" class=""float-right"" id=""input"" onkeyup=""FilterTable(this, 'holidaysTablebody')"" placeholder=""Smart Search.."" />
    </div>
</div>
<hr />

<div class=""row"">
    <div class=""col-sm-4 text-center"">
        ");
#nullable restore
#line 24 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.EmloyeeFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral(": <b>");
#nullable restore
#line 24 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
                                                            Write(Html.DisplayFor(model => model.EmloyeeFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"col-sm-4 text-center\">\r\n        ");
#nullable restore
#line 27 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.EmployeeTotalNoOfDays));

#line default
#line hidden
#nullable disable
            WriteLiteral(":<b> ");
#nullable restore
#line 27 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
                                                                  Write(Html.DisplayFor(model => model.EmployeeTotalNoOfDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"col-sm-3 text-center\">\r\n        ");
#nullable restore
#line 30 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
   Write(Html.DisplayNameFor(model => model.EmployeeTotalDaysLeft));

#line default
#line hidden
#nullable disable
            WriteLiteral("<text>:</text><b> ");
#nullable restore
#line 30 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
                                                                               Write(Html.DisplayFor(model => model.EmployeeTotalDaysLeft));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n\r\n<table class=\"table table-hover\" id=\"holidaysTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
           Write(Html.ActionLink("Start Date", "Index", new { sortOrder = ViewBag.StartSortParam }, new { @class = "color-dark" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
           Write(Html.ActionLink("End Date", "Index", new { sortOrder = ViewBag.EndSortParam }, new { @class = "color-dark" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
           Write(Html.ActionLink("Days", "Index", new { sortOrder = ViewBag.DaysSortParam }, new { @class = "color-dark" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
           Write(Html.ActionLink("Status", "Index", new { sortOrder = ViewBag.TypeSortParam }, new { @class = "color-dark" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
           Write(Html.ActionLink("Type", "Index", new { sortOrder = ViewBag.StatusSortParam }, new { @class = "color-dark" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
           Write(Html.ActionLink("Modified on", "Index", new { sortOrder = ViewBag.ModifiedOnSortParam }, new { @class = "color-dark" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
           Write(Html.ActionLink("Approver", "Index", new { sortOrder = ViewBag.ApproverSortParam }, new { @class = "color-dark" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody id=\"holidaysTablebody\">\r\n");
#nullable restore
#line 64 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
         foreach (var item in Model.Holidays)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NoOfDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Approver.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 89 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
                     if (item.Status == Constants.Status.Pending)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef9d923a5f264eaa83e8a0773d6e3c0849f4bffb16505", async() => {
                WriteLiteral("<i class=\"fas fa-edit color-dark\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 91 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
                                               WriteLiteral(item.HolidayRequestId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef9d923a5f264eaa83e8a0773d6e3c0849f4bffb18914", async() => {
                WriteLiteral("<i class=\"fas fa-trash-alt color-dark\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
                                                 WriteLiteral(item.HolidayRequestId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 93 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 96 "C:\Users\manue\source\repos\HolidayProjectApp\Holiday.Web\Views\HolidayRequests\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Holiday.Web.ViewModels.HolidayPageViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
