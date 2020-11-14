namespace Jobs_Offers_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddJobsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.jobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobTitle = c.String(nullable: false),
                        JobContent = c.String(nullable: false),
                        JobImg = c.String(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.jobs", "CategoryId", "dbo.Categories");
            DropIndex("dbo.jobs", new[] { "CategoryId" });
            DropTable("dbo.jobs");
        }
    }
}
