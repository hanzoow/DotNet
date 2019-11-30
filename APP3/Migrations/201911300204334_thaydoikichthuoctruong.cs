namespace APP3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thaydoikichthuoctruong : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LearningHistories", "Address", c => c.String(maxLength: 100));
            AlterColumn("dbo.Students", "FirstName", c => c.String(maxLength: 20));
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 20));
            AlterColumn("dbo.Students", "PlaceOfBirth", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "PlaceOfBirth", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            AlterColumn("dbo.LearningHistories", "Address", c => c.String());
        }
    }
}
