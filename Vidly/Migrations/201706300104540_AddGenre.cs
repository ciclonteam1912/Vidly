namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ADMINISTRADOR.GENRES",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 3, scale: 0),
                        NAME = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("ADMINISTRADOR.MOVIES", "GENRE_ID", c => c.Decimal(nullable: false, precision: 3, scale: 0));
            CreateIndex("ADMINISTRADOR.MOVIES", "GENRE_ID");
            AddForeignKey("ADMINISTRADOR.MOVIES", "GENRE_ID", "ADMINISTRADOR.GENRES", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("ADMINISTRADOR.MOVIES", "GENRE_ID", "ADMINISTRADOR.GENRES");
            DropIndex("ADMINISTRADOR.MOVIES", new[] { "GENRE_ID" });
            DropColumn("ADMINISTRADOR.MOVIES", "GENRE_ID");
            DropTable("ADMINISTRADOR.GENRES");
        }
    }
}
