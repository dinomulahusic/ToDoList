using Microsoft.AspNet.Identity.EntityFramework;

namespace ToDoList.Database
{
    public class AuthContext : IdentityDbContext<IdentityUser>
    {
        public AuthContext()
            : base("DatabaseConnectionString")
        {

        }
    }
}