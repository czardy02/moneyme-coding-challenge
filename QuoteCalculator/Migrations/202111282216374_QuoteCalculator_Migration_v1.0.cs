namespace QuoteCalculator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuoteCalculator_Migration_v10 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BlackListedDomains",
                c => new
                    {
                        domainId = c.Int(nullable: false, identity: true),
                        domain = c.String(),
                    })
                .PrimaryKey(t => t.domainId);
            
            CreateTable(
                "dbo.Loans",
                c => new
                    {
                        LoanId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        LoanAmount = c.Double(nullable: false),
                        TotalRepayments = c.Double(nullable: false),
                        InterestRate = c.Double(nullable: false),
                        PeriodInMonths = c.Int(nullable: false),
                        MonthlyPaymentRate = c.Double(nullable: false),
                        EstablishmentFee = c.Double(nullable: false),
                        LoanStartDate = c.DateTime(nullable: false),
                        LoanEndDate = c.DateTime(nullable: false),
                        LoanStatus = c.String(),
                    })
                .PrimaryKey(t => t.LoanId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ProductIcon = c.String(),
                        LowestLoanableAmount = c.Double(nullable: false),
                        HighestLoanableAmount = c.Double(nullable: false),
                        InterestRate = c.Double(nullable: false),
                        InterestFrequency = c.String(),
                        FreeInterestPeriod = c.Int(nullable: false),
                        MinimumLoanDuration = c.Int(nullable: false),
                        MaximumLoanDuration = c.Int(nullable: false),
                        EstablishmentFee = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Quotations",
                c => new
                    {
                        QuotationId = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        amountRequired = c.Double(nullable: false),
                        ApplicationStatus = c.String(),
                    })
                .PrimaryKey(t => t.QuotationId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Title = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Mobile = c.String(),
                        Email = c.String(),
                        IsBlackListed = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Quotations");
            DropTable("dbo.Products");
            DropTable("dbo.Loans");
            DropTable("dbo.BlackListedDomains");
        }
    }
}
