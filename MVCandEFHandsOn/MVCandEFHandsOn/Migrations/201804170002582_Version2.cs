namespace MVCandEFHandsOn.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Version2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Course", "Title", c => c.String());
            DropColumn("dbo.Course", "CourseName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Course", "CourseName", c => c.String());
            DropColumn("dbo.Course", "Title");
        }
    }
}
