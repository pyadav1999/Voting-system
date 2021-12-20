namespace Voting_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialfirst2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Votings", "img", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Votings", "img", c => c.Byte(nullable: false));
        }
    }
}
