using Microsoft.EntityFrameworkCore;

namespace DreamBits.Merada.IdentityServer.Web
{
    public class AuthorizationDbContext : DbContext
    {
        public AuthorizationDbContext(DbContextOptions<AuthorizationDbContext> options) : base(options)
        {
            /*
             
             dotnet ef migrations add InitialCreate --context PersistedGrantDbContext --output-dir Migrations/PersistedGrantDb
             dotnet ef migrations add InitialCreate --context ConfigurationDbContext --output-dir Migrations/ConfigurationDb
            
             */
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasDefaultSchema("merada_auth_db");
            base.OnModelCreating(builder);
        }
    }
}