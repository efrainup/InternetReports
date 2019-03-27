using Hinojosa.Common.DataAccessLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace InternetReports.AppExtensions
{
    public static class IdentityExtensions
    {
        //Testing purpouses
        public static IIdentityExtensions Implementation { get; set; } = new IdentityExtensionsDefaultImplementation();
        public static string GetClientId(this IIdentity identity)
        {
            return Implementation.GetClientId(identity);
            // var claim = ((ClaimsIdentity)identity).FindFirst("ClientId");
            //// Test for null to avoid issues during local testing
            //return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetNombreCliente(this IIdentity identity)
        {
            return Implementation.GetNombreCliente(identity);
            //var claim = ((ClaimsIdentity)identity).FindFirst("NombreCliente");
            //// Test for null to avoid issues during local testing
            //return (claim != null) ? claim.Value : string.Empty;
        }
    }

    public interface IIdentityExtensions
    {
        string GetClientId(IIdentity identity);
        string GetNombreCliente(IIdentity identity);
    }

    internal class IdentityExtensionsDefaultImplementation : IIdentityExtensions
    {
        public string GetClientId(IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("ClientId");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public string GetNombreCliente(IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("NombreCliente");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
    }

}