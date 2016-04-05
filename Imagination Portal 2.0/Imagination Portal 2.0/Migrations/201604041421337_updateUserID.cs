namespace Imagination_Portal_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateUserID : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Solutions", "UserId");
            AddColumn("dbo.Solutions", "UserId", c => c.Guid());
            DropColumn("dbo.Reviews", "UserId");
            AddColumn("dbo.Reviews", "UserId", c => c.Guid());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Solutions", "UserId");
            AddColumn("dbo.Solutions", "UserId", c => c.Int());
            DropColumn("dbo.Reviews", "UserId");
            AddColumn("dbo.Reviews", "UserId", c => c.Int());
        }
    }
}
