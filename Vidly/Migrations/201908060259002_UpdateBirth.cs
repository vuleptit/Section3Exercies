namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBirth : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Bith = '1997-08-26' WHERE Id = '1'");
            Sql("UPDATE Customers SET Bith = '2019-08-26' WHERE Id = '2'");
        }
        
        public override void Down()
        {
        }
    }
}
