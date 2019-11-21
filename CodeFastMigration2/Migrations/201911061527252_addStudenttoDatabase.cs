namespace CodeFastMigration2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addStudenttoDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        RegNo = c.String(nullable: false),
                        Passoward = c.String(nullable: false),
                        ConfrumPassoward = c.String(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        Departments_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.Departments_Id)
                .Index(t => t.Departments_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "Departments_Id", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "Departments_Id" });
            DropTable("dbo.Students");
        }
    }
}
