namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ADMINISTRADOR.CUSTOMERS",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 10, scale: 0, identity: true),
                        NAME = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("ADMINISTRADOR.CUSTOMERS");
        }
    }
}
