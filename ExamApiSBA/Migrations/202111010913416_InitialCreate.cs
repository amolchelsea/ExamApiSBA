namespace ExamApiSBA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Dept_Id = c.Int(nullable: false, identity: true),
                        Dept_Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Dept_Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Salary = c.Single(nullable: false),
                        DID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Departments", t => t.DID, cascadeDelete: true)
                .Index(t => t.DID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "DID", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DID" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
        }
    }
}
