namespace APP3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doikhoangoai : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.LearningHistories", new[] { "Student_Id" });
            DropColumn("dbo.LearningHistories", "IdStudent");
            RenameColumn(table: "dbo.LearningHistories", name: "Student_Id", newName: "IdStudent");
            AlterColumn("dbo.LearningHistories", "IdStudent", c => c.String(maxLength: 128));
            CreateIndex("dbo.LearningHistories", "IdStudent");
        }
        
        public override void Down()
        {
            DropIndex("dbo.LearningHistories", new[] { "IdStudent" });
            AlterColumn("dbo.LearningHistories", "IdStudent", c => c.String());
            RenameColumn(table: "dbo.LearningHistories", name: "IdStudent", newName: "Student_Id");
            AddColumn("dbo.LearningHistories", "IdStudent", c => c.String());
            CreateIndex("dbo.LearningHistories", "Student_Id");
        }
    }
}
