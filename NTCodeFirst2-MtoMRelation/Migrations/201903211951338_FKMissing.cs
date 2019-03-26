namespace NTCodeFirst2_MtoMRelation.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKMissing : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.Teachers", "Teacher_ID", "dbo.Teachers");
            DropIndex("dbo.Students", new[] { "Student_ID" });
            DropIndex("dbo.Teachers", new[] { "Teacher_ID" });
            CreateTable(
                "dbo.TeacherStudents",
                c => new
                    {
                        Teacher_ID = c.Int(nullable: false),
                        Student_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Teacher_ID, t.Student_ID })
                .ForeignKey("dbo.Teachers", t => t.Teacher_ID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_ID, cascadeDelete: true)
                .Index(t => t.Teacher_ID)
                .Index(t => t.Student_ID);
            
            DropColumn("dbo.Students", "Student_ID");
            DropColumn("dbo.Teachers", "Teacher_ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "Teacher_ID", c => c.Int());
            AddColumn("dbo.Students", "Student_ID", c => c.Int());
            DropForeignKey("dbo.TeacherStudents", "Student_ID", "dbo.Students");
            DropForeignKey("dbo.TeacherStudents", "Teacher_ID", "dbo.Teachers");
            DropIndex("dbo.TeacherStudents", new[] { "Student_ID" });
            DropIndex("dbo.TeacherStudents", new[] { "Teacher_ID" });
            DropTable("dbo.TeacherStudents");
            CreateIndex("dbo.Teachers", "Teacher_ID");
            CreateIndex("dbo.Students", "Student_ID");
            AddForeignKey("dbo.Teachers", "Teacher_ID", "dbo.Teachers", "ID");
            AddForeignKey("dbo.Students", "Student_ID", "dbo.Students", "ID");
        }
    }
}
