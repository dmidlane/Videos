namespace Videos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'28bb137f-5c0d-4ce5-b28c-43b9b5fb4d07', N'admin@vidly.com', 0, N'AKHH1Sxy0ayLXohPRohlGFe135aOCZhPve3t5Ro6Ap2SFH29YTscg7ZQk8P2YK+W8Q==', N'2e5fa214-4e0c-4312-9163-5ae42a798b36', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'58661d17-0428-4137-ba21-43039398a199', N'guest@vidly.com', 0, N'AAJTyLTbzVtUKNm4j1ujfdHzHpZhOqkkE3olv80aFvTulx8sYcju5687DQv/1kvBLw==', N'7c3468d9-8d26-4a7b-9c11-66a618d720c1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8d5d9194-590c-4546-88f8-f242c336450b', N'CanManageMovies')

    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'28bb137f-5c0d-4ce5-b28c-43b9b5fb4d07', N'8d5d9194-590c-4546-88f8-f242c336450b')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
