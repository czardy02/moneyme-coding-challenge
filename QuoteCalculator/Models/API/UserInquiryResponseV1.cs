using QuoteCalculator.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Models.API
{
    public class UserInquiryResponseHeadersV1
    {
        public string RedirectedURL { get; set; }
    }

    public class UserInquiryResponseUserBodyResponseV1
    {
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }

    public class UserInquiryResponseProductBodyResponseV1
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double AmountRequired { get; set; }
        public int Term { get; set; }
        public Product SelectedProduct { get; set; }
    }

    public class UserInquiryResponseV1
    {
        public UserInquiryResponseHeadersV1 Headers { get; set; }
        public UserInquiryResponseUserBodyResponseV1 User { get; set; }
        public UserInquiryResponseProductBodyResponseV1 Product { get; set; }
    }
}