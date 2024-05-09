namespace BoscoWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Data1234 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Category", "TypeCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Category", "TypeCode", c => c.String());
        }
    }
}
