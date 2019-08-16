namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMovieProperty3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumAvailable", c => c.Int(nullable: false));
            Sql("UPDATE Movies SET NumAvailable = NumInStock");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "NumAvailable");
        }
    }
}
