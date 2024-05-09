namespace BoscoWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmigrationUpdateCategory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Category", "Title", c => c.String(nullable: false));
            AlterColumn("dbo.tb_Category", "Description", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Category", "SeoTitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Category", "SeoDescription", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Category", "SeoKeyWords", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Category", "SeoKeyWords", c => c.String());
            AlterColumn("dbo.tb_Category", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Category", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_Category", "Description", c => c.String());
            AlterColumn("dbo.tb_Category", "Title", c => c.String());
        }
    }
}
