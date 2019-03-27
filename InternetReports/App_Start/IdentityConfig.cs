using InternetReports.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Owin;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

[assembly: OwinStartupAttribute(typeof(InternetReports.App_Start.IdentityConfig))]
namespace InternetReports.App_Start
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder App)
        {
            
            App.CreatePerOwinContext(() => new AccountDbContext());
            App.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
            App.CreatePerOwinContext<RoleManager<AppRole>>((options, context) =>
                new RoleManager<AppRole>(
                    new RoleStore<AppRole>(context.Get<AccountDbContext>())
                    )
            );

            

            App.UseCookieAuthentication(new CookieAuthenticationOptions()
            {
               //  ExpireTimeSpan = TimeSpan.FromMinutes(1),
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new Microsoft.Owin.PathString("/Account/Login"),
                Provider = new CookieAuthenticationProvider
                {
                    
                     OnResponseSignIn = (something) =>
                     {
                         //something.OwinContext.GetUserManager<AppUserManager>().Users.
                         //var user = something.OwinContext.Get<AppUser>();
                         var manager = something.OwinContext.GetUserManager<AppUserManager>();
                         var user = manager.FindByName(something.Identity.Name);

                          user.GenerateUserIdentity(something.Identity);
                     },
                    OnValidateIdentity =  SecurityStampValidator.OnValidateIdentity<AppUserManager,AppUser>(
                        
                        validateInterval: TimeSpan.FromMinutes(20),
                        regenerateIdentity: (manager, user) =>
                        {
                            return user.GenerateUserIdentityAsync(manager);
                        }
                    )
                    
                }
            });
        }
    }
}