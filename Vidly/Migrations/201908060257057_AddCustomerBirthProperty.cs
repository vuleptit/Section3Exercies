namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerBirthProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Bith", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Bith");
        }
    }
}
