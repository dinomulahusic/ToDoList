using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using ToDoList.Models;

namespace ToDoList.Database
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext() : base("DatabaseConnectionString", throwIfV1Schema: false)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

        public System.Data.Entity.DbSet<ToDoList.Models.Category> Categories { get; set; }
    }
}