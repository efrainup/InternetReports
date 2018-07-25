using InternetReports.Areas.Reportes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InternetReports
{
    public class ReportesDbContext : DbContext
    {
        public ReportesDbContext() : base("ReportesDB")
        {

        }

        public DbSet<EdicionReporte> ObservacionesReportes { get; set; }
    }
}