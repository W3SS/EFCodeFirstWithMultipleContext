namespace EFCodeFirstSample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renameNameToStudentName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "StudentName", c => c.String());
            DropColumn("dbo.Students", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "Name", c => c.String());
            DropColumn("dbo.Students", "StudentName");
        }
    }
}
