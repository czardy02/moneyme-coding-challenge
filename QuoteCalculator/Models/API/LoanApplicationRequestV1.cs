using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Models.API
{
    public class LoanApplicationRequestV1
    {
        public LoanApplicationRequest_UserInput userInput;
        public LoanApplicationRequest_LoanInput loanInput;
        public PMTResponseV1 PMTData;
    }

    public class LoanApplicationRequest_UserInput
    {
        public string userBirthDate { get; set; }
        public string userEmail { get; set; }
        public string userFirstName { get; set; }
        public string userLastName { get; set; }
        public string userMobile { get; set; }
        public string userTitle { get; set; }
    }

    public class LoanApplicationRequest_LoanInput
    {
        public int LoanDuration { get; set; }
        public string ProductName { get; set; }
        public double RequestedAmount { get; set; }
    }
}
