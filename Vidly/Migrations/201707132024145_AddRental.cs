namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRental : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ADMINISTRADOR.RENTALS",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        CUSTOMER_ID = c.Decimal(nullable: false, precision: 10, scale: 0),
                        MOVIE_ID = c.Decimal(nullable: false, precision: 10, scale: 0),
                        DATE_RENTED = c.DateTime(nullable: false),
                        DATE_RETURNED = c.DateTime(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("ADMINISTRADOR.CUSTOMERS", t => t.CUSTOMER_ID, cascadeDelete: true)
                .ForeignKey("ADMINISTRADOR.MOVIES", t => t.MOVIE_ID, cascadeDelete: true)
                .Index(t => t.CUSTOMER_ID)
                .Index(t => t.MOVIE_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("ADMINISTRADOR.RENTALS", "MOVIE_ID", "ADMINISTRADOR.MOVIES");
            DropForeignKey("ADMINISTRADOR.RENTALS", "CUSTOMER_ID", "ADMINISTRADOR.CUSTOMERS");
            DropIndex("ADMINISTRADOR.RENTALS", new[] { "MOVIE_ID" });
            DropIndex("ADMINISTRADOR.RENTALS", new[] { "CUSTOMER_ID" });
            DropTable("ADMINISTRADOR.RENTALS");
        }
    }
}
