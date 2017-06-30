namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMoviesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ADMINISTRADOR.MOVIES",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        NAME = c.String(nullable: false, maxLength: 255),
                        DATE_ADDED = c.DateTime(nullable: false),
                        RELEASE_DATE = c.DateTime(nullable: false),
                        NUMBER_IN_STOCK = c.Decimal(nullable: false, precision: 3, scale: 0),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("ADMINISTRADOR.MOVIES");
        }
    }
}
