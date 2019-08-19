namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRentalProperty : DbMigration
    {
        public override void Up()
        {
            Sql("DROP TABLE Rentals");
        }
        
        public override void Down()
        {
        }
    }
}
