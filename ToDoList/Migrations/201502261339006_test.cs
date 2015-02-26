namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Categories", name: "ParentCategory_CategoryId", newName: "Category_CategoryId");
            RenameIndex(table: "dbo.Categories", name: "IX_ParentCategory_CategoryId", newName: "IX_Category_CategoryId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Categories", name: "IX_Category_CategoryId", newName: "IX_ParentCategory_CategoryId");
            RenameColumn(table: "dbo.Categories", name: "Category_CategoryId", newName: "ParentCategory_CategoryId");
        }
    }
}
