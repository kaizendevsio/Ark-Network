#pragma checksum "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Admin\Trade.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93a2d95c44ac8ae2059694a2142dd32d20c8a544"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Trade), @"mvc.1.0.view", @"/Views/Admin/Trade.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93a2d95c44ac8ae2059694a2142dd32d20c8a544", @"/Views/Admin/Trade.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab89ba2c61106176ea4978ca965633e6e6efe04b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Trade : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Admin\Trade.cshtml"
  

    ViewBag.Title = "WCC Admin | Trade List";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<div id=""content"" class=""content"">
    <!-- begin breadcrumb -->
    <ol class=""breadcrumb float-xl-right"">
        <li class=""breadcrumb-item""><a href=""javascript:;"">Trade</a></li>
        <li class=""breadcrumb-item active"">All channels</li>
    </ol>
    <!-- end breadcrumb -->
    <!-- begin page-header -->
    <h1 class=""page-header"">Trade List  <small> </small></h1>

    <div class=""row"">

");
            WriteLiteral("\r\n\r\n\r\n        <div class=\"col-md-12\">\r\n            <div class=\"panel panel-inverse\">\r\n                <div class=\"panel-heading\">\r\n");
            WriteLiteral("                    <h4 class=\"panel-title\">Trade List</h4>\r\n                </div>\r\n                <div class=\"table-responsive\">\r\n                    <div class=\"panel-body\">\r\n");
            WriteLiteral(@"

                        <table class=""table table-bordered"" id=""property"">
                            <thead>
                                <tr>

                                    <th colspan=""2"">Total Trade Balance : </th>
                                    <th colspan=""2"">Profit (WCCP):</th>

                                    <th colspan=""2"">Affiliate (WCCP): </th>
                                    <th colspan=""2"">Binary Bonus (WCCP) :</th>
                                </tr>


                                <tr>
                                    <th>CreatedOn</th>
                                    <th>ID</th>
                                    <th>Name</th>
                                    <th>Int.ID(Code) </th>
                                    <th>Int.Name </th>
                                    <th>TradeItem   </th>
                                    <th>Quantity   </th>
                                    <th>Amount   </th>

                          ");
            WriteLiteral("      </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
            WriteLiteral(@"                                <tr>
                                    <td>

                                        Html.DisplayFor(modelItem => item.CreatedOn)
                                    </td>
                                    <td>
                                        Html.DisplayFor(modelItem => item.ID)
                                    </td>

                                    <td>
                                        Html.DisplayFor(modelItem => item.FirstName)   Html.DisplayFor(modelItem => item.LastName)
                                    </td>
                                    <td>

                                        Html.DisplayFor(modelItem => item.IntName)
                                    </td>
                                    <td>
                                        Html.DisplayFor(modelItem => item.IntCode)
                                    </td>
                                    <td>
                                        Html.Dis");
            WriteLiteral(@"playFor(modelItem => item.TradeItem)
                                    </td>








                                    <td>
                                        Html.DisplayFor(modelItem => item.Quantity)
                                    </td>
                                    <td>

                                        Html.DisplayFor(modelItem => item.Amount)
                                    </td>













                                </tr>
                                }

                            </tbody>
                        </table>

                    </div>
                </div>
            </div>
        </div>
        <!-- end panel -->
    </div>
    <!-- end col-4 -->

</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <style>
        .toggle-button {
            margin: 5px 0;
            border-radius: 20px;
            border: 2px solid #D0D0D0;
            height: 24px;
            cursor: pointer;
            width: 50px;
            position: relative;
            display: inline-block;
            user-select: none;
            -webkit-user-select: none;
            -ms-user-select: none;
            -moz-user-select: none;
        }

            .toggle-button span {
                position: absolute;
                left: 0;
                top: 0;
                border-radius: 100%;
                width: 26px;
                height: 26px;
                background-color: white;
                float: left;
                margin: -3px 0 0 -3px;
                border: 2px solid #D0D0D0;
                transition: left 0.3s;
            }

        .toggle-button-selected {
            background-color: #83B152;
            border: 2px solid #7DA652;
        }

        ");
                WriteLiteral(@"    .toggle-button-selected span {
                left: 26px;
                top: 0;
                margin: 0;
                border: none;
                width: 24px;
                height: 24px;
                box-shadow: 0 0 4px rgba(0,0,0,0.1);
            }

        .dataTable > thead > tr > th[class*=""sort""]:after {
            content: """" !important;
        }
    </style>


    <script>

        $('#send').click(function () {
            var date_ = $(this).closest(""tr"").find(""td"").eq(0).text();
            var membercode_ = $(this).closest(""tr"").find(""td"").eq(1).text();
            var name_ = $(this).closest(""tr"").find(""td"").eq(2).text();
            var from = $(this).closest(""tr"").find(""td"").eq(3).text();
            var to = $(this).closest(""tr"").find(""td"").eq(4).text();
            var amount = $(this).closest(""tr"").find(""td"").eq(5).text();
            var currency = $(this).closest(""tr"").find(""td"").eq(6).text();
            var txid = $(this).closest(""tr"").find(");
                WriteLiteral(@"""td"").eq(7).text();
            document.getElementById('dateDetails').innerHTML = '<b> Date : ' + date_ + '</b>';
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
            ");
                WriteLiteral(@"table = document.getElementById(""property"");
            tr = table.getElementsByTagName(""tr"");
            for (i = 0; i < tr.length; i++) {
                td = tr[i].getElementsByTagName(""td"")[0];
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
        //    var us");
                WriteLiteral(@"d = $(this).closest(""tr"").find(""td"").eq(6).text();
        //    document.getElementById('currencyDetails').innerHTML = '<b> Date : ' + currency + '</b>';
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
            (day < 10 ? '0' : '') ");
                WriteLiteral(@"+ day;


        $('#property').DataTable({
            stateSave: true,
            autoWidth: true,
            dom: 'lBf<""toolbar"">rtip<""clear"">', fnInitComplete: function () {
                $('div.toolbar').html('<div id=""example_filter"" class=""dataTables_filter input-daterange""><label><input type=""text"" id=""from_date_picker"" class=""date-range-filter"" placeholder=""Date Start"" data-date-format=""mm-dd-yyyy"" id=""min"" placeholder="""" aria-controls=""example"">To<input type=""text"" id=""to_date_picker"" class=""date-range-filter""  placeholder=""Date End"" data-date-format=""mm-dd-yyyy"" id=""max"" aria-controls=""example""></label></div>');
            },
            buttons: [
                {
                    extend: 'copy',

                    className: 'dt-button btn btn-primary '
                }, {
                    extend: 'csv',
                    orientation: 'landscape',
                    title: 'WCC.com',
                    messageTop: 'The information in this table is copyright to");
                WriteLiteral(@" WCC.',
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
                    messageTop: 'The information in this table is copyright to WCC.',
                    messageBottom: output,
                    className: 'dt-button btn btn-primary '
                }, {
                    extend: 'print',
                    orientation: 'landscape',
     ");
                WriteLiteral(@"               pageSize: 'LEGAL',
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
                    var createdAt = data[0] || 1; // Our date column in the table

                    if (
                        (min == """" || max == """") ||
                        (moment(createdAt).isSameOrAfter(min) && moment(createdAt).isSameOrBefore(max))
                    ) {
      ");
                WriteLiteral(@"                  return true;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
