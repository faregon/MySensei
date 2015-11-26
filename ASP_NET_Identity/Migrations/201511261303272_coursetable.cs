namespace ASP_NET_Identity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class coursetable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                   "dbo.Courses",
                   c => new
                   {
                       CourseID = c.Int(nullable: false, identity: true),
                       CourseName = c.String(),
                   })
                   .PrimaryKey(t => t.CourseID);
        }
        
        public override void Down()
        {
             
        }
    }
}
