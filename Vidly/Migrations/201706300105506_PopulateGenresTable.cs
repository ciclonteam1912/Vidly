namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (ID, NAME) VALUES (1, 'Action')");
            Sql("INSERT INTO GENRES (ID, NAME) VALUES (2, 'Thriller')");
            Sql("INSERT INTO GENRES (ID, NAME) VALUES (3, 'Family')");
            Sql("INSERT INTO GENRES (ID, NAME) VALUES (4, 'Romance')");
            Sql("INSERT INTO GENRES (ID, NAME) VALUES (5, 'Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
