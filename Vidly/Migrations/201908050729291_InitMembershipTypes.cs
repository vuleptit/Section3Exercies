    namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes (Id, Duration, Price, Discount) VALUES (1, 0, 0, 0)");
            Sql("INSERT INTO MembershipTypes (Id, Duration, Price, Discount) VALUES (2, 1, 15, 10)");
            Sql("INSERT INTO MembershipTypes (Id, Duration, Price, Discount) VALUES (3, 3, 35, 15)");
            Sql("INSERT INTO MembershipTypes (Id, Duration, Price, Discount) VALUES (4, 6, 60, 20)");
            Sql("INSERT INTO MembershipTypes (Id, Duration, Price, Discount) VALUES (5, 12, 110, 25)");
        }
        
        public override void Down()
        {
        }
    }
}
