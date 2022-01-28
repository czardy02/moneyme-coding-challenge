using QuoteCalculator.Models.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace QuoteCalculator.DbContexts
{
    public class QuoteCalculatorDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<BlackListedDomain> BlackListedDomains { get; set; }


        public QuoteCalculatorDbContext() {
            
        }
    }
}
