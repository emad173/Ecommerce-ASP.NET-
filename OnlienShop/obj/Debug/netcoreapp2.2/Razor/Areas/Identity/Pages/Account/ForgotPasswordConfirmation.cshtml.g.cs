#pragma checksum "C:\Users\Hamada Salim G Trd\Desktop\Emad\OnlienShop\OnlienShop\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6cca4e98ecffd649ecb8fb7baa4a1e11a3075c130b170abf8f90bf4a6cad0831"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlienShop.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ForgotPasswordConfirmation), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml", typeof(OnlienShop.Areas.Identity.Pages.Account.Areas_Identity_Pages_Account_ForgotPasswordConfirmation), null)]
namespace OnlienShop.Areas.Identity.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Hamada Salim G Trd\Desktop\Emad\OnlienShop\OnlienShop\Areas\Identity\Pages\_ViewImports.cshtml"
using OnlienShop.Areas.Identity;

#line default
#line hidden
#line 3 "C:\Users\Hamada Salim G Trd\Desktop\Emad\OnlienShop\OnlienShop\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "C:\Users\Hamada Salim G Trd\Desktop\Emad\OnlienShop\OnlienShop\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using OnlienShop.Areas.Identity.Pages.Account;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6cca4e98ecffd649ecb8fb7baa4a1e11a3075c130b170abf8f90bf4a6cad0831", @"/Areas/Identity/Pages/Account/ForgotPasswordConfirmation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d594f7300ef7e33e539e32efe860ce1ce404e31addc638178a53f815c39784c5", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a13f9766ea1f0d386c256bb8b91d8ce90a15e6e976306dc766f472f2cf5d1816", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_ForgotPasswordConfirmation : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Hamada Salim G Trd\Desktop\Emad\OnlienShop\OnlienShop\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
  
    ViewData["Title"] = "Forgot password confirmation";

#line default
#line hidden
            BeginContext(106, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(113, 17, false);
#line 7 "C:\Users\Hamada Salim G Trd\Desktop\Emad\OnlienShop\OnlienShop\Areas\Identity\Pages\Account\ForgotPasswordConfirmation.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(130, 73, true);
            WriteLiteral("</h1>\r\n<p>\r\n    Please check your email to reset your password.\r\n</p>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ForgotPasswordConfirmation> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ForgotPasswordConfirmation>)PageContext?.ViewData;
        public ForgotPasswordConfirmation Model => ViewData.Model;
    }
}
#pragma warning restore 1591
