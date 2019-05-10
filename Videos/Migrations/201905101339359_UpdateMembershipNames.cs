namespace Videos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipNames : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE MembershipTypes SET MembershipName = 'Pay as You Go' WHERE MembershipTypeId = 1");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Monthly' WHERE MembershipTypeId = 2");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Quarterly' WHERE MembershipTypeId = 3");
            Sql("UPDATE MembershipTypes SET MembershipName = 'Annual' WHERE MembershipTypeId = 4");
        }
        
        public override void Down()
        {
        }
    }
}
