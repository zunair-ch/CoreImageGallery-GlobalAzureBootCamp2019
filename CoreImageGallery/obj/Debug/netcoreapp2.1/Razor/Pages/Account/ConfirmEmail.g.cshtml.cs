#pragma checksum "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\Account\ConfirmEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a2e3f5fb9ed0ffb4a49786fb5ab2462b17a35d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoreImageGallery.Pages.Account.Pages_Account_ConfirmEmail), @"mvc.1.0.razor-page", @"/Pages/Account/ConfirmEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Account/ConfirmEmail.cshtml", typeof(CoreImageGallery.Pages.Account.Pages_Account_ConfirmEmail), null)]
namespace CoreImageGallery.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\_ViewImports.cshtml"
using CoreImageGallery;

#line default
#line hidden
#line 3 "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\_ViewImports.cshtml"
using CoreImageGallery.Data;

#line default
#line hidden
#line 1 "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\Account\_ViewImports.cshtml"
using CoreImageGallery.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a2e3f5fb9ed0ffb4a49786fb5ab2462b17a35d2", @"/Pages/Account/ConfirmEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"851008172138ebaba5ff564f18960b2ea02bbf8a", @"/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66263235bd1d7965fc1413d31c61ff5fba2db79a", @"/Pages/Account/_ViewImports.cshtml")]
    public class Pages_Account_ConfirmEmail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\Account\ConfirmEmail.cshtml"
  
    ViewData["Title"] = "Confirm email";

#line default
#line hidden
            BeginContext(77, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(83, 17, false);
#line 7 "C:\Users\muhammad.zunair\Desktop\BasicImageGallery-vs2019-launch\CoreImageGallery\CoreImageGallery\Pages\Account\ConfirmEmail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(100, 81, true);
            WriteLiteral("</h2>\n<div>\n    <p>\n        Thank you for confirming your email.\n    </p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConfirmEmailModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ConfirmEmailModel>)PageContext?.ViewData;
        public ConfirmEmailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
