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
    public class LoanApplicationController : ControllerBase
    {
        public QuoteCalculatorDbContext dbContext = new QuoteCalculatorDbContext();

        [AcceptVerbs("Post")]
        [Route("api/ApplyLoan")]
        public LoanApplicationResponseV1 ApplyLoans([FromBody] object applicationData)
        {
            try
            {
                LoanApplicationRequestV1 request = Newtonsoft.Json.JsonConvert.DeserializeObject<LoanApplicationRequestV1>(applicationData.ToString());
                this.ValidateRequest(request);
                var loanEntry = this.UpdateDatabaseTablesBasedFrom(request);
                return this.BuildApplicationResponse(loanEntry);
            }
            catch(Exception e)
            {
                var errorResponse = new LoanApplicationResponseV1();
                errorResponse.errorMessage = e.Message;
                errorResponse.responseCode = 404;
                return errorResponse;
            }
        }
        
            private void ValidateRequest(LoanApplicationRequestV1 request)
            {
                this.ValidateUserDateOfBirth(request);
                this.ValidateUserIfBlackListed(request);
            }

                private void ValidateUserDateOfBirth(LoanApplicationRequestV1 request)
                {
                    var userAge = this.CalulateUserAge(request.userInput.userBirthDate);
                    if(userAge < 18) throw new Exception("Sorry, the minimum age required to apply for a loan is 18 years old.");
                }

                    private int CalulateUserAge(string userBirthDate)
                    {
                        var userDateOfBirth = DateTime.Parse(userBirthDate);
                        int age = DateTime.Today.Year - userDateOfBirth.Year;
                        if (userBirthDateHasNotHappenedYetThisYear(userDateOfBirth)) age--;
                        return age;
                    }

                    private bool userBirthDateHasNotHappenedYetThisYear(DateTime userDateOfBirth)
                    {
                        return DateTime.Today.Month < userDateOfBirth.Month ||
                                (DateTime.Today.Month == userDateOfBirth.Month &&
                                    DateTime.Today.Day < userDateOfBirth.Day);
                    }
                
                private void ValidateUserIfBlackListed(LoanApplicationRequestV1 request)
                {
                    this.ValidateUserIfBlackListedViaMobileAndEmail(request);
                    this.ValidateUserIfBlackListedViaEmailDomain(request.userInput.userEmail);
                }

                    private void ValidateUserIfBlackListedViaMobileAndEmail(LoanApplicationRequestV1 request)
                    {
                        var matchedBlackListedUsers = this.dbContext.Users.Where<User>(user => user.IsBlackListed &&
                                                                           (user.Mobile == request.userInput.userMobile ||
                                                                                user.Email == request.userInput.userEmail)
                                                                           ).ToList<User>();
                        if (matchedBlackListedUsers.Count != 0) throw new Exception("Cannot process loan application as your account is currently blacklisted.");
                    }

                    private void ValidateUserIfBlackListedViaEmailDomain(string userEmail)
                    {
                        var userEmailDomain = userEmail.Split("@")[1];
                        var matchedBlackListedDomains = this.dbContext.BlackListedDomains.Where<BlackListedDomain>(
                            domain => domain.domain == userEmailDomain).ToList<BlackListedDomain>();
                        if(matchedBlackListedDomains.Count != 0) throw new Exception("The email you provided is part of our blacklisted domains. Please provide another email address.");
                    }

            private Loan UpdateDatabaseTablesBasedFrom(LoanApplicationRequestV1 request)
            {
                this.AddPotentiallyNewUserToDatabase(request);
                var user = this.GetUserFromDatabase(request.userInput.userEmail, request.userInput.userMobile);
                var loan = this.AddNewLoanToDatabase(user, request);
                return loan;
            }

                private void AddPotentiallyNewUserToDatabase(LoanApplicationRequestV1 request)
                {
                    var matchedUsers = this.dbContext.Users.Where<User>(user => user.Email == request.userInput.userEmail
                        || user.Mobile == request.userInput.userMobile).ToList<User>();
                    var newUser = this.CreateNewUserFromRequestInputData(request.userInput);
                    if(matchedUsers.Count == 0) {
                        this.dbContext.Users.Add(newUser);
                        this.dbContext.SaveChanges();
                    }
                }

                    private User CreateNewUserFromRequestInputData(LoanApplicationRequest_UserInput userInput)
                    {
                        var dateOfBirth = DateTime.Parse(userInput.userBirthDate);
                        return new User(userInput.userFirstName, userInput.userLastName, userInput.userTitle,
                                            dateOfBirth, userInput.userMobile, userInput.userEmail);
                    }

                private User GetUserFromDatabase(string userEmail, string userMobile)
                {
                    var matchedUsers = this.dbContext.Users.Where<User>(user => user.Email == userEmail || user.Mobile == userMobile);
                    return matchedUsers.First<User>();
                }
        
                private Loan AddNewLoanToDatabase(User user, LoanApplicationRequestV1 request)
                {
                    var selectedProduct = this.GetProductFromRequest(request);
                    var loan = new Loan();
                    loan.UserId = user.UserId;
                    loan.ProductId = selectedProduct.ProductId;
                    loan.LoanAmount = request.loanInput.RequestedAmount;
                    loan.InterestRate = selectedProduct.InterestRate;
                    loan.PeriodInMonths = request.loanInput.LoanDuration;
                    loan.MonthlyPaymentRate = request.PMTData.RepaymentsAmount;
                    loan.EstablishmentFee = selectedProduct.EstablishmentFee;
                    loan.TotalRepayments = (loan.MonthlyPaymentRate * loan.PeriodInMonths) + selectedProduct.EstablishmentFee;
                    loan.LoanStartDate = DateTime.Today;
                    loan.LoanEndDate = DateTime.Today.AddMonths(request.loanInput.LoanDuration);
                    loan.LoanStatus = "ACTIVE";
                    this.dbContext.Loans.Add(loan);
                    this.dbContext.SaveChanges();
                    return loan;
                }

                    private Product GetProductFromRequest(LoanApplicationRequestV1 request)
                    {
                        return this.dbContext.Products.Where<Product>(product => product.ProductName == request.loanInput.ProductName).First<Product>();
                    }

                private LoanApplicationResponseV1 BuildApplicationResponse(Loan loanEntry)
                {
                    LoanApplicationResponseV1 response = new LoanApplicationResponseV1();
                    response.LoanId = loanEntry.LoanId;
                    response.responseCode = 200;
                    return response;
                }
    }
}
