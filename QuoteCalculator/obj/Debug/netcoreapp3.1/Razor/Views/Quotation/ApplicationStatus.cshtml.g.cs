#pragma checksum "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\ApplicationStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e66c637975448cac905d4468feb6fcd2a3bc3675"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quotation_ApplicationStatus), @"mvc.1.0.view", @"/Views/Quotation/ApplicationStatus.cshtml")]
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
#line 1 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\_ViewImports.cshtml"
using QuoteCalculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\_ViewImports.cshtml"
using QuoteCalculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66c637975448cac905d4468feb6fcd2a3bc3675", @"/Views/Quotation/ApplicationStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd689eca912f4a1c809607e45d0458af1bf784b", @"/Views/_ViewImports.cshtml")]
    public class Views_Quotation_ApplicationStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuoteCalculator.Models.Data.ApplicationStatusRenderData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\ApplicationStatus.cshtml"
  
    ViewData["Title"] = "Quotes Calculator Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron jumbotron-fluid"">
    <div class=""container"">
        <div class=""text-center"">
            <img src=""/shared/success.gif"" id=""resultsImage"" style=""height: 150px; width: 150px;"" />
            <h1 id=""resultsHeader"" class=""display-4"">Congratulations!</h1>
            <p id=""resultsMessage"" class=""lead"">Your loan application has been sent successfully.</p>
            <hr />
        </div>
        <div class=""row mr-1"">
            <div class=""card col ml-3"" style=""width: 18rem;"">

                <!-- Application Summary -->
                <div id=""ApplicationSummaryDiv"" class=""mt-4"">
                    <h3>Loan Application Summary</h3>
                    <ul class=""list-group list-group-flush"">
                        <li class=""list-group-item text-left"">
                            <b>Finance Amount</b>
                            <span id=""ApplicationSummary_FinanceAmount"" class=""text-right"" style=""float: right"">
                                $");
#nullable restore
#line 25 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\ApplicationStatus.cshtml"
                            Write(Model.FinanceAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </span>
                        </li>
                        <li class=""list-group-item text-left"">
                            <b>Repayments from</b>
                            <span id=""ApplicationSummary_Repayments"" class=""text-right"" style=""float: right"">
                                $");
#nullable restore
#line 31 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\ApplicationStatus.cshtml"
                            Write(Model.Repayments);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                <span id=\"ApplicationSummary_LoanDuration\" class=\"text-muted\"><b>for ");
#nullable restore
#line 32 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\ApplicationStatus.cshtml"
                                                                                                Write(Model.LoanDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" month/s</b></span>
                            </span>
                        </li>

                        <li class=""list-group-item text-left small"">
                            <b><span class=""ml-4"">Establishment Fee</b></span>
                            <span id=""ApplicationSummary_EstablishmentFee"" class=""text-right text-muted"" style=""float: right"">
                                $");
#nullable restore
#line 39 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\ApplicationStatus.cshtml"
                            Write(Model.EstablishmentFee);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <br />
                            </span>
                        </li>
                        <li class=""list-group-item text-left small"">
                            <b><span class=""ml-4"">Interest</b></span>
                            <span id=""ApplicationSummary_Interest"" class=""text-right text-muted"" style=""float: right"">
                                $");
#nullable restore
#line 45 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\ApplicationStatus.cshtml"
                            Write(Model.Interest);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <br />
                            </span>
                        </li>
                        <li class=""list-group-item text-left"">
                            <h4>
                                <b>Total Repayments</b>
                                <span id=""ApplicationSummary_TotalRepayments"" class=""text-right"" style=""float: right"">
                                    $");
#nullable restore
#line 52 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\ApplicationStatus.cshtml"
                                Write(Model.TotalRepayments);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <br />
                                </span>
                            </h4>
                        </li>
                    </ul>
                </div>

                <div class=""mt-4"">
                    <p class=""text-muted text-center"">
                        Please expect a call from our Loan Agents within 3-5 business days after the application has been submitted.<br />
                        For any inquiries, feel free to <a");
            BeginWriteAttribute("href", " href=\"", 3310, "\"", 3317, 0);
            EndWriteAttribute();
            WriteLiteral(@">Contact Us</a>. <br /><br />
                        Thank you for choosing <b>MoneyMe!</b>
                    </p>
                </div>

                <div class=""card-body text-right"">
                    <hr />
                    <button type=""button"" class=""card-link btn btn-success"" data-toggle="""" data-target="""" data-whatever=""""");
            BeginWriteAttribute("onclick", " onclick=\"", 3667, "\"", 3677, 0);
            EndWriteAttribute();
            WriteLiteral(@">Manage your Applications</button>
                </div>
            </div>
        </div>
        <div class=""text-center"">
            <br><br><br>
            <p class=""lead"">Got some concerns? Send us an email at <b>czardy16@gmail.com</b>!</p><br><br><br>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuoteCalculator.Models.Data.ApplicationStatusRenderData> Html { get; private set; }
    }
}
#pragma warning restore 1591
