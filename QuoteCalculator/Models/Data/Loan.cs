using QuoteCalculator.DbContexts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Models.Data
{
    public class Loan
    {
        [Key]
        public int LoanId { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public double LoanAmount { get; set; }
        public double TotalRepayments { get; set; }
        public double InterestRate { get; set; }
        public int PeriodInMonths { get; set; }
        public double MonthlyPaymentRate { get; set; }
        public double EstablishmentFee { get; set; }
        public DateTime LoanStartDate { get; set; }
        public DateTime LoanEndDate { get; set; }
        public string LoanStatus { get; set; }

    }
}
