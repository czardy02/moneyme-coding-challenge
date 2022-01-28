using Microsoft.AspNetCore.Mvc;
using QuoteCalculator.DbContexts;
using QuoteCalculator.Models.API;
using QuoteCalculator.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Controllers.FrontEnd
{
    public class QuotationController : Controller
    {
        public QuoteCalculatorDbContext dbContext = new QuoteCalculatorDbContext();

        public IActionResult QuotesCalculator(string inquiryResponse)
        {
            QuotesCalculatorRenderData dataToRender = new QuotesCalculatorRenderData();
            dataToRender.UserResponse = this.createUserResponseFrom(inquiryResponse);
            dataToRender.ProductsMetaData = this.fetchAllProductMetaData();
            return View(dataToRender);
        }

            private UserInquiryResponseV1 createUserResponseFrom(string inquiryResponse)
            {
                if (inquiryResponse == null) inquiryResponse = "";
                UserInquiryResponseV1 response = Newtonsoft.Json.JsonConvert.DeserializeObject<UserInquiryResponseV1>(inquiryResponse);
                response.Product.SelectedProduct.ProductIcon = this.GetProductIconForSelectedProduct(response.Product.SelectedProduct.ProductName);
                return response;
            }

                private string GetProductIconForSelectedProduct(string ProductName)
                {
                    var product = dbContext.Products.Where(product => product.ProductName == ProductName);
                    return product.First<Product>().ProductIcon;
                }

            private List<Product> fetchAllProductMetaData()
            {
                return this.dbContext.Products.ToList<Product>();
            }

        public IActionResult ApplicationStatus(int loanId)
        {
            Loan loan = this.GetLoanFromDatabase(loanId);
            User user = this.GetUserFromDatabaseBasedFrom(loan);
            ApplicationStatusRenderData dataToRender = new ApplicationStatusRenderData();
            dataToRender.FinanceAmount = loan.LoanAmount;
            dataToRender.Repayments = loan.MonthlyPaymentRate;
            dataToRender.LoanDuration = loan.PeriodInMonths;
            dataToRender.Interest = loan.LoanAmount * (loan.InterestRate/100);
            dataToRender.TotalRepayments = loan.TotalRepayments;
            dataToRender.EstablishmentFee = loan.EstablishmentFee;
            return View(dataToRender);
        }

            private Loan GetLoanFromDatabase(int loanId)
            {
                var selectedLoan = this.dbContext.Loans.Where<Loan>(loanRow => loanRow.LoanId == loanId);
                return selectedLoan.First<Loan>();
            }

            private User GetUserFromDatabaseBasedFrom(Loan loan)
            {
                var involvedUser = this.dbContext.Users.Where<User>(userRow => userRow.UserId == loan.UserId);
                return involvedUser.First<User>();
            }
    }
}
