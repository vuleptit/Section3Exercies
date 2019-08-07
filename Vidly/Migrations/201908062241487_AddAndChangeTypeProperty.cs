namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAndChangeTypeProperty : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Customers", name: "MemberShipType_Id", newName: "MemberShipTypeId");
            RenameIndex(table: "dbo.Customers", name: "IX_MemberShipType_Id", newName: "IX_MemberShipTypeId");
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movies", "MyPropertyId", c => c.Byte());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "MyPropertyId");
            DropTable("dbo.Genres");
            RenameIndex(table: "dbo.Customers", name: "IX_MemberShipTypeId", newName: "IX_MemberShipType_Id");
            RenameColumn(table: "dbo.Customers", name: "MemberShipTypeId", newName: "MemberShipType_Id");
        }
    }
}
