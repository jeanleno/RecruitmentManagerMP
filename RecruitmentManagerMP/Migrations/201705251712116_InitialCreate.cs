namespace RecruitmentManagerMP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Candidates",
                c => new
                    {
                        CandidateId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        HTML = c.Int(),
                        JavaScript = c.Int(),
                        CSS = c.Int(),
                        Python = c.Int(),
                        Django = c.Int(),
                        DevIOS = c.Int(),
                        DevAndroid = c.Int(),
                    })
                .PrimaryKey(t => t.CandidateId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Candidates");
        }
    }
}
