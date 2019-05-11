namespace Videos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDateRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "DateAdded", c => c.DateTime());
        }
    }
}
