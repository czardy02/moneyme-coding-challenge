
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.Models.Data
{
    public class BlackListedDomain
    {
        public BlackListedDomain() { }

        [Key]
        public int domainId { get; set; }
        public string domain { get; set; }

        public BlackListedDomain(int domainId, string domain)
        {
            this.domainId = domainId;
            this.domain = domain;
        }
    }
}
