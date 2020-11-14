namespace Jobs_Offers_Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImgInput : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.jobs", "JobImg", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.jobs", "JobImg", c => c.String(nullable: false));
        }
    }
}
