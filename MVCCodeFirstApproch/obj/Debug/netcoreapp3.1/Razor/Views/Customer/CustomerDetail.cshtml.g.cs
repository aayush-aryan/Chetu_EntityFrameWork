#pragma checksum "C:\Users\user\OneDrive\Desktop\dotCoreMvc\MVCCodeFirstApproch\Views\Customer\CustomerDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe72b272362297574176dfea5abba2d55075c3c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerDetail), @"mvc.1.0.view", @"/Views/Customer/CustomerDetail.cshtml")]
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
#line 1 "C:\Users\user\OneDrive\Desktop\dotCoreMvc\MVCCodeFirstApproch\Views\_ViewImports.cshtml"
using MVCCodeFirstApproch;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\OneDrive\Desktop\dotCoreMvc\MVCCodeFirstApproch\Views\_ViewImports.cshtml"
using MVCCodeFirstApproch.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe72b272362297574176dfea5abba2d55075c3c8", @"/Views/Customer/CustomerDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"659abeeb7e28888c7ea3efd3fc691e0bdc8cdb92", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CustomerDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCCodeFirstApproch.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-6 offset-3"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">CustomerDetail</h4>
            </div>
            <div class=""card-body"">
                <table class=""table table-bordered"">
                    
                        <tr>
                            <td><label>Customer Name :</label></td>
                            <td>");
#nullable restore
#line 14 "C:\Users\user\OneDrive\Desktop\dotCoreMvc\MVCCodeFirstApproch\Views\Customer\CustomerDetail.cshtml"
                           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td><label>Customer Email :</label></td>\r\n                            <td>");
#nullable restore
#line 20 "C:\Users\user\OneDrive\Desktop\dotCoreMvc\MVCCodeFirstApproch\Views\Customer\CustomerDetail.cshtml"
                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <td><label>Customer Gender :</label></td>\r\n                            <td>");
#nullable restore
#line 26 "C:\Users\user\OneDrive\Desktop\dotCoreMvc\MVCCodeFirstApproch\Views\Customer\CustomerDetail.cshtml"
                           Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <td><label>Customer MobileNumber :</label></td>\r\n                            <td>");
#nullable restore
#line 31 "C:\Users\user\OneDrive\Desktop\dotCoreMvc\MVCCodeFirstApproch\Views\Customer\CustomerDetail.cshtml"
                           Write(Model.Mobile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n\r\n                </table>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCCodeFirstApproch.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
