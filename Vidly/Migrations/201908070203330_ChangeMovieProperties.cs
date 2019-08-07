namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMovieProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movies", "NumInStock", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "Year");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "Year", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "NumInStock");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
