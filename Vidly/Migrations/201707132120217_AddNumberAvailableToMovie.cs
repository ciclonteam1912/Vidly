namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("ADMINISTRADOR.MOVIES", "NUMBER_AVAILABLE", c => c.Decimal(precision: 3, scale: 0));

            Sql("UPDATE MOVIES SET NUMBER_AVAILABLE = NUMBER_IN_STOCK");
        }
        
        public override void Down()
        {
            DropColumn("ADMINISTRADOR.MOVIES", "NUMBER_AVAILABLE");
        }
    }
}
