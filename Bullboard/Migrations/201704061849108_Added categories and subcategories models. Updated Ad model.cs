namespace Bullboard.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedcategoriesandsubcategoriesmodelsUpdatedAdmodel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.SubCategories",
                c => new
                    {
                        SubCategoryId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        CategoryId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.SubCategoryId);
            
            AddColumn("dbo.Ads", "CategoryId", c => c.Long(nullable: false));
            AddColumn("dbo.Ads", "SubCategoryId", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Ads", "SubCategoryId");
            DropColumn("dbo.Ads", "CategoryId");
            DropTable("dbo.SubCategories");
            DropTable("dbo.Categories");
        }
    }
}
