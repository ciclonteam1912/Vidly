namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDrivingLicenseToApplicationUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("ADMINISTRADOR.AspNetUsers", "DrivingLicense", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("ADMINISTRADOR.AspNetUsers", "DrivingLicense");
        }
    }
}
