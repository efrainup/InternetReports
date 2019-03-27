using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RECOVFP.Entidades.SORF
{
    /// <summary>
    /// Entidad para la base de datos RECO/SORF/../data/srsoli01. 
    /// Esta base de datos guarda un resumen de las entradas, salidas y servicios en Hinojosa Terminal Multiusos para aquellas que esten aceptadas.
    /// </summary>
    public class Srsoli01Entity
    {
        /// <summary>
        /// Clave de referencia SORF
        /// </summary>
        public string Cveref01 { get; set; }
        /// <summary>
        /// Fecha en que se autorizó ls solicitud de servicio SORF
        /// </summary>
        public string Fecin01 { get; set; }
        /// <summary>
        /// Tipo de movimiento: 1=Importacion, 2=Exportacion
        /// </summary>
        public string Tipope01 { get; set; }
        /// <summary>
        /// Clave del agente o apoderado aduanal
        /// </summary>
        public string Cveage01 { get; set; }
        /// <summary>
        /// Nombre del agente o apoderado aduanal
        /// </summary>
        public string Nomage01 { get; set; }
        /// <summary>
        /// Identificador del contenedor o CARGA SUELTA en caso de que no tenga contenedor.
        /// </summary>
        public string Numcon01 { get; set; }
        /// <summary>
        /// Tamaño del contenedor: 1=20" 2=40"
        /// </summary>
        public string Tamcon01 { get; set; }
        /// <summary>
        /// Tipo de contenedor
        /// </summary>
        public string Tipcon01 { get; set; }
        /// <summary>
        /// Clave del buque
        /// </summary>
        public string Cvebar01 { get; set; }
        /// <summary>
        /// Nombre del buque
        /// </summary>
        public string Nombar01 { get; set; }
        /// <summary>
        /// Fecha de arribo de buque
        /// </summary>
        public DateTime Fecent01 { get; set; }
        /// <summary>
        /// Número de conocimiento de BL (Bill of Landing)
        /// </summary>
        public string Conoci01 { get; set; }
        /// <summary>
        /// Nombre del puerto de origen
        /// </summary>
        public string Nompue01 { get; set; }
        /// <summary>
        /// Descripción de la mercancia
        /// </summary>
        public string Mercon01 { get; set; }
        /// <summary>
        /// ???
        /// </summary>
        public string Claimo01 { get; set; }
        /// <summary>
        /// Fecha de salida de la terminal
        /// </summary>
        public DateTime? Fecsal01 { get; set; }
        /// <summary>
        /// Nombre de la linea de transporte para salidas
        /// </summary>
        public string Nomtra01 { get; set; }
        /// <summary>
        /// Fecha de liberación de los contenedores del pedimento
        /// </summary>
        public DateTime? Feclib01 { get; set; }
        /// <summary>
        /// Nombre del operador de transporte de salida
        /// </summary>
        public string Nomope01 { get; set; }
        /// <summary>
        /// Número económico de la unidad que transporta la mercancia de salida
        /// </summary>
        public string Numeco01 { get; set; }
        /// <summary>
        /// Placas de la unidad que transporta la mercancia de salida
        /// </summary>
        public string Placas01 { get; set; }
        /// <summary>
        /// ???
        /// </summary>
        public int Diarec01 { get; set; }
        /// <summary>
        /// ???
        /// </summary>
        public int Estadi01 { get; set; }
        /// <summary>
        /// ???
        /// </summary>
        public string Status01 { get; set; }
        /// <summary>
        /// ???
        /// </summary>
        public string Cvecon01 { get; set; }
        /// <summary>
        /// ???
        /// </summary>
        public string Nomcon01 { get; set; }
        /// <summary>
        /// Clave de agente aduanal salida
        /// </summary>
        public string Cveags01 { get; set; }
        /// <summary>
        /// Nombre agente aduanal salida
        /// </summary>
        public string Nomags01 { get; set; }
        /// <summary>
        /// ???
        /// </summary>
        public string Numped01 { get; set; }
        /// <summary>
        /// ???
        /// </summary>
        public string Valmer01 { get; set; }
        /// <summary>
        /// Terminal de origen
        /// </summary>
        public string Maniob01 { get; set; }
        /// <summary>
        /// Peso bruto
        /// </summary>
        public decimal Pesobr01 { get; set; }
        /// <summary>
        /// Número de liberación
        /// </summary>
        public string Nolibera01 { get; set; }
        /// <summary>
        /// Línea naviera
        /// </summary>
        public string Linbar01 { get; set; }
        /// <summary>
        /// Fecha de entrada de vehiculo al recinto
        /// </summary>
        public DateTime? Fentve01 { get; set; }
        /// <summary>
        /// Hora de entrada del vehículo  al recinto
        /// </summary>
        public string Hentve01 { get; set; }
        /// <summary>
        /// Fecha de carga del vehiculo
        /// </summary>
        public DateTime? Fcarve01 { get; set; }
        /// <summary>
        /// Hora de carga del vehiculo
        /// </summary>
        public string Hcarve01 { get; set; }

        /// <summary>
        /// Referencia del sistema de trafico a la cual esta asociada la solicitud.
        /// </summary>
        public string Refcia01 { get; set; }
        /// <summary>
        /// Nombre del cliente
        /// </summary>
        public string Nomcli01 { get; set; }
        /// <summary>
        /// Fecha de entrada del contenedor a la terminal multiusos
        /// </summary>
        public DateTime? Fecini01 { get; set; }
        /// <summary>
        /// Fecha de arribo de buque capturada en el sistema
        /// </summary>
        public DateTime? Fechaimp { get; set; }
        /// <summary>
        /// Folio de ingreso
        /// </summary>
        public string Foling01 { get; set; }
        /// <summary>
        /// Folio de salida
        /// </summary>
        public string Folsal01 { get; set; }



    }
}
