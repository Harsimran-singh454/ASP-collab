namespace Final_Project.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class drivadmin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "IsAdmin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drivers", "IsAdmin");
        }
    }
}
