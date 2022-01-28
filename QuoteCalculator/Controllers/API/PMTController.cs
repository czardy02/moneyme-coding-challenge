using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using QuoteCalculator.DbContexts;
using QuoteCalculator.Models.API;
using QuoteCalculator.Models.Data;
using System;
using System.Linq;

namespace QuoteCalculator.Controllers.API
{
    public class PMTController : ControllerBase
    {

        public QuoteCalculatorDbContext dbContext = new QuoteCalculatorDbContext();

        [AcceptVerbs("Post")]
        [Route("api/PMTFormula")]
        public PMTResponseV1 ProcessPayment([FromBody] object requestBody)
        {
            PMTRequestV1 request = Newtonsoft.Json.JsonConvert.DeserializeObject<PMTRequestV1>(requestBody.ToString());
            var interestRate = this.GetInterestRateForProduct(request.ProductName);
            return this.createPaymentResponseFrom(request, interestRate);
        }

            private PMTResponseV1 createPaymentResponseFrom(PMTRequestV1 request, double interestRate)
            {
                PMTResponseV1 response = new PMTResponseV1();
                response.FinanceAmount = request.RequestedAmount;
                response.LoanDuration = request.LoanDuration;
                int loanPayingDurationInMonths = this.deductFreeInterestMonthsFrom(request.LoanDuration, request.ProductName, response);
                response.RepaymentsAmount = PMT(interestRate, loanPayingDurationInMonths, request.RequestedAmount);
                response.TotalRepayments = this.calculateTotalRepayments(response.RepaymentsAmount, loanPayingDurationInMonths, request.ProductName);
                return response;
            }

                private double PMT(double annualInterestRate, int loanDurationInMonths, double loanAmount)
                {
                    var RepaymentsAmount = Financial.Pmt(annualInterestRate / 12, loanDurationInMonths, loanAmount * -1);
                    return Math.Round(RepaymentsAmount, 2);
                }

                private int deductFreeInterestMonthsFrom(int loanDurationInMonths, string productName, PMTResponseV1 response)
                {
                    response.FreeInterestPeriod = this.GetFreeInteresttRatesDurationForProduct(productName);
                    var calculatedLoanDuration = loanDurationInMonths - response.FreeInterestPeriod;
                    return calculatedLoanDuration >= 0 ? calculatedLoanDuration : 0;
                }

            private double calculateTotalRepayments(double RepaymentsAmount, int loanPayingDurationInMonths, string ProductName)
            {
                return (RepaymentsAmount * loanPayingDurationInMonths) + this.GetEstablishmentFeeForProduct(ProductName);
            }

            private double GetInterestRateForProduct(string ProductName)
            {
                return this.GetProduct(ProductName, "interest rates fetch").InterestRate;
            }

            private int GetFreeInteresttRatesDurationForProduct(string ProductName)
            {
                return this.GetProduct(ProductName, "free interest rates duration").FreeInterestPeriod;
            }

            private double GetEstablishmentFeeForProduct(string ProductName)
            {
                return this.GetProduct(ProductName, "establishment fee").EstablishmentFee;
            }

            private Product GetProduct(string ProductName, string ProcessName)
            {
                var products = this.dbContext.Products.Where(product => product.ProductName == ProductName);
                if (products.Count() == 0) throw new Exception("No products found during " + ProcessName + ".");
                return products.First();
            }
    }
}
