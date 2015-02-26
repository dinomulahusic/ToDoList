namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ToDoList.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDoList.Database.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ToDoList.Database.AuthContext context)
        {/*
            Category cat1 = new Category();
            cat1.Name = "Category 1";
            cat1.Order = 1;

            Category cat2 = new Category();
            cat2.Name = "Category 2";
            cat2.Order = 1;

            Category cat11 = new Category();
            cat11.Name = "Category 11";
            cat11.Order = 1;

            
            context.Categories.AddOrUpdate(cat1);
            context.Categories.AddOrUpdate(cat2);
            context.SaveChanges();

            if (cat1.SubCategories == null)
                cat1.SubCategories = new System.Collections.Generic.List<Category>();

            cat1.SubCategories.Add(cat11);
            context.Categories.AddOrUpdate(cat11);

            context.SaveChanges();
            */
            
            
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
