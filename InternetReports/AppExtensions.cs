﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;

namespace InternetReports.AppExtensions
{
    public static class IdentityExtensions
    {
        public static string GetClientId(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("ClientId");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }

        public static string GetNombreCliente(this IIdentity identity)
        {
            var claim = ((ClaimsIdentity)identity).FindFirst("NombreCliente");
            // Test for null to avoid issues during local testing
            return (claim != null) ? claim.Value : string.Empty;
        }
    }
}