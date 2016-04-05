namespace Imagination_Portal_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixForeignKeys : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Solutions", new[] { "User_Id" });
            DropIndex("dbo.Reviews", new[] { "User_Id" });
            DropColumn("dbo.Solutions", "UserId");
            DropColumn("dbo.Reviews", "UserId");
            RenameColumn(table: "dbo.Solutions", name: "User_Id", newName: "UserId");
            RenameColumn(table: "dbo.Reviews", name: "User_Id", newName: "UserId");
            AlterColumn("dbo.Solutions", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Reviews", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Solutions", "UserId");
            CreateIndex("dbo.Reviews", "UserId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Reviews", new[] { "UserId" });
            DropIndex("dbo.Solutions", new[] { "UserId" });
            AlterColumn("dbo.Reviews", "UserId", c => c.Guid());
            AlterColumn("dbo.Solutions", "UserId", c => c.Guid());
            RenameColumn(table: "dbo.Reviews", name: "UserId", newName: "User_Id");
            RenameColumn(table: "dbo.Solutions", name: "UserId", newName: "User_Id");
            AddColumn("dbo.Reviews", "UserId", c => c.Guid());
            AddColumn("dbo.Solutions", "UserId", c => c.Guid());
            CreateIndex("dbo.Reviews", "User_Id");
            CreateIndex("dbo.Solutions", "User_Id");
        }
    }
}
