using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RECOVFP.Entidades.Trafico
{
    /// <summary>
    /// Entidad de las operaciones del sistema de tráfico. Hace referencia a Reco/Trafico/data/stctrl21
    /// </summary>
    public class Stctrl21Entity
    {
        /// <summary>
        /// Número de referencia para el control interno.
        /// </summary>
        public string Refcia21 { get; set; }
        /// <summary>
        /// Fecha de apertura del expediente
        /// </summary>
        public DateTime? Frecep21 { get; set; }
        /// <summary>
        /// Clave del cliente
        /// </summary>
        public string Cvecli21 { get; set; }
        /// <summary>
        /// Clave de la aduana
        /// </summary>
        public string Cveadu21 { get; set; }
        /// <summary>
        /// Patente o clave del agente aduanal
        /// </summary>
        public string Patent21 { get; set; }
        /// <summary>
        /// Fecha de ETA de arribo de buque
        /// </summary>
        public DateTime? Fecbar21 { get; set; }
    }
}
