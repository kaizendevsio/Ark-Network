#pragma checksum "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fab595d76ebb6bdc3763a37739b433688d46113d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trade_History), @"mvc.1.0.view", @"/Views/Trade/History.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fab595d76ebb6bdc3763a37739b433688d46113d", @"/Views/Trade/History.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab89ba2c61106176ea4978ca965633e6e6efe04b", @"/Views/_ViewImports.cshtml")]
    public class Views_Trade_History : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TradeVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 211 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
  

    ViewBag.Title = "WCC Plan | History";
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"content\" class=\"content\">\r\n    <!-- begin breadcrumb -->\r\n    <ol class=\"breadcrumb float-xl-right\">\r\n        <li class=\"breadcrumb-item\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 10129, "\"", 10186, 3);
            WriteAttributeValue("", 10139, "location.href=\'", 10139, 15, true);
#nullable restore
#line 220 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
WriteAttributeValue("", 10154, Url.Action("History", "Trade"), 10154, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 10185, "\'", 10185, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">History</a></li>
        <li class=""breadcrumb-item active"">All channels</li>
    </ol>
    <!-- end breadcrumb -->
    <!-- begin page-header -->
    <h1 class=""page-header"">WCCP History <small> </small></h1>

    <div class=""row"">




        <div class=""col-md-12"">
            <div class=""panel panel-inverse"">
                <div class=""panel-heading"">
                    <div class=""panel-heading-btn"">
");
            WriteLiteral("                    </div>\r\n                    <h4 class=\"panel-title\">History</h4>\r\n                </div>\r\n                <div class=\"table-responsive\">\r\n                    <div class=\"panel-body\">\r\n");
            WriteLiteral(@"
                        <table class=""display table dataTable table-bordered table-striped"" id=""property"" cellspacing=""0"" width=""100%"">

                            <thead>
                                <tr>
                                    <th colspan=""1"">WCCP Balance  ");
#nullable restore
#line 267 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
                                                             Write(Html.DisplayFor(model => model.WCCPBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th colspan=\"1\">Total Daily Profit:");
#nullable restore
#line 268 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
                                                                  Write(Html.DisplayFor(model => model.YesterdayProfit));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th colspan=\"1\">Total Affiliate: ");
#nullable restore
#line 269 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
                                                                Write(Html.DisplayFor(model => model.TotalInvestment));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                    <th colspan=\"2\">Total Binary Bonus :");
#nullable restore
#line 270 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
                                                                   Write(Html.DisplayFor(model => model.YesterdayProfit));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</th>
                                </tr>
                                <tr>
                                    <th>Date</th>

                                    <th>Bonus Type</th>
                                    <th>In</th>

                                    <th>Out</th>
                                    <th>Balance</th>
                                </tr>
                            </thead>

                            <tbody>
");
#nullable restore
#line 284 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
                                 foreach (var item in Model.TradeTransactions)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n\r\n                                        ");
#nullable restore
#line 289 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.DividendDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 294 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.DividendBonusCd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 297 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.DividendPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                   \r\n                                    <td>\r\n                                        ");
#nullable restore
#line 301 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.DividendRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 304 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.DividendBonusCd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 307 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Trade\History.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </tbody>\r\n\r\n                        </table>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- end panel -->\r\n    </div>\r\n    <!-- end col-4 -->\r\n\r\n</div>\r\n");
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
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/p");
                WriteLiteral(@"dfmake.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.53/vfs_fonts.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.6.1/js/buttons.html5.min.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.6.1/js/buttons.print.min.js""></script>


    <script>

        $('#send').click(function () {
            var date_ = $(this).closest(""tr"").find(""td"").eq(0).text();
            var membercode_ = $(this).closest(""tr"").find(""td"").eq(1).text();
            var name_ = $(this).closest(""tr"").find(""td"").eq(2).text();
            var from = $(this).closest(""tr"").find(""td"").eq(3).text();
            var to = $(this).closest(""tr"").find(""td"").eq(4).text();
            var amount = $(this).closest(""tr"").find(""td"").eq(5).text();
            var currency = $(this).closest(""tr"").find(""td"").eq(6).text();
            var txid = $(this).closest(""tr"").find(""td"").eq(7).text();
            document.getElementById('dateDetails').innerHTML = '<b> Date ");
                WriteLiteral(@": ' + date_ + '</b>';
            document.getElementById('memcodeDetails').innerHTML = '<b> ID : ' + membercode_ + '</b>';
            document.getElementById('memnameDetails').innerHTML = '<b> ID : ' + name_ + '</b>';
            document.getElementById('fromDetails').innerHTML = '<b> From : ' + from + '</b>';
            document.getElementById('toDetails').innerHTML = '<b> To: ' + to + '</b>';

            document.getElementById('currencyDetails').innerHTML = '<b> From : ' + currency + '</b>';
            document.getElementById('amountDetails').innerHTML = '<b> Total Amount : ' + amount + '</b>';

            document.getElementById('txidDetails').innerHTML = '<b> TxID : ' + txid + '</b>';

        });
        function myFunction() {
            var input, filter, table, tr, td, i;
            input = document.getElementById(""mylist"");
            filter = input.value.toUpperCase();
            table = document.getElementById(""property"");
            tr = table.getElementsByTagName(""tr""");
                WriteLiteral(@");
            for (i = 0; i < tr.length; i++) {
                td = tr[i].getElementsByTagName(""td"")[4];
                if (td) {
                    if (td.innerHTML.toUpperCase().indexOf(filter) > -1) {
                        tr[i].style.display = """";
                    } else {
                        tr[i].style.display = ""none"";
                    }
                }
            }
        }

        //$('#from').click(function () {
        //    var currency = $(this).closest(""tr"").find(""td"").eq(0).text();
        //    var balance = $(this).closest(""tr"").find(""td"").eq(1).text();
        //    var available = $(this).closest(""tr"").find(""td"").eq(2).text();
        //    var hot = $(this).closest(""tr"").find(""td"").eq(3).text();
        //    var cold = $(this).closest(""tr"").find(""td"").eq(4).text();
        //    var rate = $(this).closest(""tr"").find(""td"").eq(5).text();
        //    var usd = $(this).closest(""tr"").find(""td"").eq(6).text();
        //    document.getElementById('cur");
                WriteLiteral(@"rencyDetails').innerHTML = '<b> Date : ' + currency + '</b>';
        //    document.getElementById('balanceDetails').innerHTML = '<b> Balance : ' + balance + '</b>';
        //    document.getElementById('availableDetails').innerHTML = '<b> Available : ' + available + '</b>';
        //    document.getElementById('hotDetails').innerHTML = '<b> HOT : ' + hot + '</b>';
        //    document.getElementById('coldDetails').innerHTML = '<b> COLD : ' + cold + '</b>';

        //    document.getElementById('rateDetails').innerHTML = '<b> RATE  : ' + rate + '</b>';
        //    document.getElementById('usdDetails').innerHTML = '<b> USD : ' + usd + '</b>';


        //});




        var d = new Date();

        var month = d.getMonth() + 1;
        var day = d.getDate();

        var output = d.getFullYear() + '/' +
            (month < 10 ? '0' : '') + month + '/' +
            (day < 10 ? '0' : '') + day;


        $('#property').DataTable({
            stateSave: true,
            auto");
                WriteLiteral(@"Width: true,
            dom: 'lBf<""toolbar"">rtip<""clear"">', fnInitComplete: function () {
                $('div.toolbar').html('<div class=""dataTables_length"" id="" ""><label> <select name="" "" aria-controls=""property"" onchange=""myFunction()"" id=""mylist""class=""""><option value=""Convert"">Convert</option><option value=""Daily Profit"">Daily Profit</option><option value=""Affiliate"">Affiliate</option><option value=""Binary"">Binary</option> </select></label></div><div id=""example_filter"" class=""dataTables_filter input-daterange""><label><input type=""text"" id=""from_date_picker"" class=""date-range-filter"" placeholder=""Date Start"" data-date-format=""mm-dd-yyyy"" id=""min"" placeholder="""" aria-controls=""example"">To<input type=""text"" id=""to_date_picker"" class=""date-range-filter""  placeholder=""Date End"" data-date-format=""mm-dd-yyyy"" id=""max"" aria-controls=""example""></label></div>');
            },
            buttons: [
                {
                    extend: 'copy',

                    className: 'dt-button btn btn");
                WriteLiteral(@"-primary '
                }, {
                    extend: 'csv',
                    orientation: 'landscape',
                    title: 'WCC.com',
                    messageTop: 'The information in this table is copyright to WCC.',
                    messageBottom: output,
                    className: 'dt-button btn btn-primary '
                }, {
                    extend: 'excel',
                    orientation: 'landscape',
                    extend: 'excelHtml5',
                    title: 'WCC.com',
                    messageTop: 'The information in this table is copyright to WCC.',
                    messageBottom: output,
                    className: 'dt-button btn btn-primary '
                }, {
                    extend: 'pdf',
                    orientation: 'landscape',
                    extend: 'pdfHtml5',
                    pageSize: 'LEGAL',
                    title: 'WCC.com',
                    messageTop: 'The information in this table is copy");
                WriteLiteral(@"right to WCC.',
                    messageBottom: output,
                    className: 'dt-button btn btn-primary '
                }, {
                    extend: 'print',
                    orientation: 'landscape',
                    pageSize: 'LEGAL',
                    title: 'WCC.com',
                    messageTop: 'The information in this table is copyright to WCC.',
                    messageBottom: output,
                    className: 'dt-button btn btn-primary '
                }
            ]
        });
        $(document).ready(function () {

            $('.input-daterange input').each(function () {
                $(this).datepicker('clearDates');
            });

            // Extend dataTables search
            $.fn.dataTable.ext.search.push(
                function (settings, data, dataIndex) {
                    var min = $('#min').val();
                    var max = $('#max').val();
                    var createdAt = data[0] || 1; // Our date colu");
                WriteLiteral(@"mn in the table

                    if (
                        (min == """" || max == """") ||
                        (moment(createdAt).isSameOrAfter(min) && moment(createdAt).isSameOrBefore(max))
                    ) {
                        return true;
                    }
                    return false;
                }
            );

            // Re-draw the table when the a date range filter changes
            $('.date-range-filter').change(function () {
                var table = $('#property').DataTable();
                table.draw();
            });


            $('.date-range-filter').datepicker();
        });
    </script>

");
            }
            );
            WriteLiteral("  ");
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
