using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Models.API
{
    public class PMTResponseV1
    {
        public double FinanceAmount { get; set; }
        public int LoanDuration { get; set; }
        public double RepaymentsAmount { get; set; }
        public int FreeInterestPeriod { get; set; }
        public double TotalRepayments { get; set; }
    }
}
