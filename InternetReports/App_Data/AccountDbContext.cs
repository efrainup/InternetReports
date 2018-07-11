using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InternetReports
{
    public class AccountDbContext :  IdentityDbContext<Models.AppUser>
    {
        public AccountDbContext() : base(ConfigurationManager.ConnectionStrings["EF_IDENTITY"].ToString())
        {

        }

        
    }

    
}