namespace APP3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class khoitaoDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LearningHistories",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FromYear = c.Int(nullable: false),
                        ToYear = c.Int(nullable: false),
                        Address = c.String(),
                        IdStudent = c.String(),
                        Student_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .Index(t => t.Student_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.Int(nullable: false),
                        PlaceOfBirth = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.LearningHistories", "Student_Id", "dbo.Students");
            DropIndex("dbo.LearningHistories", new[] { "Student_Id" });
            DropTable("dbo.Students");
            DropTable("dbo.LearningHistories");
        }
    }
}
