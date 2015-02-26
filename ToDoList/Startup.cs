using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Data.Entity.Migrations;
using System.Web.Http;
using ToDoList.Database;

[assembly: OwinStartup(typeof(ToDoList.Startup))]
namespace ToDoList
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            try
            {
               /* var configuration = new Migrations.Configuration();
                var migrator = new DbMigrator(configuration);
                migrator.Update();*/
            }
            catch (Exception ex)
            { 
            }

            ConfigureOAuth(app);
            
            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            //app.UseCors(Microsoft.Owin.Cors.CorsOptions.AllowAll);
            app.UseWebApi(config);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {
            OAuthAuthorizationServerOptions OAuthServerOptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(30),
                Provider = new SimpleAuthorizationServerProvider(),
                RefreshTokenProvider = new SimpleRefreshTokenProvider()
            };

            // Token Generation
            app.UseOAuthAuthorizationServer(OAuthServerOptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());

        }
    }
}