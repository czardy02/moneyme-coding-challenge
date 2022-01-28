using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Models.Data
{
    public class ApplicationStatusRenderData
    {
        public double FinanceAmount { get; set; }
        public int LoanDuration { get; set; }
        public double Repayments { get; set; }
        public double Interest { get; set; }
        public double TotalRepayments { get; set; }
        public double EstablishmentFee { get; set; }
    }
}
