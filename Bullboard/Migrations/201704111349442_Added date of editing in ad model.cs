namespace Bullboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addeddateofeditinginadmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ads", "EditDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ads", "EditDate");
        }
    }
}
