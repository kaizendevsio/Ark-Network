#pragma checksum "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Admin\Account.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5610a990cc8780906cdd5368bbc1ba834dfd94e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Account), @"mvc.1.0.view", @"/Views/Admin/Account.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5610a990cc8780906cdd5368bbc1ba834dfd94e3", @"/Views/Admin/Account.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab89ba2c61106176ea4978ca965633e6e6efe04b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Account : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Admin\Account.cshtml"
  

    ViewBag.Title = "WCC Admin | Account";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""content"" class=""content"">
    <!-- begin breadcrumb -->
    <ol class=""breadcrumb float-xl-right"">
        <li class=""breadcrumb-item""><a href=""javascript:;"">Admin Account</a></li>
        <li class=""breadcrumb-item active"">All channels</li>
    </ol>
    <!-- end breadcrumb -->
    <!-- begin page-header -->
    <h1 class=""page-header"">Admin Details <small> </small></h1>


    <div class=""row"">

        <div class=""col-md-12"">
            <div class=""panel panel-inverse"">
                <div class=""panel-heading"">
");
            WriteLiteral(@"                    <h4 class=""panel-title"">Admin Account</h4>
                </div>
                <div class=""panel-body"">
                    <div class=""row"">
                        <div class=""col-md-8"">
                            <div class=""form-group"">
                                <label>Username</label>
                                <input type=""text""");
            BeginWriteAttribute("value", " value=\"", 1759, "\"", 1818, 2);
#nullable restore
#line 36 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Admin\Account.cshtml"
WriteAttributeValue("", 1767, Html.DisplayFor(model => model.UserInfo.UserName), 1767, 50, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1817, "", 1818, 1, true);
            EndWriteAttribute();
            WriteLiteral("   class=\"form-control\"");
            BeginWriteAttribute("readonly", " readonly=\"", 1842, "\"", 1853, 0);
            EndWriteAttribute();
            WriteLiteral(@">  
                            </div>
                        </div>
                    
                    </div>
                    <div class=""row"">
                        <div class=""col-md-8"">
                            <div class=""form-group"">
                                <label>Date Joined</label>
                                <input type=""date""");
            BeginWriteAttribute("name", " name=\"", 2228, "\"", 2235, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", "value=\"", 2236, "\"", 2306, 2);
#nullable restore
#line 45 "C:\Projects\Net Core\CryptoCityWallet\CryptoCityWallet.FrontEnd\Views\Admin\Account.cshtml"
WriteAttributeValue("", 2243, Html.DisplayFor(model => model.UserInfo.CreatedOn).ToString(), 2243, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2305, "", 2306, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\"");
            BeginWriteAttribute("readonly", " readonly=\"", 2328, "\"", 2339, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n                       \r\n                    </div>\r\n\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n    </div>\r\n    <!-- end panel -->\r\n</div>");
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
