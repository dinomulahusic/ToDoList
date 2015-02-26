namespace ToDoList.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ToDoList.Database.AuthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ToDoList.Database.AuthContext";
        }

        protected override void Seed(ToDoList.Database.AuthContext context)
        {
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
            try
            {
               /* context.Clients.Add(new Models.Client() { Id = "ngAuthApp", Active = true, AllowedOrigin = "localhost", ApplicationType = Models.ApplicationTypes.JavaScript, Name = "ngAuthApp", RefreshTokenLifeTime = 7200, Secret = "test" });
                context.SaveChanges();*/
            }
            catch (Exception ex)
            { }
        }
    }
}
