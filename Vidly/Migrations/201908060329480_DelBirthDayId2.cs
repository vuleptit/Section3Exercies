namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DelBirthDayId2 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Bith = '' WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
