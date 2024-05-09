namespace BoscoWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Data123 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "TypeCode", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Category", "TypeCode");
        }
    }
}
