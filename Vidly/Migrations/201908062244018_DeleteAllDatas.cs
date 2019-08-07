namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteAllDatas : DbMigration
    {
        public override void Up()
        {
            Sql("DELETE FROM Customers");
            Sql("DELETE FROM Movies");
        }
        
        public override void Down()
        {
        }
    }
}
