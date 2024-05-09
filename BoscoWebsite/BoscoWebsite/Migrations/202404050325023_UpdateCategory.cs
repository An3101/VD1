namespace BoscoWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "Link", c => c.String());
            AlterColumn("dbo.tb_Category", "Description", c => c.String(maxLength: 350));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Category", "Description", c => c.String(maxLength: 150));
            DropColumn("dbo.tb_Category", "Link");
        }
    }
}
