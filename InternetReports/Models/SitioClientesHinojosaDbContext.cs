using InternetReports.Areas.Reportes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InternetReports
{
    public partial class SitioClientesHinojosaDbContext : DbContext
    {
        public SitioClientesHinojosaDbContext() : base("Name=ReportesDB")
        {

        }

        static SitioClientesHinojosaDbContext()
        {
            System.Data.Entity.Database.SetInitializer<SitioClientesHinojosaDbContext>(null);
        }

        public DbSet<EdicionReporte> ObservacionesReportes { get; set; }

    }
}