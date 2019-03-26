namespace NTCodeFirst2_MtoMRelation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class OriginalDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Student_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Students", t => t.Student_ID)
                .Index(t => t.Student_ID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Teacher_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID)
                .Index(t => t.Teacher_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "Teacher_ID", "dbo.Teachers");
            DropForeignKey("dbo.Students", "Student_ID", "dbo.Students");
            DropIndex("dbo.Teachers", new[] { "Teacher_ID" });
            DropIndex("dbo.Students", new[] { "Student_ID" });
            DropTable("dbo.Teachers");
            DropTable("dbo.Students");
        }
    }
}
