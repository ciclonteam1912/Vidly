namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MEMBERSHIP_TYPES (ID, SIGNUP_FEE, DURATION_IN_MONTHS, DISCOUNT_RATE) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MEMBERSHIP_TYPES (ID, SIGNUP_FEE, DURATION_IN_MONTHS, DISCOUNT_RATE) VALUES (2, 30, 1, 10)");
            Sql("INSERT INTO MEMBERSHIP_TYPES (ID, SIGNUP_FEE, DURATION_IN_MONTHS, DISCOUNT_RATE) VALUES (3, 90, 3, 15)");
            Sql("INSERT INTO MEMBERSHIP_TYPES (ID, SIGNUP_FEE, DURATION_IN_MONTHS, DISCOUNT_RATE) VALUES (4, 300, 12, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
