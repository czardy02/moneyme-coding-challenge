using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Models.API
{
    public class PMTRequestV1
    {
        public double RequestedAmount { get; set; }
        public int LoanDuration { get; set; }
        public string ProductName { get; set; }
    }
}
