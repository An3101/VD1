namespace BoscoWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDatabase2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_ProductImage",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        Image = c.String(),
                        IsDefault = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.tb_Product", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            AddColumn("dbo.tb_Product", "ViewCount", c => c.Int(nullable: false));
            AddColumn("dbo.tb_ProductCategory", "Alias", c => c.String(nullable: false, maxLength: 150));
            AlterColumn("dbo.tb_Product", "PriceSale", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.tb_ProductCategory", "Icon", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String(maxLength: 500));
            AlterColumn("dbo.tb_ProductCategory", "SeoKeyWords", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_ProductImage", "ProductId", "dbo.tb_Product");
            DropIndex("dbo.tb_ProductImage", new[] { "ProductId" });
            AlterColumn("dbo.tb_ProductCategory", "SeoKeyWords", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoTitle", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "Icon", c => c.String());
            AlterColumn("dbo.tb_Product", "PriceSale", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.tb_ProductCategory", "Alias");
            DropColumn("dbo.tb_Product", "ViewCount");
            DropTable("dbo.tb_ProductImage");
        }
    }
}
