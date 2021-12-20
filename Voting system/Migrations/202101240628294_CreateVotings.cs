
using System;
using System.Data.Entity.Migrations;

namespace Voting_system.Migrations
{
    
    public partial class CreateVotings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Votings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VoteA = c.Int(nullable: false),
                        VoteB = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Votings");
        }
    }
}
