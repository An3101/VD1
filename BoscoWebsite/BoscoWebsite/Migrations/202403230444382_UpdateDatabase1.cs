namespace BoscoWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_New", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Posts", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Product", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "IsActive");
            DropColumn("dbo.tb_Posts", "IsActive");
            DropColumn("dbo.tb_New", "IsActive");
            DropColumn("dbo.tb_Category", "IsActive");
        }
    }
}
