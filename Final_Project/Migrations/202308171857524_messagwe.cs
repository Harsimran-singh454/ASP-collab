namespace Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class messagwe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "UserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Messages", "UserID");
            AddForeignKey("dbo.Messages", "UserID", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Messages", "user1");
            DropColumn("dbo.Messages", "user2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "user2", c => c.String());
            AddColumn("dbo.Messages", "user1", c => c.String());
            DropForeignKey("dbo.Messages", "UserID", "dbo.AspNetUsers");
            DropIndex("dbo.Messages", new[] { "UserID" });
            DropColumn("dbo.Messages", "UserID");
        }
    }
}
