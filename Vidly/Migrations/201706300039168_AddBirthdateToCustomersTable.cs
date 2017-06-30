namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToCustomersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("ADMINISTRADOR.CUSTOMERS", "BIRTHDATE", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("ADMINISTRADOR.CUSTOMERS", "BIRTHDATE");
        }
    }
}
