#pragma checksum "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb39f5ced204591aa0b90a5ec16edf37528d1dea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quotation_QuotesCalculator), @"mvc.1.0.view", @"/Views/Quotation/QuotesCalculator.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb39f5ced204591aa0b90a5ec16edf37528d1dea", @"/Views/Quotation/QuotesCalculator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd689eca912f4a1c809607e45d0458af1bf784b", @"/Views/_ViewImports.cshtml")]
    public class Views_Quotation_QuotesCalculator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuoteCalculator.Models.Data.QuotesCalculatorRenderData>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
  
    ViewData["Title"] = "Quotes Calculator Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron jumbotron-fluid"">
    <div class=""container"">
        <div class=""text-center"">
            <h1 class=""display-4"">Quote Calculator</h1>
            <p class=""lead"">Explore different loan options by having some sample quotations from our Quote Calculator</p><br><hr />
        </div>
        <div class=""row mr-1"">
            <div class=""card col ml-3"" style=""width: 18rem;"">
                <div class=""card-body"">
                    <!-- LOAN PLAN -->
                    <div id=""LoanPlanDiv"">
                        <div class=""row mb-2"">
                            <div class=""col mt-2"">
                                <div class=""btn-group"">
                                    <button class=""btn btn-secondary btn-lg dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                        Choose your loan plan. <span class=""fas fa-hand-holding-usd""></span>
                                    </button>
  ");
            WriteLiteral("                                  <div class=\"dropdown-menu\">\r\n");
#nullable restore
#line 25 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
                                         foreach(var Product in Model.ProductsMetaData) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <a class=\"dropdown-item\" href=\"#\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1378, "\"", 1595, 19);
            WriteAttributeValue("", 1388, "return", 1388, 6, true);
            WriteAttributeValue(" ", 1394, "changeSelectedProduct(\'", 1395, 24, true);
#nullable restore
#line 26 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
WriteAttributeValue("", 1418, Product.ProductName, 1418, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1438, "\',", 1438, 2, true);
            WriteAttributeValue(" ", 1440, "\'", 1441, 2, true);
#nullable restore
#line 26 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
WriteAttributeValue("", 1442, Product.ProductIcon, 1442, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1462, "\',", 1462, 2, true);
            WriteAttributeValue(" ", 1464, "\'", 1465, 2, true);
#nullable restore
#line 26 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
WriteAttributeValue("", 1466, Product.LowestLoanableAmount, 1466, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1495, "\',", 1495, 2, true);
            WriteAttributeValue(" ", 1497, "\'", 1498, 2, true);
#nullable restore
#line 26 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
WriteAttributeValue("", 1499, Product.HighestLoanableAmount, 1499, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1529, "\',", 1529, 2, true);
            WriteAttributeValue(" ", 1531, "\'", 1532, 2, true);
#nullable restore
#line 26 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
WriteAttributeValue("", 1533, Product.MinimumLoanDuration, 1533, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1561, "\',", 1561, 2, true);
            WriteAttributeValue(" ", 1563, "\'", 1564, 2, true);
#nullable restore
#line 26 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
WriteAttributeValue("", 1565, Product.MaximumLoanDuration, 1565, 28, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1593, "\')", 1593, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
                                                                                                                                                                                                                                                                                                   Write(Product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 27 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""dropdown-divider""></div>
                                        <a class=""dropdown-item"" href=""#"">Browse More Products</a>
                                    </div>
                                </div>
                            </div>
                            <div class=""col text-right mb-2"">
                                <h2 id=""selectedProductHeader""><span");
            BeginWriteAttribute("class", " class=\"", 2095, "\"", 2168, 3);
            WriteAttributeValue("", 2103, "fas", 2103, 3, true);
#nullable restore
#line 34 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
WriteAttributeValue(" ", 2106, Model.UserResponse.Product.SelectedProduct.ProductIcon, 2107, 55, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2162, "fa-2x", 2163, 6, true);
            EndWriteAttribute();
            WriteLiteral("></span> <span id=\"SelectedProduct\">");
#nullable restore
#line 34 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
                                                                                                                                                                             Write(Model.UserResponse.Product.SelectedProduct.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h2>
                            </div>
                        </div>
                    </div>

                    <!-- PRICE RANGE SLIDER -->
                    <div class=""AmountRequiredSliderDiv text-center"">
                        <input id=""AmountRequiredSlider"" type=""range"" min=""0"" max=""100"" value=""50"" />
                        <div id=""AmountRequiredSliderSelector"">
                            <div id=""AmountRequiredSliderButton""></div>
                            <div id=""AmountRequiredSliderValue""></div>
                        </div>

                        <div id=""AmountRequiredSliderLabels"">
                            <div class=""row"">
                                <p class=""col lead text-left"" id=""AmountRequiredSlider_MinimumValueLabel"">$");
#nullable restore
#line 49 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
                                                                                                      Write(Model.UserResponse.Product.SelectedProduct.LowestLoanableAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                <p class=""col lead text-center"" id=""AmountRequiredSlider_InstructionLabel"">How much do you want to loan?</p>
                                <p class=""col lead text-right"" id=""AmountRequiredSlider_MaximumValueLabel"">$");
#nullable restore
#line 51 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
                                                                                                       Write(Model.UserResponse.Product.SelectedProduct.HighestLoanableAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                            </div>
                        </div>

                        <script>
                            var amountRequiredSlider = document.getElementById(""AmountRequiredSlider"");
                            var amountRequiredSelector = document.getElementById(""AmountRequiredSliderSelector"");
                            var amountRequiredSelectedValue = document.getElementById(""AmountRequiredSliderValue"");

                            amountRequiredSelectedValue.innerHTML = ""$"" + adjustSlideLabel(amountRequiredSlider.value,
                                document.getElementById(""AmountRequiredSlider_MinimumValueLabel""),
                                document.getElementById(""AmountRequiredSlider_MaximumValueLabel""),
                                ""$"")

                            amountRequiredSlider.oninput = function () {
                                amountRequiredSelectedValue.innerHTML = ""$"" + adjustSlideLabel(this.value,
                                 ");
            WriteLiteral(@"   document.getElementById(""AmountRequiredSlider_MinimumValueLabel""),
                                    document.getElementById(""AmountRequiredSlider_MaximumValueLabel""),
                                    ""$"")
                                amountRequiredSelector.style.left = this.value + ""%"";
                            }
                        </script>
                    </div>

                    <!-- DURATION RANGE SLIDER -->
                    <div class=""LoanDurationSliderDiv text-center"">
                        <input id=""LoanDurationSlider"" type=""range"" min=""0"" max=""100"" value=""50"" />
                        <div id=""LoanDurationSliderSelector"">
                            <div id=""LoanDurationSliderButton""></div>
                            <div id=""LoanDurationSliderValue""></div>
                        </div>
                        <div id=""LoanDurationSliderLabels"">
                            <div class=""row"">
                                <p class=""col lead text-le");
            WriteLiteral("ft\" id=\"LoanDurationSlider_MinimumValueLabel\">");
#nullable restore
#line 84 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
                                                                                                   Write(Model.UserResponse.Product.SelectedProduct.MinimumLoanDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" month/s</p>
                                <p class=""col lead text-center"" id=""LoanDurationSlider_InstructionLabel"">How long would you like to pay for your loan?</p>
                                <p class=""col lead text-right"" id=""LoanDurationSlider_MaximumValueLabel"">");
#nullable restore
#line 86 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
                                                                                                    Write(Model.UserResponse.Product.SelectedProduct.MaximumLoanDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" month/s</p>
                            </div>
                        </div>

                        <script>
                            var loanDurationSlider = document.getElementById(""LoanDurationSlider"");
                            var loanDurationSelector = document.getElementById(""LoanDurationSliderSelector"");
                            var loanDurationSelectedValue = document.getElementById(""LoanDurationSliderValue"");

                            loanDurationSelectedValue.innerHTML = adjustSlideLabel(loanDurationSelectedValue.value,
                                document.getElementById(""LoanDurationSlider_MinimumValueLabel""),
                                document.getElementById(""LoanDurationSlider_MaximumValueLabel""),
                                "" month/s"") + "" month/s"";

                            loanDurationSelectedValue.innerHTML = adjustSlideLabel(this.value,
                                document.getElementById(""LoanDurationSlider_MinimumValueLabel""),
           ");
            WriteLiteral(@"                     document.getElementById(""LoanDurationSlider_MaximumValueLabel""),
                                "" month/s"") + "" month/s"";
                            loanDurationSlider.oninput = function () {
                                loanDurationSelectedValue.innerHTML = adjustSlideLabel(this.value,
                                    document.getElementById(""LoanDurationSlider_MinimumValueLabel""),
                                    document.getElementById(""LoanDurationSlider_MaximumValueLabel""),
                                    "" month/s"") + "" month/s"";
                                loanDurationSelector.style.left = this.value + ""%"";
                            }
                        </script>

                    </div>

                    <!-- USER INFO FIELDS -->
                    <div class=""form-group"">
                        <label for=""UserFormsLabel"" class=""lead col-form-label"">Please provide the following information.</label>
                        <div cla");
            WriteLiteral(@"ss=""row"">
                            <div class=""col"">
                                <div class=""input-group"">
                                    <div class=""input-group-prepend"">
                                        <button class=""btn btn-outline-secondary dropdown-toggle"" type=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                        <span id=""UserInquiryForm_Title"">Title</span>
                                        </button>
                                        <div class=""dropdown-menu"">
                                            <a class=""dropdown-item"" onclick=""return setUserTitleAs('Mr.')"">Mr.</a>
                                            <a class=""dropdown-item"" onclick=""return setUserTitleAs('Ms.')"">Ms.</a>
                                            <a class=""dropdown-item"" onclick=""return setUserTitleAs('Mrs.')"">Mrs.</a>
                                        </div>
                                    </div>
    ");
            WriteLiteral("                                <input id=\"UserInquiryForm_FirstName\" type=\"text\" class=\"form-control\" placeholder=\"First name\"");
            BeginWriteAttribute("value", " value=\"", 9135, "\"", 9177, 1);
#nullable restore
#line 131 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
WriteAttributeValue("", 9143, Model.UserResponse.User.FirstName, 9143, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                                    <div id=""UserInquiryForm_FirstName_Invalid"" class=""invalid-feedback"">Please provide valid first name.</div>
                                </div>
                            </div>
                            <div class=""col"">
                                <input id=""UserInquiryForm_LastName"" type=""text"" class=""form-control"" placeholder=""Last name""");
            BeginWriteAttribute("value", " value=\"", 9583, "\"", 9624, 1);
#nullable restore
#line 136 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
WriteAttributeValue("", 9591, Model.UserResponse.User.LastName, 9591, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                                <div id=""UserInquiryForm_LastName_Invalid"" class=""invalid-feedback"">Please provide valid last name.</div>
                            </div>
                        </div>
                        <div class=""row mt-2"">
                            <div class=""col"" id=""UserInquiryForm_Birthdate_Column"">
                                <input id=""UserInquiryForm_Birthdate"" type=""text"" class=""form-control"" placeholder=""Date of Birth"" onclick=""return setDefaultValueForBirthdateDatePicker()""");
            BeginWriteAttribute("value", " value=\"", 10164, "\"", 10208, 1);
#nullable restore
#line 142 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
WriteAttributeValue("", 10172, Model.UserResponse.User.DateOfBirth, 10172, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required/>
                                <div id=""UserInquiryForm_Birthdate_Invalid"" class=""invalid-feedback"">Please provide valid birthdate (YYYY-MM-DD).</div>
                            </div>
                        </div>
                        <div class=""row mt-2"">
                            <div class=""col"">
                                <input id=""UserInquiryForm_Mobile"" type=""text"" class=""form-control"" placeholder=""Mobile Number""");
            BeginWriteAttribute("value", " value=\"", 10665, "\"", 10704, 1);
#nullable restore
#line 148 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
WriteAttributeValue("", 10673, Model.UserResponse.User.Mobile, 10673, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                                <div id=""UserInquiryForm_Mobile_Invalid"" class=""invalid-feedback"">Please provide valid mobile number.</div>
                            </div>
                        </div>
                        <div class=""row mt-2"">
                            <div class=""col"">
                                <input id=""UserInquiryForm_Email"" type=""text"" class=""form-control"" placeholder=""Email""");
            BeginWriteAttribute("value", " value=\"", 11139, "\"", 11177, 1);
#nullable restore
#line 154 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
WriteAttributeValue("", 11147, Model.UserResponse.User.Email, 11147, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" required>
                                <div id=""UserInquiryForm_Address_Invalid"" class=""invalid-feedback"">Please provide valid mobile number.</div>
                            </div>
                        </div>
                    </div>

                </div>
                <div class=""row mr-1 justify-content-center"">
                    <button id=""CalculateQuoteButton"" type=""button"" class=""card-link btn btn-success mt-4 mb-4 text-center"" data-toggle=""modal"" data-target=""#QuotationResultsModal"" data-whatever=""QuotationResultsLabel"">
                        Calculate Quote
                    </button>
                </div>
                <div class=""row mr-1 justify-content-center"">
                    <p class=""small text-mute""></p>
                </div>
            </div>
        </div>
        
        <div class=""text-center"">
            <br><br><br>
            <p class=""lead"">Got some concerns? Send me an email at <b>czardy16@gmail.com</b>!</p><br><br><br>
        </");
            WriteLiteral(@"div>
    </div>
</div>

<!-- Quotation Results Modal -->
<div class=""modal fade"" id=""QuotationResultsModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""QuotationResultsLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""QuotationResultsLabel"">Here's your quotation, ");
#nullable restore
#line 184 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
                                                                                     Write(Model.UserResponse.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"!</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""QuotationResultsTable"">
                <!-- User Information -->
                <div id=""UserInformationDiv"">
                    <h5>Your Information</h5>
                    <ul class=""list-group list-group-flush"">
                        <li class=""list-group-item text-left"">
                            <b>Full Name</b>
                            <span id=""QuotationResultsTable_FullName"" style=""float: right""></span>
                        </li>
                        <li class=""list-group-item text-left"">
                            <b>Birth Date</b>
                            <span id=""QuotationResultsTable_BirthDate"" style=""float: right""></span>
                        </li>
                        <li class=""list-group-item text-left"">
  ");
            WriteLiteral(@"                          <b>Mobile</b>
                            <span id=""QuotationResultsTable_Mobile"" style=""float: right""></span>
                        </li>
                        <li class=""list-group-item text-left"">
                            <b>Email Address</b>
                            <span id=""QuotationResultsTable_Email"" style=""float: right""></span>
                        </li>
                    </ul>
                </div>

                <!-- Quotation Results -->
                <div id=""QuotationResultsDiv"" class=""mt-4"">
                    <h5>Finance Details</h5>
                    <ul class=""list-group list-group-flush"">
                        <li class=""list-group-item text-left"">
                            <b>Chosen Product</b>
                            <span class=""text-right"" style=""float: right"">
                                <span id=""QuotationResultsTable_ChosenProduct""></span><br />
                                <span id=""QuotationResultsTab");
            WriteLiteral(@"le_ChosenProduct_Subtext"" class=""text-muted""></span>
                            </span>
                        </li>
                        <li class=""list-group-item text-left"">
                            <b>Finance Amount</b>
                            <span class=""text-right"" style=""float: right"">
                                <span id=""QuotationResultsTable_FinanceAmount""></span><br />
                                <span id=""QuotationResultsTable_LoanDuration"" class=""text-muted""></span>
                            </span>
                        </li>
                        <li class=""list-group-item text-left"">
                            <b>Repayments from</b>
                            <span class=""text-right"" style=""float: right"">
                                <span id=""QuotationResultsTable_Repayments""></span><br />
                                <span id=""QuotationResultsTable_RepaymentsFrequency"" class=""text-muted""><b>Monthly</b><br /></span>
                           ");
            WriteLiteral(@"     <span id=""QuotationResultsTable_FreeInterestPeriod"" class=""small text-success""><b></b></span>
                            </span>
                        </li>
                        <li class=""list-group-item text-left "">
                            <p class=""h4"">
                                <b>Total Repayments</b>
                                <span class=""text-right"" style=""float: right"">
                                    <span id=""QuotationResultsTable_TotalRepayments""></span><br />
                                </span>
                            </p>
                        </li>
                    </ul>
                </div>
            </div>
            <div id=""footerApplyNowButton"" class=""text-center mb-4"">
                <button id=""ApplyNowButton"" type=""button"" class=""btn btn-success"">Apply Now!</button>
            </div>
            <div class=""modal-footer text-align"">
                <div id=""footerTermsAndConditions"" class=""small text-center ml-5 mr-5"">
");
            WriteLiteral("                    <b><u></u>Important: </b><u></u> Total Repayments include <b>");
#nullable restore
#line 255 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
                                                                            Write(Model.UserResponse.Product.SelectedProduct.InterestRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("% interest and additional $");
#nullable restore
#line 255 "C:\Users\cdy\Desktop\Czar Dy\Projects\ASP.NET Projects\QuoteCalculator\QuoteCalculator\Views\Quotation\QuotesCalculator.cshtml"
                                                                                                                                                               Write(Model.UserResponse.Product.SelectedProduct.EstablishmentFee);

#line default
#line hidden
#nullable disable
            WriteLiteral(" establishment fee</b> which are both subject to change based from our <a");
            BeginWriteAttribute("href", " href=\"", 17077, "\"", 17084, 0);
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return show_alert(\'Dummy link for UI purposes only. Doesn\\\'t redirect to any pages.\')\"><b>Terms and Conditions</b></a></>.\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuoteCalculator.Models.Data.QuotesCalculatorRenderData> Html { get; private set; }
    }
}
#pragma warning restore 1591
