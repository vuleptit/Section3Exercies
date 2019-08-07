namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCustomerProperty2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Bith", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Bith", c => c.DateTime());
        }
    }
}
