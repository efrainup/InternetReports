using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RECO.Models.Trafico
{
    /// <summary>
    /// Entidad de las operaciones del sistema de tráfico. Hace referencia a Reco/Trafico/data/stctrl21
    /// </summary>
    public class Stcrl21Entity
    {
        /// <summary>
        /// Número de referencia para el control interno.
        /// </summary>
        public string Refcia21 { get; set; }
        /// <summary>
        /// Fecha de apertura del expediente
        /// </summary>
        public DateTime? Frecep21 { get; set; }
    }
}
