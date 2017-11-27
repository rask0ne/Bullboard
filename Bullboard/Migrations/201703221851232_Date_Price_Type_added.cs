namespace Bullboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Date_Price_Type_added : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ads", "CreationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Ads", "Type", c => c.String());
            AddColumn("dbo.Ads", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ads", "Price");
            DropColumn("dbo.Ads", "Type");
            DropColumn("dbo.Ads", "CreationDate");
        }
    }
}
