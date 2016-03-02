namespace Imagination_Portal_2._0.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTags : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Solutions", "Tags", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Solutions", "Tags");
        }
    }
}
