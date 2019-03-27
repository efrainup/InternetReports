using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RECOVFP.Entidades.Trafico
{
    /// <summary>
    /// Entidad para los datos de los previos de contenedores
    /// </summary>
    public class Stprev26Entity
    {
        /// <summary>
        /// Número de la patente del agente  aduanal
        /// </summary>
        public string Patent26 { get; set; }
        /// <summary>
        /// Clave de la aduana
        /// </summary>
        public string Cveadu26 { get; set; }
        /// <summary>
        /// Referencia del sistema de tráfico a la cual pertenecen los contenedores
        /// </summary>
        public string Refcia26 { get; set; }
        /// <summary>
        /// Observaciones del previo
        /// </summary>
        public string Obser26 { get; set; }
        /// <summary>
        /// Fecha de reconocimiento de previo
        /// </summary>
        public DateTime? Frecon26 { get; set; }
        /// <summary>
        /// Hora de inicio del reconocimiento del previo
        /// </summary>
        public string Hinici26 { get; set; }
        /// <summary>
        /// Hora de fin del reconocimiento del previo
        /// </summary>
        public string Hfinal26 { get; set; }
        /// <summary>
        /// Nombre del reconocedor del previo
        /// </summary>
        public string Nomrec26 { get; set; }
        /// <summary>
        /// Nombre de la terminal
        /// </summary>
        public string Nomter26 { get; set; }
        /// <summary>
        /// Tipo de reconocimiento de previo
        /// </summary>
        public string Tipop26 { get; set; }
        /// <summary>
        /// Tipo de embalaje de la mercancia
        /// </summary>
        public string Tipoemb26 { get; set; }
        /// <summary>
        /// Daños observados duarante el reconocimiento de previo
        /// </summary>
        public string Danos26 { get; set; }
        /// <summary>
        /// Origen de la mercancia
        /// </summary>
        public string Origen26 { get; set; }
    }
}
