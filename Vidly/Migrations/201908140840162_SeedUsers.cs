namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(
                @"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'41e4a0f4-4ab2-44d2-b286-340b41a994ec', N'admin@gmail.com', 0, N'AC/1Q+alrr5ur/tHZ/T91Ymc9nsyVdWXJxGRfiMhebIoLK0GvViLrf2EoMDVnny4Zw==', N'a805df3a-e85e-44ca-9083-f7526c896623', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ca83b6bc-e590-477d-9bd2-9f5fdb99cc8b', N'vietnamese97er@gmail.com', 0, N'ANeU6BCl3hxQTWANknGOQeuiAwGDBb6klFulLkWc/VAp8n9xrb4Sg81cMk9S+GRb3g==', N'00b25f9d-9bbe-496f-9f4a-cb26276ba3fe', NULL, 0, 0, NULL, 1, 0, N'vietnamese97er@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4854b2b7-5c9d-4b9f-9c3a-aa5a9021ab08', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'41e4a0f4-4ab2-44d2-b286-340b41a994ec', N'4854b2b7-5c9d-4b9f-9c3a-aa5a9021ab08')

"

            );

        }
        
        public override void Down()
        {
        }
    }
}
