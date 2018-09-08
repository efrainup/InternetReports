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
        public SitioClientesHinojosaDbContext() : base("ReportesDB")
        {

        }

        public DbSet<EdicionReporte> ObservacionesReportes { get; set; }

    }
}