namespace EFCodeFirstSample.TeacherMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameToTeacherName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "TeacherName", c => c.String());
            DropColumn("dbo.Teachers", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Name", c => c.String());
            DropColumn("dbo.Teachers", "TeacherName");
        }
    }
}
