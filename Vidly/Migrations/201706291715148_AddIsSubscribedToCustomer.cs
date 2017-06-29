namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribedToCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("ADMINISTRADOR.CUSTOMERS", "IS_SUBSCRIBED_TO_NEWSLETTER", c => c.Decimal(nullable: false, precision: 1, scale: 0));
        }
        
        public override void Down()
        {
            DropColumn("ADMINISTRADOR.CUSTOMERS", "IS_SUBSCRIBED_TO_NEWSLETTER");
        }
    }
}
