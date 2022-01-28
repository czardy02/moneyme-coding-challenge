namespace QuoteCalculator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class QuoteCalculator_Migration_v11 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Quotations");
        }
        
        public override void Down()
        {
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
            
        }
    }
}
