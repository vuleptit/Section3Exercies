namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateNameMembershipType : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MemberShipTypes SET Name = 'Free' WHERE Duration = 0");
            Sql("UPDATE MemberShipTypes SET Name = 'Monthly' WHERE Duration = 1");
            Sql("UPDATE MemberShipTypes SET Name = 'Three Months' WHERE Duration = 3");
            Sql("UPDATE MemberShipTypes SET Name = 'Half of a Year' WHERE Duration = 6");
            Sql("UPDATE MemberShipTypes SET Name = 'One Year' WHERE Duration = 12");
        }
        
        public override void Down()
        {
        }
    }
}
