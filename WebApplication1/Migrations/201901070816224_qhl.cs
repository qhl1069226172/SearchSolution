namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class qhl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClothSize",
                c => new
                    {
                        ClothSizeId = c.Int(nullable: false, identity: true),
                        ClothSizeName = c.String(),
                    })
                .PrimaryKey(t => t.ClothSizeId);
            
            CreateTable(
                "dbo.ColthColor",
                c => new
                    {
                        ColthColorId = c.Int(nullable: false, identity: true),
                        ColthColorName = c.String(),
                    })
                .PrimaryKey(t => t.ColthColorId);
            
            CreateTable(
                "dbo.ColthType",
                c => new
                    {
                        ColthTypeId = c.Int(nullable: false, identity: true),
                        ColthTypeName = c.String(),
                    })
                .PrimaryKey(t => t.ColthTypeId);
            
            CreateTable(
                "dbo.PriceRamdom",
                c => new
                    {
                        PriceRamdomId = c.Int(nullable: false, identity: true),
                        PriceRamdomName = c.String(),
                    })
                .PrimaryKey(t => t.PriceRamdomId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        ColthColorId = c.Int(nullable: false),
                        ClothSizeId = c.Int(nullable: false),
                        PriceRamdomId = c.Int(nullable: false),
                        ColthTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Product");
            DropTable("dbo.PriceRamdom");
            DropTable("dbo.ColthType");
            DropTable("dbo.ColthColor");
            DropTable("dbo.ClothSize");
        }
    }
}
