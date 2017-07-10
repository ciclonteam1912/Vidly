namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhoneToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("ADMINISTRADOR.AspNetUsers", "Phone", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("ADMINISTRADOR.AspNetUsers", "Phone");
        }
    }
}
