#pragma checksum "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1febbd133fc97b82702090cf3b8b1c20d460d150"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trade_Index), @"mvc.1.0.view", @"/Views/Trade/Index.cshtml")]
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
#line 1 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\_ViewImports.cshtml"
using CryptoCityWallet.FrontEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\_ViewImports.cshtml"
using CryptoCityWallet.FrontEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 344 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
using CryptoCityWallet.Entities.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1febbd133fc97b82702090cf3b8b1c20d460d150", @"/Views/Trade/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab89ba2c61106176ea4978ca965633e6e6efe04b", @"/Views/_ViewImports.cshtml")]
    public class Views_Trade_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TradeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PartialsTrade/Cancel.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 338 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

    ViewBag.Title = "World Crypto City | Trade";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"content\" class=\"content\">\r\n    <!-- begin breadcrumb -->\r\n    <ol class=\"breadcrumb float-xl-right\">\r\n        <li class=\"breadcrumb-item\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 14582, "\"", 14637, 3);
            WriteAttributeValue("", 14592, "location.href=\'", 14592, 15, true);
#nullable restore
#line 348 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
WriteAttributeValue("", 14607, Url.Action("Index", "Trade"), 14607, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 14636, "\'", 14636, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Trade</a></li>
        <li class=""breadcrumb-item active"">All channels</li>
    </ol>
    <!-- end breadcrumb -->
    <!-- begin page-header -->
    <h1 class=""page-header"">WCC Trade  <small> </small></h1>

    <div class=""row"">


        <div class=""col-md-12"">
            <div class=""panel panel-inverse"">
                <div class=""panel-heading"">
");
            WriteLiteral(@"                    <h4 class=""panel-title"">Trade</h4>
                </div>
                <div class=""panel-body"">
                    <div class=""row"">
                        <div class=""col-md-8"">
                            <div class=""form-group"">
                                <h4>Select currency to participate in WCC Trade: </h4>
                            </div>


                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1febbd133fc97b82702090cf3b8b1c20d460d1505896", async() => {
                WriteLiteral(@"
                                <div class=""col-md-8"">
                                    <div class=""form-group"">

                                        <label>Currency (Available Balance)</label>
                                        <select class=""form-control"" Name=""FromWalletCode"">
");
#nullable restore
#line 383 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                             foreach (var modelItem in Model.UserWallets)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1febbd133fc97b82702090cf3b8b1c20d460d1506851", async() => {
#nullable restore
#line 385 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                                                                                             Write(Html.DisplayFor(modelList => modelItem.WalletName));

#line default
#line hidden
#nullable disable
                    WriteLiteral(" (");
#nullable restore
#line 385 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                                                                                                                                                  Write(Html.DisplayFor(modelList => modelItem.Balance));

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 385 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                                                                                                                                                                                                   Write(Html.DisplayFor(modelList => modelItem.WalletCode));

#line default
#line hidden
#nullable disable
                    WriteLiteral(" | ");
#nullable restore
#line 385 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                                                                                                                                                                                                                                                         Write(String.Format("{0:#,##0.00}", modelItem.BalanceFiat).ToString());

#line default
#line hidden
#nullable disable
                    WriteLiteral(" USD)");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 385 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                                   WriteLiteral(Html.ValueFor(modelList => modelItem.WalletCode));

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 386 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                           Write(Html.DisplayFor(modelList => modelItem.WalletCode));

#line default
#line hidden
#nullable disable
#nullable restore
#line 386 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                                                                                   
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                        </select>
                                    </div>
                                </div>
                                <div class=""col-md-8"">
                                    <div class=""form-group"">
                                        <label>Amount (USD)</label>
                                        <input type=""number"" Name=""AmountPaid"" value=""0.00"" class=""form-control"">
                                    </div>
                                </div>
                                <div class=""col-md-8"">
                                    <label><br></label>
                                    <div class=""form-group"">
                                        <h6 style=""color:red;"">Note : *100 USD Minimum</h6>
                                        <button type=""submit"" class=""btn btn-primary"">PURCHASE TRADE PACKAGE</button>

                                    </div>

                                </div>

                          ");
                WriteLiteral("      <input style=\"display:none\" type=\"text\" Name=\"FromCurrencyIso3\" value=\"USD\">\r\n                                <input style=\"display:none\" type=\"text\" Name=\"PaymentAddress\"");
                BeginWriteAttribute("value", " value=\"", 18376, "\"", 18384, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <input style=\"display:none\" type=\"text\" Name=\"BusinessPackageID\" value=\"1\">\r\n");
                WriteLiteral("                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onsubmit", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 16154, "SendPackagePurchase(\'", 16154, 21, true);
#nullable restore
#line 377 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
AddHtmlAttributeValue("", 16175, Url.Action("BuyPackage", "Trade"), 16175, 34, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 16209, "\',\'POST\',this);", 16209, 15, true);
            AddHtmlAttributeValue(" ", 16224, "return", 16225, 7, true);
            AddHtmlAttributeValue(" ", 16231, "false", 16232, 6, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=\"col-md-12\" style=\"padding:0px\">\r\n            <div class=\"panel panel-inverse\">\r\n                <div class=\"panel-heading\">\r\n");
            WriteLiteral(@"                    <h4 class=""panel-title"">Trade List</h4>
                </div>
                <div class=""table-responsive"">
                    <div class=""panel-body"">

                        <table class=""table table-bordered"" id=""dataTable"">
                            <thead>


                                <tr>

                                    <th>
                                        Total Investment:
                                        ");
#nullable restore
#line 441 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                   Write(Html.DisplayFor(model => model.TotalInvestment));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </th>

                                </tr>
                                <tr>
                                    <th>Date</th>
                                    <th>Package Name</th>
                                    <th>Type</th>
                                    <th>Package Amount</th>
                                    <th>Daily Profits</th>
                                    <th>Cancellation Date</th>
                                    <th>Total Profits</th>
                                    <th>Status</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 457 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                 foreach (var item in Model.UserBusinessPackages)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n\r\n                                            ");
#nullable restore
#line 462 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 465 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.BusinessPackage.PackageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 469 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.BusinessPackage.PackageType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 473 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.UserDepositRequest.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral(" USD\r\n\r\n                                        </td>\r\n                                        <td>\r\n                                            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 21897, "\"", 21954, 3);
            WriteAttributeValue("", 21907, "location.href=\'", 21907, 15, true);
#nullable restore
#line 477 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
WriteAttributeValue("", 21922, Url.Action("History", "Trade"), 21922, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 21953, "\'", 21953, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">PROFIT HISTORY </button>\r\n                                        </td>\r\n                                        <td>\r\n");
#nullable restore
#line 480 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                             if (item.CancellationDate == null)
                                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <button id=\"send\" data-toggle=\"modal\" data-target=\"#cancelModal\" class=\"btn btn-warning\">CANCEL </button>\r\n");
#nullable restore
#line 484 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                            }
                                            else
                                            {
                                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 487 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.CancellationDate));

#line default
#line hidden
#nullable disable
#nullable restore
#line 487 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                                                                                    
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 493 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.PackageStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 497 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1febbd133fc97b82702090cf3b8b1c20d460d15021641", async() => {
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
            WriteLiteral("\r\n\r\n                            </tbody>\r\n                        </table>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- end panel -->\r\n    </div>\r\n    <!-- end col-4 -->\r\n");
            WriteLiteral("</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"



    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.mask/1.14.11/jquery.mask.min.js""></script>
    <link href=""https://cdn.datatables.net/1.10.9/css/jquery.dataTables.css"" rel=""stylesheet"" type=""text/css"" />
    <script src=""https://cdn.datatables.net/1.10.9/js/jquery.dataTables.js""></script>
    <link href=""https://cdn.datatables.net/1.10.20/css/jquery.dataTables.min.css"" rel=""stylesheet"" />
    <link href=""https://cdn.datatables.net/buttons/1.6.1/css/buttons.dataTables.min.css"" rel=""stylesheet"" />

    <link href=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-datepicker/1.7.1/css/bootstrap-datepicker.min.css"" rel=""stylesheet"" />
    <script src=""https://cdn.datatables.net/buttons/1.6.1/js/dataTables.buttons.min.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.6.1/js/buttons.flash.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53");
                WriteLiteral(@"/pdfmake.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.6.1/js/buttons.html5.min.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.6.1/js/buttons.print.min.js""></script>


    <script>
        $(document).ready(function () {
            $('#datatable_trade').DataTable({
                initComplete: function () {
                    this.api().columns().every(function () {
                        var column = this;
                        var select = $('<select><option value=""""></option></select>')
                            .appendTo($(column.footer()).empty())
                            .on('change', function () {
                                var val = $.fn.dataTable.util.escapeRegex(
                                    $(this).val()
                                );

                                column
                                    .se");
                WriteLiteral(@"arch(val ? '^' + val + '$' : '', true, false)
                                    .draw();
                            });

                        column.data().unique().sort().each(function (d, j) {
                            select.append('<option value=""' + d + '"">' + d + '</option>')
                        });
                    });
                }
            });
        });</script>

    <script type=""text/javascript"">
        var p, q;

        function showPreload(e) {
            q = e.innerHTML;
            e.innerHTML = ""Loading..."";
            e.style.opacity = 0.5;
            p = e;
        }
        function CopyText() {
            /* Get the text field */
            var copyText = document.getElementById(""genlink"");

            /* Select the text field */
            copyText.select();
            copyText.setSelectionRange(0, 99999); /*For mobile devices*/

            /* Copy the text inside the text field */
            document.execCommand(""copy"");
");
                WriteLiteral(@"
            /* Alert the copied text */
            alert(""Link Copied to clipboard."");
        }


        function getFormData(form) {
            var unindexed_array = $(form).serializeArray();
            var indexed_array = {};

            $.map(unindexed_array, function (n, i) {
                indexed_array[n['name']] = n['value'];
            });

            return JSON.stringify(indexed_array);
        }

        function SendPackagePurchase(url, type, form) {
            $.ajax({
                url: url,
                type: type,
                data: getFormData(form),
                contentType: 'application/json',
                success: function (data) {
                    if (data.Message != undefined) {
                        alert(data.Message);
                        window.location.reload();
                    }
                    p.style.opacity = 1;
                    p.innerHTML = q;
                },
                error: function (data, te");
                WriteLiteral(@"xtStatus, jqXHR) {
                    console.log(data.responseJSON);
                    alert(data.responseJSON.Message);
                    p.style.opacity = 1;
                    p.innerHTML = q;
                },
            });

            return false
        }

    </script>


");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TradeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
