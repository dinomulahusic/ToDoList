namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "ParentCategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "ParentCategoryId", c => c.Int(nullable: false));
        }
    }
}
