#pragma checksum "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Wallet\MyEthereum.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "261caa7cb3da5f7504b9acbd6d641ba6f6a28c31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wallet_MyEthereum), @"mvc.1.0.view", @"/Views/Wallet/MyEthereum.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"261caa7cb3da5f7504b9acbd6d641ba6f6a28c31", @"/Views/Wallet/MyEthereum.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab89ba2c61106176ea4978ca965633e6e6efe04b", @"/Views/_ViewImports.cshtml")]
    public class Views_Wallet_MyEthereum : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WalletVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/wallet-bg-img-2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("150px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-lg-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PartialsWallet/Send.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PartialsWallet/Receive.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Wallet\MyEthereum.cshtml"
  

    ViewBag.Title = "WCC  | My Ethereum";
    Layout = "~/Views/Shared/_LayoutUser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"content\" class=\"content\">\r\n    <!-- begin breadcrumb -->\r\n    <ol class=\"breadcrumb float-xl-right\">\r\n        <li class=\"breadcrumb-item\"><a");
            BeginWriteAttribute("onclick", " onclick=\"", 269, "\"", 330, 3);
            WriteAttributeValue("", 279, "location.href=\'", 279, 15, true);
#nullable restore
#line 10 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Wallet\MyEthereum.cshtml"
WriteAttributeValue("", 294, Url.Action("MyEthereum", "Wallet"), 294, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 329, "\'", 329, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Wallet</a></li>
        <li class=""breadcrumb-item active"">All channels</li>
    </ol>
    <!-- end breadcrumb -->
    <!-- begin page-header -->
    <h1 class=""page-header""> Ethereum wallet <small> </small></h1>

    <div class=""row"">
        <!-- begin col-6 -->
        <div class=""col-xl-6""");
            BeginWriteAttribute("onclick", " onclick=\"", 635, "\"", 696, 3);
            WriteAttributeValue("", 645, "location.href=\'", 645, 15, true);
#nullable restore
#line 19 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Wallet\MyEthereum.cshtml"
WriteAttributeValue("", 660, Url.Action("MyEthereum", "Wallet"), 660, 35, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 695, "\'", 695, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
            <!-- begin card -->
            <div class=""card border-0   text-white mb-3 overflow-hidden"" style=""background-color: #563d7c"">
                <!-- begin card-body -->
                <div class=""card-body"">
                    <!-- begin row -->
                    <div class=""row"">
                        <!-- begin col-7 -->
                        <div class=""col-xl-7 col-lg-8"">
                            <!-- begin title -->
                            <div class=""mb-3 text-white "">
                                <b>
                                    <svg version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px""
                                         width=""42px"" height=""42px"" viewBox=""0 0 42 42"" style=""enable-background:new 0 0 42 42;"" xml:space=""preserve"">
                                    <path fill=""#fff"" d=""M32,0H10C4.5,0,0,4.5,0,10v22c0,5.5,4.5,10,10,10h22c5.5,0,10-4.5,10-10V10C42,4.5,37.5,0,32,0z M14.831,21.05
");
            WriteLiteral(@"										   c1.99-3.383,4.08-6.667,6.07-10.05c2.09,3.383,4.08,6.667,6.07,10.05c-0.099,0.099-0.199,0.099-0.298,0.199
										   c-1.891,1.094-3.781,2.189-5.572,3.284c-0.199,0.099-0.398,0.099-0.597,0c-1.791-1.095-3.932-2.304-5.723-3.398L14.831,21.05z
											M20.901,31c-1.99-3.085-4.08-5.97-6.169-8.856c0.199,0.099,0.298,0.199,0.497,0.298c1.791,1.095,3.483,2.09,5.274,3.184
										   c0.298,0.199,0.497,0.199,0.796,0c1.891-1.094,3.781-2.189,5.672-3.284l0.249-0.139C25.13,25.089,23.09,28.114,20.901,31z"" />















									   </svg>
                                </b>
");
            WriteLiteral(@"                            </div>
                            <!-- end title -->
                            <!-- begin total-sales -->
                            <div class=""row text-truncate"">
                                <!-- begin col-6 -->
                                <div class=""col-6"">
                                    <div class=""f-s-12 text-white"">ETHEREUM WALLET</div>
                                    <div class=""f-s-18 m-b-5 f-w-600 p-b-1"" data-animation=""number"" data-value=""-"">ETH</div>
                                    <div class=""progress progress-xs rounded-lg bg-dark-darker m-b-5"">
                                        <div class=""progress-bar progress-bar-striped rounded-right bg-teal"" data-animation=""width"" data-value=""55%"" style=""width: 0%""></div>
                                    </div>
                                </div>
                                <!-- end col-6 -->
                                <!-- begin col-6 -->
                               ");
            WriteLiteral(" <div class=\"col-6\">\r\n                                    <div class=\"f-s-12 text-white\">Balance:</div>\r\n");
            WriteLiteral("                                <div class=\"f-s-18 m-b-5 f-w-600 p-b-1\"><span data-animation=\"number\" data-value=\"0.00\"> ");
#nullable restore
#line 75 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Wallet\MyEthereum.cshtml"
                                                                                                                     Write((decimal)Model.UserWalletAddressTxs.Txrefs.Sum(i => i.Value) / 100000000);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" ETH </font></span></div>
                                    <div class=""progress progress-xs rounded-lg bg-dark-darker m-b-5"">
                                        <div class=""progress-bar progress-bar-striped rounded-right"" data-animation=""width"" data-value=""55%"" style=""width: 0%""></div>
                                    </div>
                                </div>
                                <!-- end col-6 -->
                            </div>
                            <!-- end total-sales -->
                            <!-- begin percentage -->
");
            WriteLiteral(@"                            <!-- end percentage -->
                            <!-- begin row -->
                            <div class=""row text-truncate"">
                                <!-- begin col-6 -->
                                <div class=""col-6"">
                                    <div class=""f-s-12 text-white"">Last day</div>
                                    <div class=""f-s-18 m-b-5 f-w-600 p-b-1"" data-animation=""number"" data-value=""0"">+ 0$</div>
                                    <div class=""progress progress-xs rounded-lg bg-dark-darker m-b-5"">
                                        <div class=""progress-bar progress-bar-striped rounded-right bg-teal"" data-animation=""width"" data-value=""55%"" style=""width: 0%""></div>
                                    </div>
                                </div>
                                <!-- end col-6 -->
                                <!-- begin col-6 -->
                                <div class=""col-6"">
                       ");
            WriteLiteral(@"             <div class=""f-s-12 text-white"">0 ETH</div>
                                    <div class=""f-s-18 m-b-5 f-w-600 p-b-1""><span data-animation=""number"" data-value=""0.00"">0 USD</font></span></div>
                                    <div class=""progress progress-xs rounded-lg bg-dark-darker m-b-5"">
                                        <div class=""progress-bar progress-bar-striped rounded-right"" data-animation=""width"" data-value=""55%"" style=""width: 0%""></div>
                                    </div>
                                </div>
                                <!-- end col-6 -->
                            </div>
                            <!-- end row -->
                        </div> <div class=""col-xl-5 col-lg-4 align-items-d d-flex justify-content-end"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "261caa7cb3da5f7504b9acbd6d641ba6f6a28c3113170", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <!-- end col-7 -->
                        <!-- begin col-5 -->
                        <!-- end col-5 -->
                    </div>
                    <span><b>Wallet number:</b> 0x45e1D2D3C1d001aC30E9C0B10e3a9cdD35018Bf0</span>
                    <!-- end row -->
                </div>
                <!-- end card-body -->
            </div>
            <!-- end card -->
        </div>




        <div class=""col-xl-2"">
            <!-- begin card -->
            <div class=""card border-0   text-white mb-3 overflow-hidden"" style=""background-color:#d9e0e7"">
                <!-- begin card-body -->
                <div class=""card-body"">
                    <!-- begin row -->



                    <span>
                        <button id=""send"" data-toggle=""modal"" data-target=""#sendModal"" class=""btn btn-primary"">SEND  </button>
                    </span>
                    <!-- end row -->
                </div>
   ");
            WriteLiteral("             <div class=\"card-body\">\r\n                    <!-- begin row -->\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "261caa7cb3da5f7504b9acbd6d641ba6f6a28c3115539", async() => {
                WriteLiteral("\r\n\r\n                        <button type=\"submit\" id=\"receive\" data-toggle=\"modal\" data-target=\"#receiveModal\" class=\"btn btn-primary popup-link\">RECEIVE </button>\r\n                        <input style=\"display:none\" type=\"text\" Name=\"WalletCode\"");
                BeginWriteAttribute("value", " value=\"", 8493, "\"", 8536, 1);
#nullable restore
#line 147 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Wallet\MyEthereum.cshtml"
WriteAttributeValue("", 8501, Html.DisplayFor(i => i.WalletCode), 8501, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "onsubmit", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 8167, "GetNewAddress(\'", 8167, 15, true);
#nullable restore
#line 144 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Wallet\MyEthereum.cshtml"
AddHtmlAttributeValue("", 8182, Url.Action("NewAddress", "Wallet"), 8182, 35, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 8217, "\',\'POST\',this);", 8217, 15, true);
            AddHtmlAttributeValue(" ", 8232, "return", 8233, 7, true);
            AddHtmlAttributeValue(" ", 8239, "false", 8240, 6, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <!-- end row -->\r\n                </div>\r\n                <div class=\"card-body\">\r\n                    <!-- begin row -->\r\n\r\n\r\n\r\n                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 8745, "\"", 8807, 3);
            WriteAttributeValue("", 8755, "location.href=\'", 8755, 15, true);
#nullable restore
#line 156 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Wallet\MyEthereum.cshtml"
WriteAttributeValue("", 8770, Url.Action("Index", "Transactions"), 8770, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 8806, "\'", 8806, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">ALL TRANSACTIONS </button>\r\n                    <!-- end row -->\r\n                </div>\r\n                <!-- end card-body -->\r\n            </div>\r\n            <!-- end card -->\r\n        </div>\r\n\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "261caa7cb3da5f7504b9acbd6d641ba6f6a28c3119288", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "261caa7cb3da5f7504b9acbd6d641ba6f6a28c3120413", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

        <!-- end card -->
    </div>
</div>

<script type=""text/javascript"">
    var p, q;

    function showPreload(e) {
        q = e.innerHTML;
        e.innerHTML = ""Loading..."";
        e.style.opacity = 0.5;
        p = e;
    }

    function CopyPaymentAddressText() {
        /* Get the text field */
        var copyText = document.getElementById(""PaymentAddress"");

        /* Select the text field */
        copyText.select();
        copyText.setSelectionRange(0, 99999); /*For mobile devices*/

        /* Copy the text inside the text field */
        document.execCommand(""copy"");

        /* Alert the copied text */
        alert(""Address Copied to clipboard."");
    }

    function getFormData(form) {
        var unindexed_array = $(form).serializeArray();
        var indexed_array = {};

        $.map(unindexed_array, function (n, i) {
            indexed_array[n['name']] = n['value'];
        });

        return JSON.stringify(indexed_array);
    }

    ");
            WriteLiteral(@"function GetNewAddress(url, type, form) {
        if (document.getElementById('PaymentAddress').value == """") {
            $.ajax({
                url: url,
                type: type,
                data: getFormData(form),
                contentType: 'application/json',
                success: function (data) {
                    if (data.Message != undefined) {
                        alert(data.Message);
                    }
                    document.getElementById('spinner').style.display = ""none"";
                    document.getElementById('PaymentAddress').value = data.Address;
                    document.getElementById('PaymentAddressImg').src = ""https://api.qrserver.com/v1/create-qr-code/?size=192x192&data="" + data.Address;
                },
                error: function (data, textStatus, jqXHR) {
                    console.log(data.responseJSON);
                    alert(data.responseJSON.Message);
                    window.location.replace(data.RedirectUrl);
   ");
            WriteLiteral("             },\r\n            });\r\n        }\r\n\r\n\r\n\r\n        return false\r\n    }\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WalletVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
