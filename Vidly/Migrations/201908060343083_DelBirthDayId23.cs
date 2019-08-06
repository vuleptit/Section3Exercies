namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DelBirthDayId23 : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Bith = NULL WHERE Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
