using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace InternetReports
{
    public partial class SitioClientesHinojosaDbContext
    {
        
        public DbSet<Areas.Operacion.Models.SolicitudDescargaMasiva> DescargasMasivas { get; set; }
    }
}