namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TaskItems", "Category_CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Tags", "TaskItem_TaskItemId", "dbo.TaskItems");
            DropIndex("dbo.TaskItems", new[] { "Category_CategoryId" });
            DropIndex("dbo.Tags", new[] { "TaskItem_TaskItemId" });
            RenameColumn(table: "dbo.Categories", name: "Category_CategoryId", newName: "ParentCategory_CategoryId");
            RenameIndex(table: "dbo.Categories", name: "IX_Category_CategoryId", newName: "IX_ParentCategory_CategoryId");
            DropTable("dbo.TaskItems");
            DropTable("dbo.Tags");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TaskItemId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        TaskItem_TaskItemId = c.Int(),
                    })
                .PrimaryKey(t => t.TaskItemId);
            
            CreateTable(
                "dbo.TaskItems",
                c => new
                    {
                        TaskItemId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Order = c.Int(nullable: false),
                        Priority = c.Int(nullable: false),
                        PlanedDate = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        SpentTimeInSeconds = c.Int(nullable: false),
                        Category_CategoryId = c.Int(),
                    })
                .PrimaryKey(t => t.TaskItemId);
            
            RenameIndex(table: "dbo.Categories", name: "IX_ParentCategory_CategoryId", newName: "IX_Category_CategoryId");
            RenameColumn(table: "dbo.Categories", name: "ParentCategory_CategoryId", newName: "Category_CategoryId");
            CreateIndex("dbo.Tags", "TaskItem_TaskItemId");
            CreateIndex("dbo.TaskItems", "Category_CategoryId");
            AddForeignKey("dbo.Tags", "TaskItem_TaskItemId", "dbo.TaskItems", "TaskItemId");
            AddForeignKey("dbo.TaskItems", "Category_CategoryId", "dbo.Categories", "CategoryId");
        }
    }
}
