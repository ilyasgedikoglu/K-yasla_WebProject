namespace KiyaslaProje.Infrasturcture.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GeneralInformations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SurName = c.String(),
                        SiteDetail = c.String(),
                        SiteLogoPath = c.String(),
                        SiteName = c.String(),
                        Instagram = c.String(),
                        Twitter = c.String(),
                        Facebook = c.String(),
                        Linkedin = c.String(),
                        Email = c.String(),
                        AboutMe = c.String(),
                        vision = c.String(),
                        Mission = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GeneralInformations");
        }
    }
}
