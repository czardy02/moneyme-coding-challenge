using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Models.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductIcon { get; set; }
        public double LowestLoanableAmount { get; set; }
        public double HighestLoanableAmount { get; set; }
        public double InterestRate { get; set; }
        public string InterestFrequency { get; set; }
        public int FreeInterestPeriod { get; set; }
        public int MinimumLoanDuration { get; set; }
        public int MaximumLoanDuration { get; set; }
        public double EstablishmentFee { get; set; }

        public Product() { } 

        public Product(int productId, string productName, string productIcon, double lowestLoanableAmount, double highestLoanableAmount, double interestRate,
                            string interestFrequency, int freeInterestPeriod, int minLoanDuration, int maxLoanDuration, double establishmentFee)
        {
            ProductId = productId;
            ProductName = productName;
            ProductIcon = productIcon;
            LowestLoanableAmount = lowestLoanableAmount;
            HighestLoanableAmount = highestLoanableAmount;
            InterestRate = interestRate;
            InterestFrequency = interestFrequency;
            FreeInterestPeriod = freeInterestPeriod;
            MinimumLoanDuration = minLoanDuration;
            MaximumLoanDuration = maxLoanDuration;
            EstablishmentFee = establishmentFee;
        }
    }
}
