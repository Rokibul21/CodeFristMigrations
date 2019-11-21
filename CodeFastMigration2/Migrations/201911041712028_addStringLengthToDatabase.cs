namespace CodeFastMigration2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStringLengthToDatabase : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "Code", c => c.String(maxLength: 50));
            AlterColumn("dbo.Departments", "Name", c => c.String(maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Departments", "Name", c => c.String());
            AlterColumn("dbo.Departments", "Code", c => c.String());
        }
    }
}
