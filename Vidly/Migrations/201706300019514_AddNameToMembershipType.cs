namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNameToMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("ADMINISTRADOR.MEMBERSHIP_TYPES", "NAME", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("ADMINISTRADOR.MEMBERSHIP_TYPES", "NAME");
        }
    }
}
