namespace Voting_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialfirst1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        img = c.Binary(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.images");
        }
    }
}
