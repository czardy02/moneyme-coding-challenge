using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Models.API
{
    public class UserInquiryRequestV1
    {
        // Product Fields
        public double AmountRequired { get; set; }
        public int Term { get; set; }
        public string ProductName { get; set; }

        // User Fields
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}
