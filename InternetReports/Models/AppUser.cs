using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace InternetReports.Models
{
    public class AppUser: IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<AppUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            //Agregar propiedades aqui
            userIdentity.AddClaim(new Claim("ClientId", this.ClientId));
            userIdentity.AddClaim(new Claim("NombreCliente", this.NombreCliente));

            return userIdentity;
        }

        public ClaimsIdentity GenerateUserIdentity(UserManager<AppUser> manager)
        {
            var userIdentity =  manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);

            //Agregar propiedades aqui
            userIdentity.AddClaim(new Claim("ClientId", this.ClientId));
            userIdentity.AddClaim(new Claim("NombreCliente", this.NombreCliente));

            return userIdentity;
        }

        public ClaimsIdentity GenerateUserIdentity(ClaimsIdentity userIdentity)
        {
            //var userIdentity = manager.CreateIdentity(this, DefaultAuthenticationTypes.ApplicationCookie);

            //Agregar propiedades aqui
            userIdentity.AddClaim(new Claim("ClientId", this.ClientId));
            userIdentity.AddClaim(new Claim("NombreCliente", this.NombreCliente));

            return userIdentity;
        }

        public string ClientId { get; set; }
        public string NombreCliente { get; set; }
    }

    
    
    
}