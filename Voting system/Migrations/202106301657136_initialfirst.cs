namespace Voting_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialfirst : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Votings", "img", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Votings", "img");
        }
    }
}
