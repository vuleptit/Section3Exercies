namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertMovieData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies(Name, Genre, Year) VALUES('Iron Man 1', 'Action', 2000)");
            Sql("INSERT INTO Movies(Name, Genre, Year) VALUES('Iron Man 2', 'Action', 2001)");
            Sql("INSERT INTO Movies(Name, Genre, Year) VALUES('Iron Man 3', 'Action', 2002)");
            Sql("INSERT INTO Movies(Name, Genre, Year) VALUES('Iron Man 4', 'Action', 2003)");
            Sql("INSERT INTO Movies(Name, Genre, Year) VALUES('Iron Man 5', 'Action', 2004)");
        }
        
        public override void Down()
        {
        }
    }
}
