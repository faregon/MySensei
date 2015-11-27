namespace MySensei.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class onetomanycourseusertable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "AppUserID", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Courses", "AppUserID");
            AddForeignKey("dbo.Courses", "AppUserID", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "AppUserID", "dbo.AspNetUsers");
            DropIndex("dbo.Courses", new[] { "AppUserID" });
            DropColumn("dbo.Courses", "AppUserID");
        }
    }
}
