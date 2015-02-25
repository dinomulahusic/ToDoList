using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using ToDoList.Models;

namespace ToDoList.Database
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("DatabaseConnectionString")
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }
    }
}