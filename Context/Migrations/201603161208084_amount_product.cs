namespace Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class amount_product : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrderItems", "Quantity", c => c.Int(nullable: false));
            AddColumn("dbo.OrderItems", "Amount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrderItems", "Amount");
            DropColumn("dbo.OrderItems", "Quantity");
        }
    }
}
