namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerBirthProperty1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Bith", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Bith", c => c.DateTime(nullable: false));
        }
    }
}
