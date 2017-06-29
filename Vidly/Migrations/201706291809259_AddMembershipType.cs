namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "ADMINISTRADOR.MEMBERSHIP_TYPES",
                c => new
                    {
                        ID = c.Decimal(nullable: false, precision: 3, scale: 0),
                        SIGNUP_FEE = c.Decimal(nullable: false, precision: 5, scale: 0),
                        DURATION_IN_MONTHS = c.Decimal(nullable: false, precision: 3, scale: 0),
                        DISCOUNT_RATE = c.Decimal(nullable: false, precision: 3, scale: 0),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("ADMINISTRADOR.CUSTOMERS", "MEMBERSHIP_TYPE_ID", c => c.Decimal(nullable: false, precision: 3, scale: 0));
            CreateIndex("ADMINISTRADOR.CUSTOMERS", "MEMBERSHIP_TYPE_ID");
            AddForeignKey("ADMINISTRADOR.CUSTOMERS", "MEMBERSHIP_TYPE_ID", "ADMINISTRADOR.MEMBERSHIP_TYPES", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("ADMINISTRADOR.CUSTOMERS", "MEMBERSHIP_TYPE_ID", "ADMINISTRADOR.MEMBERSHIP_TYPES");
            DropIndex("ADMINISTRADOR.CUSTOMERS", new[] { "MEMBERSHIP_TYPE_ID" });
            DropColumn("ADMINISTRADOR.CUSTOMERS", "MEMBERSHIP_TYPE_ID");
            DropTable("ADMINISTRADOR.MEMBERSHIP_TYPES");
        }
    }
}
