using QuoteCalculator.Models.API;
using QuoteCalculator.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Models.Data
{
    public class QuotesCalculatorRenderData
    {
        public UserInquiryResponseV1 UserResponse { get; set; }
        
        public List<Product> ProductsMetaData { get; set; }
    }
}
