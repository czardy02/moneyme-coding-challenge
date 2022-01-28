using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Models.API
{
    public class LoanApplicationResponseV1
    {
        public int LoanId { get; set; }
        public string errorMessage { get; set; }
        public int responseCode { get; set; }
    }
}
