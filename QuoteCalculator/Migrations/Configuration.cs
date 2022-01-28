namespace QuoteCalculator.Migrations
{
    using QuoteCalculator.DbContexts;
    using QuoteCalculator.Models.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QuoteCalculator.DbContexts.QuoteCalculatorDbContext>
    {
        private QuoteCalculatorDbContext dbContext;

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "QuoteCalculator.DbContexts.QuoteCalculatorDbContext";
        }

        protected override void Seed(QuoteCalculator.DbContexts.QuoteCalculatorDbContext context)
        {
           this.dbContext = context;
           this.dbContext.Database.Delete();
           this.dbContext.Database.Create();
           this.LoadAllProducts();
           this.LoadAllBlackListedDomains();
           this.LoadSomeBlackListedUsers();
        }

        private void LoadAllProducts()
        {
            var ProductA = new Product(1, "Product A", "fa-hand-holding-usd", 100, 1000, 3, "Monthly", 0, 1, 3, 100);
            var ProductB = new Product(2, "Product B", "fa-money-check-alt", 200, 10000, 4.5, "Monthly", 2, 6, 12, 200);
            var ProductC = new Product(3, "Product C", "fa-money-bill-wave", 1000, 20000, 5, "Monthly", 0, 9, 18, 300);

            this.dbContext.Products.Add(ProductA);
            this.dbContext.Products.Add(ProductB);
            this.dbContext.Products.Add(ProductC);

            this.dbContext.SaveChanges();
        }

        private void LoadAllBlackListedDomains()
        {
            var BlackListA = new BlackListedDomain(1, "gmail.com");
            var BlackListB = new BlackListedDomain(1, "yahoo.com");
            var BlackListC = new BlackListedDomain(1, "blacklist.com");

            this.dbContext.BlackListedDomains.Add(BlackListA);
            this.dbContext.BlackListedDomains.Add(BlackListB);
            this.dbContext.BlackListedDomains.Add(BlackListC);

            this.dbContext.SaveChanges();
        }

        private void LoadSomeBlackListedUsers()
        {
            var blackListedUser = new User();
            blackListedUser.UserId = 999;
            blackListedUser.FirstName = "Black";
            blackListedUser.LastName = "List";
            blackListedUser.DateOfBirth = DateTime.Today;
            blackListedUser.Mobile = "1234567890";
            blackListedUser.Email = "wagtest@sample.com";
            blackListedUser.IsBlackListed = true;
            this.dbContext.Users.Add(blackListedUser);
            this.dbContext.SaveChanges();
        }
    }
}
