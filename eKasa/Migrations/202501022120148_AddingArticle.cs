namespace eKasa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingArticle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Purchase_price = c.Int(nullable: false),
                        Retail_price = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ArticleId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Articles", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Articles", new[] { "CategoryId" });
            DropTable("dbo.Articles");
        }
    }
}
