namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateExistingRecordsOnMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MEMBERSHIP_TYPES SET NAME = 'Pay as You Go' WHERE ID = 1");
            Sql("UPDATE MEMBERSHIP_TYPES SET NAME = 'Monthly' WHERE ID = 2");
            Sql("UPDATE MEMBERSHIP_TYPES SET NAME = 'Quarterly' WHERE ID = 3");
            Sql("UPDATE MEMBERSHIP_TYPES SET NAME = 'Annual' WHERE ID = 4");
        }
        
        public override void Down()
        {
        }
    }
}
